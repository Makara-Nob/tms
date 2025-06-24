using tms.Model;
using tms.Repository;

namespace tms.Config
{
    public class ValidateVehicleConfiguration
    {
        public List<string> ValidateConfiguration(VehicleConfigurations config)
        {
            var errors = new List<string>();

            // Vehicle ID validation - should exist as foreign key
            if (string.IsNullOrEmpty(config.VehicleId))
            {
                errors.Add("Vehicle ID is required");
            }
            else if (!IsValidVehicleId(config.VehicleId))
            {
                errors.Add($"Vehicle ID '{config.VehicleId}' does not exist. Please select a valid vehicle from the dropdown.");
            }

            if (string.IsNullOrEmpty(config.VehicleName))
                errors.Add("Vehicle Name is required");

            if (string.IsNullOrEmpty(config.VehicleType))
                errors.Add("Vehicle Type is required");

            if (config.TotalRows <= 0)
                errors.Add("Total rows must be greater than 0");

            if (config.SeatsPerRow <= 0)
                errors.Add("Seats per row must be greater than 0");

            if (string.IsNullOrEmpty(config.SeatLayout))
                errors.Add("Seat layout is required");

            // Validate seat layout against seats per row
            if (!ValidateSeatLayoutConsistency(config.SeatLayout, config.SeatsPerRow))
                errors.Add($"Seat layout '{config.SeatLayout}' doesn't match seats per row ({config.SeatsPerRow})");

            // Seat type configuration validation
            if (config.SeatTypeConfigurations == null || !config.SeatTypeConfigurations.Any())
            {
                errors.Add("At least one seat type configuration is required");
            }
            else
            {
                // Check for overlapping seat type ranges
                var activeSeatTypes = config.SeatTypeConfigurations
                    .Where(t => t.IsActive)
                    .OrderBy(t => t.FromRow)
                    .ToList();

                if (!activeSeatTypes.Any())
                    errors.Add("At least one active seat type configuration is required");

                // Validate each seat type configuration
                foreach (var seatType in activeSeatTypes)
                {
                    if (string.IsNullOrEmpty(seatType.SeatType))
                        errors.Add("Seat type name is required");

                    if (seatType.FromRow <= 0)
                        errors.Add($"FromRow must be greater than 0 for seat type {seatType.SeatType}");

                    if (seatType.ToRow <= 0)
                        errors.Add($"ToRow must be greater than 0 for seat type {seatType.SeatType}");

                    if (seatType.FromRow > seatType.ToRow)
                        errors.Add($"FromRow cannot be greater than ToRow for seat type {seatType.SeatType}");

                    if (seatType.ToRow > config.TotalRows)
                        errors.Add($"ToRow ({seatType.ToRow}) cannot exceed total rows ({config.TotalRows}) for seat type {seatType.SeatType}");

                    if (seatType.BasePrice < 0)
                        errors.Add($"Base price cannot be negative for seat type {seatType.SeatType}");
                }

                // Check for overlapping ranges
                for (int i = 0; i < activeSeatTypes.Count - 1; i++)
                {
                    if (activeSeatTypes[i].ToRow >= activeSeatTypes[i + 1].FromRow)
                    {
                        errors.Add($"Overlapping seat type ranges: {activeSeatTypes[i].SeatType} (rows {activeSeatTypes[i].FromRow}-{activeSeatTypes[i].ToRow}) and {activeSeatTypes[i + 1].SeatType} (rows {activeSeatTypes[i + 1].FromRow}-{activeSeatTypes[i + 1].ToRow})");
                    }
                }

                // Check for gaps in seat type coverage
                var sortedTypes = activeSeatTypes.OrderBy(t => t.FromRow).ToList();
                if (sortedTypes.First().FromRow > 1)
                    errors.Add($"Seat type configuration doesn't start from row 1 (starts from row {sortedTypes.First().FromRow})");

                if (sortedTypes.Last().ToRow < config.TotalRows)
                    errors.Add($"Seat type configuration doesn't cover all rows (ends at row {sortedTypes.Last().ToRow}, but vehicle has {config.TotalRows} rows)");

                // Check for gaps between ranges
                for (int i = 0; i < sortedTypes.Count - 1; i++)
                {
                    if (sortedTypes[i].ToRow + 1 < sortedTypes[i + 1].FromRow)
                    {
                        errors.Add($"Gap in seat type coverage between rows {sortedTypes[i].ToRow + 1} and {sortedTypes[i + 1].FromRow - 1}");
                    }
                }
            }

            return errors;
        }

        private bool ValidateSeatLayoutConsistency(string seatLayout, int seatsPerRow)
        {
            if (string.IsNullOrEmpty(seatLayout)) return false;

            // Calculate expected seats based on layout
            var layoutParts = seatLayout.Split('-');
            int expectedSeats = 0;

            foreach (var part in layoutParts)
            {
                if (int.TryParse(part, out int seats))
                {
                    expectedSeats += seats;
                }
                else
                {
                    return false; // Invalid layout format
                }
            }

            return expectedSeats == seatsPerRow;
        }

        // Additional helper method to check for duplicate vehicle IDs
        private bool IsValidVehicleId(string vehicleId)
        {
            try
            {
                VehicleRepository _vehicleRepository = new VehicleRepository();

                if (string.IsNullOrEmpty(vehicleId)) return false;

                var existingVehicles = _vehicleRepository?.GetAll();
                if (existingVehicles == null) return false;

                // Check if vehicle ID exists in the vehicles table
                return existingVehicles.Any(v =>
                    v.VehicleID?.Equals(vehicleId, StringComparison.OrdinalIgnoreCase) == true);
            }
            catch
            {
                return false;
            }
        }
    }
}
