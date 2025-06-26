using System;
using System.Collections.Generic;
using System.Windows.Forms;
using tms.Model;
using tms.Repository;

namespace tms.Forms
{
    public partial class FormVehicle : Form
    {
        private readonly VehicleRepository _vehicleRepository;
        private readonly RouteRepository _routeRepository;
        private List<Vehicle> allVehicles;
        private string selectedVehicleId = string.Empty; // Changed to match Staff pattern

        public FormVehicle()
        {
            InitializeComponent();
            _vehicleRepository = new VehicleRepository();
            _routeRepository = new RouteRepository();

            LoadVehicles();
            WireEvents();
        }

        private void LoadVehicles()
        {
            try
            {
                allVehicles = _vehicleRepository.GetAll();
                lstVehicles.DataSource = allVehicles; // Use DataSource like Staff form
                LoadComboBoxData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void WireEvents()
        {
            txtSearch.TextChanged += TxtSearch_TextChanged;
            lstVehicles.SelectedIndexChanged += LstVehicles_SelectedIndexChanged;
            btnInsert.Click += btnAddVehicle_Click; // Renamed to match Staff pattern
            btnUpdate.Click += btnEditVehicle_Click; // Renamed to match Staff pattern
            btnClear.Click += btnClear_Click; // Renamed to match Staff pattern
            btnLogOut.Click += BtnLogOut_Click;
        }

        private void LoadComboBoxData()
        {
            try
            {
                cmbType.Items.Clear();
                cmbType.Items.AddRange(_vehicleRepository.GetVehicleTypes().ToArray());

                cmbStatus.Items.Clear();
                cmbStatus.Items.AddRange(_vehicleRepository.GetVehiclestatuses().ToArray());

                var routes = _routeRepository.GetAll();
                cmbRouteID.Items.Clear();
                cmbRouteID.Items.Add("");
                foreach (var route in routes)
                {
                    cmbRouteID.Items.Add(route.RouteID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading combo box data: {ex.Message}");
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                List<Vehicle> filteredVehicles;

                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    filteredVehicles = allVehicles;
                }
                else
                {
                    string searchTerm = txtSearch.Text.Trim().ToLower();
                    filteredVehicles = allVehicles.Where(v =>
                        (v.VehicleID?.ToLower().Contains(searchTerm) ?? false) ||
                        (v.Type?.ToLower().Contains(searchTerm) ?? false) ||
                        (v.LicensePlate?.ToLower().Contains(searchTerm) ?? false) ||
                        (v.Status?.ToLower().Contains(searchTerm) ?? false)
                    ).ToList();
                }

                lstVehicles.DataSource = filteredVehicles;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching vehicles: {ex.Message}");
            }
        }

        private void LstVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVehicles.SelectedItem is Vehicle selectedVehicle)
            {
                selectedVehicleId = selectedVehicle.VehicleID;

                // Load vehicle data into input controls - same pattern as Staff
                txtVehicleID.Text = selectedVehicle.VehicleID;
                cmbType.Text = selectedVehicle.Type;
                txtCapacity.Text = selectedVehicle.Capacity?.ToString() ?? "";
                txtLicensePlate.Text = selectedVehicle.LicensePlate;
                cmbRouteID.Text = selectedVehicle.RouteID ?? "";
                cmbStatus.Text = selectedVehicle.Status;

                if (selectedVehicle.MaintenanceDate.HasValue)
                {
                    dtpMaintenanceDate.Value = selectedVehicle.MaintenanceDate.Value;
                    dtpMaintenanceDate.Checked = true;
                }
                else
                {
                    dtpMaintenanceDate.Checked = false;
                }
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm()) return;

                var vehicle = new Vehicle
                {
                    VehicleID = txtVehicleID.Text.Trim(),
                    Type = cmbType.Text.Trim(),
                    Capacity = int.TryParse(txtCapacity.Text.Trim(), out int capacity) ? capacity : (int?)null,
                    LicensePlate = txtLicensePlate.Text.Trim(),
                    RouteID = string.IsNullOrWhiteSpace(cmbRouteID.Text) ? null : cmbRouteID.Text.Trim(),
                    Status = cmbStatus.Text.Trim(),
                    MaintenanceDate = dtpMaintenanceDate.Checked ? dtpMaintenanceDate.Value.Date : (DateTime?)null
                };

                // Check if Vehicle ID already exists
                if (_vehicleRepository.GetById(vehicle.VehicleID) != null)
                {
                    MessageBox.Show("Vehicle ID already exists. Please use a different ID.");
                    return;
                }

                _vehicleRepository.Add(vehicle);
                MessageBox.Show("Vehicle added successfully!");
                LoadVehicles();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding vehicle: " + ex.Message);
            }
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedVehicleId))
            {
                MessageBox.Show("Please select a vehicle to update.");
                return;
            }

            try
            {
                if (!ValidateForm()) return;

                var updatedVehicle = new Vehicle
                {
                    VehicleID = selectedVehicleId, // Use the selected ID, don't allow changing it
                    Type = cmbType.Text.Trim(),
                    Capacity = int.TryParse(txtCapacity.Text.Trim(), out int capacity) ? capacity : (int?)null,
                    LicensePlate = txtLicensePlate.Text.Trim(),
                    RouteID = string.IsNullOrWhiteSpace(cmbRouteID.Text) ? null : cmbRouteID.Text.Trim(),
                    Status = cmbStatus.Text.Trim(),
                    MaintenanceDate = dtpMaintenanceDate.Checked ? dtpMaintenanceDate.Value.Date : (DateTime?)null
                };

                bool success = _vehicleRepository.Update(updatedVehicle);

                if (success)
                {
                    MessageBox.Show("Vehicle updated successfully!");
                    LoadVehicles();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to update vehicle.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating vehicle: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtVehicleID.Clear();
            cmbType.Text = "";
            txtCapacity.Clear();
            txtLicensePlate.Clear();
            cmbRouteID.Text = "";
            cmbStatus.Text = "";
            dtpMaintenanceDate.Checked = false;

            selectedVehicleId = string.Empty; // Reset selected vehicle ID
            lstVehicles.ClearSelected(); // Unselect any selected item
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtVehicleID.Text))
            {
                MessageBox.Show("Vehicle ID is required.");
                txtVehicleID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbType.Text))
            {
                MessageBox.Show("Vehicle Type is required.");
                cmbType.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLicensePlate.Text))
            {
                MessageBox.Show("License Plate is required.");
                txtLicensePlate.Focus();
                return false;
            }

            return true;
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstVehicles_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}