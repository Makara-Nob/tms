using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tms.Model
{
    public class VehicleConfigurations
    {
        [Key]
        public int ConfigId { get; set; }

        [Required]
        public string VehicleId { get; set; }

        [Required]
        public string VehicleName { get; set; }

        [Required]
        public string VehicleType { get; set; }

        public int TotalRows { get; set; }
        public int SeatsPerRow { get; set; }
        public string SeatLayout { get; set; }

        // Store aisle positions as comma-separated string
        public string AislePositionsString { get; set; }

        public bool HasUpperDeck { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? LastModified { get; set; }
        public string CreatedBy { get; set; }

        // Navigation properties
        public virtual ICollection<SeatTypeConfigurations> SeatTypeConfigurations { get; set; }
        public virtual ICollection<SeatExclusions> SeatExclusions { get; set; }

        // Helper property for UI (not mapped to database)
        [NotMapped]
        public List<int> AislePositions
        {
            get
            {
                if (string.IsNullOrEmpty(AislePositionsString))
                    return new List<int>();

                return AislePositionsString.Split(',')
                    .Where(x => int.TryParse(x, out _))
                    .Select(int.Parse)
                    .ToList();
            }
            set
            {
                AislePositionsString = value != null ? string.Join(",", value) : "";
            }
        }

        public VehicleConfigurations()
        {
            SeatTypeConfigurations = new List<SeatTypeConfigurations>();
            SeatExclusions = new List<SeatExclusions>();
        }
    }


}
