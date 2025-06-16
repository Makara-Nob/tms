// Repository/OrderRepository.cs
using System;
using System.Collections.Generic;
using System.Linq;
using tms.Model;

namespace tms.Repository
{
    public class OrderRepository
    {
        // Simulate a database table for Orders
        // In a real application, you would inject AppDbContext here and use EF Core.
        private static List<Order> _orders = new List<Order>();

        public OrderRepository()
        {
            // Optional: Initialize with some dummy data for demonstration
            if (_orders.Count == 0)
            {
                _orders.Add(new Order { OrderID = "ORD-001", CustomerID = "CUST-A1", OrderType = "Online", OrderDate = new DateTime(2025, 5, 10) });
                _orders.Add(new Order { OrderID = "ORD-002", CustomerID = "CUST-B2", OrderType = "Phone", OrderDate = new DateTime(2025, 5, 12) });
                _orders.Add(new Order { OrderID = "ORD-003", CustomerID = "CUST-C3", OrderType = "In-store", OrderDate = new DateTime(2025, 5, 15) });
            }
        }

        public List<Order> GetAllOrders()
        {
            // In a real app: return _context.Orders.ToList();
            return _orders.ToList(); // Return a copy to avoid direct modification
        }

        public Order GetOrderById(string orderId)
        {
            // In a real app: return _context.Orders.FirstOrDefault(o => o.OrderID == orderId);
            return _orders.FirstOrDefault(o => o.OrderID == orderId);
        }

        public void AddOrder(Order order)
        {
            if (_orders.Any(o => o.OrderID == order.OrderID))
            {
                throw new ArgumentException($"Order with ID '{order.OrderID}' already exists.");
            }
            _orders.Add(order);
            // In a real app: _context.Orders.Add(order); _context.SaveChanges();
        }

        public void UpdateOrder(Order orderToUpdate)
        {
            var existingOrder = _orders.FirstOrDefault(o => o.OrderID == orderToUpdate.OrderID);
            if (existingOrder != null)
            {
                existingOrder.CustomerID = orderToUpdate.CustomerID;
                existingOrder.OrderType = orderToUpdate.OrderType;
                existingOrder.OrderDate = orderToUpdate.OrderDate;
                // In a real app: _context.Entry(existingOrder).State = EntityState.Modified; _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException($"Order with ID '{orderToUpdate.OrderID}' not found.");
            }
        }

        public void DeleteOrder(string orderId)
        {
            var orderToRemove = _orders.FirstOrDefault(o => o.OrderID == orderId);
            if (orderToRemove != null)
            {
                _orders.Remove(orderToRemove);
                // In a real app: _context.Orders.Remove(orderToRemove); _context.SaveChanges();
            }
            else
            {
                throw new KeyNotFoundException($"Order with ID '{orderId}' not found.");
            }
        }
    }
}