using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tms.Model
{
    public class Payment
    {
        [Key]
        public string PaymentID { get; set; }

        [Required]
        [StringLength(50)]
        public string InvoiceNo { get; set; }

        [Required]
        [StringLength(50)]
        public string PaymentMethod { get; set; }

        [Required]
        [StringLength(50)]
        public string StaffID { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountPaid { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime ModifiedDate { get; set; } = DateTime.Now;

        public override string ToString()
        {
            return $"ID: {PaymentID} | Invoice: {InvoiceNo} | Amount: ${AmountPaid:F2} | Method: {PaymentMethod} | Status: {Status}";
        }
    }
}