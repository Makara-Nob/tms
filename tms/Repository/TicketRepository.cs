using tms.Data;
using tms.Model;
using Microsoft.EntityFrameworkCore;

namespace tms.Repository
{
    public class TicketRepository
    {
        public List<Ticket> GetAll()
        {
            try
            {
                using var context = new AppDbContext();
                return context.Tickets
                    .OrderBy(t => t.TicketID)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving all tickets: {ex.Message}", ex);
            }
        }

        public Ticket? GetById(string ticketId)
        {
            try
            {
                using var context = new AppDbContext();
                return context.Tickets
                    .FirstOrDefault(t => t.TicketID == ticketId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving ticket with ID {ticketId}: {ex.Message}", ex);
            }
        }

        public List<Ticket> Search(string searchTerm)
        {
            try
            {
                using var context = new AppDbContext();
                return context.Tickets
                    .Where(t =>
                        t.TicketID.Contains(searchTerm) ||
                        t.SupplierID.Contains(searchTerm) ||
                        t.SupplierName.Contains(searchTerm) ||
                        t.CustomerPosition.Contains(searchTerm) ||
                        t.CustomerAddress.Contains(searchTerm))
                    .OrderBy(t => t.TicketID)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error searching tickets with term '{searchTerm}': {ex.Message}", ex);
            }
        }

        public List<Ticket> GetBySupplierID(string supplierId)
        {
            try
            {
                using var context = new AppDbContext();
                return context.Tickets
                    .Where(t => t.SupplierID == supplierId)
                    .OrderBy(t => t.SupplierDate)
                    .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving tickets for supplier {supplierId}: {ex.Message}", ex);
            }
        }

        public bool Add(Ticket ticket)
        {
            try
            {
                using var context = new AppDbContext();

                ticket.CreatedDate = DateTime.Now;
                ticket.ModifiedDate = DateTime.Now;

                context.Tickets.Add(ticket);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error adding new ticket: {ex.Message}", ex);
            }
        }

        public bool Update(Ticket ticket)
        {
            try
            {
                using var context = new AppDbContext();

                ticket.ModifiedDate = DateTime.Now;

                context.Tickets.Update(ticket);
                return context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating ticket: {ex.Message}", ex);
            }
        }

        public bool Delete(string ticketId)
        {
            try
            {
                using var context = new AppDbContext();
                var ticket = context.Tickets.FirstOrDefault(t => t.TicketID == ticketId);
                if (ticket != null)
                {
                    context.Tickets.Remove(ticket);
                    return context.SaveChanges() > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting ticket with ID {ticketId}: {ex.Message}", ex);
            }
        }
    }
}