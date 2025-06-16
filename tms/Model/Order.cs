// Model/Order.cs
using System;

namespace tms.Model
{
    public class Order
    {
        // Based on the Delivery Management form's fields, adapted for Order
        public string OrderID { get; set; } // Corresponds to Order ID on Delivery form
        public string CustomerID { get; set; } // Corresponds to Customer ID
        public string OrderType { get; set; } // Corresponds to Order Type
        public DateTime OrderDate { get; set; } // Corresponds to Order Date
        // You might also consider adding:
        // public string DeliveryStatus { get; set; } // If an Order can have its own delivery status
        // public decimal TotalAmount { get; set; }
        // public string DeliveryID { get; set; } // If an Order is linked to a Delivery
    }
}