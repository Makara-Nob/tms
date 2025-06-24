using tms.Data;
using tms.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace tms.Repository
{
    public class RouteRepository
    {
        public List<Route> GetAll()
        {
            using var context = new AppDbContext();
            return context.Routes
                .FromSqlRaw("EXEC GetAllRoutes")
                .ToList();
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

    }
}
