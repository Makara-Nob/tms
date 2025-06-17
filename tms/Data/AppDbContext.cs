
using Delivery_info.Model;
using Microsoft.EntityFrameworkCore;
using Passenger_info.Model;
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
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Trip> Trips { get; set; }

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

            modelBuilder.Entity<Route>()
          .Property(r => r.DistanceKm)
          .HasPrecision(10, 2); // Adjust precision as needed

            modelBuilder.Entity<Staff>()
                .Property(s => s.Salary)
                .HasPrecision(12, 2); // Adjust precision as needed

            modelBuilder.Entity<Staff>();
            modelBuilder.Entity<Route>();
            modelBuilder.Entity<Vehicle>();
            modelBuilder.Entity<Ticket>(
                entity =>
                {
                    entity.HasKey(t => t.TicketID);

                    entity.Property(t => t.TicketID)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(t => t.SupplierID)
                        .IsRequired()
                        .HasMaxLength(50);

                    entity.Property(t => t.SupplierName)
                        .IsRequired()
                        .HasMaxLength(200);

                    entity.Property(t => t.SupplierDate)
                        .IsRequired()
                        .HasColumnType("datetime2");

                    entity.Property(t => t.CustomerPosition)
                        .HasMaxLength(200);

                    entity.Property(t => t.CustomerAddress)
                        .HasMaxLength(500);

                    entity.Property(t => t.CreatedDate)
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    entity.Property(t => t.ModifiedDate)
                        .IsRequired()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    entity.HasIndex(t => t.SupplierID)
                        .HasDatabaseName("IX_Tickets_SupplierID");

                    entity.HasIndex(t => t.SupplierDate)
                        .HasDatabaseName("IX_Tickets_SupplierDate");

                    entity.HasIndex(t => t.CreatedDate)
                        .HasDatabaseName("IX_Tickets_CreatedDate");
                }
                );

            Console.WriteLine("Entities tracked by EF:");
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                Console.WriteLine($"- {entity.Name}");
            }
        }

       
    }

}
