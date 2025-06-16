using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tms.Model
{
    public class Vehicle
    {
        [Key]
        public string VehicleID { get; set; }
        public string Type { get; set; }
        public int? Capacity { get; set; }
        public string LicensePlate { get; set; }
        public string RouteID { get; set; }
        public string Status { get; set; }
        public DateTime? MaintenanceDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("RouteID")]
        public Route? Route { get; set; }

        public Vehicle()
        {
            VehicleID = string.Empty;
            Type = string.Empty;
            LicensePlate = string.Empty;
            RouteID = string.Empty;
            Status = string.Empty;
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
    }
}