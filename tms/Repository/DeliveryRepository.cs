using Delivery_info.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using tms.Data;

namespace Delivery_info.Repository
{
    public class DeliveryRepository
    {
        public List<Delivery> GetAllDeliveries()
        {
            using var context = new AppDbContext();
            return context.Deliveries
                .FromSqlRaw("EXEC GetAllDeliveries")
                .ToList();
        }

        public void AddDelivery(Delivery delivery)
        {
            using var context = new AppDbContext();
            context.Database.ExecuteSqlRaw(
                "EXEC AddDelivery @DeliveryId, @OrderId, @DeliveryDate, @DeliveryStatus",
                new SqlParameter("@DeliveryId", delivery.DeliveryId),
                new SqlParameter("@OrderId", delivery.OrderId),
                new SqlParameter("@DeliveryDate", delivery.DeliveryDate),
                new SqlParameter("@DeliveryStatus", delivery.DeliveryStatus)
            );

            // Update the order to mark it as having a delivery
            context.Database.ExecuteSqlRaw(
                "EXEC UpdateOrderDelivery @OrderId, @DeliveryId",
                new SqlParameter("@OrderId", delivery.OrderId),
                new SqlParameter("@DeliveryId", delivery.DeliveryId)
            );
        }

        public void UpdateDelivery(Delivery delivery)
        {
            using var context = new AppDbContext();
            context.Database.ExecuteSqlRaw(
                "EXEC UpdateDelivery @DeliveryId, @OrderId, @DeliveryDate, @DeliveryStatus",
                new SqlParameter("@DeliveryId", delivery.DeliveryId),
                new SqlParameter("@OrderId", delivery.OrderId),
                new SqlParameter("@DeliveryDate", delivery.DeliveryDate),
                new SqlParameter("@DeliveryStatus", delivery.DeliveryStatus ?? (object)DBNull.Value)
            );
        }
    }
}
