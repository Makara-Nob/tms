using System;

namespace tms.Models
{
    public class DeliveryViewModel
    {
        public int DeliveryId { get; set; }
        public string OrderId { get; set; }
        public string DeliveryStatus { get; set; }
        public string OrderID { get; set; }
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public string OrderType { get; set; }
        public DateTime OrderDate { get; set; }
        public int IsAssigned { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}