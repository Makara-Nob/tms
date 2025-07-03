using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using tms.Data;
using tms.Model;
using tms.Repository;

namespace tms.Forms
{
    public partial class FormTicket : Form
    {
        private readonly TicketRepository ticketRepository;
        private readonly PaymentRepository paymentRepository;
        private string currentTicketId = string.Empty;
        private bool isEditMode = false;

        public FormTicket()
        {
            InitializeComponent();
            ticketRepository = new TicketRepository();
            paymentRepository = new PaymentRepository();
            InitializeEventHandlers();
            LoadPaymentStatuses();
        }

        private void InitializeEventHandlers()
        {
            btnNew.Click += BtnNew_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnClear.Click += btnClear_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            IsTicket.SelectedIndexChanged += lstRoutes_SelectedIndexChanged;
            txtInvoiceNo.SelectedIndexChanged += TxtInvoiceNo_SelectedIndexChanged;
        }

        private void LoadPaymentStatuses()
        {
            txtInvoiceNo.Items.Clear();
            txtInvoiceNo.Items.Add(""); // Empty option
            txtInvoiceNo.Items.AddRange(paymentRepository.GetAll()
                .Where(p => p.Status == "Completed")
                .Select(p => p.InvoiceNo)
                .Distinct()
                .ToArray());
        }

        private void TxtInvoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedInvoice = txtInvoiceNo.Text;
            if (!string.IsNullOrEmpty(selectedInvoice))
            {
                var payment = paymentRepository.GetByInvoiceNo(selectedInvoice);
                lblPaymentStatus.Text = payment != null ? $"Status: {payment.Status}" : "Status: Not Found";
            }
            else
            {
                lblPaymentStatus.Text = "Status:";
            }
        }

        private void FormTicket_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshTicketList();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
                return;

            if (!ValidatePaymentStatus())
                return;

            CreateNewTicket();
            MessageBox.Show("New ticket created successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            RefreshTicketList();
            ClearForm();
            isEditMode = false;
            currentTicketId = string.Empty;
            txtSupplierID.Focus();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    if (!ValidatePaymentStatus())
                        return;

                    if (isEditMode && !string.IsNullOrEmpty(currentTicketId))
                    {
                        UpdateExistingTicket();
                        MessageBox.Show("Ticket updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CreateNewTicket();
                        MessageBox.Show("New ticket created successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    RefreshTicketList();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving ticket: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RefreshTicketList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching tickets: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (IsTicket.SelectedIndex >= 0)
                {
                    string selectedItem = IsTicket.SelectedItem?.ToString() ?? "";
                    string[] parts = selectedItem.Split('-');
                    if (parts.Length > 0)
                    {
                        string ticketId = parts[0].Trim();
                        if (!string.IsNullOrEmpty(ticketId))
                        {
                            var ticket = ticketRepository.GetById(ticketId);
                            LoadTicketToForm(ticket);
                            currentTicketId = ticketId;
                            isEditMode = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading ticket: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTicketToForm(Ticket ticket)
        {
            if (ticket == null) return;

            txtSupplierID.Text = ticket.SupplierID;
            txtSupplierName.Text = ticket.SupplierName;
            dtSupplierDate.Value = ticket.SupplierDate;
            txtCustomerPosition.Text = ticket.CustomerPosition;
            txtCustomerAddress.Text = ticket.CustomerAddress;

            // Set invoice number if exists
            if (!string.IsNullOrEmpty(ticket.InvoiceNo))
            {
                txtInvoiceNo.SelectedItem = ticket.InvoiceNo;
            }
            else
            {
                txtInvoiceNo.SelectedIndex = -1;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtSupplierID.Clear();
            txtSupplierName.Clear();
            dtSupplierDate.Value = DateTime.Now;
            txtCustomerPosition.Clear();
            txtCustomerAddress.Clear();
            txtInvoiceNo.SelectedIndex = -1;
            lblPaymentStatus.Text = "Status:";
            currentTicketId = string.Empty;
            isEditMode = false;
        }

        private bool ValidateForm()
        {
            // Validate Supplier ID
            if (string.IsNullOrWhiteSpace(txtSupplierID.Text))
            {
                MessageBox.Show("Supplier ID is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierID.Focus();
                return false;
            }

            // Validate Supplier Name
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Supplier Name is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierName.Focus();
                return false;
            }

            // Check for duplicate Supplier ID (only when creating new ticket)
            if (!isEditMode)
            {
                try
                {
                    var existingTicket = ticketRepository.GetBySupplierID(txtSupplierID.Text.Trim());
                    if (existingTicket != null && existingTicket.Count > 0)
                    {
                        MessageBox.Show("A ticket with this Supplier ID already exists!", "Validation Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSupplierID.Focus();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error checking existing tickets: {ex.Message}", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private bool ValidatePaymentStatus()
        {
            string selectedInvoice = txtInvoiceNo.Text;
            if (string.IsNullOrEmpty(selectedInvoice))
                return true; // Allow if no invoice is selected

            var payment = paymentRepository.GetByInvoiceNo(selectedInvoice);

            if (payment == null)
            {
                MessageBox.Show("Payment not found for this invoice number!",
                    "Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (payment.Status != "Completed")
            {
                MessageBox.Show($"Payment status is '{payment.Status}'. Only 'Completed' payments can create tickets.",
                    "Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void CreateNewTicket()
        {
            var newTicket = new Ticket
            {
                TicketID = GenerateTicketId(),
                SupplierID = txtSupplierID.Text.Trim(),
                SupplierName = txtSupplierName.Text.Trim(),
                SupplierDate = dtSupplierDate.Value,
                CustomerPosition = txtCustomerPosition.Text.Trim(),
                CustomerAddress = txtCustomerAddress.Text.Trim(),
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now,
                InvoiceNo = txtInvoiceNo.Text // Set invoice number
            };

            bool success = ticketRepository.Add(newTicket);
            if (!success)
            {
                throw new Exception("Failed to create new ticket in database.");
            }
        }

        private void UpdateExistingTicket()
        {
            var existingTicket = ticketRepository.GetById(currentTicketId);
            if (existingTicket != null)
            {
                existingTicket.SupplierID = txtSupplierID.Text.Trim();
                existingTicket.SupplierName = txtSupplierName.Text.Trim();
                existingTicket.SupplierDate = dtSupplierDate.Value;
                existingTicket.CustomerPosition = txtCustomerPosition.Text.Trim();
                existingTicket.CustomerAddress = txtCustomerAddress.Text.Trim();
                existingTicket.ModifiedDate = DateTime.Now;
                existingTicket.InvoiceNo = txtInvoiceNo.Text;

                bool success = ticketRepository.Update(existingTicket);
                if (!success)
                {
                    throw new Exception("Failed to update ticket in database.");
                }
            }
            else
            {
                throw new Exception("Ticket not found for update.");
            }
        }

        private void RefreshTicketList()
        {
            if (IsTicket == null) return;

            IsTicket.Items.Clear();

            List<Ticket> tickets;
            string searchText = txtSearch?.Text?.Trim() ?? "";

            try
            {
                if (string.IsNullOrEmpty(searchText))
                {
                    tickets = ticketRepository.GetAll();
                }
                else
                {
                    tickets = ticketRepository.Search(searchText);
                }

                if (tickets == null) return;

                foreach (var ticket in tickets)
                {
                    if (ticket != null)
                    {
                        IsTicket.Items.Add($"{ticket.TicketID} - {ticket.SupplierName}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tickets: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateTicketId()
        {
            return "TKT" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
            // Painting logic
        }

        private void gbRoute2_Enter(object sender, EventArgs e)
        {

        }
    }
}