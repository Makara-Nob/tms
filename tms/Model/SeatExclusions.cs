
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tms.Model
{
    public class SeatExclusions
    {
        [Key]
        public int ExclusionId { get; set; }

        [ForeignKey("VehicleConfigurations")]
        public int ConfigId { get; set; }

        public int RowNumber { get; set; }
        public int? SeatPosition { get; set; }

        [Required]
        public string Reason { get; set; }

        public bool IsTemporary { get; set; }
        public DateTime? ExclusionStart { get; set; }
        public DateTime? ExclusionEnd { get; set; }

        // Navigation property
        public virtual VehicleConfigurations VehicleConfigurations { get; set; }
    }
}
