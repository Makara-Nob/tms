using tms.Model;
using Staff_info.Repository;

namespace tms
{
    public partial class FormStaff : Form
    {
        private readonly StaffRepository _staffRepository;
        private List<Staff> allStaffs;
        private int selectedStaffId = -1;

        public FormStaff()
        {
            InitializeComponent();
            _staffRepository = new StaffRepository();

            LoadStaff();
            WireEvents();
        }

        private void LoadStaff()
        {
            try
            {
                allStaffs = _staffRepository.GetAll();
                Dgv_staff.DataSource = allStaffs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void WireEvents()
        {
            chkIsWorking.CheckedChanged += (s, e) =>
            {
                if (chkIsWorking.Checked) chkIsStopWorking.Checked = false;
            };

            chkIsStopWorking.CheckedChanged += (s, e) =>
            {
                if (chkIsStopWorking.Checked) chkIsWorking.Checked = false;
            };

            textBox_searchStaff.TextChanged += TxtSearch_TextChanged;
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

                _staffRepository.Add(staff);
                MessageBox.Show("Staff added successfully!");
                LoadStaff();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding staff: " + ex.Message);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBox_searchStaff.Text))
                {
                    allStaffs = _staffRepository.GetAll();
                }
                else
                {
                    allStaffs = _staffRepository.Search(textBox_searchStaff.Text.Trim());
                }

                Dgv_staff.DataSource = allStaffs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching staff: {ex.Message}");
            }
        }

        private void Dgv_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var staff = Dgv_staff.Rows[e.RowIndex].DataBoundItem as Staff;

                if (staff != null)
                {
                    selectedStaffId = staff.StaffId;

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
                }
            }
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
                var updatedStaff = new Staff
                {
                    StaffId = selectedStaffId,
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

                bool success = _staffRepository.Update(updatedStaff);

                if (success)
                {
                    MessageBox.Show("Staff updated successfully!");
                    LoadStaff();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to update staff.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating staff: " + ex.Message);
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

            selectedStaffId = -1;
            Dgv_staff.ClearSelection();
        }
    }
}
