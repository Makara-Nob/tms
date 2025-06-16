using Staff_info.Repository;
using System.Data;
using tms.Model;
using tms.Repository;

namespace tms.Forms
{
    public partial class FormTrip : Form
    {
        private TripRepository tripRepository;
        private VehicleRepository vehicleRepository; // Assuming you have these
        private StaffRepository driverRepository;   // Assuming you have these
        private RouteRepository routeRepository;



        public FormTrip()
        {
            tripRepository = new TripRepository();
            vehicleRepository = new VehicleRepository();
            driverRepository = new StaffRepository();
            routeRepository = new RouteRepository();

            InitializeFormComponents(); // Now safe!
        }

        private void InitializeFormComponents()
        {
            this.Text = "Trip Management";
            this.Size = new System.Drawing.Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            SetupLayout();                  // All controls are created here
            InitializeStatusComboBox();     // cmbStatus is ready
            LoadComboBoxes();               // cmbDriver, cmbRoute, cmbVehicle are ready
            LoadData();                     // dgvTrips is ready
            AttachEventHandlers();          // Button/Combo events hook up
        }



        private void SetupLayout()
        {
            // ========== MAIN PANEL ==========
            var mainPanel = new TableLayoutPanel
            {
                RowCount = 3,
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                AutoSize = true,
            };

            // ========== GROUP: Trip Details ==========
            var grpTripDetails = new GroupBox
            {
                Text = "Trip Details",
                Dock = DockStyle.Top,
                AutoSize = true,
                Padding = new Padding(10),
            };

            var inputPanel = new TableLayoutPanel
            {
                ColumnCount = 4,
                RowCount = 4,
                Dock = DockStyle.Top,
                AutoSize = true,
            };

            for (int i = 0; i < 4; i++)
                inputPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25));

            // === Labels and Inputs ===
            lblTripId = new Label { Text = "Trip ID:", AutoSize = true };
            txtTripId = new TextBox { Width = 200, ReadOnly = true };

