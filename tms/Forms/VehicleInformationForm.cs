using System;
using System.Collections.Generic;
using System.Windows.Forms;
using tms.Model;

namespace tms.Forms
{
    public partial class VehicleInformationForm : Form
    {
        private VehicleDAL vehicleDAL;
        private RouteDAL routeDAL;
        private List<Vehicle> allVehicles;
        private Vehicle currentVehicle;

        public VehicleInformationForm()
        {
            InitializeComponent();
            vehicleDAL = new VehicleDAL();
            routeDAL = new RouteDAL();
            LoadData();
            WireEvents();
        }

        private void WireEvents()
        {
            txtSearch.TextChanged += TxtSearch_TextChanged;
            lstVehicles.SelectedIndexChanged += LstVehicles_SelectedIndexChanged;
            btnInsert.Click += BtnInsert_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnNew.Click += BtnNew_Click;
            btnLogOut.Click += BtnLogOut_Click;
            lblLicensePlate.Click += lblLicensePlate_Click;
            lblMaintenanceDate.Click += lblMaintenanceDate_Click;
            this.Load += VehicleInformationForm_Load;
        }

        private void LoadData()
        {
            try
            {
                allVehicles = vehicleDAL.GetAllVehicles();
                RefreshVehiclesList();
                LoadComboBoxData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshVehiclesList()
        {
            lstVehicles.Items.Clear();
            foreach (var vehicle in allVehicles)
            {
                lstVehicles.Items.Add($"{vehicle.VehicleID} - {vehicle.Type} ({vehicle.LicensePlate})");
            }
        }

        private void LoadComboBoxData()
        {
            try
            {
                cmbType.Items.Clear();
                cmbType.Items.AddRange(vehicleDAL.GetVehicleTypes().ToArray());

                cmbStatus.Items.Clear();
                cmbStatus.Items.AddRange(vehicleDAL.GetVehicleStatuses().ToArray());

                var routes = routeDAL.GetAllRoutes();
                cmbRouteID.Items.Clear();
                cmbRouteID.Items.Add("");
                foreach (var route in routes)
                {
                    cmbRouteID.Items.Add(route.RouteID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading combo box data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    allVehicles = vehicleDAL.GetAllVehicles();
                }
                else
                {
                    allVehicles = vehicleDAL.SearchVehicles(txtSearch.Text.Trim());
                }
                RefreshVehiclesList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching vehicles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVehicles.SelectedIndex >= 0 && lstVehicles.SelectedIndex < allVehicles.Count)
            {
                currentVehicle = allVehicles[lstVehicles.SelectedIndex];
                PopulateForm(currentVehicle);
            }
        }

        private void PopulateForm(Vehicle vehicle)
        {
            txtVehicleID.Text = vehicle.VehicleID;
            cmbType.Text = vehicle.Type;
            txtCapacity.Text = vehicle.Capacity?.ToString() ?? "";
            txtLicensePlate.Text = vehicle.LicensePlate;
            cmbRouteID.Text = vehicle.RouteID ?? "";
            cmbStatus.Text = vehicle.Status;

            if (vehicle.MaintenanceDate.HasValue)
            {
                dtpMaintenanceDate.Value = vehicle.MaintenanceDate.Value;
                dtpMaintenanceDate.Checked = true;
            }
            else
            {
                dtpMaintenanceDate.Checked = false;
            }
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
            currentVehicle = null;
        }

        private Vehicle GetVehicleFromForm()
        {
            return new Vehicle
            {
                VehicleID = txtVehicleID.Text.Trim(),
                Type = cmbType.Text.Trim(),
                Capacity = int.TryParse(txtCapacity.Text.Trim(), out int capacity) ? capacity : (int?)null,
                LicensePlate = txtLicensePlate.Text.Trim(),
                RouteID = cmbRouteID.Text.Trim(),
                Status = cmbStatus.Text.Trim(),
                MaintenanceDate = dtpMaintenanceDate.Checked ? dtpMaintenanceDate.Value.Date : (DateTime?)null
            };
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtVehicleID.Text))
            {
                MessageBox.Show("Vehicle ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVehicleID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cmbType.Text))
            {
                MessageBox.Show("Vehicle Type is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbType.Focus();
                return false;
            }

            return true;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm()) return;

                var vehicle = GetVehicleFromForm();

                if (vehicleDAL.GetVehicleById(vehicle.VehicleID) != null)
                {
                    MessageBox.Show("Vehicle ID already exists. Please use a different ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (vehicleDAL.InsertVehicle(vehicle))
                {
                    MessageBox.Show("Vehicle inserted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to insert vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting vehicle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentVehicle == null)
                {
                    MessageBox.Show("Please select a vehicle to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateForm()) return;

                var vehicle = GetVehicleFromForm();

                if (vehicleDAL.UpdateVehicle(vehicle))
                {
                    MessageBox.Show("Vehicle updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to update vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating vehicle: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
            var newVehicle = new Vehicle();
            using (var newVehicleForm = new VehicleUpdateForm(newVehicle))
            {
                if (newVehicleForm.ShowDialog() == DialogResult.OK)
                {
                    // Insert the new vehicle
                    if (vehicleDAL.InsertVehicle(newVehicleForm.UpdatedVehicle))
                    {
                        MessageBox.Show("Vehicle created successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to create vehicle.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void VehicleInformationForm_Load(object sender, EventArgs e) { }
        private void lblMaintenanceDate_Click(object sender, EventArgs e) { }
        private void lblLicensePlate_Click(object sender, EventArgs e) { }

        private void VehicleInformationForm_Load_1(object sender, EventArgs e)
        {

        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}