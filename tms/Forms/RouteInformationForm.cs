using System;
using System.Collections.Generic;
using System.Windows.Forms;
using tms.Model;

namespace tms.Forms
{
    public partial class RouteInformationForm : Form
    {
        private RouteDAL routeDAL;
        private VehicleDAL vehicleDAL;
        private List<Route> allRoutes;
        private Route currentRoute;

        public RouteInformationForm()
        {
            InitializeComponent();
            routeDAL = new RouteDAL();
            vehicleDAL = new VehicleDAL();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                allRoutes = routeDAL.GetAllRoutes();
                RefreshRoutesList();
                LoadVehicleComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshRoutesList()
        {
            lstRoutes.Items.Clear();
            foreach (var route in allRoutes)
            {
                lstRoutes.Items.Add($"{route.RouteID} - {route.StartPoint} to {route.EndPoint}");
            }
        }

        private void LoadVehicleComboBox()
        {
            try
            {
                var vehicles = vehicleDAL.GetAllVehicles();
                cmbVehicleAssigned.Items.Clear();
                cmbVehicleAssigned.Items.Add(""); // Empty option
                foreach (var vehicle in vehicles)
                {
                    cmbVehicleAssigned.Items.Add(vehicle.VehicleID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicles: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    allRoutes = routeDAL.GetAllRoutes();
                }
                else
                {
                    allRoutes = routeDAL.SearchRoutes(txtSearch.Text.Trim());
                }
                RefreshRoutesList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching routes: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LstRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRoutes.SelectedIndex >= 0 && lstRoutes.SelectedIndex < allRoutes.Count)
            {
                currentRoute = allRoutes[lstRoutes.SelectedIndex];
                PopulateForm(currentRoute);
            }
        }

        private void PopulateForm(Route route)
        {
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
            currentRoute = null;
        }

        private Route GetRouteFromForm()
        {
            var route = new Route();
            route.RouteID = txtRouteID.Text.Trim();
            route.StartPoint = txtStartPoint.Text.Trim();
            route.EndPoint = txtEndPoint.Text.Trim();

            if (decimal.TryParse(txtDistance.Text.Trim(), out decimal distance))
                route.DistanceKm = distance;

            if (int.TryParse(txtEstimatedTime.Text.Trim(), out int time))
                route.EstimatedTimeMinutes = time;

            route.VehicleAssigned = cmbVehicleAssigned.Text.Trim();
            route.Priority = cmbPriority.Text.Trim();
            route.AvoidTolls = chkAvoidTolls.Checked;
            route.EnableWeatherAlerts = chkEnableWeatherAlerts.Checked;

            return route;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtRouteID.Text))
            {
                MessageBox.Show("Route ID is required.", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRouteID.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtStartPoint.Text))
            {
                MessageBox.Show("Start Point is required.", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStartPoint.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEndPoint.Text))
            {
                MessageBox.Show("End Point is required.", "Validation Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEndPoint.Focus();
                return false;
            }

            return true;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateForm()) return;

                var route = GetRouteFromForm();

                // Check if route ID already exists
                if (routeDAL.GetRouteById(route.RouteID) != null)
                {
                    MessageBox.Show("Route ID already exists. Please use a different ID.", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (routeDAL.InsertRoute(route))
                {
                    MessageBox.Show("Route inserted successfully.", "Success",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to insert route.", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting route: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentRoute == null)
                {
                    MessageBox.Show("Please select a route to update.", "Warning",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!ValidateForm()) return;

                var route = GetRouteFromForm();

                if (routeDAL.UpdateRoute(route))
                {
                    MessageBox.Show("Route updated successfully.", "Success",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to update route.", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating route: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearForm();
            var newRouteForm = new RouteNewForm();
            if (newRouteForm.ShowDialog() == DialogResult.OK)
            {
                // Route was successfully created
                LoadData(); // Refresh the main form
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void RouteInformationForm_Load(object sender, EventArgs e)
        {
            // Form load logic
        }

        private void txtDistance_TextChanged(object sender, EventArgs e)
        {
            // Distance text changed logic
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            // Search label click logic
        }

        private void txtEndPoint_TextChanged(object sender, EventArgs e)
        {
            // End point text changed logic
        }
    }
}