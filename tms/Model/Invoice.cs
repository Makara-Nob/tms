using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Invoice
{
    [Key]
    [StringLength(50)]
    public string InvoiceID { get; set; } = string.Empty;

    [Required]
    public DateTime InvoiceDate { get; set; }

    [Required]
    [StringLength(50)]
    public string StaffID { get; set; } = string.Empty;

    [Required]
    [Column(TypeName = "decimal(12,2)")]
    public decimal TotalAmount { get; set; }

    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}