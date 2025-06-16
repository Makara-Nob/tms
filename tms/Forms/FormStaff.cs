using tms.Model;
using Staff_info.Repository;
using tms.Data;

namespace tms
{
    public partial class FormStaff : Form
    {
        private readonly StaffRepository _staffRepository;
        private List<Staff> allStaffs;
        private string selectedStaffId = null;

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

            chk_Male.CheckedChanged += (s, e) =>
            {
                if (chk_Male.Checked) chk_Female.Checked = false;
            };

            chk_Female.CheckedChanged += (s, e) =>
            {
                if (chk_Female.Checked) chk_Male.Checked = false;
            };

            textBox_searchStaff.TextChanged += TxtSearch_TextChanged;
        }

        public string GenerateNextStaffId()
        {
            using (var context = new AppDbContext())
            {
                var lastStaff = context.Staffs
                    .OrderByDescending(s => s.StaffId)
                    .FirstOrDefault();

                if (lastStaff == null)
                    return "ST-001";

                string lastId = lastStaff.StaffId; // e.g. ST-005
                int num = int.Parse(lastId.Substring(3)); // get 005 as integer
                num++; // increment

                return $"ST-{num.ToString("D3")}"; // format as ST-006
            }
        }


        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                var staff = new Staff
                {
                    StaffId = GenerateNextStaffId(),   
                    Name = textBox_staffName.Text,
                    Gender = chk_Male.Checked ? "Male" : (chk_Female.Checked ? "Female" : ""),
                    BirthDate = dt_birthdate.Value,
                    Address = textBox_address.Text,
                    Personal_PhoneNumber = textBox_ps_phoneNumber.Text,
                    Contact_PhoneNumber = textBox_ct_phoneNumber.Text,
                    Hired_Date = dt_hiredDate.Value,
                    Salary = decimal.Parse(textBox_salary.Text),
                    IsStopWorking = chkIsStopWorking.Checked,
                    position = txt_postion.Text
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
                    chk_Male.Checked = staff.Gender == "Male";
                    chk_Female.Checked = staff.Gender == "Female";

                    dt_birthdate.Value = staff.BirthDate;
                    dt_hiredDate.Value = staff.Hired_Date;


                    textBox_salary.Text = staff.Salary.ToString();
                    chkIsStopWorking.Checked = staff.IsStopWorking;
                    chkIsWorking.Checked = !staff.IsStopWorking;
                    txt_postion.Text = staff.position;
                }
            }
        }

        private void btnEditStaff_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == null)
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
                    Gender = chk_Male.Checked ? "Male" : (chk_Female.Checked ? "Female" : ""),
                    BirthDate = dt_birthdate.Value,
                    Address = textBox_address.Text,
                    Personal_PhoneNumber = textBox_ps_phoneNumber.Text,
                    Contact_PhoneNumber = textBox_ct_phoneNumber.Text,
                    Hired_Date = dt_hiredDate.Value,
                    Salary = decimal.Parse(textBox_salary.Text),
                    IsStopWorking = chkIsStopWorking.Checked,
                    position = txt_postion.Text
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
            chk_Male.Checked = false;
            chk_Female.Checked = false;
            dt_birthdate.Value = DateTime.Now;
            textBox_address.Clear();
            textBox_ps_phoneNumber.Clear();
            textBox_ct_phoneNumber.Clear();
            dt_hiredDate.Value = DateTime.Now;
            textBox_salary.Clear();
            chkIsStopWorking.Checked = false;
            chkIsWorking.Checked = false;
            txt_postion.Clear();

            selectedStaffId = null;
            Dgv_staff.ClearSelection();
        }
    }
}
