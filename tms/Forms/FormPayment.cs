using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Staff_info.Repository;
using tms.Model;
using tms.Repository;

namespace tms.Forms
{
    public partial class PaymentForm : Form
    {
        private readonly PaymentRepository _paymentRepo = new PaymentRepository();
        private readonly StaffRepository _staffRepo = new StaffRepository();
        private readonly InvoiceRepository _invoiceRepo = new InvoiceRepository(); // Added InvoiceRepository
        private List<Payment> _payments = new List<Payment>();
        private List<Payment> _filteredPayments = new List<Payment>();

        public PaymentForm()
        {
            InitializeComponent();
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            InitializeForm();
            LoadStaffComboBox();
            LoadInvoiceComboBox(); // Load invoice data into combobox
            RefreshPaymentList();
        }

        private void InitializeForm()
        {
            panel1.BackColor = Color.White;
            lblSearch.BackColor = Color.FromArgb(45, 45, 48);
            lblSearch.Padding = new Padding(5);

            cmbPaymentMethod.DataSource = _paymentRepo.GetPaymentMethods();
            cmbStatus.DataSource = _paymentRepo.GetPaymentStatuses();

            InitializeDateComboBox();
            txtSearch.Focus();
        }

        // Load staff into combobox
        private void LoadStaffComboBox()
        {
            try
            {
                var staffList = _staffRepo.GetAll()
                    .Select(s => new
                    {
                        s.StaffId,
                        DisplayText = $"{s.StaffId} - {s.Name}"
                    })
                    .ToList();

                cmbStaffID.DisplayMember = "DisplayText";
                cmbStaffID.ValueMember = "StaffId";
                cmbStaffID.DataSource = staffList;
                cmbStaffID.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // New method to load invoices into combobox
        private void LoadInvoiceComboBox()
        {
            try
            {
                var invoiceList = _invoiceRepo.GetAll()
                    .Select(i => new
                    {
                        i.InvoiceID,
                        DisplayText = $"{i.InvoiceID} - ${i.TotalAmount:F2} ({i.InvoiceDate:yyyy-MM-dd})"
                    })
                    .ToList();

                cmbInvoiceNo.DisplayMember = "DisplayText";
                cmbInvoiceNo.ValueMember = "InvoiceID";
                cmbInvoiceNo.DataSource = invoiceList;
                cmbInvoiceNo.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading invoices: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDateComboBox()
        {
            List<string> dates = new List<string>();
            for (int i = 0; i <= 30; i++)
            {
                dates.Add(DateTime.Now.AddDays(-i).ToString("yyyy-MM-dd"));
            }
            cmbPaymentDate.DataSource = dates;
        }

        private void RefreshPaymentList()
        {
            try
            {
                _payments = _paymentRepo.GetAll();
                ApplySearchFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payments: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplySearchFilter()
        {
            lstPayments.Items.Clear();

            _filteredPayments = string.IsNullOrEmpty(txtSearch.Text)
                ? _payments.ToList()
                : _payments.Where(p =>
                    p.PaymentID.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                    p.InvoiceNo.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                    p.StaffID.Contains(txtSearch.Text, StringComparison.OrdinalIgnoreCase)
                ).ToList();

            foreach (var payment in _filteredPayments)
            {
                lstPayments.Items.Add(payment);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplySearchFilter();
        }

        private void lstPayments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPayments.SelectedItem is Payment selectedPayment)
            {
                PopulateFields(selectedPayment);
            }
        }

        private void PopulateFields(Payment payment)
        {
            txtPaymentID.Text = payment.PaymentID;

            // Set invoice combobox value instead of textbox
            if (cmbInvoiceNo.Items.Cast<dynamic>().Any(item => item.InvoiceID == payment.InvoiceNo))
            {
                cmbInvoiceNo.SelectedValue = payment.InvoiceNo;
            }

            cmbPaymentMethod.Text = payment.PaymentMethod;

            // Set staff combobox value
            if (cmbStaffID.Items.Cast<dynamic>().Any(item => item.StaffId == payment.StaffID))
            {
                cmbStaffID.SelectedValue = payment.StaffID;
            }

            txtAmountPaid.Text = payment.AmountPaid.ToString("F2");
            cmbPaymentDate.Text = payment.PaymentDate.ToString("yyyy-MM-dd");
            cmbStatus.Text = payment.Status;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    var newPayment = CreatePaymentFromForm();

                    if (_paymentRepo.Add(newPayment))
                    {
                        RefreshPaymentList();
                        ClearForm();
                        MessageBox.Show("Payment inserted successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting payment: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstPayments.SelectedItem is Payment selectedPayment && ValidateInput())
                {
                    var updatedPayment = CreatePaymentFromForm();

                    if (_paymentRepo.Update(updatedPayment))
                    {
                        RefreshPaymentList();
                        MessageBox.Show("Payment updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a payment to update.", "No Selection",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating payment: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtPaymentID.Text))
            {
                MessageBox.Show("Payment ID is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPaymentID.Focus();
                return false;
            }

            // Changed from textbox validation to combobox validation for Invoice No
            if (cmbInvoiceNo.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an invoice.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbInvoiceNo.Focus();
                return false;
            }

            if (cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a payment method.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPaymentMethod.Focus();
                return false;
            }

            if (cmbStaffID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a staff member.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStaffID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAmountPaid.Text))
            {
                MessageBox.Show("Amount Paid is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmountPaid.Focus();
                return false;
            }

            if (!decimal.TryParse(txtAmountPaid.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount greater than 0.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmountPaid.Focus();
                return false;
            }

            if (cmbPaymentDate.SelectedIndex == -1 && string.IsNullOrWhiteSpace(cmbPaymentDate.Text))
            {
                MessageBox.Show("Please select or enter a payment date.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPaymentDate.Focus();
                return false;
            }

            if (cmbStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a status.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return false;
            }

            return true;
        }

        private Payment CreatePaymentFromForm()
        {
            DateTime paymentDate;
            if (!DateTime.TryParse(cmbPaymentDate.Text, out paymentDate))
            {
                paymentDate = DateTime.Now;
            }

            return new Payment
            {
                PaymentID = txtPaymentID.Text.Trim(),
                // Get InvoiceNo from combobox selected value
                InvoiceNo = cmbInvoiceNo.SelectedValue.ToString(),
                PaymentMethod = cmbPaymentMethod.Text,
                StaffID = cmbStaffID.SelectedValue.ToString(),
                AmountPaid = decimal.Parse(txtAmountPaid.Text),
                PaymentDate = paymentDate,
                Status = cmbStatus.Text
            };
        }

        private void ClearForm()
        {
            txtPaymentID.Text = "";
            cmbInvoiceNo.SelectedIndex = -1; // Reset invoice combobox
            cmbPaymentMethod.SelectedIndex = -1;
            cmbStaffID.SelectedIndex = -1;
            txtAmountPaid.Text = "";
            cmbPaymentDate.SelectedIndex = 0;
            cmbStatus.SelectedIndex = -1;

            lstPayments.ClearSelected();
            txtPaymentID.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Existing code
        }
    }
}