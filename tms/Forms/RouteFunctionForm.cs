using System;
using System.Windows.Forms;
using tms.Model;

namespace tms.Forms
{
    public partial class RouteNewForm : Form
    {
        private RouteDAL routeDAL;
        private VehicleDAL vehicleDAL;

        public Route CreatedRoute { get; private set; }
        public DialogResult FormResult { get; private set; }

        public RouteNewForm()
        {
            InitializeComponent();
            routeDAL = new RouteDAL();
            vehicleDAL = new VehicleDAL();
            LoadComboBoxData();
            SetupForm();
        }

        private void SetupForm()
        {
            // Set focus to first field
            txtRouteID.Focus();

            // Set default values
            cmbPriority.SelectedIndex = 0; // Empty selection
            chkAvoidTolls.Checked = false;
            chkEnableWeatherAlerts.Checked = false;
        }

        private void LoadComboBoxData()
        {
            try
            {
                // Load vehicles
                var vehicles = vehicleDAL.GetAllVehicles();
                cmbVehicleAssigned.Items.Clear();
                cmbVehicleAssigned.Items.Add(""); // Empty option for no assignment

                foreach (var vehicle in vehicles)
                {
                    cmbVehicleAssigned.Items.Add(vehicle.VehicleID);
                }

                if (cmbVehicleAssigned.Items.Count > 0)
                    cmbVehicleAssigned.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicle data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            // Route ID validation
            if (string.IsNullOrWhiteSpace(txtRouteID.Text))
            {
                MessageBox.Show("Route ID is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRouteID.Focus();
                return false;
            }

            // Start Point validation
            if (string.IsNullOrWhiteSpace(txtStartPoint.Text))
            {
                MessageBox.Show("Start Point is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStartPoint.Focus();
                return false;
            }

            // End Point validation
            if (string.IsNullOrWhiteSpace(txtEndPoint.Text))
            {
                MessageBox.Show("End Point is required.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndPoint.Focus();
                return false;
            }

            // Distance validation
            if (!string.IsNullOrWhiteSpace(txtDistance.Text) &&
                !decimal.TryParse(txtDistance.Text, out _))
            {
                MessageBox.Show("Distance must be a valid number.", "Validation Error");
                txtDistance.Focus();
                return false;
            }

            // Estimated Time validation
            if (!string.IsNullOrWhiteSpace(txtEstimatedTime.Text) &&
                !int.TryParse(txtEstimatedTime.Text, out _))
            {
                MessageBox.Show("Estimated Time must be a whole number.", "Validation Error");
                txtEstimatedTime.Focus();
                return false;
            }

            return true;
        }

        private Route GetRouteFromForm()
        {
            var route = new Route
            {
                RouteID = txtRouteID.Text.Trim(),
                StartPoint = txtStartPoint.Text.Trim(),
                EndPoint = txtEndPoint.Text.Trim(),
                VehicleAssigned = string.IsNullOrWhiteSpace(cmbVehicleAssigned.Text) ? null : cmbVehicleAssigned.Text.Trim(),
                Priority = string.IsNullOrWhiteSpace(cmbPriority.Text) ? null : cmbPriority.Text.Trim(),
                AvoidTolls = chkAvoidTolls.Checked,
                EnableWeatherAlerts = chkEnableWeatherAlerts.Checked,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow
            };

            // Parse distance if provided
            if (!string.IsNullOrWhiteSpace(txtDistance.Text) &&
                decimal.TryParse(txtDistance.Text.Trim(), out decimal distance))
            {
                route.DistanceKm = distance;
            }

            // Parse estimated time if provided
            if (!string.IsNullOrWhiteSpace(txtEstimatedTime.Text) &&
                int.TryParse(txtEstimatedTime.Text.Trim(), out int time))
            {
                route.EstimatedTimeMinutes = time;
            }

            return route;
        }

        private void ClearForm()
        {
            txtRouteID.Clear();
            txtStartPoint.Clear();
            txtEndPoint.Clear();
            txtDistance.Clear();
            txtEstimatedTime.Clear();
            cmbVehicleAssigned.SelectedIndex = 0;
            cmbPriority.SelectedIndex = 0;
            chkAvoidTolls.Checked = false;
            chkEnableWeatherAlerts.Checked = false;
            txtRouteID.Focus();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm())
                    return;

                var route = GetRouteFromForm();

                // Check if route ID already exists
                if (routeDAL.GetRouteById(route.RouteID) != null)
                {
                    MessageBox.Show("Route ID already exists. Please use a different ID.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRouteID.Focus();
                    return;
                }

                // Insert the new route
                if (routeDAL.InsertRoute(route))
                {
                    CreatedRoute = route;
                    FormResult = DialogResult.OK;
                    MessageBox.Show("Route created successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to create route. Please try again.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating route: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to clear all fields?", "Confirm Clear",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                ClearForm();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to cancel? Any unsaved changes will be lost.",
                "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FormResult = DialogResult.Cancel;
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            txtRouteID.Focus();
        }

        // Handle Enter key to move to next control
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (ActiveControl == btnSave)
                {
                    BtnSave_Click(this, EventArgs.Empty);
                    return true;
                }
                else if (ActiveControl != txtDistance && ActiveControl != txtEstimatedTime)
                {
                    SelectNextControl(ActiveControl, true, true, true, true);
                    return true;
                }
            }
            else if (keyData == Keys.Escape)
            {
                BtnCancel_Click(this, EventArgs.Empty);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void cmbVehicleAssigned_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void RouteNewForm_Load(object sender, EventArgs e)
        {
        }
    }
}