
using tms.Model;
using tms.Repository;

namespace tms.Config
{
    public class SeatLayoutService
    {
        private readonly SeatRepository? _seatRepository;
        private readonly VehicleRepository? _vehicleRepository;


        public SeatLayoutService() {
            _seatRepository = new SeatRepository();
            _vehicleRepository = new VehicleRepository();
        } 

        public async Task<bool> ConfigureVehicleLayoutAsync(VehicleConfigurations vehicleConfig,
            ICollection<SeatTypeConfigurations> seatTypes, ICollection<SeatExclusions> exclusions = null)
        {
            try
            {
                string vehicleId = vehicleConfig.VehicleId;
                var vehicle = _vehicleRepository?.GetById(vehicleConfig.VehicleId);

                bool isUpdate = vehicle != null;

                // Step 1: Save vehicle configuration
                bool vehicleSaved = await _seatRepository.SaveVehicleConfigurationAsync(vehicleConfig, vehicle, isUpdate);
                if (!vehicleSaved)
                {
                    MessageBox.Show("Failed to save vehicle configuration.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Step 2: Add seat type configurations
                foreach (var seatType in seatTypes)
                {
                    int configId = await _seatRepository.AddSeatTypeConfigurationAsync(seatType, vehicleId);
                    if (configId == 0)
                    {
                        MessageBox.Show($"Failed to save seat type configuration: {seatType.SeatType}",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                // Step 3: Add seat exclusions if any
                if (exclusions != null)
                {
                    foreach (var exclusion in exclusions)
                    {
                        int exclusionId = await _seatRepository.AddSeatExclusionAsync(exclusion);
                        if (exclusionId == 0)
                        {
                            MessageBox.Show($"Failed to save seat exclusion for row {exclusion.RowNumber}",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }

                // Step 4: Generate seats based on configuration
                int seatsGenerated = await _seatRepository.GenerateSeatsFromConfigurationAsync(vehicleId);

                if (seatsGenerated > 0)
                {
                    MessageBox.Show($"Successfully configured vehicle layout and generated {seatsGenerated} seats.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Vehicle configuration saved but no seats were generated.",
                        "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error configuring vehicle layout: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    
}
}
