using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using tms.Data;
using tms.Model;
using Microsoft.EntityFrameworkCore;

namespace tms.Repository
{
    public class TicketRepository
    {
        public List<Ticket> GetAll()
        {
            using var context = new AppDbContext();
            return context.Tickets
                .FromSqlRaw("EXEC GetAllTickets")
                .AsEnumerable()     
                .OrderBy(t => t.SupplierDate)
                .ToList();
        }

        public Ticket GetById(string ticketId)
        {
            using var context = new AppDbContext();
            var param = new SqlParameter("@TicketID", ticketId);
            return context.Tickets
                .FromSqlRaw("EXEC GetTicketById @TicketID", param)
                .AsEnumerable()
                .FirstOrDefault();
        }

        public List<Ticket> GetBySupplierID(string supplierId)
        {
            using var context = new AppDbContext();
            var param = new SqlParameter("@SupplierID", supplierId);
            return context.Tickets
                .FromSqlRaw("EXEC GetTicketsBySupplierID @SupplierID", param)
                .ToList();
        }

        public List<Ticket> Search(string term)
        {
            using var context = new AppDbContext();
            var param = new SqlParameter("@term", term);
            return context.Tickets
                .FromSqlRaw("EXEC SearchTickets @term", param)
                .ToList();
        }

        public bool Add(Ticket ticket)
        {
            using var context = new AppDbContext();
            var parameters = new[]
            {
                new SqlParameter("@TicketID", ticket.TicketID),
                new SqlParameter("@SupplierID", ticket.SupplierID),
                new SqlParameter("@SupplierName", ticket.SupplierName),
                new SqlParameter("@SupplierDate", ticket.SupplierDate),
                new SqlParameter("@CustomerPosition",
                    ticket.CustomerPosition ?? (object)DBNull.Value),
                new SqlParameter("@CustomerAddress",
                    ticket.CustomerAddress ?? (object)DBNull.Value),
                new SqlParameter("@CreatedDate", ticket.CreatedDate),
                new SqlParameter("@ModifiedDate", ticket.ModifiedDate),
                new SqlParameter("@InvoiceNo",
                    ticket.InvoiceNo ?? (object)DBNull.Value)  // New parameter
            };

            return context.Database.ExecuteSqlRaw(
                "EXEC InsertTicket @TicketID, @SupplierID, @SupplierName, " +
                "@SupplierDate, @CustomerPosition, @CustomerAddress, " +
                "@CreatedDate, @ModifiedDate, @InvoiceNo",
                parameters) > 0;
        }

        public bool Update(Ticket ticket)
        {
            using var context = new AppDbContext();
            var parameters = new[]
            {
                new SqlParameter("@TicketID", ticket.TicketID),
                new SqlParameter("@SupplierID", ticket.SupplierID),
                new SqlParameter("@SupplierName", ticket.SupplierName),
                new SqlParameter("@SupplierDate", ticket.SupplierDate),
                new SqlParameter("@CustomerPosition",
                    ticket.CustomerPosition ?? (object)DBNull.Value),
                new SqlParameter("@CustomerAddress",
                    ticket.CustomerAddress ?? (object)DBNull.Value),
                new SqlParameter("@ModifiedDate", ticket.ModifiedDate),
                new SqlParameter("@InvoiceNo",
                    ticket.InvoiceNo ?? (object)DBNull.Value)
            };

            return context.Database.ExecuteSqlRaw(
                "EXEC UpdateTicket @TicketID, @SupplierID, @SupplierName, " +
                "@SupplierDate, @CustomerPosition, @CustomerAddress, " +
                "@ModifiedDate, @InvoiceNo",
                parameters) > 0;
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