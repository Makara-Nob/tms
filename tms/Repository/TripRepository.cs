using Microsoft.EntityFrameworkCore;
using System.Linq;
using tms.Data;
using tms.Model;

namespace tms.Repository
{
    
        public class TripRepository
        {
            public List<Trip> GetAll()
            {
                using var context = new AppDbContext();
                return context.Trips
                    .Include(t => t.Vehicle)
                    .Include(t => t.Driver)
                    .Include(t => t.Route)
                    .OrderBy(t => t.TripId)
                    .ToList();
            }

            public Trip? GetById(int tripId)
            {
                using var context = new AppDbContext();
                return context.Trips
                    .Include(t => t.Vehicle)
                    .Include(t => t.Driver)
                    .Include(t => t.Route)
                    .FirstOrDefault(t => t.TripId.Equals(tripId));
            }

            public List<Trip> GetByVehicleId(int vehicleId)
            {
                using var context = new AppDbContext();
                return context.Trips
                    .Include(t => t.Vehicle)
                    .Include(t => t.Driver)
                    .Include(t => t.Route)
                    .Where(t => t.VehicleId.Equals(vehicleId))
                    .OrderBy(t => t.TripId)
                    .ToList();
            }

            public List<Trip> GetByDriverId(int driverId)
            {
                using var context = new AppDbContext();
                return context.Trips
                    .Include(t => t.Vehicle)
                    .Include(t => t.Driver)
                    .Include(t => t.Route)
                    .Where(t => t.DriverId.Equals(driverId))
                    .OrderBy(t => t.TripId)
                    .ToList();
            }

            public List<Trip> GetByRouteId(int routeId)
            {
                using var context = new AppDbContext();
                return context.Trips
                    .Include(t => t.Vehicle)
                    .Include(t => t.Driver)
                    .Include(t => t.Route)
                    .Where(t => t.RouteId.Equals(routeId))
                    .OrderBy(t => t.TripId)
                    .ToList();
            }

            public List<Trip> GetByDateRange(DateTime startDate, DateTime endDate)
            {
                using var context = new AppDbContext();
                return context.Trips
                    .Include(t => t.Vehicle)
                    .Include(t => t.Driver)
                    .Include(t => t.Route)
                    .Where(t => t.DepatureTime >= startDate && t.DepatureTime <= endDate)
                    .OrderBy(t => t.Status)
                    .ToList();
            }

            public List<Trip> Search(string searchTerm)
            {
                using var context = new AppDbContext();
                return context.Trips
                    .Include(t => t.Vehicle)
                    .Include(t => t.Driver)
                    .Include(t => t.Route)
                    .Where(t =>
                        t.TripId.ToString().Contains(searchTerm) ||
                        t.VehicleId.ToString().Contains(searchTerm) ||
                        t.DriverId.ToString().Contains(searchTerm) ||
                        (t.RouteId != null && t.RouteId.ToString().Contains(searchTerm)))
                    .OrderBy(t => t.TripId)
                    .ToList();
            }

            public bool Add(Trip trip)
            {
                using var context = new AppDbContext();
                context.Trips.Add(trip);
                return context.SaveChanges() > 0;
            }

            public bool Update(Trip trip)
            {
                using var context = new AppDbContext();
                context.Trips.Update(trip);
                return context.SaveChanges() > 0;
            }

            public void Delete(int tripId)
            {
                using var context = new AppDbContext();
                var trip = context.Trips.FirstOrDefault(t => t.TripId.Equals(tripId));
                if (trip != null)
                {
                    context.Trips.Remove(trip);
                    context.SaveChanges();
                }
            }

            public bool DeleteMultiple(List<string> tripIds)
            {
                using var context = new AppDbContext();
                var trips = context.Trips.Where(t => tripIds.Contains(t.TripId)).ToList();
                if (trips.Any())
                {
                    context.Trips.RemoveRange(trips);
                    return context.SaveChanges() > 0;
                }
                return false;
            }
        }
    
}
