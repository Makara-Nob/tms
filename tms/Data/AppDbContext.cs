using Delivery_info.Model;
using Microsoft.EntityFrameworkCore;
using Seat_info.Model;
using tms.Model;
using tms.projection;
using tms.Models; // Add this for DeliveryViewModel

namespace tms.Data
{
    public class AppDbContext : DbContext
    {
        // Your existing DbSets
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<SeatTypeConfigurations> SeatTypeConfigurations { get; set; }
        public DbSet<VehicleConfigurations> VehicleConfigurations { get; set; }
        public DbSet<SeatExclusions> SeatExclusions { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<TripDetail> TripDetail { get; set; }

        // Add this new DbSet for delivery stored procedure results
        public DbSet<DeliveryViewModel> DeliveryViewModels { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public AppDbContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                                  "Server=STEELBEAST;Database=tms;Trusted_Connection=True;Encrypt=False;"
                                  );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Your existing configurations
            modelBuilder.Entity<Route>()
          .Property(r => r.DistanceKm)
          .HasPrecision(10, 2);

            modelBuilder.Entity<Staff>()
                .Property(s => s.Salary)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Staff>();
            modelBuilder.Entity<Route>();
            modelBuilder.Entity<Vehicle>();

            modelBuilder.Entity<TripDetail>(entity =>
            {
                entity.HasNoKey();
                entity.ToView(null);
            });

            // Add configuration for DeliveryViewModel (for stored procedure results)
            modelBuilder.Entity<DeliveryViewModel>(entity =>
            {
                entity.HasNoKey();
                entity.ToView(null); // No table, used only for stored procedure results
            });

            // Configure Order entity (if not already configured)
            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.OrderID);
                entity.Property(e => e.OrderID).HasMaxLength(20);
                entity.Property(e => e.Sender).HasMaxLength(100);
                entity.Property(e => e.Reciever).HasMaxLength(100);
                entity.Property(e => e.OrderType).HasMaxLength(50);
                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18,2)");
            });

            // Configure Delivery entity (if not already configured)
            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.HasKey(e => e.DeliveryId);
                entity.Property(e => e.OrderId).HasMaxLength(20);
                entity.Property(e => e.DeliveryStatus).HasMaxLength(40);
            });

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