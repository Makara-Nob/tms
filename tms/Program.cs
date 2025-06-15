using Microsoft.EntityFrameworkCore;
using System.Configuration;
using tms.Data;
using tms.DataSeed;
using tms.Forms;
using tms.Model;

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

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            using (var dbContext = new AppDbContext(optionsBuilder.Options))
            {
                // Seed the database with sample data
                DatabaseSeeder.SeedDatabase(dbContext);

                // Optional: Uncomment below to clear and reseed data
                // DatabaseSeeder.ReseedDatabase(dbContext);
            }

            Console.WriteLine("\n✅ Database initialization complete. Press any key to continue...");
            Console.ReadLine();

            Console.WriteLine("✅ Test complete.");
            Console.ReadLine();
            Application.Run(new FormMain());
        }
    }
}