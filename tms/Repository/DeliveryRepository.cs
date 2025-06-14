using Delivery_info.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tms.Data;

namespace Delivery_info.Repository
{
    public class DeliveryRepository
    {
        public List<Delivery> getAllDeliveries()
        {
            using var context = new AppDbContext();
            return context.Deliveries.ToList();
        }

        public void UpdateDelivery(Delivery delivery)
        {
            using var context = new AppDbContext();
            context.Deliveries.Update(delivery);
            context.SaveChanges();
        }

    }
}