            lblVehicle = new Label { Text = "Vehicle:", AutoSize = true };
            cmbVehicle = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 200 };

            lblDriver = new Label { Text = "Driver:", AutoSize = true };
            cmbDriver = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 200 };

            lblRoute = new Label { Text = "Route:", AutoSize = true };
            cmbRoute = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 200 };

            cmbStatus = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 200 };
            dtpDepatureTime = new DateTimePicker { Width = 200 };

            btnAdd = new Button { Text = "Add", Width = 100 };
            btnUpdate = new Button { Text = "Update", Width = 100 };
            btnDelete = new Button { Text = "Delete", Width = 100 };
            btnClear = new Button { Text = "Clear", Width = 100 };

            // === Add controls to table layout ===
            inputPanel.Controls.Add(lblTripId, 0, 0);
            inputPanel.Controls.Add(txtTripId, 1, 0);
            inputPanel.Controls.Add(lblVehicle, 2, 0);
            inputPanel.Controls.Add(cmbVehicle, 3, 0);

            inputPanel.Controls.Add(lblDriver, 0, 1);
            inputPanel.Controls.Add(cmbDriver, 1, 1);
            inputPanel.Controls.Add(lblRoute, 2, 1);
            inputPanel.Controls.Add(cmbRoute, 3, 1);

            inputPanel.Controls.Add(new Label { Text = "Status:", AutoSize = true }, 0, 2);
            inputPanel.Controls.Add(cmbStatus, 1, 2);
            inputPanel.Controls.Add(new Label { Text = "Departure Time:", AutoSize = true }, 2, 2);
            inputPanel.Controls.Add(dtpDepatureTime, 3, 2);

            inputPanel.Controls.Add(btnAdd, 0, 3);
            inputPanel.Controls.Add(btnUpdate, 1, 3);
            inputPanel.Controls.Add(btnDelete, 2, 3);
            inputPanel.Controls.Add(btnClear, 3, 3);

            grpTripDetails.Controls.Add(inputPanel);

            // ========== GROUP: Search ==========
            var grpSearch = new GroupBox
            {
                Text = "Search",
                Dock = DockStyle.Top,
                AutoSize = true,
                Padding = new Padding(10),
            };

            var searchPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true
            };

            txtSearch = new TextBox { Width = 300 };
            btnSearch = new Button { Text = "Search", Width = 100 };

            searchPanel.Controls.Add(txtSearch);
            searchPanel.Controls.Add(btnSearch);
            grpSearch.Controls.Add(searchPanel);

            // ========== GROUP: Trip List ==========
            var grpTrips = new GroupBox
            {
                Text = "Trip List",
                Dock = DockStyle.Fill,
                Padding = new Padding(10)
            };

            dgvTrips = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            grpTrips.Controls.Add(dgvTrips);

            // ========== Add Groups to Main Panel ==========
            mainPanel.Controls.Add(grpTripDetails);
            mainPanel.Controls.Add(grpSearch);
            mainPanel.Controls.Add(grpTrips);

            this.Controls.Add(mainPanel);
        }



        // Recursive method to get all controls inside a container (including nested ones)
        public IEnumerable<Control> GetAllControls(Control parent)
{
    foreach (Control c in parent.Controls)
    {
        yield return c;
        foreach (var child in GetAllControls(c))
            yield return child;
    }
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


            // Enter key search
            txtSearch.KeyPress += (s, e) =>
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    BtnSearch_Click(s, e);
                }
            };
        }

        private void LoadComboBoxes()
        {
            try
            {
                // Get data from repositories
                var vehicles = vehicleRepository.GetAll().ToList();
                var drivers = driverRepository.GetDriverStaff().ToList();
                drivers.Insert(0, new Staff { StaffId = "", Name = "-- Select Driver --" });

                cmbDriver.DisplayMember = "Name";
                cmbDriver.ValueMember = "StaffId";
                cmbDriver.DataSource = drivers;

                var routes = routeRepository.GetAll().ToList();

                // Insert placeholder for Vehicle
                vehicles.Insert(0, new Vehicle
                {
                    VehicleID = "", // Use 0 or -1 if VehicleID is int
                    Type = "-- Select Vehicle --"
                });
                cmbVehicle.DisplayMember = "Type";
                cmbVehicle.ValueMember = "VehicleID";
                cmbVehicle.DataSource = vehicles;


                // Insert placeholder for Route
                routes.Insert(0, new Route { RouteID = "", StartPoint = "-- Select Route --" });
                cmbRoute.DisplayMember = "StartPoint"; // Or custom property like Display                                                       // You may also want to use a custom property like Display if needed
                cmbRoute.ValueMember = "RouteID";
                cmbRoute.DataSource = routes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading combo boxes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            cmbStatus.SelectedIndex = 1; // Default to "Scheduled"
        }

        private void CmbTripStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Auto-set departure time based on status
            if (cmbStatus.SelectedValue != null)
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
        private void LoadData()
        {
            try
            {
                var trips = tripRepository.GetAll();
                var tripData = trips.Select(t => new
                {
                    TripId = t.TripId,
                    VehicleId = t.VehicleId,
                    DriverId = t.DriverId,
                    RouteId = t.RouteId,
                    DepartureTime = t.DepatureTime,
                    Status = t.Status,
                    VehicleName = t.Vehicle?.Type ?? "N/A",
                    DriverName = t.Driver?.Name ?? "N/A",
                    RouteName = $"{t.Route?.StartPoint} → {t.Route?.EndPoint}" ?? "N/A"
                }).OrderByDescending(t => t.DepartureTime).ToList();

                dgvTrips.DataSource = tripData;


                // Format columns
                if (dgvTrips.Columns["DepartureTime"] != null)
                {
                    dgvTrips.Columns["DepartureTime"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm tt";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    var trip = new Trip
                    {
                        TripId = txtTripId.Text,
                        VehicleId = (string)cmbVehicle.SelectedValue,
                        DriverId = (string)cmbDriver.SelectedValue,
                        RouteId = (string)cmbRoute.SelectedValue,
                        DepatureTime = dtpDepatureTime.Value,
                        Status = (string)cmbStatus.SelectedValue
                    };

                    if (tripRepository.Add(trip))
                    {
                        MessageBox.Show("Trip added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();
                        GenerateNewTripId(); // Generate new ID for next entry
                    }
                    else
                    {
                        MessageBox.Show("Failed to add trip.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding trip: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenerateNewTripId()
        {
            try
            {
                string newId = GenerateTripId();
                txtTripId.Text = newId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating Trip ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                var existingTrips = tripRepository.GetAll();
                var todayTrips = existingTrips.Where(t => t.TripId.StartsWith(prefix)).ToList();

                int nextNumber = todayTrips.Count + 1;
                return $"{prefix}{nextNumber:D4}";
            }
            catch
            {
                // Fallback method if repository fails
                return $"TR-{DateTime.Now:yyyyMMddHHmmss}";
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTripId.Text))
                {
                    MessageBox.Show("Please select a trip to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (ValidateInput())
                {
                    var trip = new Trip
                    {
                        TripId = txtTripId.Text,
                        VehicleId = (string)cmbVehicle.SelectedValue,
                        DriverId = (string)cmbDriver.SelectedValue,
                        RouteId = (string)cmbRoute.SelectedValue,
                        DepatureTime = dtpDepatureTime.Value,
                        Status = (string)cmbStatus.SelectedValue
                    };

                    if (tripRepository.Update(trip))
                    {
                        MessageBox.Show("Trip updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update trip.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating trip: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTripId.Text))
                {
                    MessageBox.Show("Please select a trip to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var result = MessageBox.Show("Are you sure you want to delete this trip?", "Confirm Delete",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    tripRepository.Delete(int.Parse(txtTripId.Text));
                    MessageBox.Show("Trip deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting trip: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    LoadData();
                }
                else
                {
                    var searchResults = tripRepository.Search(txtSearch.Text.Trim());
                    dgvTrips.DataSource = searchResults.Select(t => new
                    {
                        TripId = t.TripId,
                        VehicleId = t.VehicleId,
                        DriverId = t.DriverId,
                        RouteId = t.RouteId,
                        DepatureTime = t.DepatureTime,
                        Status = t.Status,
                        VehicleName = t.Vehicle?.Type ?? "N/A",
                        DriverName = t.Driver?.Name ?? "N/A",
                        RouteName = t.Route?.RouteID ?? "N/A"
                    }).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DgvTrips_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvTrips.SelectedRows.Count > 0)
                {
                    var row = dgvTrips.SelectedRows[0];
                    var tripId = row.Cells["TripID"].Value?.ToString();
                    MessageBox.Show("Row selected. Trip ID: " + tripId);

                    txtTripId.Text = row.Cells["TripId"].Value?.ToString();

                    cmbVehicle.SelectedValue = row.Cells["VehicleId"].Value;
                    cmbDriver.SelectedValue = row.Cells["DriverId"].Value;
                    cmbRoute.SelectedValue = row.Cells["RouteId"].Value;
                    cmbStatus.SelectedValue = row.Cells["Status"].Value?.ToString();

                    if (DateTime.TryParse(row.Cells["DepartureTime"].Value?.ToString(), out DateTime departureTime))
                    {
                        dtpDepatureTime.Value = departureTime;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Selection error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool ValidateInput()
        {
            
            if (cmbVehicle.SelectedValue == null || cmbVehicle.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Please select a vehicle.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbVehicle.Focus();
                return false;
            }

            if (cmbDriver.SelectedValue == null || cmbDriver.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Please select a driver.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDriver.Focus();
                return false;
            }

            if (cmbRoute.SelectedValue == null || cmbRoute.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Please select a route.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRoute.Focus();
                return false;
            }

            if (cmbStatus.SelectedValue == null || cmbStatus.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Please select a status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return false;
            }

            // Validate departure time for scheduled trips
            if (cmbStatus.SelectedValue.ToString() == "Scheduled" && dtpDepatureTime.Value <= DateTime.Now)
            {
                MessageBox.Show("Scheduled trips must have a future departure time.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDepatureTime.Focus();
                return false;
            }

            return true;
        }

        private void ClearForm(bool clearTripId = true)
        {
            if (clearTripId)
                txtTripId.Clear();
            cmbVehicle.SelectedIndex = 0;
            cmbDriver.SelectedIndex = 0;
            cmbRoute.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 1; // Default to "Scheduled"
            dtpDepatureTime.Value = DateTime.Now.AddHours(1);
        }


        private void txtTripId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
