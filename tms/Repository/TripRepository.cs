using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using tms.Data;
using tms.Model;
using tms.projection;

namespace tms.Repository
{
    public class TripRepository
    {
        public List<TripDetail> GetAll()
            {
                using var context = new AppDbContext();
                return context.TripDetail
                    .FromSqlRaw("EXEC GetTripsDetails")
                    .ToList();
         }

        public Trip? GetById(string tripId)
        {
            using var context = new AppDbContext();
            return context.Trips
                .FromSqlRaw("EXEC GetTripById @TripID = {0}", tripId)
                .Include(t => t.Vehicle)
                .Include(t => t.Driver)
                .Include(t => t.Route)
                .AsEnumerable()
                .FirstOrDefault();
        }

        public List<Trip> GetByVehicleId(string vehicleId)
        {
            using var context = new AppDbContext();
            return context.Trips
                .FromSqlRaw("EXEC GetTripsByVehicleId @VehicleID = {0}", vehicleId)
                .AsEnumerable()
                 .Select(t => {
                     t.Vehicle = context.Vehicles.Find(t.VehicleId);
                     t.Driver = context.Staffs.Find(t.DriverId);
                     t.Route = context.Routes.Find(t.RouteId);
                     return t;
                 })
                .ToList();
        }

        public List<Trip> GetByDriverId(string driverId)
        {
            using var context = new AppDbContext();
            return context.Trips
                .FromSqlRaw("EXEC GetTripsByDriverId @DriverID = {0}", driverId)
                .AsEnumerable()
                .Select(t => {
                    t.Vehicle = context.Vehicles.Find(t.VehicleId);
                    t.Driver = context.Staffs.Find(t.DriverId);
                    t.Route = context.Routes.Find(t.RouteId);
                    return t;
                })
                .ToList();
        }

        public List<Trip> GetByRouteId(string routeId)
        {
            using var context = new AppDbContext();
            return context.Trips
                .FromSqlRaw("EXEC GetTripsByRouteId @RouteID = {0}", routeId)
                .AsEnumerable()
                .Select(t => {
                    t.Vehicle = context.Vehicles.Find(t.VehicleId);
                    t.Driver = context.Staffs.Find(t.DriverId);
                    t.Route = context.Routes.Find(t.RouteId);
                    return t;
                })
                .ToList();
        }

        public List<Trip> GetByDateRange(DateTime start, DateTime end)
        {
            using var context = new AppDbContext();
            return context.Trips
                .FromSqlRaw("EXEC GetTripsByDateRange @StartDate = {0}, @EndDate = {1}", start, end)
                .AsEnumerable()
               .Select(t => {
                   t.Vehicle = context.Vehicles.Find(t.VehicleId);
                   t.Driver = context.Staffs.Find(t.DriverId);
                   t.Route = context.Routes.Find(t.RouteId);
                   return t;
               })
                .ToList();
        }

        public List<Trip> Search(string term)
        {
            using var context = new AppDbContext();
            return context.Trips
                .FromSqlRaw("EXEC SearchTrips @SearchTerm = {0}", term)
                .AsEnumerable()
               .Select(t => {
                   t.Vehicle = context.Vehicles.Find(t.VehicleId);
                   t.Driver = context.Staffs.Find(t.DriverId);
                   t.Route = context.Routes.Find(t.RouteId);
                   return t;
               })
                .ToList();
        }

        public bool Add(Trip trip)
        {
            using var context = new AppDbContext();
            var result = context.Database.ExecuteSqlRaw(
                "EXEC InsertTrip @TripID, @VehicleID, @DriverID, @RouteID, @DepatureTime, @Status",
                new SqlParameter("@TripID", trip.TripId),
                new SqlParameter("@VehicleID", trip.VehicleId),
                new SqlParameter("@DriverID", trip.DriverId),
                new SqlParameter("@RouteID", trip.RouteId),
                new SqlParameter("@DepatureTime", trip.DepatureTime),
                new SqlParameter("@Status", trip.Status ?? (object)DBNull.Value)
            );
            return result > 0;
        }

        public bool Update(Trip trip)
        {
            using var context = new AppDbContext();
            var result = context.Database.ExecuteSqlRaw(
                "EXEC UpdateTrip @TripID, @VehicleID, @DriverID, @RouteID, @DepatureTime, @Status",
                new SqlParameter("@TripID", trip.TripId),
                new SqlParameter("@VehicleID", trip.VehicleId),
                new SqlParameter("@DriverID", trip.DriverId),
                new SqlParameter("@RouteID", trip.RouteId),
                new SqlParameter("@DepatureTime", trip.DepatureTime),
                new SqlParameter("@Status", trip.Status ?? (object)DBNull.Value)
            );
            return result > 0;
        }

        public bool Delete(string tripId)
        {
            using var context = new AppDbContext();
            var result = context.Database.ExecuteSqlRaw(
                "EXEC DeleteTrip @TripID = {0}", tripId
            );
            return result > 0;
        }
    }
}
