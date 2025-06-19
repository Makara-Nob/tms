using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Seat_info.Model;
using tms.Data;

namespace tms.Repository
{
    public class SeatRepository
    {
        public List<Seat> GetAllSeats()
        {
            using var context = new AppDbContext();
            return context.Seats
                .FromSqlRaw("EXEC GetAllSeats")
                .ToList();
        }

        public void AddSeat(Seat seat)
        {
            using var context = new AppDbContext();
            context.Database.ExecuteSqlRaw(
                "EXEC InsertSeat @VehicleID, @SeatNumber, @SeatType, @SeatStatus",
                new SqlParameter("@VehicleID", seat.VehicleID ?? (object)DBNull.Value),
                new SqlParameter("@SeatNumber", seat.SeatNumber ?? (object)DBNull.Value),
                new SqlParameter("@SeatType", seat.SeatType ?? (object)DBNull.Value),
                new SqlParameter("@SeatStatus", seat.seatStatus ?? (object)DBNull.Value)
            );
        }

        public void UpdateSeat(Seat seat)
        {
            using var context = new AppDbContext();
            context.Database.ExecuteSqlRaw(
                "EXEC UpdateSeat @SeatID, @VehicleID, @SeatNumber, @SeatType, @SeatStatus",
                new SqlParameter("@SeatID", seat.SeatId),
                new SqlParameter("@VehicleID", seat.VehicleID ?? (object)DBNull.Value),
                new SqlParameter("@SeatNumber", seat.SeatNumber ?? (object)DBNull.Value),
                new SqlParameter("@SeatType", seat.SeatType ?? (object)DBNull.Value),
                new SqlParameter("@SeatStatus", seat.seatStatus ?? (object)DBNull.Value)
            );
        }

        public void DeleteSeat(int id)
        {
            using var context = new AppDbContext();
            context.Database.ExecuteSqlRaw(
                "EXEC DeleteSeat @SeatID",
                new SqlParameter("@SeatID", id)
            );
        }
    }
}
