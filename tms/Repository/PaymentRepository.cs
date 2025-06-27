using tms.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using tms.Data;
using System.IO;
using System.Text;

namespace tms.Repository
{
    public class PaymentRepository
    {
        public List<Payment> GetAll()
        {
            using var context = new AppDbContext();
            return context.Payments
                .FromSqlRaw("EXEC GetAllPayments")
                .ToList();
        }

        public Payment GetById(string paymentId)
        {
            using var context = new AppDbContext();
            var param = new SqlParameter("@PaymentID", paymentId);
            return context.Payments
                .FromSqlRaw("EXEC GetPaymentById @PaymentID", param)
                .AsEnumerable()
                .FirstOrDefault();
        }

        public List<Payment> Search(string term)
        {
            using var context = new AppDbContext();
            var param = new SqlParameter("@term", term);
            return context.Payments
                .FromSqlRaw("EXEC SearchPayments @term", param)
                .ToList();
        }

        public bool Add(Payment payment)
        {
            using var context = new AppDbContext();
            var parameters = new[]
            {
                new SqlParameter("@PaymentID", payment.PaymentID),
                new SqlParameter("@InvoiceNo", payment.InvoiceNo),
                new SqlParameter("@PaymentMethod", payment.PaymentMethod),
                new SqlParameter("@StaffID", payment.StaffID),
                new SqlParameter("@AmountPaid", payment.AmountPaid),
                new SqlParameter("@PaymentDate", payment.PaymentDate),
                new SqlParameter("@Status", payment.Status)
            };

            return context.Database.ExecuteSqlRaw(
                "EXEC InsertPayment @PaymentID, @InvoiceNo, @PaymentMethod, @StaffID, " +
                "@AmountPaid, @PaymentDate, @Status",
                parameters) > 0;
        }

        public bool Update(Payment payment)
        {
            using var context = new AppDbContext();
            var parameters = new[]
            {
                new SqlParameter("@PaymentID", payment.PaymentID),
                new SqlParameter("@InvoiceNo", payment.InvoiceNo),
                new SqlParameter("@PaymentMethod", payment.PaymentMethod),
                new SqlParameter("@StaffID", payment.StaffID),
                new SqlParameter("@AmountPaid", payment.AmountPaid),
                new SqlParameter("@PaymentDate", payment.PaymentDate),
                new SqlParameter("@Status", payment.Status)
            };

            return context.Database.ExecuteSqlRaw(
                "EXEC UpdatePayment @PaymentID, @InvoiceNo, @PaymentMethod, @StaffID, " +
                "@AmountPaid, @PaymentDate, @Status",
                parameters) > 0;
        }

        public bool Delete(string paymentId)
        {
            using var context = new AppDbContext();
            var param = new SqlParameter("@PaymentID", paymentId);
            return context.Database.ExecuteSqlRaw(
                "EXEC DeletePayment @PaymentID", param) > 0;
        }

        public List<string> GetPaymentMethods() =>
            new() { "Cash", "Credit Card", "Debit Card", "Bank Transfer", "Mobile Payment" };

        public List<string> GetPaymentStatuses() =>
            new() { "Completed", "Pending", "Failed", "Refunded" };

        public void ExportToCSV(string filePath)
        {
            var payments = GetAll();
            var csv = new StringBuilder();
            csv.AppendLine("PaymentID,InvoiceNo,PaymentMethod,StaffID,AmountPaid,PaymentDate,Status");

            foreach (var payment in payments)
            {
                csv.AppendLine(
                    $"{payment.PaymentID}," +
                    $"{payment.InvoiceNo}," +
                    $"{payment.PaymentMethod}," +
                    $"{payment.StaffID}," +
                    $"{payment.AmountPaid}," +
                    $"{payment.PaymentDate:yyyy-MM-dd}," +
                    $"{payment.Status}"
                );
            }

            File.WriteAllText(filePath, csv.ToString());
        }
    }
}