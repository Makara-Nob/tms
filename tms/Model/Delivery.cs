using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tms.Model;

namespace Delivery_info.Model
{
    public class Delivery
    {
        public int DeliveryId { get; set; }

        [ForeignKey(nameof(Order))]
        [Column("OrderId")]
        public string OrderId { get; set; }

        public string? DeliveryStatus { get; set; }

        // 👇 nav to its Order
        public Order Order { get; set; }
    }
}
