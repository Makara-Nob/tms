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
