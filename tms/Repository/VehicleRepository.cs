using tms.Data;
using tms.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace tms.Repository
{
    public class VehicleRepository : IDisposable
    {

        private readonly AppDbContext _context;
        private bool _disposed = false;

        // Constructor that optionally takes a context (for dependency injection)
        public VehicleRepository(AppDbContext context = null)
        {
            _context = context ?? new AppDbContext();
        }

        public List<Vehicle> GetAll()
        {
            try
            {
                return _context.Vehicles
                    .AsNoTracking()
                    .OrderBy(v => v.Type)
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting vehicles: {ex.Message}");
                return new List<Vehicle>();
            }
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