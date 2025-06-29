using System;
using System.Windows.Forms;
using tms;

namespace Login
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
            btnLogin.Click += btnLogin_Click;  // Hook up the event manually if missing
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim().ToLower();
            string password = txtPwd.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPwd.Focus();
            }
            else
            {
                // Replace this section with your real authentication logic (e.g., from database)
                if (username == "that" && password == "1111")
                {
                    MessageBox.Show("Login Success!");  // Test if this shows
                    this.Hide();
                    FormMain mainForm = new FormMain();
                    mainForm.FormClosed += (s, args) => this.Show(); 
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            // For testing/demo only — remove in production
            // txtUser.Text = "tmsG3";
            // txtPwd.Text = "1111";
            // btnLogin.PerformClick();
        }
    }
}
