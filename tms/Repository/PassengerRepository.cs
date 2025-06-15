using Passenger_info.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tms.Data;

namespace tms.Repository
{
    public class PassengerRepository
    {
        public List<Passenger> GetAllPassengers()
        {
            using var context = new AppDbContext();
            return context.Passengers.ToList();
        }

        public void AddPassenger(Passenger passenger)
        {
            using var context = new AppDbContext();
            context.Passengers.Add(passenger);
            context.SaveChanges();
        }

        public void UpdatePassenger(Passenger passenger)
        {
            using var context = new AppDbContext();
            var existingPassenger = context.Passengers.FirstOrDefault(p => p.PassengerID == passenger.PassengerID);

            if (existingPassenger == null)
            {
                throw new InvalidOperationException("Passenger not found.");
            }

            // Update properties
            existingPassenger.PassengerName = passenger.PassengerName;
            existingPassenger.Gender = passenger.Gender;
            existingPassenger.PersonalNumber = passenger.PersonalNumber;
            existingPassenger.Email = passenger.Email;
            existingPassenger.IsActive = passenger.IsActive;

            context.SaveChanges();
        }

        public void DeletePassenger(int id)
        {
            using var context = new AppDbContext();
            var passenger = context.Passengers.FirstOrDefault(p => p.PassengerID == id);
            if (passenger != null)
            {
                context.Passengers.Remove(passenger);
                context.SaveChanges();
            }
        }

    }
}
