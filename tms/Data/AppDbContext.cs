
using Delivery_info.Model;
using Microsoft.EntityFrameworkCore;
using Seat_info.Model;
using tms.Model;

namespace tms.Data
{
    public class AppDbContext: DbContext
    {

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Seat> Seats { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public AppDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                                  "Server=ACER\\SQLEXPRESS01;Database=tms;Trusted_Connection=True;Encrypt=False;"
                                  );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Staff>();
            modelBuilder.Entity<Route>();
            modelBuilder.Entity<Vehicle>();


            Console.WriteLine("Entities tracked by EF:");
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                Console.WriteLine($"- {entity.Name}");
            }
        }

       
    }

}
