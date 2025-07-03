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
            txtSender.Clear();
            txtReceiver.Clear();
            txtOrderType.Clear();
            dtpOrderDate.Value = DateTime.Now;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Add validation for receiver field
                if (string.IsNullOrWhiteSpace(txtOrderID.Text) ||
                    string.IsNullOrWhiteSpace(txtSender.Text) ||
                    string.IsNullOrWhiteSpace(txtReceiver.Text))
                {
                    MessageBox.Show("Order ID, Sender and Receiver are required");
                    return;
                }

                Order newOrder = new Order
                {
                    OrderID = txtOrderID.Text.Trim(),
                    Sender = txtSender.Text.Trim(),
                    Reciever = txtReceiver.Text.Trim(),
                    OrderType = txtOrderType.Text.Trim(),
                    OrderDate = dtpOrderDate.Value
                };

                _orderRepository.AddOrder(newOrder);
                LoadOrdersToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnCreateDelivery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderID.Text))
            {
                MessageBox.Show("Please select an order first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var deliveryForm = new FormDelivery(txtOrderID.Text);
            deliveryForm.Show();
            this.Hide(); // or keep both forms open: deliveryForm.ShowDialog();
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewOrders.Rows[e.RowIndex];

                txtOrderID.Text = row.Cells["OrderID"].Value?.ToString();
                txtSender.Text = row.Cells["Sender"].Value?.ToString();
                txtReceiver.Text = row.Cells["Reciever"].Value?.ToString();
                txtOrderType.Text = row.Cells["OrderType"].Value?.ToString();
                dtpOrderDate.Value = Convert.ToDateTime(row.Cells["OrderDate"].Value);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}