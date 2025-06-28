using Delivery_info.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace tms.Model
{
    public class Order
    {
        [Key][MaxLength(20)] public string OrderID { get; set; }
        [Required][MaxLength(20)] public string Sender { get; set; }
        [Required][MaxLength(20)] public string Reciever { get; set; }
        [Required][MaxLength(50)] public string OrderType { get; set; }
        [Required] public DateTime OrderDate { get; set; }
        public int IsAssigned { get; set; } = 0;

        [Column(TypeName = "decimal(10,2)")]
        public decimal? TotalAmount { get; set; }

        // 👇 1‑to‑1 (or 1‑to‑0/1) nav back to Delivery
        public Delivery Delivery { get; set; }
    }
}