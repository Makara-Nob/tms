
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace tms.Model
{
    public class Trip
    {
        [Key]
        [Column("TripID")]
        public string? TripId { get; set; }

        [ForeignKey("Vehicle")]
        [Column("VehicleID")]
        public string? VehicleId { get; set; }

        [ForeignKey("Driver")]
        [Column("DriverID")]
        public string? DriverId { get; set; }

        [ForeignKey("Route")]
        [Column("RouteID")]
        public string? RouteId { get; set; }

        public DateTime DepatureTime { get; set; }

        [Column("status")]
        public String? Status { get; set; }

        public virtual Vehicle? Vehicle { get; set; }
        public virtual Staff? Driver { get; set; }
        public virtual Route? Route { get; set; }
    }
}
