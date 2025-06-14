using tms.Data;
using tms.Model;

namespace tms.Repository
{
    public class VehicleRepository
    {
        public List<Vehicle> GetAll()
        {
            using var context = new AppDbContext();
            return context.Vehicles
                .OrderBy(v => v.VehicleID)
                .ToList();
        }

        public Vehicle? GetById(string vehicleId)
        {
            using var context = new AppDbContext();
            return context.Vehicles
                .FirstOrDefault(v => v.VehicleID == vehicleId);
        }

        public List<Vehicle> Search(string keyword)
        {
            using var context = new AppDbContext();

            return context.Vehicles
                .Where(v =>
                    v.VehicleID.Contains(keyword) ||
                    v.Type.Contains(keyword) ||
                    v.LicensePlate.Contains(keyword) ||
                    v.RouteID.Contains(keyword) ||
                    v.Status.Contains(keyword))
                .OrderBy(v => v.VehicleID)
                .ToList();
        }

        public bool Add(Vehicle vehicle)
        {
            using var context = new AppDbContext();
            context.Vehicles.Add(vehicle); // make sure this is the correct DbSet name
            return context.SaveChanges() > 0;
        }


        public bool Update(Vehicle vehicle)
        {
            using var context = new AppDbContext();
            context.Vehicles.Update(vehicle);
            return context.SaveChanges() > 0;
        }

        public void Delete(string vehicleId)
        {
            using var context = new AppDbContext();
            var vehicle = context.Vehicles.FirstOrDefault(v => v.VehicleID == vehicleId);
            if (vehicle != null)
            {
                context.Vehicles.Remove(vehicle);
                context.SaveChanges();
            }
        }

        public List<string> GetVehicleTypes() => new() { "Bus", "Van", "Truck", "Car", "Motorcycle" };

        public List<string> GetVehiclestatuses() => new() { "Active", "Inactive", "Maintenance", "Retired" };
    }
}
