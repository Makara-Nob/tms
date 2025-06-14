using System;

namespace tms.Model
{
    public class Route
    {
        public string RouteID { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public decimal? DistanceKm { get; set; }
        public int? EstimatedTimeMinutes { get; set; }
        public string VehicleAssigned { get; set; }
        public string Priority { get; set; }
        public bool AvoidTolls { get; set; }
        public bool EnableWeatherAlerts { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public Route()
        {
            RouteID = string.Empty;
            StartPoint = string.Empty;
            EndPoint = string.Empty;
            VehicleAssigned = string.Empty;
            Priority = string.Empty;
            AvoidTolls = false;
            EnableWeatherAlerts = false;
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
    }
}