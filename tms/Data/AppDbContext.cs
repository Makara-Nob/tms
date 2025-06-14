using Microsoft.EntityFrameworkCore;
using Staff_info.Model;
using Seat_info.Model;
using Vehicle_info.Model;

namespace Staff_info.Data
{
    public class AppDbContext : DbContext
    {

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
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Staff> Staffs { get; set; }
    }

}
