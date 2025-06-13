
using Microsoft.EntityFrameworkCore;
using Staff_info.Model;

namespace Staff_info.Data
{
    public class AppDbContext: DbContext
    {
    
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
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Staff> Staffs { get; set; }
    }

}
