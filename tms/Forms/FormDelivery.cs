using Delivery_info.Model;
using Delivery_info.Repository;
using tms.Model;
using tms.Repository;

namespace tms.Forms
{
    public partial class FormDelivery : Form
    {
        private readonly DeliveryRepository _deliveryRepo;
        private readonly OrderRepository _orderRepo;
        private List<Order> _availableOrders;
        private List<Delivery> _deliveries;
        private string _orderIdParam;

        public FormDelivery(string orderId = null)
        {
            _orderIdParam = orderId;
            InitializeComponent();
            _deliveryRepo = new DeliveryRepository();
            _orderRepo = new OrderRepository();
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            deliveryId.ReadOnly = true;
            cmbOrder.DisplayMember = "OrderID";
            cmbOrder.ValueMember = "OrderID";
            deliveryStatus.Items.AddRange(new[] { "Processing", "In Transit", "Delivered", "Cancelled" });
        }

        private void FormDelivery_Load(object sender, EventArgs e)
        {
            LoadDeliveryData();
            LoadAvailableOrders();
            deliveryId.Text = (_deliveries.Count + 1).ToString();

            if (!string.IsNullOrEmpty(_orderIdParam))
            {
                cmbOrder.SelectedValue = _orderIdParam;
            }
        }

        private void LoadDeliveryData()
        {
            _deliveries = _deliveryRepo.GetAllDeliveries();
            dataGridView1.DataSource = _deliveries;
        }

        private void LoadAvailableOrders()
        {
            _availableOrders = _orderRepo.GetAllOrders()
                .Where(o => o.DeliveryId == null)
                .ToList();
            cmbOrder.DataSource = _availableOrders;
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOrder.SelectedItem is Order selectedOrder)
            {
                orderType.Text = selectedOrder.OrderType;
                orderDate.Text = selectedOrder.OrderDate.ToString("yyyy-MM-dd");
            }
        }

        private void btnSaveDelivery_Click(object sender, EventArgs e)
        {
            if (cmbOrder.SelectedItem == null || !int.TryParse(deliveryId.Text, out int deliveryIdValue))
            {
                MessageBox.Show("Please select an order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var delivery = new Delivery
            {
                DeliveryId = deliveryIdValue,
                OrderId = int.Parse(((Order)cmbOrder.SelectedItem).OrderID),
                DeliveryDate = DateTime.Now,
                DeliveryStatus = deliveryStatus.SelectedItem.ToString()
            };

            _deliveryRepo.AddDelivery(delivery);

            var order = (Order)cmbOrder.SelectedItem;
            order.DeliveryId = delivery.DeliveryId;
            _orderRepo.UpdateOrder(order);

            MessageBox.Show("Delivery created successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ResetForm();
            LoadDeliveryData();
            LoadAvailableOrders();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                deliveryId.Text = row.Cells["DeliveryId"].Value?.ToString();

                if (row.Cells["OrderId"].Value != null && int.TryParse(row.Cells["OrderId"].Value.ToString(), out int orderId))
                {
                    cmbOrder.SelectedValue = orderId;
                }

                deliveryStatus.SelectedItem = row.Cells["DeliveryStatus"].Value?.ToString();
            }
        }

        private void ResetForm()
        {
            deliveryId.Text = (_deliveries.Count + 1).ToString();
            cmbOrder.SelectedIndex = -1;
            orderType.Clear();
            orderDate.Clear();
            deliveryStatus.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();
            dataGridView1.DataSource = _deliveries
                .Where(d =>
                    (d.OrderId.ToString().Contains(search)) ||
                    (d.DeliveryStatus?.ToLower().Contains(search) ?? false))
                .ToList();
        }

        // Empty event handlers to resolve designer errors
        private void deliveryId_TextChanged(object sender, EventArgs e) { }
        private void customerId_TextChanged(object sender, EventArgs e) { }
        private void orderType_TextChanged(object sender, EventArgs e) { }
        private void orderDate_TextChanged(object sender, EventArgs e) { }
        private void deliveryStatus_SelectedIndexChanged(object sender, EventArgs e) { }
        private void tableDelivery_CellClick(object sender, DataGridViewCellEventArgs e) { }
        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e) { }
    }
}