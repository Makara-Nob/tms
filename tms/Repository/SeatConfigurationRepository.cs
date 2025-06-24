using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using tms.Data;
using tms.Model;

namespace tms.Repository
{

    public class SeatConfigurationRepository
    {
        public List<VehicleConfigurations> GetVehicleConfiguration(string vehicleId)
        {
            using var context = new AppDbContext();

            var param = new SqlParameter("@VehicleId", vehicleId);

            return context.VehicleConfigurations
                .FromSqlRaw("EXEC GetVehicleSeatConfiguration @VehicleId", param)
                .ToList();
        }

        public List<SeatTypeConfigurations> GetSeatTypeConfigurations(string vehicleId)
        {
            using var context = new AppDbContext();

            var param = new SqlParameter("@VehicleId", vehicleId);

            return context.SeatTypeConfigurations
                .FromSqlRaw("EXEC GetSeatTypeConfigurations @VehicleId", param)
                .ToList();
        }

        public List<SeatExclusions> GetSeatExclusions(string vehicleId)
        {
            using var context = new AppDbContext();

            var param = new SqlParameter("@VehicleId", vehicleId);

            return context.SeatExclusions
                .FromSqlRaw("EXEC GetSeatExclusions @VehicleId", param)
                .ToList();
        }

    }
}
