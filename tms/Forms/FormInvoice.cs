using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Staff_info.Repository;
using tms.Data;
using tms.Model;
using tms.Repository;

namespace tms.Forms
{
    public partial class InvoiceForm : Form
    {
        private readonly InvoiceRepository _invoiceRepository = new InvoiceRepository();
        private readonly StaffRepository _staffRepository = new StaffRepository();

        public InvoiceForm()
        {
            InitializeComponent();
            this.Load += InvoiceForm_Load;
        }

        private void InvoiceForm_Load(object sender, EventArgs e)
        {
            dtpInvoiceDate.Value = DateTime.Today;

            ConfigureDataGridViewColumns();

            dgvInvoices.AutoGenerateColumns = false;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            LoadStaffComboBox();
            LoadInvoiceData();
            ClearForm();
        }
        private void ConfigureDataGridViewColumns()
        {
            dgvInvoices.Columns.Clear();

            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InvoiceID",
                HeaderText = "Invoice ID",
                Name = "colInvoiceID",
                Width = 120
            });

            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "InvoiceDate",
                HeaderText = "Invoice Date",
                Name = "colInvoiceDate",
                Width = 150
            });

            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "StaffID",
                HeaderText = "Staff ID",
                Name = "colStaffID",
                Width = 100
            });

            dgvInvoices.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText = "Total Amount",
                Name = "colTotalAmount",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "C2",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
        }
        private void LoadStaffComboBox()
        {
            try
            {
                var staffList = _staffRepository.GetAll()
                    .Select(s => new
                    {
                        s.StaffId,
                        DisplayText = $"{s.StaffId} - {s.Name}"
                    })
                    .ToList();

                cmbStaffId.DataSource = staffList;
                cmbStaffId.DisplayMember = "DisplayText";
                cmbStaffId.ValueMember = "StaffId";
                cmbStaffId.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInvoiceData()
        {
            try
            {
                var invoices = _invoiceRepository.GetAll();
                dgvInvoices.DataSource = invoices;
                dgvInvoices.Refresh();
                dgvInvoices.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading invoices: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var invoice = new Invoice
                {
                    InvoiceID = txtInvoiceId.Text.Trim(),
                    InvoiceDate = dtpInvoiceDate.Value,
                    StaffID = cmbStaffId.SelectedValue.ToString(),
                    TotalAmount = decimal.Parse(txtTotalAmount.Text),
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                };

                if (_invoiceRepository.Add(invoice))
                {
                    MessageBox.Show("Invoice added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInvoiceData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add invoice. It might already exist.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var invoice = new Invoice
                {
                    InvoiceID = txtInvoiceId.Text.Trim(),
                    InvoiceDate = dtpInvoiceDate.Value,
                    StaffID = cmbStaffId.SelectedValue.ToString(),
                    TotalAmount = decimal.Parse(txtTotalAmount.Text),
                    ModifiedDate = DateTime.Now
                };

                if (_invoiceRepository.Update(invoice))
                {
                    MessageBox.Show("Invoice updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInvoiceData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to update invoice. It might not exist.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInvoiceId.Text))
            {
                MessageBox.Show("Please select an invoice to delete.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this invoice?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _invoiceRepository.Delete(txtInvoiceId.Text.Trim());
                    MessageBox.Show("Invoice deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInvoiceData();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    dgvInvoices.DataSource = _invoiceRepository.Search(txtSearch.Text.Trim());
                }
                else
                {
                    LoadInvoiceData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching invoices: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvInvoices.Rows.Count)
            {
                DataGridViewRow row = dgvInvoices.Rows[e.RowIndex];
                txtInvoiceId.Text = row.Cells["colInvoiceID"].Value?.ToString();

                if (row.Cells["colInvoiceDate"].Value is DateTime invoiceDate)
                {
                    dtpInvoiceDate.Value = invoiceDate;
                }
                else if (DateTime.TryParse(row.Cells["colInvoiceDate"].Value?.ToString(), out invoiceDate))
                {
                    dtpInvoiceDate.Value = invoiceDate;
                }

                if (row.Cells["colStaffID"].Value != null)
                {
                    string staffId = row.Cells["colStaffID"].Value.ToString();
                    cmbStaffId.SelectedValue = staffId;
                }

                txtTotalAmount.Text = row.Cells["colTotalAmount"].Value?.ToString();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtInvoiceId.Text))
            {
                MessageBox.Show("Invoice ID is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInvoiceId.Focus();
                return false;
            }

            if (cmbStaffId.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a staff member.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStaffId.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTotalAmount.Text))
            {
                MessageBox.Show("Total Amount is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalAmount.Focus();
                return false;
            }

            if (!decimal.TryParse(txtTotalAmount.Text, NumberStyles.Currency,
                CultureInfo.InvariantCulture, out decimal amount) || amount < 0)
            {
                MessageBox.Show("Please enter a valid positive amount.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalAmount.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm()
        {
            txtInvoiceId.Clear();
            dtpInvoiceDate.Value = DateTime.Today;
            cmbStaffId.SelectedIndex = -1;
            txtTotalAmount.Clear();
            txtSearch.Clear();
            txtInvoiceId.Focus();
        }

        private void txtTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}