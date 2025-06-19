using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Passenger_info.Model;
using tms.Data;

namespace tms.Repository
{
    public class PassengerRepository
    {
        public List<Passenger> GetAllPassengers()
        {
            using var context = new AppDbContext();
            return context.Passengers
                .FromSqlRaw("EXEC GetAllPassengers")
                .ToList();
        }

        public Passenger? GetPassengerById(string passengerId)
        {
            using var context = new AppDbContext();
            var param = new SqlParameter("@PassengerID", passengerId);
            return context.Passengers
                .FromSqlRaw("EXEC GetPassengerById @PassengerID", param)
                .AsEnumerable()
                .FirstOrDefault();
        }

        public void AddPassenger(Passenger passenger)
        {
            using var context = new AppDbContext();
            var parameters = new[]
            {
                new SqlParameter("@PassengerID", passenger.PassengerID),
                new SqlParameter("@PassengerName", passenger.PassengerName),
                new SqlParameter("@Gender", passenger.Gender),
                new SqlParameter("@PersonalNumber", passenger.PersonalNumber),
                new SqlParameter("@Email", passenger.Email),
                new SqlParameter("@IsActive", passenger.IsActive)
            };

            context.Database.ExecuteSqlRaw("EXEC InsertPassenger @PassengerID, @PassengerName, @Gender, @PersonalNumber, @Email, @IsActive", parameters);
        }

        public void UpdatePassenger(Passenger passenger)
        {
            using var context = new AppDbContext();
            var parameters = new[]
            {
                new SqlParameter("@PassengerID", passenger.PassengerID),
                new SqlParameter("@PassengerName", passenger.PassengerName),
                new SqlParameter("@Gender", passenger.Gender),
                new SqlParameter("@PersonalNumber", passenger.PersonalNumber),
                new SqlParameter("@Email", passenger.Email),
                new SqlParameter("@IsActive", passenger.IsActive)
            };

            context.Database.ExecuteSqlRaw("EXEC UpdatePassenger @PassengerID, @PassengerName, @Gender, @PersonalNumber, @Email, @IsActive", parameters);
        }

        public void DeletePassenger(string passengerId)
        {
            using var context = new AppDbContext();
            var param = new SqlParameter("@PassengerID", passengerId);
            context.Database.ExecuteSqlRaw("EXEC DeletePassenger @PassengerID", param);
        }

        public List<Passenger> SearchPassengers(string term)
        {
            using var context = new AppDbContext();
            var param = new SqlParameter("@SearchTerm", term);
            return context.Passengers
                .FromSqlRaw("EXEC SearchPassengers @SearchTerm", param)
                .ToList();
        }
    }
}
