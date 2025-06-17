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
        private bool imageChanged = false; // Add this flag

        public FormStaff()
        {
            InitializeComponent();
            _staffRepository = new StaffRepository();

            RegisterCommonPositions();
            LoadStaff();
            WireEvents();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picStaffPhoto.Image = Image.FromFile(ofd.FileName);
                imageChanged = true; // Mark that image was changed
            }
        }

        private byte[]? ImageToByteArray(Image? image)
        {
            if (image == null) return null;

            try
            {
                using MemoryStream ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image conversion failed: " + ex.Message);
                return null;
            }
        }



        private Image? ByteArrayToImage(byte[]? data)
        {
            if (data == null || data.Length == 0) return null;
            using MemoryStream ms = new MemoryStream(data);
            return Image.FromStream(ms);
        }


        private void LoadStaff()
        {
            try
            {
                allStaffs = _staffRepository.GetAll();
                dgvStaff.DataSource = allStaffs;
                dgvStaff.Columns["Photo"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void WireEvents()
        {
            rbInactive.CheckedChanged += (s, e) =>
            {
                if (rbActive.Checked) rbInactive.Checked = false;
            };

            rbInactive.CheckedChanged += (s, e) =>
            {
                if (rbInactive.Checked) rbActive.Checked = false;
            };

            rbMale.CheckedChanged += (s, e) =>
            {
                if (rbMale.Checked) rbFemale.Checked = false;
            };

            rbFemale.CheckedChanged += (s, e) =>
            {
                if (rbFemale.Checked) rbMale.Checked = false;
            };

            txtSearch.TextChanged += TxtSearch_TextChanged;
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

        private void RegisterCommonPositions()
        {
            cmbPosition.Items.Clear(); // Optional: avoids duplicates if called again

            cmbPosition.Items.AddRange(new object[]
                {
                    "General Manager",
                    "Operations Manager",
                    "Fleet Supervisor",
                    "Dispatcher",
                    "Driver",
                    "Driver Assistant",
                    "Mechanic",
                    "Maintenance Staff",
                    "Logistics Coordinator",
                    "Route Planner",
                    "Safety Officer",
                    "HR Officer",
                    "Accountant",
                    "Receptionist",
                    "IT Support"
                });

            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList; // Optional: restrict to listed items
        }



        private void BtnRemovePhoto_Click(object sender, EventArgs e)
        {
            picStaffPhoto.Image = null;
        }


        private void BtnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                var staff = new Staff
                {
                    StaffId = GenerateNextStaffId(),
                    Name = txtStaffName.Text,
                    Gender = rbMale.Checked ? "Male" : (rbFemale.Checked ? "Female" : ""),
                    BirthDate = dtBirthDate.Value,
                    Address = txtAddress.Text,
                    Personal_PhoneNumber = txtPersonalNumber.Text,
                    Contact_PhoneNumber = txtContactNumber.Text,
                    Hired_Date = dtHiredDate.Value,
                    Photo = ImageToByteArray(picStaffPhoto.Image),
                    Salary = decimal.Parse(txtSalary.Text),
                    IsStopWorking = rbInactive.Checked,
                    position = cmbPosition.Text
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
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    allStaffs = _staffRepository.GetAll();
                }
                else
                {
                    allStaffs = _staffRepository.Search(txtSearch.Text.Trim());
                }

                dgvStaff.DataSource = allStaffs;
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
                var staff = dgvStaff.Rows[e.RowIndex].DataBoundItem as Staff;

                if (staff != null)
                {
                    selectedStaffId = staff.StaffId;
                    imageChanged = false;

                    txtStaffName.Text = staff.Name;
                    rbMale.Checked = staff.Gender == "Male";
                    rbFemale.Checked = staff.Gender == "Female";

                    txtPersonalNumber.Text = staff.Personal_PhoneNumber;
                    txtContactNumber.Text = staff.Contact_PhoneNumber;
                    txtAddress.Text = staff.Address;
                    dtBirthDate.Value = staff.BirthDate;
                    dtHiredDate.Value = staff.Hired_Date;
                    cmbPosition.ValueMember = staff.position;
                    picStaffPhoto.Image = ByteArrayToImage(staff.Photo);

                    txtSalary.Text = staff.Salary.ToString();
                    rbInactive.Checked = staff.IsStopWorking;
                    rbActive.Checked = !staff.IsStopWorking;
                    cmbPosition.Text = staff.position;
                }
            }
        }

        private void BtnEditStaff_Click(object sender, EventArgs e)
        {
           

            if (selectedStaffId == null)
            {
                MessageBox.Show("Please select a staff member to update.");
                return;
            }

            try
            {
                byte[]? currentPhoto;

                if (imageChanged)
                {
                    // Only convert if image was actually changed
                    currentPhoto = ImageToByteArray(picStaffPhoto.Image);
                }
                else
                {
                    // Keep original photo data
                    currentPhoto = allStaffs.FirstOrDefault(s => s.StaffId == selectedStaffId)?.Photo;
                }

                var updatedStaff = new Staff
                {
                    StaffId = selectedStaffId,
                    Name = txtStaffName.Text,
                    Gender = rbMale.Checked ? "Male" : (rbFemale.Checked ? "Female" : ""),
                    BirthDate = dtBirthDate.Value,
                    Address = txtAddress.Text,
                    Personal_PhoneNumber = txtPersonalNumber.Text,
                    Contact_PhoneNumber = txtContactNumber.Text,
                    Hired_Date = dtHiredDate.Value,
                    Photo = currentPhoto,
                    Salary = decimal.Parse(txtSalary.Text),
                    IsStopWorking = rbInactive.Checked,
                    position = cmbPosition.Text
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
            txtStaffName.Clear();
            rbMale.Checked = false;
            rbFemale.Checked = false;
            dtBirthDate.Value = DateTime.Now;
            txtAddress.Clear();
            txtPersonalNumber.Clear();
            txtContactNumber.Clear();
            dtHiredDate.Value = DateTime.Now;
            txtSalary.Clear();
            rbInactive.Checked = false;
            rbActive.Checked = false;
            cmbPosition.SelectedIndex = -1;
            picStaffPhoto.Image = null;

            selectedStaffId = null;
            imageChanged = false; // Reset flag
            dgvStaff.ClearSelection();
        }

    }
}
