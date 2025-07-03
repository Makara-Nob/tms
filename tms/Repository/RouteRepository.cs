using tms.Data;
using tms.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace tms.Repository
{
    public class RouteRepository : IDisposable
    {
        private readonly AppDbContext _context;
        private bool _disposed = false;

        // Constructor that optionally takes a context (for dependency injection)
        public RouteRepository(AppDbContext context = null)
        {
            _context = context ?? new AppDbContext();
        }
        public List<Route> GetAll()
        {
            try
            {
                return _context.Routes
                    .AsNoTracking()
                    .OrderBy(r => r.StartPoint)
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting routes: {ex.Message}");
                return new List<Route>();
            }
        }

        public Route? GetById(string routeId)
        {
            using var context = new AppDbContext();
            var param = new SqlParameter("@RouteID", routeId);
            return context.Routes
                .FromSqlRaw("EXEC GetRouteById @RouteID", param)
                .AsEnumerable()
                .FirstOrDefault();
        }

        public List<Route> Search(string searchTerm)
        {
            using var context = new AppDbContext();
            var parameter = new SqlParameter("@term", searchTerm);

            return context.Routes
                .FromSqlRaw("EXEC SearchRoute @term", parameter)
                .ToList();
        }

        public bool Add(Route route)
        {
            using var context = new AppDbContext();
            var parameters = new[]
            {
                new SqlParameter("@RouteID", route.RouteID),
                new SqlParameter("@StartPoint", route.StartPoint),
                new SqlParameter("@EndPoint", route.EndPoint),
                new SqlParameter("@DistanceKm", route.DistanceKm ?? (object)DBNull.Value),
                new SqlParameter("@EstimatedTimeMinutes", route.EstimatedTimeMinutes ?? (object)DBNull.Value),
                new SqlParameter("@VehicleAssigned", route.VehicleAssigned),
                new SqlParameter("@Priority", route.Priority),
                new SqlParameter("@AvoidTolls", route.AvoidTolls),
                new SqlParameter("@EnableWeatherAlerts", route.EnableWeatherAlerts),
                new SqlParameter("@CreatedDate", route.CreatedDate),
                new SqlParameter("@ModifiedDate", route.ModifiedDate)
            };

            return context.Database.ExecuteSqlRaw("EXEC InsertRoute @RouteID, @StartPoint, @EndPoint, @DistanceKm, @EstimatedTimeMinutes, @VehicleAssigned, @Priority, @AvoidTolls, @EnableWeatherAlerts, @CreatedDate, @ModifiedDate", parameters) > 0;
        }

        public bool Update(Route route)
        {
            using var context = new AppDbContext();
            var parameters = new[]
            {
                new SqlParameter("@RouteID", route.RouteID),
                new SqlParameter("@StartPoint", route.StartPoint),
                new SqlParameter("@EndPoint", route.EndPoint),
                new SqlParameter("@DistanceKm", route.DistanceKm ?? (object)DBNull.Value),
                new SqlParameter("@EstimatedTimeMinutes", route.EstimatedTimeMinutes ?? (object)DBNull.Value),
                new SqlParameter("@VehicleAssigned", route.VehicleAssigned),
                new SqlParameter("@Priority", route.Priority),
                new SqlParameter("@AvoidTolls", route.AvoidTolls),
                new SqlParameter("@EnableWeatherAlerts", route.EnableWeatherAlerts),
                new SqlParameter("@ModifiedDate", route.ModifiedDate)
            };

            return context.Database.ExecuteSqlRaw("EXEC UpdateRoute @RouteID, @StartPoint, @EndPoint, @DistanceKm, @EstimatedTimeMinutes, @VehicleAssigned, @Priority, @AvoidTolls, @EnableWeatherAlerts, @ModifiedDate", parameters) > 0;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Dispose managed resources
                    _context.Dispose();
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