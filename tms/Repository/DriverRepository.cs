using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using tms.Data;
using tms.Model;

namespace tms.Repository
{
    public class DriverRepository : IDisposable
    {

        private readonly AppDbContext _context;
        private bool _disposed = false;

        public DriverRepository(AppDbContext context = null)
        {
            _context = context ?? new AppDbContext();
        }
        public List<DriverWithName> GetAllDrivers()
        {
            try
            {
                return _context.Drivers
                    .Include(d => d.Staff)
                    .AsNoTracking()
                    .Select(d => new DriverWithName
                    {
                        DriverID = d.DriverID,
                        StaffId = d.StaffId,
                        Name = d.Staff.Name,
                        LicenseNumber = d.LicenseNumber,
                        LicenseExpiryDate = d.LicenseExpiryDate,
                        LicenseType = d.LicenseType,
                        Availability = d.Availability
                    })
                    .OrderBy(d => d.Name)
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting drivers: {ex.Message}");
                return new List<DriverWithName>();
            }
        }

        public class DriverWithName
        {
            public int DriverID { get; set; }
            public string StaffId { get; set; }
            public string Name { get; set; }
            public string LicenseNumber { get; set; }
            public DateTime? LicenseExpiryDate { get; set; }
            public string LicenseType { get; set; }
            public string Availability { get; set; }
        }

        public Driver? GetById(string staffId)
        {
            using var context = new AppDbContext();
            try
            {
                var param = new SqlParameter("@StaffId", staffId);
                return context.Drivers
                    .FromSqlRaw("EXEC GetDriverById @StaffId", param)
                    .AsEnumerable()
                    .FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetDriverById: {ex.Message}");
                return null;
            }
        }

        // Create driver
        // In DriverRepository.cs

        public bool AddDriver(Driver driver)
        {
            using var context = new AppDbContext();
            try
            {
                var parameters = new[]
                {
            // Removed DriverID parameter
            new SqlParameter("@StaffId", driver.StaffId),
            new SqlParameter("@LicenseNumber", driver.LicenseNumber),
            new SqlParameter("@LicenseExpiryDate", driver.LicenseExpiryDate ?? (object)DBNull.Value),
            new SqlParameter("@LicenseType", driver.LicenseType ?? (object)DBNull.Value),
            new SqlParameter("@Availability", driver.Availability ?? (object)DBNull.Value)
        };

                return context.Database.ExecuteSqlRaw(
                    "EXEC CreateDriver @StaffId, @LicenseNumber, @LicenseExpiryDate, @LicenseType, @Availability",
                    parameters) > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding driver: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool UpdateDriver(Driver driver)
        {
            using var context = new AppDbContext();
            try
            {
                var parameters = new[]
                {
            new SqlParameter("@DriverID", driver.DriverID),
            new SqlParameter("@StaffId", driver.StaffId),
            new SqlParameter("@LicenseNumber", driver.LicenseNumber),
            new SqlParameter("@LicenseExpiryDate", driver.LicenseExpiryDate ?? (object)DBNull.Value),
            new SqlParameter("@LicenseType", driver.LicenseType ?? (object)DBNull.Value),
            new SqlParameter("@Availability", driver.Availability ?? (object)DBNull.Value)
        };

                return context.Database.ExecuteSqlRaw(
                    "EXEC UpdateDriver @DriverID, @StaffId, @LicenseNumber, @LicenseExpiryDate, @LicenseType, @Availability",
                    parameters) > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating driver: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Delete driver
        public bool Delete(string staffId)
        {
            using var context = new AppDbContext();
            try
            {
                var param = new SqlParameter("@StaffId", staffId);
                context.Database.ExecuteSqlRaw("EXEC DeleteDriver @StaffId", param);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting driver: {ex.Message}");
                return false;
            }
        }

        // Search drivers with names (assuming SP returns data mappable to DriverWithName)
        public List<DriverWithName> SearchDrivers(string searchTerm)
        {
            using var context = new AppDbContext();
            try
            {
                var param = new SqlParameter("@SearchTerm", searchTerm);
                return context.Drivers
                    .FromSqlRaw("EXEC SearchDrivers @SearchTerm", param) // This SP should return all fields for DriverWithName
                    .Select(d => new DriverWithName
                    {
                        DriverID = d.DriverID,
                        StaffId = d.StaffId,
                        LicenseNumber = d.LicenseNumber,
                        LicenseExpiryDate = d.LicenseExpiryDate,
                        LicenseType = d.LicenseType,
                        Availability = d.Availability
                    })
                    .ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error searching drivers (SP): {ex.Message}");
                return new List<DriverWithName>();
            }
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