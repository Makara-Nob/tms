
using tms.Data;

namespace tms.Forms
{
    public partial class FormDelivery : Form
    {
        public FormDelivery()
        {
            InitializeComponent();
            LoadDeliveryData();
            Load_Status();
        }

        private void LoadDeliveryData()
        {
            using var context = new AppDbContext();
            var deliveries = context.Deliveries.ToList();
            tableDelivery.DataSource = deliveries;
            tableDelivery.Columns["DeliveryId"].HeaderText = "Delivery ID";
            tableDelivery.Columns["OrderId"].HeaderText = "Order ID";
            tableDelivery.Columns["DeliveryDate"].HeaderText = "Delivery Date";
            tableDelivery.Columns["DeliveryStatus"].HeaderText = "Delivery Status";

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();

            if (string.IsNullOrWhiteSpace(deliveryId.Text) || deliveryStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a delivery and a valid status to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int deliveryIdValue = int.Parse(deliveryId.Text);
            var delivery = context.Deliveries.FirstOrDefault(d => d.DeliveryId == deliveryIdValue);

            if (delivery == null)
            {
                MessageBox.Show("Delivery not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            delivery.DeliveryStatus = deliveryStatus.SelectedItem.ToString();
            context.SaveChanges();

            MessageBox.Show("Delivery status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Refresh the delivery data in the table
            LoadDeliveryData();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // you can change when click on this button show login form
        }
        private void deliveryId_TextChanged(object sender, EventArgs e)
        {
            deliveryId.ReadOnly = true;
        }

        private void orderId_TextChanged(object sender, EventArgs e)
        {
            orderId.ReadOnly = true;
        }

        private void customerId_TextChanged(object sender, EventArgs e)
        {
            customerId.ReadOnly = true;
        }

        private void orderType_TextChanged(object sender, EventArgs e)
        {

        }

        private void orderDate_TextChanged(object sender, EventArgs e)
        {

        }
        private void deliveryStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void tableDelivery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure the clicked row is valid
            {
                DataGridViewRow row = tableDelivery.Rows[e.RowIndex];

                // Populate the fields with the selected row's data
                deliveryId.Text = row.Cells["DeliveryId"].Value?.ToString();
                orderId.Text = row.Cells["OrderId"].Value?.ToString();
                orderDate.Text = row.Cells["DeliveryDate"].Value?.ToString();
                deliveryStatus.SelectedItem = row.Cells["DeliveryStatus"].Value?.ToString();
            }
        }

        private void Load_Status()
        {
            deliveryStatus.Items.Add("Processing");
            deliveryStatus.Items.Add("Delivered");
            deliveryStatus.Items.Add("In Transit");
            deliveryStatus.Items.Add("Pending");
            deliveryStatus.Items.Add("Cancelled");
            deliveryStatus.Items.Add("Delivered");
            deliveryStatus.Items.Add("In Transit");
            deliveryStatus.SelectedIndex = -1;
        }

        private void resetForm()
        {
            deliveryId.Clear();
            orderId.Clear();
            customerId.Clear();
            orderDate.Clear();
            orderType.Clear();
            deliveryStatus.SelectedIndex = -1;
        }

    }
}
