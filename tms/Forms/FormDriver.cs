using Microsoft.Data.SqlClient;
using Staff_info.Repository;
using System.Data;
using tms.Model;
using tms.Repository;

namespace tms.Forms
{
    public partial class FormDriver : Form
    {
        private readonly DriverRepository driverRepository;
        private readonly StaffRepository staffRepository;
        private List<Driver> drivers;
        private List<Staff> staffMembers;

        public FormDriver()
        {
            InitializeComponent();
            driverRepository = new DriverRepository();
            staffRepository = new StaffRepository();
            InitializeData();
        }

        private void InitializeData()
        {
            try
            {
                LoadStaff();
                LoadAvailabilityOptions();
                LoadDrivers();
                SetupDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStaff()
        {
            try
            {
                staffMembers = staffRepository.GetAll();

                cmbStaff.DataSource = null;
                cmbStaff.DataSource = staffMembers;
                cmbStaff.DisplayMember = "Name"; // Use FullName or whatever property contains the staff name
                cmbStaff.ValueMember = "StaffId";
                cmbStaff.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading staff: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvailabilityOptions()
        {
            var availabilityOptions = new List<string>
            {
                "Available",
                "Unavailable",
                "On Trip",
                "On Leave"
            };

            cmbAvailability.DataSource = availabilityOptions;
            cmbAvailability.SelectedIndex = -1;
        }

        private void LoadDrivers()
        {
            try
            {
                drivers = driverRepository.GetAllDrivers();

                // Create a list with staff names for display
                var driversWithStaffNames = drivers.Select(d => new
                {
                    d.DriverID,
                    d.StaffId,
                    StaffName = GetStaffName(d.StaffId),
                    d.LicenseNumber,
                    d.LicenseExpiryDate,
                    d.LicenseType,
                    d.Availability
                }).ToList();

                dgvDrivers.DataSource = driversWithStaffNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading drivers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetStaffName(string staffId)
        {
            var staff = staffMembers?.FirstOrDefault(s => s.StaffId == staffId);
            return staff?.Name ?? "Unknown Staff"; // Use FullName or whatever property contains the staff name
        }

        private void SetupDataGridView()
        {
            if (dgvDrivers.Columns.Count > 0)
            {
                // Hide or rename columns as needed
                dgvDrivers.Columns["DriverID"].HeaderText = "Driver ID";

                // Hide StaffId column and show StaffName instead
                if (dgvDrivers.Columns["StaffId"] != null)
                    dgvDrivers.Columns["StaffId"].Visible = false;

                if (dgvDrivers.Columns["StaffName"] != null)
                    dgvDrivers.Columns["StaffName"].HeaderText = "Staff Name";

                dgvDrivers.Columns["LicenseNumber"].HeaderText = "License Number";
                dgvDrivers.Columns["LicenseExpiryDate"].HeaderText = "License Expiry";
                dgvDrivers.Columns["LicenseType"].HeaderText = "License Type";
                dgvDrivers.Columns["Availability"].HeaderText = "Status";

                // Format date column if it exists
                if (dgvDrivers.Columns["LicenseExpiryDate"] != null)
                {
                    dgvDrivers.Columns["LicenseExpiryDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }

                // Set column order
                if (dgvDrivers.Columns["StaffName"] != null)
                    dgvDrivers.Columns["StaffName"].DisplayIndex = 1;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;

                var driver = new Driver
                {
                    StaffId = (string)cmbStaff.SelectedValue,
                    LicenseNumber = txtLicenseNumber.Text.Trim(),
                    LicenseExpiryDate = dtpLicenseExpiryDate.Value,
                    LicenseType = txtLicenseType.Text.Trim(),
                    Availability = cmbAvailability.SelectedItem?.ToString()
                };

                if (driverRepository.AddDriver(driver))
                {
                    MessageBox.Show("Driver added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDrivers();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add driver. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding driver: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDriverID.Text))
                {
                    MessageBox.Show("Please select a driver to update.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateInput())
                    return;

                var driver = new Driver
                {
                    DriverID = int.Parse(txtDriverID.Text),
                    StaffId = (string)cmbStaff.SelectedValue,
                    LicenseNumber = txtLicenseNumber.Text.Trim(),
                    LicenseExpiryDate = dtpLicenseExpiryDate.Value,
                    LicenseType = txtLicenseType.Text.Trim(),
                    Availability = cmbAvailability.SelectedItem?.ToString()
                };

                if (driverRepository.UpdateDriver(driver))
                {
                    MessageBox.Show("Driver updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDrivers();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to update driver. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating driver: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtDriverID.Clear();
            cmbStaff.SelectedIndex = -1;
            txtLicenseNumber.Clear();
            txtLicenseType.Clear();
            cmbAvailability.SelectedIndex = -1;
            dtpLicenseExpiryDate.Value = DateTime.Now;

            // Clear selection in DataGridView
            dgvDrivers.ClearSelection();
        }

        private bool ValidateInput()
        {
            if (cmbStaff.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a staff member.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStaff.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLicenseNumber.Text))
            {
                MessageBox.Show("Please enter a license number.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLicenseNumber.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLicenseType.Text))
            {
                MessageBox.Show("Please enter a license type.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLicenseType.Focus();
                return false;
            }

            if (cmbAvailability.SelectedIndex == -1)
            {
                MessageBox.Show("Please select availability status.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbAvailability.Focus();
                return false;
            }

            if (dtpLicenseExpiryDate.Value <= DateTime.Now)
            {
                MessageBox.Show("License expiry date must be in the future.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpLicenseExpiryDate.Focus();
                return false;
            }

            return true;
        }

        private void DgvDrivers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDrivers.SelectedRows.Count > 0)
            {
                var selectedRow = dgvDrivers.SelectedRows[0];

                txtDriverID.Text = selectedRow.Cells["DriverID"].Value?.ToString();

                // Set staff selection
                var staffId = selectedRow.Cells["StaffId"].Value;
                if (staffId != null)
                {
                    cmbStaff.SelectedValue = staffId;
                }

                txtLicenseNumber.Text = selectedRow.Cells["LicenseNumber"].Value?.ToString();
                txtLicenseType.Text = selectedRow.Cells["LicenseType"].Value?.ToString();

                // Set availability selection
                var availability = selectedRow.Cells["Availability"].Value?.ToString();
                if (!string.IsNullOrEmpty(availability))
                {
                    cmbAvailability.SelectedItem = availability;
                }

                // Set license expiry date
                var expiryDate = selectedRow.Cells["LicenseExpiryDate"].Value;
                if (expiryDate != null && DateTime.TryParse(expiryDate.ToString(), out DateTime date))
                {
                    dtpLicenseExpiryDate.Value = date;
                }
            }
        }

        private void PerformSearch(object sender, EventArgs e)
        {
            try
            {
                string searchTerm = txtSearch.Text.Trim();

                if (string.IsNullOrEmpty(searchTerm))
                {
                    LoadDrivers(); // Show all drivers if search is empty
                }
                else
                {
                    var searchResults = driverRepository.SearchDrivers(searchTerm);

                    // Create a list with staff names for display
                    var searchResultsWithStaffNames = searchResults.Select(d => new
                    {
                        d.DriverID,
                        d.StaffId,
                        StaffName = GetStaffName(d.StaffId),
                        d.LicenseNumber,
                        d.LicenseExpiryDate,
                        d.LicenseType,
                        d.Availability
                    }).ToList();

                    dgvDrivers.DataSource = searchResultsWithStaffNames;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching drivers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
    }
}