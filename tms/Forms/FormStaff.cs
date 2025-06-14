using Microsoft.EntityFrameworkCore;
using Staff_info.Data;
using Staff_info.Model;
using Staff_info.Repository;
using System.Configuration;
using System.Xml.Linq;

namespace Staff_info
{
    public partial class FormStaff : Form
    {
        private AppDbContext? _context;
        private int selectedStaffId = -1;

        public FormStaff()
        {
            InitializeComponent();
            InitCheckBox();
            InitializeDbContext();
            LoadStaff();
        }
        private void InitializeDbContext()
        {
            string? connStr = ConfigurationManager.ConnectionStrings["AppDbContext"]?.ConnectionString;

            if (string.IsNullOrEmpty(connStr))
            {
                MessageBox.Show("Connection string not found.");
                return;
            }

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(connStr)
                .Options;

            _context = new AppDbContext(options);
        }

        private void LoadStaff()
        {
            var staffLIst = _context?.Staffs.ToList();
            Dgv_staff.DataSource = staffLIst;
        }

        private void InitCheckBox()
        {
            chkIsWorking.CheckedChanged += (s, e) =>
            {
                if (chkIsWorking.Checked) chkIsStopWorking.Checked = false;
            };

            chkIsStopWorking.CheckedChanged += (s, e) =>
            {
                if (chkIsStopWorking.Checked) chkIsWorking.Checked = false;
            };
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                var staff = new Staff
                {
                    Name = textBox_staffName.Text,
                    Gender = textBox_gender.Text,
                    BirthDate = textBox_birthDate.Text,
                    Address = textBox_address.Text,
                    Personal_PhoneNumber = textBox_ps_phoneNumber.Text,
                    Contact_PhoneNumber = textBox_ct_phoneNumber.Text,
                    Hired_Date = textBox_hiredDate.Text,
                    Salary = decimal.Parse(textBox_salary.Text),
                    IsStopWorking = chkIsStopWorking.Checked
                };

                _context?.Staffs.Add(staff);
                _context.SaveChanges();

                MessageBox.Show("Staff added successfully!");
                LoadStaff(); // Optional: refresh DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var keyword = textBox_searchStaff.Text.Trim();
            var repo = new StaffRepository();
            var result = repo.Search(keyword);

            Dgv_staff.DataSource = result;
        }

        private void Dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // make sure not header row
            {
                var row = Dgv_staff.Rows[e.RowIndex];
                var staff = row.DataBoundItem as Staff;

                if (staff != null)
                {
                    // Load staff data into input controls
                    textBox_staffName.Text = staff.Name;
                    textBox_gender.Text = staff.Gender;
                    textBox_birthDate.Text = staff.BirthDate;
                    textBox_address.Text = staff.Address;
                    textBox_ps_phoneNumber.Text = staff.Personal_PhoneNumber;
                    textBox_ct_phoneNumber.Text = staff.Contact_PhoneNumber;
                    textBox_hiredDate.Text = staff.Hired_Date;
                    textBox_salary.Text = staff.Salary.ToString();
                    chkIsStopWorking.Checked = staff.IsStopWorking;
                    chkIsWorking.Checked = !staff.IsStopWorking;

                    // You might want to store the selected staff Id for updating later
                    selectedStaffId = staff.StaffId; // Add this field in your class
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }


        private void ClearForm()
        {
            textBox_staffName.Clear();
            textBox_gender.Clear();
            textBox_birthDate.Clear();
            textBox_address.Clear();
            textBox_ps_phoneNumber.Clear();
            textBox_ct_phoneNumber.Clear();
            textBox_hiredDate.Clear();
            textBox_salary.Clear();

            chkIsStopWorking.Checked = false;
            chkIsWorking.Checked = false;

            selectedStaffId = -1; // Reset selected staff ID

            Dgv_staff.ClearSelection(); // Unselect any selected row
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == -1)
            {
                MessageBox.Show("Please select a staff member to update.");
                return;
            }

            try
            {
                // Find the staff entity by ID
                var staff = _context.Staffs.Find(selectedStaffId);
                if (staff == null)
                {
                    MessageBox.Show("Staff not found.");
                    return;
                }

                // Update staff properties from input fields
                staff.Name = textBox_staffName.Text;
                staff.Gender = textBox_gender.Text;
                staff.BirthDate = textBox_birthDate.Text;
                staff.Address = textBox_address.Text;
                staff.Personal_PhoneNumber = textBox_ps_phoneNumber.Text;
                staff.Contact_PhoneNumber = textBox_ct_phoneNumber.Text;
                staff.Hired_Date = textBox_hiredDate.Text;
                staff.Salary = decimal.Parse(textBox_salary.Text);
                staff.IsStopWorking = chkIsStopWorking.Checked;

                _context.SaveChanges();

                MessageBox.Show("Staff updated successfully!");
                LoadStaff(); // refresh grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
