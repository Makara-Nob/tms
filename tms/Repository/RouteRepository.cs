using tms.Data;
using tms.Model;
using Microsoft.EntityFrameworkCore;

namespace tms.Repository
{
    public class RouteRepository
    {
        public List<Route> GetAll()
        {
            using var context = new AppDbContext();
            return context.Routes
                .OrderBy(r => r.RouteID)
                .ToList();
        }

        public Route? GetById(string routeId)
        {
            using var context = new AppDbContext();
            return context.Routes
                .FirstOrDefault(r => r.RouteID == routeId);
        }

        public List<Route> Search(string searchTerm)
        {
            using var context = new AppDbContext();

            return context.Routes
                .Where(r =>
                    r.RouteID.Contains(searchTerm) ||
                    r.StartPoint.Contains(searchTerm) ||
                    r.EndPoint.Contains(searchTerm) ||
                    r.VehicleAssigned.Contains(searchTerm))
                .OrderBy(r => r.RouteID)
                .ToList();
        }

        public bool Add(Route route)
        {
            using var context = new AppDbContext();
            context.Routes.Add(route);
            return context.SaveChanges() > 0;
        }

        public bool Update(Route route)
        {
            using var context = new AppDbContext();
            context.Routes.Update(route);
            return context.SaveChanges() > 0;
        }

        public void Delete(string routeId)
        {
            using var context = new AppDbContext();
            var route = context.Routes.FirstOrDefault(r => r.RouteID == routeId);
            if (route != null)
            {
                context.Routes.Remove(route);
                context.SaveChanges();
            }
        }
    }
}
