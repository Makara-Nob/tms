using tms.Data;
using tms.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace tms.Repository
{
    public class VehicleRepository
    {
        public List<Vehicle> GetAll()
        {
            using var context = new AppDbContext();
            return context.Vehicles
                .FromSqlRaw("EXEC GetAllVehicles")
                .ToList();
        }

        public Vehicle? GetById(string vehicleId)
        {
            using var context = new AppDbContext();
            var param = new SqlParameter("@VehicleID", vehicleId);
            return context.Vehicles
                .FromSqlRaw("EXEC GetVehicleById @VehicleID", param)
                .AsEnumerable()
                .FirstOrDefault();
        }

        public List<Vehicle> Search(string keyword)
        {
            using var context = new AppDbContext();
            var param = new SqlParameter("@term", keyword);
            return context.Vehicles
                .FromSqlRaw("EXEC SearchVehicles @term", param)
                .ToList();
        }

        public bool Add(Vehicle vehicle)
        {
            using var context = new AppDbContext();
            var parameters = new[]
            {
                new SqlParameter("@VehicleID", vehicle.VehicleID),
                new SqlParameter("@Type", vehicle.Type),
                new SqlParameter("@Capacity", (object?)vehicle.Capacity ?? DBNull.Value),
                new SqlParameter("@LicensePlate", vehicle.LicensePlate),
                new SqlParameter("@RouteID", vehicle.RouteID),
                new SqlParameter("@Status", vehicle.Status),
                new SqlParameter("@MaintenanceDate", (object?)vehicle.MaintenanceDate ?? DBNull.Value),
                new SqlParameter("@CreatedDate", vehicle.CreatedDate),
                new SqlParameter("@ModifiedDate", vehicle.ModifiedDate),
            };

            return context.Database.ExecuteSqlRaw(
                "EXEC InsertVehicle @VehicleID, @Type, @Capacity, @LicensePlate, @RouteID, @Status, @MaintenanceDate, @CreatedDate, @ModifiedDate",
                parameters) > 0;
        }

        public bool Update(Vehicle vehicle)
        {
            using var context = new AppDbContext();
            var parameters = new[]
            {
                new SqlParameter("@VehicleID", vehicle.VehicleID),
                new SqlParameter("@Type", vehicle.Type),
                new SqlParameter("@Capacity", (object?)vehicle.Capacity ?? DBNull.Value),
                new SqlParameter("@LicensePlate", vehicle.LicensePlate),
                new SqlParameter("@RouteID", vehicle.RouteID),
                new SqlParameter("@Status", vehicle.Status),
                new SqlParameter("@MaintenanceDate", (object?)vehicle.MaintenanceDate ?? DBNull.Value),
                new SqlParameter("@ModifiedDate", vehicle.ModifiedDate),
            };

            return context.Database.ExecuteSqlRaw(
                "EXEC UpdateVehicle @VehicleID, @Type, @Capacity, @LicensePlate, @RouteID, @Status, @MaintenanceDate, @ModifiedDate",
                parameters) > 0;
        }

        public void Delete(string vehicleId)
        {
            using var context = new AppDbContext();
            var param = new SqlParameter("@VehicleID", vehicleId);
            context.Database.ExecuteSqlRaw("EXEC DeleteVehicle @VehicleID", param);
        }

        public List<string> GetVehicleTypes() =>
            new() { "Bus", "Van", "Truck", "Car", "Motorcycle" };

        public List<string> GetVehiclestatuses() =>
            new() { "Active", "Inactive", "Maintenance", "Retired" };
    }
}
