using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using tms.Data;
using tms.Model;

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
                    .FromSqlRaw("EXEC GetAllTickets")
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

                var ticket = context.Tickets
                    .FromSqlRaw("EXEC GetTicketById @TicketID",
                        new SqlParameter("@TicketID", ticketId))
                    .AsEnumerable() 
                    .FirstOrDefault();

                return ticket;
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

                var result = context.Database.ExecuteSqlRaw(
                    "EXEC InsertTicket @TicketID, @SupplierID, @SupplierName, @SupplierDate, @CustomerPosition, @CustomerAddress, @CreatedDate, @ModifiedDate",
                    new SqlParameter("@TicketID", ticket.TicketID),
                    new SqlParameter("@SupplierID", ticket.SupplierID),
                    new SqlParameter("@SupplierName", ticket.SupplierName),
                    new SqlParameter("@SupplierDate", ticket.SupplierDate),
                    new SqlParameter("@CustomerPosition", ticket.CustomerPosition ?? (object)DBNull.Value),
                    new SqlParameter("@CustomerAddress", ticket.CustomerAddress ?? (object)DBNull.Value),
                    new SqlParameter("@CreatedDate", ticket.CreatedDate),
                    new SqlParameter("@ModifiedDate", ticket.ModifiedDate)
                );

                return result > 0;
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

                var result = context.Database.ExecuteSqlRaw(
                    "EXEC UpdateTicket @TicketID, @SupplierID, @SupplierName, @SupplierDate, @CustomerPosition, @CustomerAddress, @ModifiedDate",
                    new SqlParameter("@TicketID", ticket.TicketID),
                    new SqlParameter("@SupplierID", ticket.SupplierID),
                    new SqlParameter("@SupplierName", ticket.SupplierName),
                    new SqlParameter("@SupplierDate", ticket.SupplierDate),
                    new SqlParameter("@CustomerPosition", ticket.CustomerPosition ?? (object)DBNull.Value),
                    new SqlParameter("@CustomerAddress", ticket.CustomerAddress ?? (object)DBNull.Value),
                    new SqlParameter("@ModifiedDate", ticket.ModifiedDate)
                );

                return result > 0;
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

                var result = context.Database.ExecuteSqlRaw(
                    "EXEC DeleteTicket @TicketID",
                    new SqlParameter("@TicketID", ticketId)
                );

                return result > 0;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error deleting ticket with ID {ticketId}: {ex.Message}", ex);
            }
        }

    }
}