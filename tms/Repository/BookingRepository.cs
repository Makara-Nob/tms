using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using tms.Data;
using tms.Model;

namespace Booking_info.Repository
{
    public class BookingRepository
    {
        public List<Booking> GetAll()
        {
            using var context = new AppDbContext();
            return context.Bookings.ToList();
        }

        public Booking? GetById(int bookingId)
        {
            using var context = new AppDbContext();
            return context.Bookings.FirstOrDefault(b => b.BookingID == bookingId);
        }

        public bool Add(Booking booking)
        {
            using var context = new AppDbContext();
            context.Bookings.Add(booking);
            return context.SaveChanges() > 0;
        }

        public bool Update(Booking booking)
        {
            using var context = new AppDbContext();
            context.Bookings.Update(booking);
            return context.SaveChanges() > 0;
        }

        public void Delete(int bookingId)
        {
            using var context = new AppDbContext();
            var booking = context.Bookings.FirstOrDefault(b => b.BookingID == bookingId);
            if (booking != null)
            {
                context.Bookings.Remove(booking);
                context.SaveChanges();
            }
        }

        // Optional search example – can adjust fields as needed
        public List<Booking> Search(string keyword)
        {
            using var context = new AppDbContext();

            return context.Bookings
                .Where(b =>
                    EF.Functions.Like(b.Status, $"%{keyword}%") ||
                    EF.Functions.Like(b.SeatNumber.ToString(), $"%{keyword}%") ||
                    EF.Functions.Like(b.BookingDate.ToString(), $"%{keyword}%"))
                .ToList();
        }
    }
}
