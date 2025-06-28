using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using tms.Data;
using tms.Models;

namespace Delivery_info.Repository
{
    public class DeliveryRepository
    {
        private readonly AppDbContext _context;

        public DeliveryRepository(AppDbContext context)
        {
            _context = context;
        }

        // Constructor for when no DI is used (creates its own context)
        public DeliveryRepository()
        {
            _context = new AppDbContext();
        }

        public List<DeliveryViewModel> GetAllDeliveries()
        {
            try
            {
                return _context.DeliveryViewModels
                    .FromSqlRaw("EXEC GetAllDeliveries")
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting all deliveries: {ex.Message}", ex);
            }
        }

        public List<DeliveryViewModel> GetUnassignedDeliveries()
        {
            try
            {
                return _context.DeliveryViewModels
                    .FromSqlRaw("EXEC GetUnassignedDeliveries")
                    .ToList();
            }
            catch (Exception ex)
            {
                // Fallback to LINQ if stored procedure doesn't exist yet
                return GetUnassignedDeliveriesLinq();
            }
        }

        public List<DeliveryViewModel> GetAssignedDeliveries()
        {
            try
            {
                return _context.DeliveryViewModels
                    .FromSqlRaw("EXEC GetAssignedDeliveries")
                    .ToList();
            }
            catch (Exception ex)
            {
                // Fallback to LINQ if stored procedure doesn't exist yet
                return GetAssignedDeliveriesLinq();
            }
        }

        public List<DeliveryViewModel> SearchDeliveries(string searchTerm)
        {
            try
            {
                return _context.DeliveryViewModels
                    .FromSqlRaw("EXEC SearchDeliveries @p0", searchTerm ?? string.Empty)
                    .ToList();
            }
            catch (Exception ex)
            {
                // Fallback to LINQ search
                return SearchDeliveriesLinq(searchTerm);
            }
        }

        public bool UpdateDeliveryStatus(string deliveryId, string statusValue)
        {
            try
            {
                var result = _context.Database
                    .ExecuteSqlRaw("EXEC UpdateDeliveryStatus @p0, @p1", deliveryId, statusValue);

                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating delivery status: {ex.Message}", ex);
            }
        }

        public bool AssignTripToOrder(string orderId)
        {
            try
            {
                var result = _context.Database
                    .ExecuteSqlRaw("EXEC AssignTripsToOrder @p0", orderId);

                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error assigning trip to order: {ex.Message}", ex);
            }
        }

        // LINQ fallback methods
        public List<DeliveryViewModel> GetUnassignedDeliveriesLinq()
        {
            try
            {
                return (from d in _context.Deliveries
                        join o in _context.Orders on d.OrderId equals o.OrderID
                        where o.IsAssigned == 0
                        select new DeliveryViewModel
                        {
                            DeliveryId = d.DeliveryId,
                            OrderId = d.OrderId,
                            DeliveryStatus = d.DeliveryStatus,
                            OrderID = o.OrderID,
                            Sender = o.Sender,
                            Reciever = o.Reciever,
                            OrderType = o.OrderType,
                            OrderDate = o.OrderDate,
                            IsAssigned = o.IsAssigned,
                            TotalAmount = o.TotalAmount
                        }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting unassigned deliveries: {ex.Message}", ex);
            }
        }

        public List<DeliveryViewModel> GetAssignedDeliveriesLinq()
        {
            try
            {
                return (from d in _context.Deliveries
                        join o in _context.Orders on d.OrderId equals o.OrderID
                        where o.IsAssigned == 1
                        select new DeliveryViewModel
                        {
                            DeliveryId = d.DeliveryId,
                            OrderId = d.OrderId,
                            DeliveryStatus = d.DeliveryStatus,
                            OrderID = o.OrderID,
                            Sender = o.Sender,
                            Reciever = o.Reciever,
                            OrderType = o.OrderType,
                            OrderDate = o.OrderDate,
                            IsAssigned = o.IsAssigned,
                            TotalAmount = o.TotalAmount
                        }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error getting assigned deliveries: {ex.Message}", ex);
            }
        }

        private List<DeliveryViewModel> SearchDeliveriesLinq(string searchTerm)
        {
            try
            {
                var query = from d in _context.Deliveries
                            join o in _context.Orders on d.OrderId equals o.OrderID
                            select new DeliveryViewModel
                            {
                                DeliveryId = d.DeliveryId,
                                OrderId = d.OrderId,
                                DeliveryStatus = d.DeliveryStatus,
                                OrderID = o.OrderID,
                                Sender = o.Sender,
                                Reciever = o.Reciever,
                                OrderType = o.OrderType,
                                OrderDate = o.OrderDate,
                                IsAssigned = o.IsAssigned,
                                TotalAmount = o.TotalAmount
                            };

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query = query.Where(x =>
                        x.OrderId.Contains(searchTerm) ||
                        x.Sender.Contains(searchTerm) ||
                        x.Reciever.Contains(searchTerm) ||
                        x.DeliveryStatus.Contains(searchTerm));
                }

                return query.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error searching deliveries: {ex.Message}", ex);
            }
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}