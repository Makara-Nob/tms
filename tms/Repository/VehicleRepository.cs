using Vehicle_info.Model;
using Staff_info.Data;

namespace Vehicle_info.Repository
{
    public class VehicleRepository
    {
        public List<Vehicle> GetAllVehicles()
        {
            using var context = new AppDbContext();
            return context.Vehicles.ToList();
        }

        public void AddVehicle(Vehicle vehicle)
        {
            using var context = new AppDbContext();
            context.Vehicles.Add(vehicle);
            context.SaveChanges();
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            using var context = new AppDbContext();
            context.Vehicles.Update(vehicle);
            context.SaveChanges();
        }

        public void DeleteVehicle(int id)
        {
            using var context = new AppDbContext();
            var vehicleToDelete = context.Vehicles.FirstOrDefault(v => v.VehicleId == id);

            if (vehicleToDelete != null)
            {
                context.Vehicles.Remove(vehicleToDelete);
                context.SaveChanges();
            }
        }
    }
}
