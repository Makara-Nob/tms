using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tms.Model
{
    [Table("Tickets")]
    public class Ticket
    {
        [Key]
        [StringLength(50)]
        public string TicketID { get; set; }

        [Required]
        [StringLength(50)]
        public string SupplierID { get; set; }
        public string? InvoiceNo { get; set; }

        [Required]
        [StringLength(200)]
        public string SupplierName { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime SupplierDate { get; set; }

        [StringLength(200)]
        public string? CustomerPosition { get; set; }

        [StringLength(500)]
        public string? CustomerAddress { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        [Required]
        [Column(TypeName = "datetime2")]
        public DateTime ModifiedDate { get; set; }

        public Ticket()
        {
            TicketID = string.Empty;
            SupplierID = string.Empty;
            SupplierName = string.Empty;
            SupplierDate = DateTime.Now;
            CustomerPosition = string.Empty;
            CustomerAddress = string.Empty;
            CreatedDate = DateTime.Now;
            ModifiedDate = DateTime.Now;
        }
    }
}