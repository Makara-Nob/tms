﻿
using Delivery_info.Model;
using Microsoft.EntityFrameworkCore;
using Seat_info.Model;
using tms.Model;
using tms.projection;

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
        public DbSet<Order> Orders { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<SpResult> SpResults { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public DbSet<SeatTypeConfigurations> SeatTypeConfigurations { get; set; }
        public DbSet<VehicleConfigurations> VehicleConfigurations { get; set; }
        public DbSet<SeatExclusions> SeatExclusions { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<TripDetail> TripDetail { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public AppDbContext() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                                  "Server=FURINA-SIMP\\SQLEXPRESS02;Database=tms;User Id=sa;Password=Chinsakda@3;Encrypt=False;"
                                  );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Trip>().HasKey(t => t.TripID);
            modelBuilder.Entity<Vehicle>().HasKey(v => v.VehicleID);
            modelBuilder.Entity<Driver>().HasKey(d => d.StaffId);
            modelBuilder.Entity<Route>().HasKey(r => r.RouteID);



            modelBuilder.Entity<Route>()
          .Property(r => r.DistanceKm)
          .HasPrecision(10, 2);

            modelBuilder.Entity<Staff>()
                .Property(s => s.Salary)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Staff>();
            modelBuilder.Entity<Route>();
            modelBuilder.Entity<Vehicle>();
            modelBuilder.Entity<Driver>()
        .HasOne(d => d.Staff)
        .WithOne()
        .HasForeignKey<Driver>(d => d.StaffId);

            modelBuilder.Entity<Trip>()
                .HasOne(t => t.Vehicle)
                .WithMany()
                .HasForeignKey(t => t.VehicleID);

            modelBuilder.Entity<Trip>()
                .HasOne(t => t.Driver)
                .WithMany()
                .HasForeignKey(t => t.DriverID);

            modelBuilder.Entity<Trip>()
                .HasOne(t => t.Route)
                .WithMany()
                .HasForeignKey(t => t.RouteID);

            modelBuilder.Entity<TripDetail>(entity =>
            {
                entity.HasNoKey();
                entity.ToView(null);  
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
            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(i => i.InvoiceID);
                entity.Property(i => i.TotalAmount).HasColumnType("decimal(18,2)");
            });
            modelBuilder.Entity<SpResult>(entity =>
            {
                entity.HasNoKey();
                entity.Property(e => e.Result).HasColumnName("Result");
                entity.Property(e => e.Message).HasColumnName("Message");
            });
            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(p => p.AmountPaid).HasColumnType("decimal(18,2)");
                entity.HasIndex(p => p.InvoiceNo).HasDatabaseName("IX_Payments_InvoiceNo");
                entity.HasIndex(p => p.StaffID).HasDatabaseName("IX_Payments_StaffID");
                entity.HasIndex(p => p.PaymentDate).HasDatabaseName("IX_Payments_PaymentDate");
            });

            Console.WriteLine("Entities tracked by EF:");
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                Console.WriteLine($"- {entity.Name}");
            }
        }

       
    }

}
