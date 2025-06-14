using System;
using System.Windows.Forms;
using tms.Model;

namespace tms.Forms
{
    public partial class VehicleUpdateForm : Form
    {
        private VehicleDAL vehicleDAL;
        private RouteDAL routeDAL;
        private Vehicle originalVehicle;

        public Vehicle UpdatedVehicle { get; private set; }
        public DialogResult FormResult { get; private set; }

        public VehicleUpdateForm(Vehicle vehicle)
        {
            originalVehicle = vehicle;
            InitializeComponent();
            vehicleDAL = new VehicleDAL();
            routeDAL = new RouteDAL();
            LoadComboBoxData();
            PopulateForm();
            WireEvents();
        }

        private void WireEvents()
        {
            chkHasMaintenanceDate.CheckedChanged += ChkHasMaintenanceDate_CheckedChanged;
            btnUpdate.Click += BtnUpdate_Click;
            btnReset.Click += BtnReset_Click;
            btnCancel.Click += BtnCancel_Click;
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
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateForm()
        {
            txtVehicleID.Text = originalVehicle.VehicleID.ToString();
            cmbType.Text = originalVehicle.Type;
            txtCapacity.Text = originalVehicle.Capacity?.ToString() ?? "";
            txtLicensePlate.Text = originalVehicle.LicensePlate;
            cmbRouteID.Text = originalVehicle.RouteID ?? "";
            cmbStatus.Text = originalVehicle.Status;

            if (originalVehicle.MaintenanceDate.HasValue)
            {
                chkHasMaintenanceDate.Checked = true;
                dtpMaintenanceDate.Value = originalVehicle.MaintenanceDate.Value;
                dtpMaintenanceDate.Enabled = true;
            }
            else
            {
                chkHasMaintenanceDate.Checked = false;
                dtpMaintenanceDate.Enabled = false;
            }
        }

        private void ChkHasMaintenanceDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpMaintenanceDate.Enabled = chkHasMaintenanceDate.Checked;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm()) return;

                var vehicle = GetVehicleFromForm();

                if (vehicleDAL.UpdateVehicle(vehicle))
                {
                    UpdatedVehicle = vehicle;
                    FormResult = DialogResult.OK;
                    MessageBox.Show("Vehicle updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
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

        private void BtnReset_Click(object sender, EventArgs e)
        {
            PopulateForm();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FormResult = DialogResult.Cancel;
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private Vehicle GetVehicleFromForm()
        {
            return new Vehicle
            {
                VehicleID = txtVehicleID.Text.Trim(),
                Type = cmbType.Text.Trim(),
                Capacity = int.TryParse(txtCapacity.Text.Trim(), out int capacity) ? capacity : (int?)null,
                LicensePlate = txtLicensePlate.Text.Trim(),
                RouteID = string.IsNullOrEmpty(cmbRouteID.Text) ? null : cmbRouteID.Text.Trim(),
                Status = cmbStatus.Text.Trim(),
                MaintenanceDate = chkHasMaintenanceDate.Checked ? dtpMaintenanceDate.Value.Date : (DateTime?)null
            };
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(cmbType.Text))
            {
                MessageBox.Show("Vehicle Type is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbType.Focus();
                return false;
            }

            return true;
        }

        private void VehicleUpdateForm_Load(object sender, EventArgs e)
        {

        }
    }
}