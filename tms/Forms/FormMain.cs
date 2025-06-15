
using tms.Forms;

namespace tms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            wire();
            this.Size = new Size(1400, 700);
        }

        private void WireEvents()
        {
            lbStaff.Click += btn_formStaff_Click;
            lbRoute.Click += btn_formRoute_Click;
            lbVehicle.Click += btn_formVehicle_Click;
            lbDelivery.Click += btn_formDelivery_Click;
            lbSeat.Click += btn_formSeat_Click;
        }

        private void loadFormIntoPanel(Form form)
        {
            var panel = splitContainer1.Panel2;

            panel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel.Controls.Add(form);
            form.Show();
        }

        private void wire()
        {
            lbStaff.Click += btn_formStaff_Click;
            lbVehicle.Click += btn_formVehicle_Click;
            lbRoute.Click += btn_formRoute_Click;
            lbDelivery.Click += btn_formDelivery_Click;
            lbSeat.Click += btn_formSeat_Click;
        }

        // Handle navigation button click
        private void btn_formStaff_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormStaff());
        }

        private void btn_formRoute_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormRoute());
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
            loadFormIntoPanel(new FormSeat());
        }

        private void load_formPassenger_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormPassenger());
        }
    }
}