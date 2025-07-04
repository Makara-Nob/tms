using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using tms.Data;
using tms.Model;

namespace tms
{
    public partial class LoginForm : Form
    {
        public static Staff CurrentUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password");
                return;
            }

            try
            {
                using (var db = new AppDbContext())
                {
                    var staff = db.Staffs.FirstOrDefault(s => s.Username == username);

                    if (staff != null)
                    {
                        // Verify password with stored hash
                        bool isValid = VerifyPassword(password, staff.PasswordHash);

                        if (isValid)
                        {
                            CurrentUser = staff;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                            return;
                        }
                    }

                    MessageBox.Show("Invalid username or password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login failed: {ex.Message}");
            }
        }

        private bool VerifyPassword(string password, string storedHash)
        {
            // SQL Server uses UTF-16 (Unicode) encoding for NVARCHAR
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.Unicode.GetBytes(password));
                string computedHash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
                return computedHash == storedHash;
            }
        }
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.Unicode.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}