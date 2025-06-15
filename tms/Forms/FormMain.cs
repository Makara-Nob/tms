using System;
using System.Drawing;
using System.Windows.Forms;
using Staff_info;
using tms.Forms;

namespace tms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            WireEvents();
        }

        private void WireEvents()
        {
            btn_formStaff.Click += btn_formStaff_Click;
            btnRouteInfo.Click += BtnRouteInfo_Click;
            btnVehicleInfo.Click += BtnVehicleInfo_Click;
            btnExit.Click += BtnExit_Click;
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

        private void btn_formStaff_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormStaff());
        }

        private void loadFormIntoPanel(FormStaff formStaff)
        {
            throw new NotImplementedException();
        }

        private void BtnRouteInfo_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new RouteInformationForm());
        }

        private void BtnVehicleInfo_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new VehicleInformationForm());
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Add custom painting code here if needed
        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}