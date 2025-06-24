using System;
using tms.Model;
using tms.Repository;

namespace tms.Forms
{
    public partial class FormRoute : Form
    {
        private readonly RouteRepository _routeRepository = new();
        private readonly VehicleRepository _vehicleRepository = new();
        private List<Route> allRoutes = new();
        private string selectedRouteId = "";
        private static HashSet<string> existingRouteIds = new HashSet<string>();
        private bool suppressSelectionEvent = false;

        public FormRoute()
        {
            InitializeComponent();
            WireEvents();
            LoadData();
        }

        private void WireEvents()
        {
            txtSearch.TextChanged += TxtSearch_TextChanged;
            lstRoutes.SelectedIndexChanged += lstRoutes_SelectedIndexChanged;
            btnClear.Click += (_, _) => ClearForm();
            btnNew.Click += btnAddRoute_Click;
        }

        private void LoadData()
        {
            LoadRoutesFromRepo();
            LoadVehicleComboBox();
        }

        private void LoadRoutesFromRepo(string? search = null)
        {
            try
            {
                allRoutes = string.IsNullOrWhiteSpace(search)
                    ? _routeRepository.GetAll()
                    : _routeRepository.Search(search);

                BindRoutesToListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading routes: {ex.Message}");
            }
        }

        private void BindRoutesToListBox()
        {
            lstRoutes.DataSource = allRoutes
                .Select(r => new { Display = $"{r.StartPoint} - {r.EndPoint}", Value = r.RouteID })
                .ToList();

            lstRoutes.DisplayMember = "Display";
            lstRoutes.ValueMember = "Value";
        }

        private void LoadVehicleComboBox()
        {
            try
            {
                cmbVehicleAssigned.Items.Clear();
                cmbVehicleAssigned.Items.Add("");
                _vehicleRepository.GetAll()
                    .ForEach(v => cmbVehicleAssigned.Items.Add(v.VehicleID));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicles: {ex.Message}");
            }
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            LoadRoutesFromRepo(txtSearch.Text.Trim());
        }

        private void FillForm(Route r)
        {
            txtRouteID.Text = r.RouteID;
            txtStartPoint.Text = r.StartPoint;
            txtEndPoint.Text = r.EndPoint;
            txtDistance.Text = r.DistanceKm?.ToString() ?? "";
            txtEstimatedTime.Text = r.EstimatedTimeMinutes?.ToString() ?? "";
            cmbVehicleAssigned.Text = r.VehicleAssigned ?? "";
            cmbPriority.Text = r.Priority ?? "";
            chkAvoidTolls.Checked = r.AvoidTolls;
            chkEnableWeatherAlerts.Checked = r.EnableWeatherAlerts;
        }

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            var route = GetRouteFromForm();

            if (_routeRepository.GetById(route.RouteID) != null)
            {
                MessageBox.Show("Route ID already exists.");
                return;
            }

            _routeRepository.Add(route);
            MessageBox.Show("Route added.");
            LoadRoutesFromRepo();
            ClearForm();
        }

        private void btnEditRoute_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedRouteId))
            {
                MessageBox.Show("Select a route first.");
                return;
            }

            if (!ValidateForm()) return;

            var route = GetRouteFromForm();
            route.RouteID = selectedRouteId;

            if (_routeRepository.Update(route))
            {
                MessageBox.Show("Route updated.");
                LoadRoutesFromRepo();
                ClearForm();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }

        private void ClearForm()
        {
            suppressSelectionEvent = true;

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

            suppressSelectionEvent = false;
        }
        private string GenerateRouteID()
        {
            string routeId;

            do
            {
                routeId = "RT:" + Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            } while (existingRouteIds.Contains(routeId));

            existingRouteIds.Add(routeId);
            return routeId;
        }


        private void lstRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (suppressSelectionEvent) return;

            if (lstRoutes.SelectedValue is string selectedId)
            {
                var route = allRoutes.FirstOrDefault(r => r.RouteID == selectedId);
                if (route != null)
                {
                    selectedRouteId = route.RouteID;
                    FillForm(route);
                }
            }
        }

        private Route GetRouteFromForm()
        {
            var route = new Route
            {
                RouteID = GenerateRouteID(),
                StartPoint = txtStartPoint.Text.Trim(),
                EndPoint = txtEndPoint.Text.Trim(),
                VehicleAssigned = cmbVehicleAssigned.Text.Trim(),
                Priority = cmbPriority.Text.Trim(),
                AvoidTolls = chkAvoidTolls.Checked,
                EnableWeatherAlerts = chkEnableWeatherAlerts.Checked
            };

            if (decimal.TryParse(txtDistance.Text.Trim(), out var km))
                route.DistanceKm = km;
            if (int.TryParse(txtEstimatedTime.Text.Trim(), out var time))
                route.EstimatedTimeMinutes = time;

            return route;
        }

        private bool ValidateForm()
        {

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
            if (MessageBox.Show("Log out?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstRoutes_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }
    }
}
