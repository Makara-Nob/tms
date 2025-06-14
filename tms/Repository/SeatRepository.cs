using Seat_info.Model;
using tms.Data;

namespace Seat_info.Repository
{
    public class SeatRepository
    {
        public List<Seat> GetAllSeats()
        {
            using var context = new AppDbContext();
            return context.Seats.ToList();
        }

        public void AddSeat(Seat seat)
        {
            using var context = new AppDbContext();
            context.Seats.Add(seat);
            context.SaveChanges();
        }
        public void UpdateSeat(Seat seat)
        {
            using var context = new AppDbContext();
            context.Seats.Update(seat);
            context.SaveChanges();
        }
        public void DeleteSeat(int id)
        {
            using var context = new AppDbContext();
            var seat = context.Seats.FirstOrDefault(s => s.SeatId == id);
            if (seat != null)
            {
                context.Seats.Remove(seat);
                context.SaveChanges();
            }
        }
    }
}