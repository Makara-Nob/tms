using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Seat_info.Model;
using System.Data;
using tms.Config;
using tms.Data;
using tms.Model;

namespace tms.Repository
{
    public class SeatRepository
    {
        // Async: Get all seats
        public async Task<List<Seat>> GetAllSeatsAsync()
        {
            using var context = new AppDbContext();
            return await context.Seats
                .FromSqlRaw("EXEC GetAllSeats")
                .ToListAsync();
        }

        // Async: Add seat
        public async Task AddSeatAsync(Seat seat)
        {
            using var context = new AppDbContext();
            await context.Database.ExecuteSqlRawAsync(
                "EXEC InsertSeat @VehicleID, @SeatNumber, @SeatType, @SeatStatus",
                new SqlParameter("@VehicleID", seat.VehicleID ?? (object)DBNull.Value),
                new SqlParameter("@SeatNumber", seat.SeatNumber ?? (object)DBNull.Value),
                new SqlParameter("@SeatType", seat.SeatType ?? (object)DBNull.Value),
                new SqlParameter("@SeatStatus", seat.seatStatus ?? (object)DBNull.Value)
            );
        }

        // Async: Update seat
        public async Task UpdateSeatAsync(Seat seat)
        {
            using var context = new AppDbContext();
            await context.Database.ExecuteSqlRawAsync(
                "EXEC UpdateSeat @SeatID, @VehicleID, @SeatNumber, @SeatType, @SeatStatus",
                new SqlParameter("@SeatID", seat.SeatId),
                new SqlParameter("@VehicleID", seat.VehicleID ?? (object)DBNull.Value),
                new SqlParameter("@SeatNumber", seat.SeatNumber ?? (object)DBNull.Value),
                new SqlParameter("@SeatType", seat.SeatType ?? (object)DBNull.Value),
                new SqlParameter("@SeatStatus", seat.seatStatus ?? (object)DBNull.Value)
            );
        }

        // Async: Delete seat
        public async Task DeleteSeatAsync(int id)
        {
            using var context = new AppDbContext();
            await context.Database.ExecuteSqlRawAsync(
                "EXEC DeleteSeat @SeatID",
                new SqlParameter("@SeatID", id)
            );
        }

        // Async: Save vehicle config
        public async Task<bool> SaveVehicleConfigurationAsync(VehicleConfigurations config, Vehicle vehicle = null, bool isUpdate = false)
        {
            try
            {
                using var context = new AppDbContext();
                context.Database.SetCommandTimeout(120);

                var parameters = new[]
                {
                    new SqlParameter("@VehicleID", config.VehicleId),
                    new SqlParameter("@Type", vehicle?.Type ?? "Bus"),
                    new SqlParameter("@Capacity", vehicle?.Capacity ?? config.TotalRows * config.SeatsPerRow),
                    new SqlParameter("@LicensePlate", vehicle?.LicensePlate ?? ""),
                    new SqlParameter("@RouteID", vehicle?.RouteID ?? ""),
                    new SqlParameter("@Status", vehicle?.Status ?? "Active"),
                    new SqlParameter("@VehicleName", config.VehicleName),
                    new SqlParameter("@VehicleType", config.VehicleType),
                    new SqlParameter("@TotalRows", config.TotalRows),
                    new SqlParameter("@SeatsPerRow", config.SeatsPerRow),
                    new SqlParameter("@SeatLayout", config.SeatLayout),
                    new SqlParameter("@CreatedBy", config.CreatedBy),
                    new SqlParameter("@AislePositionsString", config.AislePositionsString ?? (object)DBNull.Value),
                    new SqlParameter("@HasUpperDeck", config.HasUpperDeck),
                    new SqlParameter("@IsUpdate", isUpdate)
                };

                    await context.Database.ExecuteSqlRawAsync(
                    "EXEC sp_CreateOrUpdateVehicle @VehicleID, @Type, @Capacity, @LicensePlate, @RouteID, @Status, " +
                    "@VehicleName, @VehicleType, @TotalRows, @SeatsPerRow, @SeatLayout, @CreatedBy, " +
                    "@AislePositionsString, @HasUpperDeck, @IsUpdate", parameters);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving vehicle configuration: {ex.Message}", ex);
            }
        }

        // Async: Add SeatType config

