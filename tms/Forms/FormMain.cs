
using tms.Forms;
using tms.Model;

namespace tms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            wire();
            this.Size = new Size(1400, 730);
        }
        private void wire()
        {
            lbStaff.Click += btn_formStaff_Click;
            lbVehicle.Click += btn_formVehicle_Click;
            lbTrip.Click += btn_formTrip_Click;
            lbDelivery.Click += btn_formDelivery_Click;
            lbSeat.Click += btn_formSeat_Click;
            lbBooking.Click += load_formBooking_Click;
            lbTicket.Click += btn_formTicket_Click;
            lbRoute.Click += btn_formRoute_Click;
            lbLogout.Click += BtnLogOut_Click;
            lbOrder.Click += btn_formOrder_Click;
            lbInvoice.Click += btn_formInvoice_Click;

        }

        private void btn_formInvoice_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new InvoiceForm());
        }

        private void loadFormIntoPanel(Form form)
        {
            var panel = splitContainer1.Panel2;

            panel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;

            panel.Controls.Add(form);
            form.Show();
        }

        // Handle navigation button click
        private void btn_formStaff_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormStaff());
        }

        private void btn_formTicket_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormTicket());
        }

        private void btn_formOrder_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormOrder());
        }


        private void btn_formRoute_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormRoute());
        }

        private void btn_formTrip_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormTrip());
        }
        private void btn_formVehicle_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormVehicle());
        }

        private void btn_formDelivery_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormDelivery());
        }

        private void btn_formSeat_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormVehicleConfig());
        }

        private void btn_formSeatPicking_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormSeatPicking());
        }

        private void load_formBooking_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormBooking(loadFormIntoPanel));
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

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardCardsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void activeTripsCard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}