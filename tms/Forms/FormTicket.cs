using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tms.Repository;
using tms.Model;

namespace tms.Forms
{
    public partial class FormTicket : Form
    {
        private readonly TicketRepository ticketRepository;
        private string currentTicketId = string.Empty;
        private bool isEditMode = false;

        public FormTicket()
        {
            InitializeComponent();
            ticketRepository = new TicketRepository();
            InitializeEventHandlers();
        }

        private void InitializeEventHandlers()
        {
            btnNew.Click += BtnNew_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnLogOut.Click += BtnLogOut_Click;

            txtSearch.TextChanged += TxtSearch_TextChanged;
            IsTicket.SelectedIndexChanged += lstRoutes_SelectedIndexChanged;
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

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
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
                    string selectedItem = IsTicket.SelectedItem.ToString();
                    string[] parts = selectedItem.Split('-');
                    if (parts.Length > 0)
                    {
                        string ticketId = parts[0].Trim();
                        var ticket = ticketRepository.GetById(ticketId);
                        if (ticket != null)
                        {
                            LoadTicketToForm(ticket);
                            currentTicketId = ticket.TicketID;
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
            txtSupplierID.Text = ticket.SupplierID;
            txtSupplierName.Text = ticket.SupplierName;
            txtSupplierDate.Text = ticket.SupplierDate.ToString("yyyy-MM-dd");
            txtCustomerPosition.Text = ticket.CustomerPosition;
            txtCustomerAddress.Text = ticket.CustomerAddress;
        }

        private void ClearForm()
        {
            txtSupplierID.Clear();
            txtSupplierName.Clear();
            txtSupplierDate.Clear();
            txtCustomerPosition.Clear();
            txtCustomerAddress.Clear();
            currentTicketId = string.Empty;
            isEditMode = false;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtSupplierID.Text))
            {
                MessageBox.Show("Supplier ID is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSupplierName.Text))
            {
                MessageBox.Show("Supplier Name is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSupplierDate.Text))
            {
                MessageBox.Show("Supplier Date is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierDate.Focus();
                return false;
            }

            if (!DateTime.TryParse(txtSupplierDate.Text, out _))
            {
                MessageBox.Show("Please enter a valid date format (YYYY-MM-DD)!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierDate.Focus();
                return false;
            }

            if (!isEditMode)
            {
                var existingTicket = ticketRepository.GetBySupplierID(txtSupplierID.Text.Trim());
                if (existingTicket.Count > 0)
                {
                    MessageBox.Show("A ticket with this Supplier ID already exists!", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSupplierID.Focus();
                    return false;
                }
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
                SupplierDate = DateTime.Parse(txtSupplierDate.Text),
                CustomerPosition = txtCustomerPosition.Text.Trim(),
                CustomerAddress = txtCustomerAddress.Text.Trim(),
                CreatedDate = DateTime.Now,
                ModifiedDate = DateTime.Now
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
                existingTicket.SupplierDate = DateTime.Parse(txtSupplierDate.Text);
                existingTicket.CustomerPosition = txtCustomerPosition.Text.Trim();
                existingTicket.CustomerAddress = txtCustomerAddress.Text.Trim();
                existingTicket.ModifiedDate = DateTime.Now;

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
            IsTicket.Items.Clear();

            List<Ticket> tickets;
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                tickets = ticketRepository.GetAll();
            }
            else
            {
                tickets = ticketRepository.Search(searchText);
            }

            foreach (var ticket in tickets)
            {
                IsTicket.Items.Add($"{ticket.TicketID} - {ticket.SupplierName}");
            }
        }

        private string GenerateTicketId()
        {
            return "TKT" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void lblRouteID_Click(object sender, EventArgs e)
        {
        }

        private void gbRoute2_Enter(object sender, EventArgs e)
        {   
        }
    }
}