        public async Task<int> AddSeatTypeConfigurationAsync(SeatTypeConfigurations config, String? VehicleId)
        {
            try
            {
                using var context = new AppDbContext();

                var idParameter = new SqlParameter
                {
                    ParameterName = "@Id",
                    SqlDbType = SqlDbType.Int,
                    Direction = ParameterDirection.InputOutput,
                    Value = config.ConfigId == 0 ? 0 : config.ConfigId
                };

                var parameters = new[]
                {
                    idParameter,
                    new SqlParameter("@VehicleId", VehicleId),
                    new SqlParameter("@SeatType", config.SeatType),
                    new SqlParameter("@FromRow", config.FromRow),
                    new SqlParameter("@ToRow", config.ToRow),
                    new SqlParameter("@BasePrice", config.BasePrice),
                    new SqlParameter("@IsActive", config.IsActive)
                };

                await context.Database.ExecuteSqlRawAsync(
                    "EXEC sp_CreateOrUpdateSeatTypeConfig @Id OUTPUT, @VehicleId, @SeatType, @FromRow, @ToRow, @BasePrice, @IsActive",
                    parameters
                );

                return (int)idParameter.Value;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving seat type configuration: {ex.Message}", ex);
            }
        }

        // Async: Add Seat exclusion
        public async Task<int> AddSeatExclusionAsync(SeatExclusions exclusion)
        {
            using var context = new AppDbContext();
            var idParameter = new SqlParameter
            {
                ParameterName = "@NewId",
                SqlDbType = System.Data.SqlDbType.Int,
                Direction = System.Data.ParameterDirection.Output
            };

            await context.Database.ExecuteSqlRawAsync(
                "EXEC InsertSeatExclusion @VehicleId, @RowNumber, @SeatPosition, @Reason, @IsTemporary, @ExclusionStart, @ExclusionEnd, @NewId OUTPUT",
                new SqlParameter("@RowNumber", exclusion.RowNumber),
                new SqlParameter("@SeatPosition", exclusion.SeatPosition.HasValue ? exclusion.SeatPosition.Value : DBNull.Value),
                new SqlParameter("@Reason", exclusion.Reason),
                new SqlParameter("@IsTemporary", exclusion.IsTemporary),
                new SqlParameter("@ExclusionStart", exclusion.ExclusionStart ?? (object)DBNull.Value),
                new SqlParameter("@ExclusionEnd", exclusion.ExclusionEnd ?? (object)DBNull.Value),
                idParameter
            );

            return (int)idParameter.Value;
        }



        // Async: Generate seats from config
        public class SeatCountResult
        {
            public int Count { get; set; }
        }

        public async Task<int> GenerateSeatsFromConfigurationAsync(string vehicleId, string updatedBy = "System")
        {
            try
            {
                using var context = new AppDbContext();
                context.Database.SetCommandTimeout(120);
                var parameters = new[]
                {
            new SqlParameter("@VehicleID", vehicleId),
            new SqlParameter("@UpdatedBy", updatedBy)
        };

                // Execute stored procedure
                var results = await context.Database
                    .SqlQueryRaw<SeatGenerationResult>(
                        "EXEC sp_GenerateSeatsForVehicle @VehicleID, @UpdatedBy",
                        parameters)
                    .ToListAsync();

                if (results.Any() && results.First().Result == "Success")
                {
                    // Use wrapper class - IMPORTANT: Use "as Count" alias
                    var seatCountResult = await context.Database
                        .SqlQueryRaw<SeatCountResult>(
                            "SELECT COUNT(*) as Count FROM [dbo].[Seats] WHERE [VehicleID] = @VehicleID",
                            new SqlParameter("@VehicleID", vehicleId))
                        .FirstOrDefaultAsync();

                    return seatCountResult?.Count ?? 0;
                }
                else
                {
                    throw new Exception(results.FirstOrDefault()?.Message ?? "Unknown error occurred");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error generating seats: {ex.Message}", ex);
            }
        }

        // Async: Update seat status
        public async Task<bool> UpdateSeatStatusAsync(int seatId, string newStatus, string updatedBy)
        {
            using var context = new AppDbContext();
            var result = await context.Database.ExecuteSqlRawAsync(
                "EXEC UpdateSeatStatus @SeatId, @NewStatus, @UpdatedBy",
                new SqlParameter("@SeatId", seatId),
                new SqlParameter("@NewStatus", newStatus),
                new SqlParameter("@UpdatedBy", updatedBy)
            );
            return result > 0;
        }

        // Async: Get seats by vehicle
        public async Task<List<Seat>> GetSeatsByVehicleIdAsync(string vehicleId)
        {
            using var context = new AppDbContext();
            return await context.Seats
                .FromSqlRaw("EXEC GetSeatsByVehicleId @VehicleId",
                    new SqlParameter("@VehicleId", vehicleId))
                .ToListAsync();
        }
    }
}
