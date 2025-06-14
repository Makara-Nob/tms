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

        // Handle navigation button click
        private void btn_formStaff_Click(object sender, EventArgs e)
        {
            loadFormIntoPanel(new FormStaff());
        }

        // Toggle sidebar width
  


    }
}
