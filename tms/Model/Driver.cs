using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tms.Model;

public class Driver
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int DriverID { get; set; }  

    [Required]
    [MaxLength(450)]
    public string StaffId { get; set; } 

    [Required]
    [MaxLength(100)]
    public string LicenseNumber { get; set; }

    public DateTime? LicenseExpiryDate { get; set; }

    [MaxLength(50)]
    public string? LicenseType { get; set; }

    [MaxLength(100)]
    public string? Availability { get; set; }

    [ForeignKey("StaffId")]
    public virtual Staff Staff { get; set; }
}