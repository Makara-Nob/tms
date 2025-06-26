using tms.Data;
using tms.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace tms.Repository
{
    public class InvoiceRepository
    {
        public List<Invoice> GetAll()
        {
            using var context = new AppDbContext();
            return context.Invoices
                .FromSqlRaw("EXEC GetAllInvoices")
                .ToList();
        }

        public bool Add(Invoice invoice)
        {
            using var context = new AppDbContext();
            var parameters = new[]
            {
            new SqlParameter("@InvoiceID", invoice.InvoiceID),
            new SqlParameter("@InvoiceDate", invoice.InvoiceDate),
            new SqlParameter("@StaffID", invoice.StaffID),
            new SqlParameter("@TotalAmount", invoice.TotalAmount),
            new SqlParameter("@CreatedDate", invoice.CreatedDate == default ? DBNull.Value : invoice.CreatedDate),
            new SqlParameter("@ModifiedDate", invoice.ModifiedDate == default ? DBNull.Value : invoice.ModifiedDate)
        };

            var result = context.SpResults
                .FromSqlRaw("EXEC InsertInvoice @InvoiceID, @InvoiceDate, @StaffID, @TotalAmount, @CreatedDate, @ModifiedDate",
                             parameters)
                .AsEnumerable()
                .FirstOrDefault();

            return result?.Result == "Success";
        }

        public bool Update(Invoice invoice)
        {
            using var context = new AppDbContext();
            var parameters = new[]
            {
            new SqlParameter("@InvoiceID", invoice.InvoiceID),
            new SqlParameter("@InvoiceDate", invoice.InvoiceDate),
            new SqlParameter("@StaffID", invoice.StaffID),
            new SqlParameter("@TotalAmount", invoice.TotalAmount),
            new SqlParameter("@ModifiedDate", invoice.ModifiedDate == default ? DBNull.Value : invoice.ModifiedDate)
        };

            var result = context.SpResults
                .FromSqlRaw("EXEC UpdateInvoice @InvoiceID, @InvoiceDate, @StaffID, @TotalAmount, @ModifiedDate",
                             parameters)
                .AsEnumerable()
                .FirstOrDefault();

            return result?.Result == "Success";
        }

        public bool Delete(string invoiceId)
        {
            using var context = new AppDbContext();
            var parameter = new SqlParameter("@InvoiceID", invoiceId);

            var result = context.SpResults
                .FromSqlRaw("EXEC DeleteInvoice @InvoiceID", parameter)
                .AsEnumerable()
                .FirstOrDefault();

            return result?.Result == "Success";
        }

        public List<Invoice> Search(string keyword)
        {
            using var context = new AppDbContext();
            var parameter = new SqlParameter("@term", keyword);
            return context.Invoices
                .FromSqlRaw("EXEC SearchInvoices @term", parameter)
                .ToList();
        }

        public List<Invoice> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            using var context = new AppDbContext();
            var parameters = new[]
            {
                new SqlParameter("@StartDate", startDate),
                new SqlParameter("@EndDate", endDate)
            };

            return context.Invoices
                .FromSqlRaw("EXEC GetInvoicesByDateRange @StartDate, @EndDate", parameters)
                .ToList();
        }

        public List<Invoice> GetByStaff(string staffId)
        {
            using var context = new AppDbContext();
            var parameter = new SqlParameter("@StaffID", staffId);
            return context.Invoices
                .FromSqlRaw("EXEC GetInvoicesByStaff @StaffID", parameter)
                .ToList();
        }
    }
}