using Staff_info.Repository;
using System.Data;
using tms.Model;
using tms.Repository;

namespace tms.Forms
{
    public partial class FormTrip : Form
    {
        private TripRepository tripRepository;
        private VehicleRepository vehicleRepository;
        private StaffRepository driverRepository;
        private RouteRepository routeRepository;

        // Add flag to prevent multiple simultaneous operations
        private bool isLoading = false;

        public FormTrip()
        {
            InitializeComponent(); // Initialize the form components first

            // Initialize repositories with null checks
            InitializeRepositories();

            // Initialize form components safely
            InitializeFormComponents();
        }

        private void InitializeRepositories()
        {
            try
            {
                tripRepository = new TripRepository();
                vehicleRepository = new VehicleRepository();
                driverRepository = new StaffRepository();
                routeRepository = new RouteRepository();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing repositories: {ex.Message}", "Initialization Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Initialize with null to prevent further errors
                tripRepository = null;
                vehicleRepository = null;
                driverRepository = null;
                routeRepository = null;
            }
        }

        private void InitializeFormComponents()
        {
            try
            {
                // Initialize controls with null checks
                LoadData();
                InitializeStatusComboBox();
                LoadComboBoxes();
                AttachEventHandlers();

                // Generate initial trip ID
                GenerateNewTripId();

                // Set default values
                SetDefaultValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form components: {ex.Message}", "Initialization Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetDefaultValues()
        {
            try
            {
                // Set default departure time
                if (dtpDepatureTime != null)
                {
                    dtpDepatureTime.Value = DateTime.Now.AddHours(1);
                }

                // Clear search text
                if (txtSearch != null)
                {
                    txtSearch.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error setting default values: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Recursive method to get all controls inside a container (including nested ones)
        public IEnumerable<Control> GetAllControls(Control parent)
        {
            if (parent?.Controls == null) yield break;

            foreach (Control c in parent.Controls)
            {
                if (c != null)
                {
                    yield return c;
                    foreach (var child in GetAllControls(c))
                        yield return child;
                }
            }
        }

        private void AttachEventHandlers()
        {
            try
            {
                // Attach button event handlers with null checks
                if (btnAdd != null)
                    btnAdd.Click += BtnAdd_Click;

                if (btnUpdate != null)
                    btnUpdate.Click += BtnUpdate_Click;

                if (btnDelete != null)
                    btnDelete.Click += BtnDelete_Click;

                if (btnClear != null)
                    btnClear.Click += BtnClear_Click;

                if (btnSearch != null)
                    btnSearch.Click += BtnSearch_Click;

                if (dgvTrips != null)
                    dgvTrips.SelectionChanged += DgvTrips_SelectionChanged;

                if (cmbStatus != null)
                    cmbStatus.SelectedIndexChanged += CmbTripStatus_SelectedIndexChanged;

                // Enter key search with null check
                if (txtSearch != null)
                {
                    txtSearch.KeyPress += (s, e) =>
                    {
                        if (e.KeyChar == (char)Keys.Enter)
                        {
                            BtnSearch_Click(s, e);
                        }
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error attaching event handlers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void LoadComboBoxes()
        {
            if (isLoading) return;

            try
            {
                isLoading = true;

                // Load Vehicle ComboBox
                await LoadVehicleComboBoxAsync();

                // Load Driver ComboBox
                await LoadDriverComboBoxAsync();

                // Load Route ComboBox
                await LoadRouteComboBoxAsync();
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
                if (cmbVehicle == null || vehicleRepository == null) return;

                // Run database operation on background thread
                var vehicles = await Task.Run(() => vehicleRepository.GetAll()?.ToList() ?? new List<Vehicle>());

                // Update UI on main thread
                if (InvokeRequired)
                {
                    Invoke(new Action(() => UpdateVehicleComboBox(vehicles)));
                }
                else
                {
                    UpdateVehicleComboBox(vehicles);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicles: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Set empty data source on error
                if (cmbVehicle != null)
                {
                    cmbVehicle.DataSource = new List<object> { new { VehicleID = "", Type = "-- No Vehicles Available --" } };
                    cmbVehicle.DisplayMember = "Type";
                    cmbVehicle.ValueMember = "VehicleID";
                }
            }
        }

        private void UpdateVehicleComboBox(List<Vehicle> vehicles)
        {
            // Insert placeholder
            vehicles.Insert(0, new Vehicle
            {
                VehicleID = "",
                Type = "-- Select Vehicle --"
            });

            cmbVehicle.DisplayMember = "Type";
            cmbVehicle.ValueMember = "VehicleID";
            cmbVehicle.DataSource = vehicles;
            cmbVehicle.SelectedIndex = 0;
        }

        private async Task LoadDriverComboBoxAsync()
        {
            try
            {
                if (cmbDriver == null || driverRepository == null) return;

                // Run database operation on background thread
                var drivers = await Task.Run(() => driverRepository.GetDriverStaff()?.ToList() ?? new List<Staff>());

                // Update UI on main thread
                if (InvokeRequired)
                {
                    Invoke(new Action(() => UpdateDriverComboBox(drivers)));
                }
                else
                {
                    UpdateDriverComboBox(drivers);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading drivers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Set empty data source on error
                if (cmbDriver != null)
                {
                    cmbDriver.DataSource = new List<object> { new { StaffId = "", Name = "-- No Drivers Available --" } };
                    cmbDriver.DisplayMember = "Name";
                    cmbDriver.ValueMember = "StaffId";
                }
            }
        }

        private void UpdateDriverComboBox(List<Staff> drivers)
        {
            // Insert placeholder
            drivers.Insert(0, new Staff { StaffId = "", Name = "-- Select Driver --" });

            cmbDriver.DisplayMember = "Name";
            cmbDriver.ValueMember = "StaffId";
            cmbDriver.DataSource = drivers;
            cmbDriver.SelectedIndex = 0;
        }

        private async Task LoadRouteComboBoxAsync()
        {
            try
            {
                if (cmbRoute == null || routeRepository == null) return;

                // Run database operation on background thread
                var routes = await Task.Run(() => routeRepository.GetAll()?.ToList() ?? new List<Route>());

                // Update UI on main thread
                if (InvokeRequired)
                {
                    Invoke(new Action(() => UpdateRouteComboBox(routes)));
                }
                else
                {
                    UpdateRouteComboBox(routes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading routes: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Set empty data source on error
                if (cmbRoute != null)
                {
                    cmbRoute.DataSource = new List<object> { new { RouteID = "", StartPoint = "-- No Routes Available --" } };
                    cmbRoute.DisplayMember = "StartPoint";
                    cmbRoute.ValueMember = "RouteID";
                }
            }
        }

        private void UpdateRouteComboBox(List<Route> routes)
        {
            // Insert placeholder
            routes.Insert(0, new Route { RouteID = "", StartPoint = "-- Select Route --" });

            cmbRoute.DisplayMember = "StartPoint";
            cmbRoute.ValueMember = "RouteID";
            cmbRoute.DataSource = routes;
            cmbRoute.SelectedIndex = 0;
        }

        private void InitializeStatusComboBox()
        {
            try
            {
                if (cmbStatus == null) return;

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
                cmbStatus.SelectedIndex = 1; // Default to "Scheduled"
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing status combo box: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CmbTripStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Auto-set departure time based on status
                if (cmbStatus?.SelectedValue != null && dtpDepatureTime != null)
                {
                    string selectedStatus = cmbStatus.SelectedValue.ToString();
                    switch (selectedStatus)
                    {
                        case "Scheduled":
                            // Set future time (default behavior)
                            if (dtpDepatureTime.Value <= DateTime.Now)
                            {
                                dtpDepatureTime.Value = DateTime.Now.AddHours(1);
                            }
                            break;
                        case "Active":
                        case "In Progress":
                            // Set current time
                            dtpDepatureTime.Value = DateTime.Now;
                            break;
                    }
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

                if (dgvTrips == null || tripRepository == null) return;

                // Run database operation on background thread
                var trips = await Task.Run(() => tripRepository.GetAll());

                if (trips == null)
                {
                    dgvTrips.DataSource = null;
                    return;
                }


                dgvTrips.DataSource = trips;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Set empty data source on error
                if (dgvTrips != null)
                {
                    dgvTrips.DataSource = null;
                }
            }
            finally
            {
                isLoading = false;
            }
        }

        private async void BtnAdd_Click(object sender, EventArgs e)
        {
            if (isLoading) return;

            try
            {
                isLoading = true;
                btnAdd.Enabled = false; // Prevent multiple clicks

                if (tripRepository == null)
                {
                    MessageBox.Show("Trip repository is not initialized.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ValidateInput())
                {
                    var trip = new Trip
                    {
                        TripId = txtTripId?.Text ?? string.Empty,
                        VehicleId = cmbVehicle?.SelectedValue?.ToString() ?? string.Empty,
                        DriverId = cmbDriver?.SelectedValue?.ToString() ?? string.Empty,
                        RouteId = cmbRoute?.SelectedValue?.ToString() ?? string.Empty,
                        DepatureTime = dtpDepatureTime?.Value ?? DateTime.Now,
                        Status = cmbStatus?.SelectedValue?.ToString() ?? string.Empty
                    };

                    // Run database operation on background thread
                    bool result = await Task.Run(() => tripRepository.Add(trip));

                    if (result)
                    {
                        MessageBox.Show("Trip added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();
                        GenerateNewTripId(); // Generate new ID for next entry
                    }
                    else
                    {
                        MessageBox.Show("Failed to add trip.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void GenerateNewTripId()
        {
            try
            {
                if (txtTripId == null) return;

                string newId = GenerateTripId();
                txtTripId.Text = newId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating Trip ID: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateTripId()
        {
            // Generate ID format: TR-YYYYMMDD-XXXX
            // Where XXXX is a sequential number for the day
            try
            {
                string dateStr = DateTime.Now.ToString("yyyyMMdd");
                string prefix = $"TR-{dateStr}-";

                if (tripRepository != null)
                {
                    var existingTrips = tripRepository.GetAll();
                    if (existingTrips != null)
                    {
                        var todayTrips = existingTrips.Where(t => t?.TripID?.StartsWith(prefix) == true).ToList();
                        int nextNumber = todayTrips.Count + 1;
                        return $"{prefix}{nextNumber:D4}";
                    }
                }

                // Fallback method if repository fails or is null
                return $"TR-{DateTime.Now:yyyyMMddHHmmss}";
            }
            catch
            {
                // Fallback method if any error occurs
                return $"TR-{DateTime.Now:yyyyMMddHHmmss}";
            }
        }

        private async void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (isLoading) return;

            try
            {
                isLoading = true;
                btnUpdate.Enabled = false; // Prevent multiple clicks

                if (tripRepository == null)
                {
                    MessageBox.Show("Trip repository is not initialized.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(txtTripId?.Text))
                {
                    MessageBox.Show("Please select a trip to update.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ValidateInput())
                {
                    var trip = new Trip
                    {
                        TripId = txtTripId?.Text ?? string.Empty,
                        VehicleId = cmbVehicle?.SelectedValue?.ToString() ?? string.Empty,
                        DriverId = cmbDriver?.SelectedValue?.ToString() ?? string.Empty,
                        RouteId = cmbRoute?.SelectedValue?.ToString() ?? string.Empty,
                        DepatureTime = dtpDepatureTime?.Value ?? DateTime.Now,
                        Status = cmbStatus?.SelectedValue?.ToString() ?? string.Empty
                    };

                    // Run database operation on background thread
                    bool result = await Task.Run(() => tripRepository.Update(trip));

                    if (result)
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
            if (isLoading) return;

            try
            {
                if (tripRepository == null)
                {
                    MessageBox.Show("Trip repository is not initialized.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(txtTripId?.Text))
                {
                    MessageBox.Show("Please select a trip to delete.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Are you sure you want to delete this trip?", "Confirm Delete",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    isLoading = true;
                    btnDelete.Enabled = false; // Prevent multiple clicks

                    // Run database operation on background thread
                    await Task.Run(() => tripRepository.Delete(txtTripId.Text));

                    MessageBox.Show("Trip deleted successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
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

                if (tripRepository == null || dgvTrips == null)
                {
                    MessageBox.Show("Form components are not properly initialized.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtSearch?.Text))
                {
                    LoadData();
                }
                else
                {
                    // Run database operation on background thread
                    var searchResults = await Task.Run(() => tripRepository.Search(txtSearch.Text.Trim()));

                    if (searchResults != null)
                    {
                        var searchData = searchResults.Select(t => new
                        {
                            TripId = t?.TripId ?? string.Empty,
                            VehicleId = t?.VehicleId ?? string.Empty,
                            DriverId = t?.DriverId ?? string.Empty,
                            RouteId = t?.RouteId ?? string.Empty,
                            DepatureTime = t?.DepatureTime ?? DateTime.MinValue,
                            Status = t?.Status ?? string.Empty,
                            VehicleName = t?.Vehicle?.Type ?? "N/A",
                            DriverName = t?.Driver?.Name ?? "N/A",
                            RouteName = t?.Route?.RouteID ?? "N/A"
                        }).ToList();

                        // Update UI on main thread
                        if (InvokeRequired)
                        {
                            Invoke(new Action(() => dgvTrips.DataSource = searchData));
                        }
                        else
                        {
                            dgvTrips.DataSource = searchData;
                        }
                    }
                    else
                    {
                        dgvTrips.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                isLoading = false;
            }
        }

        private void DgvTrips_SelectionChanged(object sender, EventArgs e)
        {
            if (isLoading) return; // Skip during loading operations

            try
            {
                if (dgvTrips?.SelectedRows?.Count > 0)
                {
                    var row = dgvTrips.SelectedRows[0];

                    // Safely get cell values with null checks
                    if (txtTripId != null)
                        txtTripId.Text = row.Cells["TripId"]?.Value?.ToString() ?? string.Empty;

                    if (cmbStatus != null)
                        cmbStatus.SelectedValue = row.Cells["Status"]?.Value?.ToString() ?? string.Empty;

                    if (dtpDepatureTime != null &&
                        DateTime.TryParse(row.Cells["DepartureTime"]?.Value?.ToString(), out DateTime departureTime))
                    {
                        dtpDepatureTime.Value = departureTime;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Selection error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (cmbVehicle?.SelectedValue == null || string.IsNullOrEmpty(cmbVehicle.SelectedValue.ToString()))
            {
                MessageBox.Show("Please select a vehicle.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbVehicle?.Focus();
                return false;
            }

            if (cmbDriver?.SelectedValue == null || string.IsNullOrEmpty(cmbDriver.SelectedValue.ToString()))
            {
                MessageBox.Show("Please select a driver.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDriver?.Focus();
                return false;
            }

            if (cmbRoute?.SelectedValue == null || string.IsNullOrEmpty(cmbRoute.SelectedValue.ToString()))
            {
                MessageBox.Show("Please select a route.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRoute?.Focus();
                return false;
            }

            if (cmbStatus?.SelectedValue == null || string.IsNullOrEmpty(cmbStatus.SelectedValue.ToString()))
            {
                MessageBox.Show("Please select a status.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus?.Focus();
                return false;
            }

            // Validate departure time for scheduled trips
            if (cmbStatus?.SelectedValue?.ToString() == "Scheduled" &&
                dtpDepatureTime != null && dtpDepatureTime.Value <= DateTime.Now)
            {
                MessageBox.Show("Scheduled trips must have a future departure time.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDepatureTime.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm(bool clearTripId = true)
        {
            try
            {
                if (clearTripId && txtTripId != null)
                    txtTripId.Clear();

                if (cmbVehicle != null)
                    cmbVehicle.SelectedIndex = 0;

                if (cmbDriver != null)
                    cmbDriver.SelectedIndex = 0;

                if (cmbRoute != null)
                    cmbRoute.SelectedIndex = 0;

                if (cmbStatus != null)
                    cmbStatus.SelectedIndex = 1; // Default to "Scheduled"

                if (dtpDepatureTime != null)
                    dtpDepatureTime.Value = DateTime.Now.AddHours(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtTripId_TextChanged(object sender, EventArgs e)
        {
            // Empty implementation - kept for compatibility
        }
       
    }
}