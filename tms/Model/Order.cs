using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tms.Model
{
    public class Order
    {
        [Key]
        [MaxLength(20)]
        public string OrderID { get; set; }

        [Required]
        [MaxLength(20)]
        public string Sender { get; set; }

        [Required]
        [MaxLength(20)]
        public string Reciever { get; set; }

        [Required]
        [MaxLength(50)]
        public string OrderType { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        // Optional: link to Delivery (One-to-One or One-to-Many depending on design)
        public int? DeliveryId { get; set; }

        [ForeignKey("DeliveryId")]
        public Delivery_info.Model.Delivery? Delivery { get; set; }

        // Optional: order-level delivery status
        [MaxLength(20)]
        public string? DeliveryStatus { get; set; }

        // Optional: financial info
        [Column(TypeName = "decimal(10,2)")]
        public decimal? TotalAmount { get; set; }
    }
}
