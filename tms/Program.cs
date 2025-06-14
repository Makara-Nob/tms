using Microsoft.EntityFrameworkCore;
using Staff_info;
using Staff_info.Data;
using Staff_info.Model;
using System.Configuration;
using tms.Forms;

namespace tms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["AppDbContext"].ConnectionString);

            using var context = new AppDbContext(optionsBuilder.Options);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                // Ensure DB is created
                dbContext.Database.EnsureCreated();

                // Insert a sample staff (if not exists)
                if (!dbContext.Staffs.Any())
                {
                    var newStaff = new Staff
                    {
                        Name = "John Doe",
                        Gender = "Male",
                        BirthDate = "1995-01-01",
                        Address = "Phnom Penh",
                        Personal_PhoneNumber = "012345678",
                        Contact_PhoneNumber = "087654321",
                        Hired_Date = "2024-06-13",
                        Salary = 1200.50m,
                        IsStopWorking = false
                    };

                    dbContext.Staffs.Add(newStaff);
                    dbContext.SaveChanges();
                    Console.WriteLine("✅ Inserted sample staff.");
                }

                // Read staff
                var allStaff = dbContext.Staffs.ToList();
                foreach (var staff in allStaff)
                {
                    Console.WriteLine($"👤 {staff.Name} - {staff.Gender} - ${staff.Salary}");
                }
            }

            Console.WriteLine("✅ Test complete.");
            Console.ReadLine();
            ApplicationConfiguration.Initialize();
            Application.Run(new FormStaff());
        }
    }
}