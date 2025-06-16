// Forms/FormOrder.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tms.Model;        // Make sure to reference your Model namespace
using tms.Repository;   // Make sure to reference your Repository namespace

namespace tms.Forms
{
    public partial class FormOrder : Form
    {
        private OrderRepository _orderRepository;

        public FormOrder()
        {
            InitializeComponent();
            _orderRepository = new OrderRepository();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            LoadOrdersToGrid();
        }

        private void LoadOrdersToGrid()
        {
            try
            {
                var orders = _orderRepository.GetAllOrders();
                dataGridViewOrders.DataSource = orders;

                // Optional: Auto-size columns to fit content
                dataGridViewOrders.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            txtOrderID.Clear();
            txtCustomerID.Clear();
            txtOrderType.Clear();
            dtpOrderDate.Value = DateTime.Now; // Reset to current date/time
            txtOrderID.ReadOnly = false; // Make OrderID editable for new entries
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Basic validation
                if (string.IsNullOrWhiteSpace(txtOrderID.Text) || string.IsNullOrWhiteSpace(txtCustomerID.Text))
                {
                    MessageBox.Show("Order ID and Customer ID cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Order newOrder = new Order
                {
                    OrderID = txtOrderID.Text.Trim(),
                    CustomerID = txtCustomerID.Text.Trim(),
                    OrderType = txtOrderType.Text.Trim(),
                    OrderDate = dtpOrderDate.Value
                };

                _orderRepository.AddOrder(newOrder);
                MessageBox.Show("Order saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFormFields();
                LoadOrdersToGrid(); // Refresh the DataGridView
            }
            catch (ArgumentException aex) // Catch specific validation errors from repository
            {
                MessageBox.Show(aex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOrderID.Text))
                {
                    MessageBox.Show("Please select an order to update, or enter its ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Order updatedOrder = new Order
                {
                    OrderID = txtOrderID.Text.Trim(),
                    CustomerID = txtCustomerID.Text.Trim(),
                    OrderType = txtOrderType.Text.Trim(),
                    OrderDate = dtpOrderDate.Value
                };

                _orderRepository.UpdateOrder(updatedOrder);
                MessageBox.Show("Order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFormFields();
                LoadOrdersToGrid(); // Refresh the DataGridView
            }
            catch (KeyNotFoundException knfex) // Catch specific "not found" errors from repository
            {
                MessageBox.Show(knfex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtOrderID.Text))
                {
                    MessageBox.Show("Please select an order to delete, or enter its ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirm = MessageBox.Show($"Are you sure you want to delete order '{txtOrderID.Text}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    _orderRepository.DeleteOrder(txtOrderID.Text.Trim());
                    MessageBox.Show("Order deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFormFields();
                    LoadOrdersToGrid(); // Refresh the DataGridView
                }
            }
            catch (KeyNotFoundException knfex)
            {
                MessageBox.Show(knfex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = this.dataGridViewOrders.Rows[e.RowIndex];

                // Populate textboxes from the selected row
                txtOrderID.Text = row.Cells["OrderID"].Value?.ToString();
                txtCustomerID.Text = row.Cells["CustomerID"].Value?.ToString();
                txtOrderType.Text = row.Cells["OrderType"].Value?.ToString();

                if (DateTime.TryParse(row.Cells["OrderDate"].Value?.ToString(), out DateTime orderDate))
                {
                    dtpOrderDate.Value = orderDate;
                }
                else
                {
                    dtpOrderDate.Value = DateTime.Now; // Default if parsing fails
                }

                txtOrderID.ReadOnly = true; // Make OrderID non-editable when updating
            }
        }
    }
}