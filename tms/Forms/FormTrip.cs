using Staff_info.Repository;
using System.Data;
using tms.Model;
using tms.Repository;
using System.Linq;
using System.Threading.Tasks;

namespace tms.Forms
{
    public partial class FormTrip : Form
    {
        private readonly VehicleRepository vehicleRepository = new();
        private readonly RouteRepository routeRepository = new();
        private readonly DriverRepository driverRepository = new();
        private readonly TripRepository tripRepository = new();
        private bool isLoading = false;

        public FormTrip()
        {
            InitializeComponent();
            InitializeFormComponents();
        }

        private void InitializeFormComponents()
        {
            try
            {
                LoadData();
                InitializeStatusComboBox();
                LoadComboBoxes();
                AttachEventHandlers();
                GenerateNewTripId();
                SetDefaultValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDefaultValues()
        {
            dtpDepatureTime.Value = DateTime.Now.AddHours(1);
            txtSearch.Text = string.Empty;
        }

        private void AttachEventHandlers()
        {
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
            btnClear.Click += BtnClear_Click;
            btnSearch.Click += BtnSearch_Click;

            dgvTrips.SelectionChanged += DgvTrips_SelectionChanged;
            cmbStatus.SelectedIndexChanged += CmbTripStatus_SelectedIndexChanged;

            txtSearch.KeyPress += (s, e) => {
                if (e.KeyChar == (char)Keys.Enter) BtnSearch_Click(s, e);
            };
        }

        private async void LoadComboBoxes()
        {
            if (isLoading) return;

            try
            {
                isLoading = true;
                await Task.WhenAll(
                    LoadVehicleComboBoxAsync(),
                    LoadDriverComboBoxAsync(),
                    LoadRouteComboBoxAsync()
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading combo boxes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isLoading = false;
            }
        }

        private async Task LoadVehicleComboBoxAsync()
        {
            try
            {
                var vehicles = await Task.Run(() => vehicleRepository.GetAll());

                if (vehicles == null)
                {
                    vehicles = new List<Vehicle>();
                }

                // Add default empty item
                vehicles.Insert(0, new Vehicle { VehicleID = "", Type = "-- Select Vehicle --" });

                if (cmbVehicle.InvokeRequired)
                {
                    cmbVehicle.Invoke((MethodInvoker)(() =>
                    {
                        cmbVehicle.DisplayMember = "Type";
                        cmbVehicle.ValueMember = "VehicleID";
                        cmbVehicle.DataSource = vehicles;
                    }));
                }
                else
                {
                    cmbVehicle.DisplayMember = "Type";
                    cmbVehicle.ValueMember = "VehicleID";
                    cmbVehicle.DataSource = vehicles;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicles: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                var errorData = new List<object>
        {
            new { VehicleID = "", Type = "-- Error Loading Vehicles --" }
        };

                if (cmbVehicle.InvokeRequired)
                {
                    cmbVehicle.Invoke((MethodInvoker)(() =>
                    {
                        cmbVehicle.DataSource = errorData;
                        cmbVehicle.DisplayMember = "Type";
                        cmbVehicle.ValueMember = "VehicleID";
                    }));
                }
                else
                {
                    cmbVehicle.DataSource = errorData;
                    cmbVehicle.DisplayMember = "Type";
                    cmbVehicle.ValueMember = "VehicleID";
                }
            }
        }

        private async Task LoadDriverComboBoxAsync()
        {
            try
            {
                var drivers = await Task.Run(() => driverRepository.GetAllDrivers());

                if (drivers == null)
                {
                    drivers = new List<DriverRepository.DriverWithName>();
                }

                // Add default empty item
                drivers.Insert(0, new DriverRepository.DriverWithName
                {
                    StaffId = "",
                    Name = "-- Select Driver --"
                });

                if (cmbDriver.InvokeRequired)
                {
                    cmbDriver.Invoke((MethodInvoker)(() =>
                    {
                        cmbDriver.DisplayMember = "Name";
                        cmbDriver.ValueMember = "StaffId";
                        cmbDriver.DataSource = drivers;
                    }));
                }
                else
                {
                    cmbDriver.DisplayMember = "Name";
                    cmbDriver.ValueMember = "StaffId";
                    cmbDriver.DataSource = drivers;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading drivers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                var errorData = new List<object>
        {
            new { StaffId = "", Name = "-- Error Loading Drivers --" }
        };

                if (cmbDriver.InvokeRequired)
                {
                    cmbDriver.Invoke((MethodInvoker)(() =>
                    {
                        cmbDriver.DataSource = errorData;
                        cmbDriver.DisplayMember = "Name";
                        cmbDriver.ValueMember = "StaffId";
                    }));
                }
                else
                {
                    cmbDriver.DataSource = errorData;
                    cmbDriver.DisplayMember = "Name";
                    cmbDriver.ValueMember = "StaffId";
                }
            }
        }

        private async Task LoadRouteComboBoxAsync()
        {
            try
            {
                var routes = await Task.Run(() => routeRepository.GetAll());

                if (routes == null)
                {
                    routes = new List<Route>();
                }

                // Add default empty item
                routes.Insert(0, new Route { RouteID = "", StartPoint = "-- Select Route --" });

                if (cmbRoute.InvokeRequired)
                {
                    cmbRoute.Invoke((MethodInvoker)(() =>
                    {
                        cmbRoute.DisplayMember = "StartPoint";
                        cmbRoute.ValueMember = "RouteID";
                        cmbRoute.DataSource = routes;
                    }));
                }
                else
                {
                    cmbRoute.DisplayMember = "StartPoint";
                    cmbRoute.ValueMember = "RouteID";
                    cmbRoute.DataSource = routes;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading routes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                var errorData = new List<object>
        {
            new { RouteID = "", StartPoint = "-- Error Loading Routes --" }
        };

                if (cmbRoute.InvokeRequired)
                {
                    cmbRoute.Invoke((MethodInvoker)(() =>
                    {
                        cmbRoute.DataSource = errorData;
                        cmbRoute.DisplayMember = "StartPoint";
                        cmbRoute.ValueMember = "RouteID";
                    }));
                }
                else
                {
                    cmbRoute.DataSource = errorData;
                    cmbRoute.DisplayMember = "StartPoint";
                    cmbRoute.ValueMember = "RouteID";
                }
            }
        }

        private void InitializeStatusComboBox()
        {
            var statusItems = new List<object>
            {
                new { Value = "", Text = "-- Select Status --" },
                new { Value = "Scheduled", Text = "Scheduled" },
                new { Value = "Active", Text = "Active" },
                new { Value = "In Progress", Text = "In Progress" },
                new { Value = "Completed", Text = "Completed" },
                new { Value = "Cancelled", Text = "Cancelled" },
                new { Value = "Delayed", Text = "Delayed" }
            };

            cmbStatus.DisplayMember = "Text";
            cmbStatus.ValueMember = "Value";
            cmbStatus.DataSource = statusItems;
            cmbStatus.SelectedIndex = 1;
        }

        private void CmbTripStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbStatus.SelectedValue == null) return;

                string selectedStatus = cmbStatus.SelectedValue.ToString();
                switch (selectedStatus)
                {
                    case "Scheduled":
                        if (dtpDepatureTime.Value <= DateTime.Now)
                        {
                            dtpDepatureTime.Value = DateTime.Now.AddHours(1);
                        }
                        break;
                    case "Active":
                    case "In Progress":
                        dtpDepatureTime.Value = DateTime.Now;
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating departure time: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void LoadData()
        {
            if (isLoading) return;

            try
            {
                isLoading = true;

                var trips = await Task.Run(() => tripRepository.GetAllAsync());


                if (dgvTrips.InvokeRequired)
                {
                    dgvTrips.Invoke((MethodInvoker)(() => {
                        dgvTrips.DataSource = trips?.ToList() ?? new List<Trip>();
                        if (dgvTrips.Columns.Count == 0)
                        {
                            dgvTrips.AutoGenerateColumns = false;
                        }
                    }));
                }
                else
                {
                    dgvTrips.DataSource = trips?.ToList() ?? new List<Trip>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading trips: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dgvTrips.DataSource = new List<Trip>();
            }
            finally
            {
                isLoading = false;
            }
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (isLoading || !ValidateInput()) return;

            try
            {
                isLoading = true;
                btnAdd.Enabled = false;

                var trip = new Trip
                {
                    TripID = txtTripId.Text,
                    VehicleID = cmbVehicle.SelectedValue?.ToString(),
                    DriverID = cmbDriver.SelectedValue?.ToString(),
                    RouteID = cmbRoute.SelectedValue?.ToString(),
                    DepatureTime = dtpDepatureTime.Value,
                    status = cmbStatus.SelectedValue?.ToString()
                };

                bool success = await Task.Run(() => tripRepository.AddAsync(trip));

                if (success)
                {
                    MessageBox.Show("Trip added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                    GenerateNewTripId();
                }
                else
                {
                    MessageBox.Show("Failed to add trip.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding trip: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isLoading = false;
                btnAdd.Enabled = true;
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (isLoading || string.IsNullOrEmpty(txtTripId.Text) || !ValidateInput()) return;

            try
            {
                isLoading = true;
                btnUpdate.Enabled = false;

                var trip = new Trip
                {
                    TripID = txtTripId.Text,
                    VehicleID = cmbVehicle.SelectedValue?.ToString(),
                    DriverID = cmbDriver.SelectedValue?.ToString(),
                    RouteID = cmbRoute.SelectedValue?.ToString(),
                    DepatureTime = dtpDepatureTime.Value,
                    status = cmbStatus.SelectedValue?.ToString()
                };

                bool success = await Task.Run(() => tripRepository.UpdateAsync(trip));

                if (success)
                {
                    MessageBox.Show("Trip updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to update trip.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating trip: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isLoading = false;
                btnUpdate.Enabled = true;
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            if (isLoading || string.IsNullOrEmpty(txtTripId.Text)) return;

            try
            {
                var result = MessageBox.Show("Are you sure you want to delete this trip?", "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No) return;

                isLoading = true;
                btnDelete.Enabled = false;

                bool success = await Task.Run(() => tripRepository.DeleteAsync(txtTripId.Text));

                if (success)
                {
                    MessageBox.Show("Trip deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to delete trip.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting trip: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isLoading = false;
                btnDelete.Enabled = true;
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private async void BtnSearch_Click(object sender, EventArgs e)
        {
            if (isLoading) return;

            try
            {
                isLoading = true;

                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    LoadData();
                    return;
                }

                var trips = await Task.Run(() => tripRepository.SearchAsync(txtSearch.Text.Trim()));

                if (dgvTrips.InvokeRequired)
                {
                    dgvTrips.Invoke((MethodInvoker)(() => {
                        dgvTrips.DataSource = trips?.ToList() ?? new List<Trip>();
                    }));
                }
                else
                {
                    dgvTrips.DataSource = trips?.ToList() ?? new List<Trip>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching trips: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (dgvTrips.InvokeRequired)
                {
                    dgvTrips.Invoke((MethodInvoker)(() => {
                        dgvTrips.DataSource = new List<Trip>();
                    }));
                }
                else
                {
                    dgvTrips.DataSource = new List<Trip>();
                }
            }
            finally
            {
                isLoading = false;
            }
        }

        private void DgvTrips_SelectionChanged(object sender, EventArgs e)
        {
            if (isLoading || dgvTrips.SelectedRows.Count == 0) return;

            try
            {
                var row = dgvTrips.SelectedRows[0];
                var trip = row.DataBoundItem as Trip;

                if (trip == null) return;

                txtTripId.Text = trip.TripID;
                cmbVehicle.SelectedValue = trip.VehicleID;
                cmbDriver.SelectedValue = trip.DriverID;
                cmbRoute.SelectedValue = trip.RouteID;
                dtpDepatureTime.Value = trip.DepatureTime;
                cmbStatus.SelectedValue = trip.status;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading trip details: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(cmbVehicle.SelectedValue?.ToString()))
            {
                MessageBox.Show("Please select a vehicle.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbVehicle.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cmbDriver.SelectedValue?.ToString()))
            {
                MessageBox.Show("Please select a driver.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDriver.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cmbRoute.SelectedValue?.ToString()))
            {
                MessageBox.Show("Please select a route.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRoute.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cmbStatus.SelectedValue?.ToString()))
            {
                MessageBox.Show("Please select a status.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return false;
            }

            if (cmbStatus.SelectedValue?.ToString() == "Scheduled" && dtpDepatureTime.Value <= DateTime.Now)
            {
                MessageBox.Show("Scheduled trips must have a future departure time.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDepatureTime.Focus();
                return false;
            }

            return true;
        }

        private async void GenerateNewTripId()
        {
            try
            {
                string dateStr = DateTime.Now.ToString("yyyyMMdd");
                string prefix = $"TR-{dateStr}-";

                var existingTrips = await tripRepository.GetAllAsync();

                var tripsList = existingTrips ?? new List<Trip>();

                var todayTrips = tripsList.Where(t => t.TripID?.StartsWith(prefix) == true).ToList();
                int nextNumber = todayTrips.Count + 1;

                txtTripId.Text = $"{prefix}{nextNumber:D4}";
            }
            catch
            {
                txtTripId.Text = $"TR-{DateTime.Now:yyyyMMddHHmmss}";
            }
        }

        private void ClearForm(bool clearTripId = true)
        {
            if (clearTripId) txtTripId.Clear();
            cmbVehicle.SelectedIndex = 0;
            cmbDriver.SelectedIndex = 0;
            cmbRoute.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 1;
            dtpDepatureTime.Value = DateTime.Now.AddHours(1);
        }

        private void txtTripId_TextChanged(object sender, EventArgs e)
        {
            // Empty implementation
        }

        private void dgvTrips_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Empty implementation
        }

        private void gbSearch_Enter(object sender, EventArgs e)
        {
            // Empty implementation
        }
    }
}