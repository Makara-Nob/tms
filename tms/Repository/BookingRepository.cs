using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using tms.Data;
using tms.Model;

namespace tms.Repository
{
    public class BookingRepository
    {
        public List<Booking> GetAll()
        {
            using var context = new AppDbContext();
            return context.Bookings
                .FromSqlRaw("EXEC GetAllBookings")
                .ToList();
        }

        public Booking? GetById(int bookingId)
        {
            using var context = new AppDbContext();
            return context.Bookings
                .FromSqlRaw("EXEC GetBookingById @BookingID",
                    new SqlParameter("@BookingID", bookingId))
                .AsEnumerable()
                .FirstOrDefault();
        }

        public bool Add(Booking booking)
        {
            using var context = new AppDbContext();

            var bookingIdParam = new SqlParameter
            {
                ParameterName = "@NewBookingID",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Output
            };

            var result = context.Database.ExecuteSqlRaw(
                "EXEC InsertBooking @BookingDate, @SeatNumber, @Status, @PassengerContact, @Gender, @StaffID, @TripID, @NewBookingID OUTPUT",
                new SqlParameter("@BookingDate", booking.BookingDate),
                new SqlParameter("@SeatNumber", booking.SeatNumber),
                new SqlParameter("@Status", booking.Status ?? (object)DBNull.Value),
                new SqlParameter("@PassengerContact", booking.PassengerContact ?? (object)DBNull.Value),
                new SqlParameter("@Gender", booking.Gender ?? (object)DBNull.Value),
                new SqlParameter("@StaffID", booking.StaffID ?? (object)DBNull.Value),
                new SqlParameter("@TripID", booking.TripID),
                bookingIdParam
            );

            return result > 0;
        }


        public bool Update(Booking booking)
        {
            using var context = new AppDbContext();

            var result = context.Database.ExecuteSqlRaw(
                "EXEC UpdateBooking @BookingID, @BookingDate, @SeatNumber, @Status, @PassengerContact, @Gender, @StaffID, @TripID",
                new SqlParameter("@BookingID", booking.BookingID),
                new SqlParameter("@BookingDate", booking.BookingDate),
                new SqlParameter("@SeatNumber", booking.SeatNumber),
                new SqlParameter("@Status", booking.Status ?? (object)DBNull.Value),
                new SqlParameter("@PassengerContact", booking.PassengerContact ?? (object)DBNull.Value),
                new SqlParameter("@Gender", booking.Gender ?? (object)DBNull.Value),
                new SqlParameter("@StaffID", booking.StaffID ?? (object)DBNull.Value),
                new SqlParameter("@TripID", booking.TripID)
            );

            return result > 0;
        }


        public bool Delete(int bookingId)
        {
            using var context = new AppDbContext();

            var result = context.Database.ExecuteSqlRaw(
                "EXEC DeleteBooking @BookingID",
                new SqlParameter("@BookingID", bookingId)
            );

            return result > 0;
        }
    }
}
