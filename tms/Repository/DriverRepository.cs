using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using tms.Data;
using tms.Model;

namespace tms.Repository
{
    public class DriverRepository
    {
        // Get all drivers
        public List<Driver> GetAllDrivers()
        {
            using var context = new AppDbContext();
            return context.Drivers
                .FromSqlRaw("EXEC GetAllDrivers")
                .ToList();
        }

        // Create driver
        public bool AddDriver(Driver driver)
        {
            using var context = new AppDbContext();

            var parameters = new[]
            {
                new SqlParameter("@StaffId", driver.StaffId),
                new SqlParameter("@LicenseNumber", driver.LicenseNumber),
                new SqlParameter("@LicenseExpiryDate", driver.LicenseExpiryDate ?? (object)DBNull.Value),
                new SqlParameter("@LicenseType", driver.LicenseType ?? (object)DBNull.Value),
                new SqlParameter("@Availability", driver.Availability ?? (object)DBNull.Value)
            };

            return context.Database.ExecuteSqlRaw(
                "EXEC CreateDriver @StaffId, @LicenseNumber, @LicenseExpiryDate, @LicenseType, @Availability",parameters) > 0;
        }

        // Update driver
        public bool UpdateDriver(Driver driver)
        {
            using var context = new AppDbContext();

            return context.Database.ExecuteSqlRaw(
                "EXEC UpdateDriver @DriverID, @StaffId, @LicenseNumber, @LicenseExpiryDate, @LicenseType, @Availability",
                new SqlParameter("@DriverID", driver.DriverID),
                new SqlParameter("@StaffId", driver.StaffId),
                new SqlParameter("@LicenseNumber", driver.LicenseNumber),
                new SqlParameter("@LicenseExpiryDate", driver.LicenseExpiryDate ?? (object)DBNull.Value),
                new SqlParameter("@LicenseType", driver.LicenseType ?? (object)DBNull.Value),
                new SqlParameter("@Availability", driver.Availability ?? (object)DBNull.Value)
            ) > 0;
        }

        // Search drivers
        public List<Driver> SearchDrivers(string searchTerm)
        {
            using var context = new AppDbContext();

            return context.Drivers
                .FromSqlRaw("EXEC SearchDrivers @SearchTerm",
                    new SqlParameter("@SearchTerm", searchTerm))
                .ToList();
        }
    }
}
