using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tms.Model
{
    public class Driver
    {
        [Key]
        public string StaffId { get; set; } // Primary Key and Foreign Key to Staff
        public int DriverID { get; set; } // This is likely an identity column in the DB, not the PK for EF Core here.
                                          // If it's an identity, you might need [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        [MaxLength(100)]
        public string LicenseNumber { get; set; }

        public DateTime? LicenseExpiryDate { get; set; }

        [MaxLength(50)]
        public string? LicenseType { get; set; }

        [MaxLength(100)]
        public string? Availability { get; set; }

        // Navigation property to Staff (one-to-one)
        [ForeignKey("StaffId")] // Explicitly define foreign key
        public virtual Staff Staff { get; set; }

    }
}
