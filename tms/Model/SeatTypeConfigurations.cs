using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tms.Model
{
    public class SeatTypeConfigurations
    {
        [Key]
        public int SeatTypeConfigId { get; set; }

        [ForeignKey("VehicleConfigurations")]
        public int ConfigId { get; set; }

        [Required]
        public string SeatType { get; set; }

        public int FromRow { get; set; }
        public int ToRow { get; set; }

        // Store specific seats as comma-separated string
        public string SpecificSeatsString { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal BasePrice { get; set; }

        public string Description { get; set; }
        public string Features { get; set; }
        public bool IsActive { get; set; } = true;

        // Helper property for UI
        [NotMapped]
        public List<int> SpecificSeats
        {
            get
            {
                if (string.IsNullOrEmpty(SpecificSeatsString))
                    return new List<int>();

                return SpecificSeatsString.Split(',')
                    .Where(x => int.TryParse(x, out _))
                    .Select(int.Parse)
                    .ToList();
            }
            set
            {
                SpecificSeatsString = value != null ? string.Join(",", value) : "";
            }
        }

        // Navigation property
        public virtual VehicleConfigurations VehicleConfigurations { get; set; }
    }
}
