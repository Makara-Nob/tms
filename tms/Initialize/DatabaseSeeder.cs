using Microsoft.EntityFrameworkCore;
using tms.Data;
using tms.Model;

namespace tms.DataSeed
{
    public static class DatabaseSeeder
    {
        public static void SeedDatabase(AppDbContext context)
        {
            // Ensure DB is created
            context.Database.EnsureCreated();

            // Seed all data
            SeedRoutes(context);
            SeedVehicles(context);
            SeedStaff(context);

            // Display seeded data
            DisplayDatabaseContent(context);
        }

        private static void SeedRoutes(AppDbContext context)
        {
            if (!context.Routes.Any())
            {
                var sampleRoutes = SampleDataProvider.GetSampleRoutes();
                context.Routes.AddRange(sampleRoutes);
                context.SaveChanges();
                Console.WriteLine("✅ Inserted sample routes.");
            }
            else
            {
                Console.WriteLine("ℹ️  Routes already exist, skipping seed.");
            }
        }

        private static void SeedVehicles(AppDbContext context)
        {
            if (!context.Vehicles.Any())
            {
                var sampleVehicles = SampleDataProvider.GetSampleVehicles();
                context.Vehicles.AddRange(sampleVehicles);
                context.SaveChanges();
                Console.WriteLine("✅ Inserted sample vehicles.");
            }
            else
            {
                Console.WriteLine("ℹ️  Vehicles already exist, skipping seed.");
            }
        }

        private static void SeedStaff(AppDbContext context)
        {
            if (!context.Staffs.Any())
            {
                var sampleStaff = SampleDataProvider.GetSampleStaff();
                context.Staffs.AddRange(sampleStaff);
                context.SaveChanges();
                Console.WriteLine("✅ Inserted sample staff.");
            }
            else
            {
                Console.WriteLine("ℹ️  Staff already exist, skipping seed.");
            }
        }

        private static void DisplayDatabaseContent(AppDbContext context)
        {
            Console.WriteLine("\n📊 DATABASE CONTENT:");
            Console.WriteLine("==================");

            // Display routes
            var allRoutes = context.Routes.ToList();
            Console.WriteLine($"\n🛣️  ROUTES ({allRoutes.Count}):");
            foreach (var route in allRoutes)
            {
                Console.WriteLine($"   {route.RouteID}: {route.StartPoint} → {route.EndPoint} ({route.DistanceKm}km, {route.Priority} priority)");
            }

            // Display vehicles with their routes
            var allVehicles = context.Vehicles.Include(v => v.Route).ToList();
            Console.WriteLine($"\n🚗 VEHICLES ({allVehicles.Count}):");
            foreach (var vehicle in allVehicles)
            {
                Console.WriteLine($"   {vehicle.VehicleID} ({vehicle.LicensePlate}): {vehicle.Type} - {vehicle.Status} - Route: {vehicle.Route?.StartPoint} → {vehicle.Route?.EndPoint}");
            }

            // Display staff
            var allStaff = context.Staffs.ToList();
            Console.WriteLine($"\n👥 STAFF ({allStaff.Count}):");
            foreach (var staff in allStaff)
            {
                Console.WriteLine($"   👤 {staff.Name} - {staff.Gender} - ${staff.Salary} - {(staff.IsStopWorking ? "Inactive" : "Active")}");
            }
        }

        public static void ClearAllData(AppDbContext context)
        {
            Console.WriteLine("🗑️  Clearing all data...");

            context.Vehicles.RemoveRange(context.Vehicles);
            context.Routes.RemoveRange(context.Routes);
            context.Staffs.RemoveRange(context.Staffs);

            context.SaveChanges();
            Console.WriteLine("✅ All data cleared.");
        }

        public static void ReseedDatabase(AppDbContext context)
        {
            ClearAllData(context);
            SeedDatabase(context);
        }
    }
}