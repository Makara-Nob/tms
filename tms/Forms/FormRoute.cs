using System;
using tms.Model;
using tms.Repository;

namespace tms.Forms
{
    public partial class FormRoute : Form
    {
        private readonly RouteRepository _routeRepository;
        private readonly VehicleRepository _vehicleRepository;
        private List<Route> allRoutes;
        private string selectedRouteId = "";

        public FormRoute()
        {
            InitializeComponent();
            _routeRepository = new RouteRepository();
            _vehicleRepository = new VehicleRepository();

            LoadRoutes();
            LoadVehicleComboBox();
            WireEvents();
        }

        private void LoadRoutes()
        {
            try
            {
                allRoutes = _routeRepository.GetAll();
                lstRoutes.DataSource = allRoutes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void LoadVehicleComboBox()
        {
            try
            {
                var vehicles = _vehicleRepository.GetAll();
                cmbVehicleAssigned.Items.Clear();
                cmbVehicleAssigned.Items.Add(""); // Empty option
                foreach (var vehicle in vehicles)
                {
                    cmbVehicleAssigned.Items.Add(vehicle.VehicleID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicles: {ex.Message}");
            }
        }

        private void WireEvents()
        {
            txtSearch.TextChanged += TxtSearch_TextChanged;
            lstRoutes.SelectedIndexChanged += lstRoutes_SelectedIndexChanged;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    allRoutes = _routeRepository.GetAll();
                }
                else
                {
                    allRoutes = _routeRepository.Search(txtSearch.Text.Trim());
                }

                lstRoutes.DataSource = allRoutes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching routes: {ex.Message}");
            }
        }

        private void lstRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRoutes.SelectedIndex >= 0)
            {
                var route = lstRoutes.SelectedItem as Route;
                if (route != null)
                {
                    selectedRouteId = route.RouteID;

                    txtRouteID.Text = route.RouteID;
                    txtStartPoint.Text = route.StartPoint;
                    txtEndPoint.Text = route.EndPoint;
                    txtDistance.Text = route.DistanceKm?.ToString() ?? "";
                    txtEstimatedTime.Text = route.EstimatedTimeMinutes?.ToString() ?? "";
                    cmbVehicleAssigned.Text = route.VehicleAssigned ?? "";
                    cmbPriority.Text = route.Priority ?? "";
                    chkAvoidTolls.Checked = route.AvoidTolls;
                    chkEnableWeatherAlerts.Checked = route.EnableWeatherAlerts;
                }
            }
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm()) return;

                var route = GetRouteFromForm();

                if (_routeRepository.GetById(route.RouteID) != null)
                {
                    MessageBox.Show("Route ID already exists. Please use a different ID.");
                    return;
                }

                _routeRepository.Add(route);
                MessageBox.Show("Route added successfully!");
                LoadRoutes();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding route: " + ex.Message);
            }
        }

        private void btnEditRoute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedRouteId))
            {
                MessageBox.Show("Please select a route to update.");
                return;
            }

            try
            {
                if (!ValidateForm()) return;

                var route = GetRouteFromForm();
                route.RouteID = selectedRouteId; // Ensure we're updating the correct route

                bool success = _routeRepository.Update(route);

                if (success)
                {
                    MessageBox.Show("Route updated successfully!");
                    LoadRoutes();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to update route.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating route: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtRouteID.Clear();
            txtStartPoint.Clear();
            txtEndPoint.Clear();
            txtDistance.Clear();
            txtEstimatedTime.Clear();
            cmbVehicleAssigned.Text = "";
            cmbPriority.Text = "";
            chkAvoidTolls.Checked = false;
            chkEnableWeatherAlerts.Checked = false;

            selectedRouteId = "";
            lstRoutes.ClearSelected();
        }

        private Route GetRouteFromForm()
        {
            var route = new Route
            {
                RouteID = txtRouteID.Text.Trim(),
                StartPoint = txtStartPoint.Text.Trim(),
                EndPoint = txtEndPoint.Text.Trim(),
                VehicleAssigned = cmbVehicleAssigned.Text.Trim(),
                Priority = cmbPriority.Text.Trim(),
                AvoidTolls = chkAvoidTolls.Checked,
                EnableWeatherAlerts = chkEnableWeatherAlerts.Checked
            };

            if (decimal.TryParse(txtDistance.Text.Trim(), out var distance))
                route.DistanceKm = distance;

            if (int.TryParse(txtEstimatedTime.Text.Trim(), out var time))
                route.EstimatedTimeMinutes = time;

            return route;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtRouteID.Text))
            {
                MessageBox.Show("Route ID is required.");
                txtRouteID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStartPoint.Text))
            {
                MessageBox.Show("Start Point is required.");
                txtStartPoint.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEndPoint.Text))
            {
                MessageBox.Show("End Point is required.");
                txtEndPoint.Focus();
                return false;
            }

            return true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        // Remove unused event handlers
        private void RouteInformationForm_Load(object sender, EventArgs e) { }
        private void txtDistance_TextChanged(object sender, EventArgs e) { }
        private void lblSearch_Click(object sender, EventArgs e) { }
        private void txtEndPoint_TextChanged(object sender, EventArgs e) { }
    }
}