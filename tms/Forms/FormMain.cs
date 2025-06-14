using System;
using System.Drawing;
using System.Windows.Forms;

namespace tms.Forms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            wire();
            this.Size = new Size(1400, 700);   
        }

        // Dynamically load forms into Panel2
        private void loadFormIntoPanel(Form form)
        {
            Panel panel = splitContainer1.Panel2;

            panel.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel.Controls.Add(form);
            form.Show();
        }

        private void wire()
        {
            btn_formStaff.Click += btn_formStaff_Click;
            btn_routeForm.Click += btn_formRoute_Click;
            btn_vehicleForm.Click += btn_formVehicle_Click;
            btn_deliveryForm.Click += btn_formDelivery_Click;
            btn_seatForm.Click += btn_formSeat_Click;
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

    }
}
