using tms.Data;
using tms.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace tms.Repository
{
    public class TripRepository : IDisposable
    {
        private readonly AppDbContext _context;
        private bool _disposed = false;

        public TripRepository(AppDbContext context = null)
        {
            _context = context ?? new AppDbContext();
        }

        public async Task<List<Trip>> GetAllAsync()
        {
            try
            {
                var trips = await _context.Trips
                    .AsNoTracking()
                    .ToListAsync();

                await LoadNavigationProperties(trips);

                return trips;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetAllTrips: {ex.Message}");
                return new List<Trip>();
            }
        }

        public async Task<Trip> GetByIdAsync(string tripId)
        {
            try
            {
                var param = new SqlParameter("@TripID", tripId);
                var trip = await _context.Trips
                    .FromSqlRaw("EXEC GetTripById @TripID", param)
                    .AsNoTracking()
                    .FirstOrDefaultAsync();

                if (trip != null)
                {
                    await LoadNavigationProperties(new List<Trip> { trip });
                }
                return trip;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetTripById: {ex.Message}");
                return null;
            }
        }

        public async Task<List<Trip>> GetByVehicleIdAsync(string vehicleId)
        {
            try
            {
                var param = new SqlParameter("@VehicleID", vehicleId);
                var trips = await _context.Trips
                    .FromSqlRaw("EXEC GetTripsByVehicleId @VehicleID", param)
                    .AsNoTracking()
                    .ToListAsync();

                await LoadNavigationProperties(trips);
                return trips;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetTripsByVehicleId: {ex.Message}");
                return new List<Trip>();
            }
        }

        public async Task<List<Trip>> GetByDriverIdAsync(string driverId)
        {
            try
            {
                var param = new SqlParameter("@DriverID", driverId);
                var trips = await _context.Trips
                    .FromSqlRaw("EXEC GetTripsByDriverId @DriverID", param)
                    .AsNoTracking()
                    .ToListAsync();

                await LoadNavigationProperties(trips);
                return trips;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetTripsByDriverId: {ex.Message}");
                return new List<Trip>();
            }
        }

        public async Task<List<Trip>> GetByRouteIdAsync(string routeId)
        {
            try
            {
                var param = new SqlParameter("@RouteID", routeId);
                var trips = await _context.Trips
                    .FromSqlRaw("EXEC GetTripsByRouteId @RouteID", param)
                    .AsNoTracking()
                    .ToListAsync();

                await LoadNavigationProperties(trips);
                return trips;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetTripsByRouteId: {ex.Message}");
                return new List<Trip>();
            }
        }

        public async Task<List<Trip>> GetByDateRangeAsync(DateTime start, DateTime end)
        {
            try
            {
                var startParam = new SqlParameter("@StartDate", start);
                var endParam = new SqlParameter("@EndDate", end);

                var trips = await _context.Trips
                    .FromSqlRaw("EXEC GetTripsByDateRange @StartDate, @EndDate", startParam, endParam)
                    .AsNoTracking()
                    .ToListAsync();

                await LoadNavigationProperties(trips);
                return trips;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetTripsByDateRange: {ex.Message}");
                return new List<Trip>();
            }
        }

        public async Task<bool> AddAsync(Trip trip)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("@TripID", trip.TripID),
                    new SqlParameter("@VehicleID", trip.VehicleID),
                    new SqlParameter("@DriverID", trip.DriverID),
                    new SqlParameter("@RouteID", trip.RouteID),
                    new SqlParameter("@DepatureTime", trip.DepatureTime),
                    new SqlParameter("@Status", trip.status)
                };

                await _context.Database.ExecuteSqlRawAsync(
                    "EXEC AddTrip @TripID, @VehicleID, @DriverID, @RouteID, @DepatureTime, @Status",
                    parameters);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding trip: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> UpdateAsync(Trip trip)
        {
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("@TripID", trip.TripID),
                    new SqlParameter("@VehicleID", trip.VehicleID),
                    new SqlParameter("@DriverID", trip.DriverID),
                    new SqlParameter("@RouteID", trip.RouteID),
                    new SqlParameter("@DepatureTime", trip.DepatureTime),
                    new SqlParameter("@Status", trip.status)
                };

                await _context.Database.ExecuteSqlRawAsync(
                    "EXEC UpdateTrip @TripID, @VehicleID, @DriverID, @RouteID, @DepatureTime, @Status",
                    parameters);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating trip: {ex.Message}");
                return false;
            }
        }

        public async Task<bool> DeleteAsync(string tripId)
        {
            try
            {
                var param = new SqlParameter("@TripID", tripId);
                await _context.Database.ExecuteSqlRawAsync("EXEC DeleteTrip @TripID", param);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting trip: {ex.Message}");
                return false;
            }
        }

        public async Task<List<Trip>> SearchAsync(string searchTerm)
        {
            try
            {
                var param = new SqlParameter("@SearchTerm", searchTerm);
                var trips = await _context.Trips
                    .FromSqlRaw("EXEC SearchTrips @SearchTerm", param)
                    .AsNoTracking()
                    .ToListAsync();

                await LoadNavigationProperties(trips);
                return trips;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching trips: {ex.Message}");
                return new List<Trip>();
            }
        }

        private async Task LoadNavigationProperties(List<Trip> trips)
        {
            if (trips == null || !trips.Any()) return;

            // Batch load all related data to avoid N+1 queries
            var vehicleIds = trips.Select(t => t.VehicleID).Distinct().ToList();
            var driverIds = trips.Select(t => t.DriverID).Distinct().ToList();
            var routeIds = trips.Select(t => t.RouteID).Distinct().ToList();

            var vehicles = await _context.Vehicles
                .Where(v => vehicleIds.Contains(v.VehicleID))
                .ToDictionaryAsync(v => v.VehicleID);

            var drivers = await _context.Drivers
                .Include(d => d.Staff)
                .Where(d => driverIds.Contains(d.StaffId))
                .ToDictionaryAsync(d => d.StaffId);

            var routes = await _context.Routes
                .Where(r => routeIds.Contains(r.RouteID))
                .ToDictionaryAsync(r => r.RouteID);

            // Assign navigation properties
            foreach (var trip in trips)
            {
                trip.Vehicle = vehicles.TryGetValue(trip.VehicleID, out var vehicle) ? vehicle : null;
                trip.Driver = drivers.TryGetValue(trip.DriverID, out var driver) ? driver : null;
                trip.Route = routes.TryGetValue(trip.RouteID, out var route) ? route : null;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context?.Dispose();
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}