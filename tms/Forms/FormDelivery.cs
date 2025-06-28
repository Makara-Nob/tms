using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Delivery_info.Repository;
using tms.Data;
using tms.Models;

namespace tms.Forms
{
    public partial class FormDelivery : Form
    {
        private readonly DeliveryRepository _deliveryRepository;
        private List<DeliveryViewModel> _unassignedDeliveries;
        private List<DeliveryViewModel> _assignedDeliveries;
        private DeliveryViewModel _selectedDelivery;

        public FormDelivery()
        {
            InitializeComponent();

            // Initialize repository (it will create its own DbContext)
            _deliveryRepository = new DeliveryRepository();

            InitializeForm();
            LoadData();
        }

        private void InitializeForm()
        {
            // Setup delivery status combo box
            Delivery_Status.Items.AddRange(new string[]
            {
                "Pending",
                "In Transit",
                "Delivered",
                "Cancelled",
                "Returned"
            });

            // Setup trip combo box - assuming you have trips in your database
            // You can modify this to load from your Trips table
            Delivery_Trip.Items.AddRange(new string[]
            {
                "Trip 1",
                "Trip 2",
                "Trip 3",
                "Trip 4",
                "Trip 5"
            });

            // You could also load trips dynamically from your database:
            // LoadTripsFromDatabase();

            // Setup event handlers
            this.FormClosed += FormDelivery_FormClosed;
        }

        private void LoadTripsFromDatabase()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var trips = context.Trips.Select(t => t.TripId.ToString()).ToList();
                    Delivery_Trip.Items.Clear();
                    Delivery_Trip.Items.AddRange(trips.ToArray());
                }
            }
            catch (Exception ex)
            {
                // If trips can't be loaded, use default values
                Console.WriteLine($"Could not load trips: {ex.Message}");
            }
        }

        private void LoadData()
        {
            try
            {
                // Load unassigned deliveries (top grid)
                _unassignedDeliveries = _deliveryRepository.GetUnassignedDeliveries();
                Order_Table.DataSource = _unassignedDeliveries;

                // Load assigned deliveries (bottom grid)
                _assignedDeliveries = _deliveryRepository.GetAssignedDeliveries();
                Delivery_Table.DataSource = _assignedDeliveries;

                FormatDataGridViews();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatDataGridViews()
        {
            FormatGrid(Order_Table);
            FormatGrid(Delivery_Table);
        }

        private void FormatGrid(DataGridView grid)
        {
            if (grid.Columns.Count > 0)
            {
                // Set column headers
                SetColumnHeader(grid, "DeliveryId", "Delivery ID");
                SetColumnHeader(grid, "OrderId", "Order ID");
                SetColumnHeader(grid, "OrderType", "Order Type");
                SetColumnHeader(grid, "OrderDate", "Order Date");
                SetColumnHeader(grid, "DeliveryStatus", "Status");
                SetColumnHeader(grid, "Sender", "Sender");
                SetColumnHeader(grid, "Reciever", "Receiver");

                // Format date column
                if (grid.Columns["OrderDate"] != null)
                {
                    grid.Columns["OrderDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                }

                // Hide unnecessary columns
                HideColumn(grid, "IsAssigned");
                HideColumn(grid, "TotalAmount");
                HideColumn(grid, "OrderID");
            }
        }

        private void SetColumnHeader(DataGridView grid, string columnName, string headerText)
        {
            if (grid.Columns[columnName] != null)
            {
                grid.Columns[columnName].HeaderText = headerText;
            }
        }

        private void HideColumn(DataGridView grid, string columnName)
        {
            if (grid.Columns[columnName] != null)
                grid.Columns[columnName].Visible = false;
        }

        private void Order_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleGridCellClick(Order_Table, e);
        }

        private void Delivery_Table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            HandleGridCellClick(Delivery_Table, e);
        }

        private void HandleGridCellClick(DataGridView grid, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < grid.Rows.Count)
            {
                var selectedRow = grid.Rows[e.RowIndex];
                _selectedDelivery = (DeliveryViewModel)selectedRow.DataBoundItem;
                PopulateFormFields(_selectedDelivery);
            }
        }

        private void PopulateFormFields(DeliveryViewModel delivery)
        {
            if (delivery != null)
            {
                Delivery_Id.Text = delivery.DeliveryId.ToString();
                Order_Id.Text = delivery.OrderId;
                Order_Type.Text = delivery.OrderType;
                Order_Date.Text = delivery.OrderDate.ToString("yyyy-MM-dd");

                // Set delivery status
                if (!string.IsNullOrEmpty(delivery.DeliveryStatus) &&
                    Delivery_Status.Items.Contains(delivery.DeliveryStatus))
                {
                    Delivery_Status.SelectedItem = delivery.DeliveryStatus;
                }
                else
                {
                    Delivery_Status.SelectedIndex = -1;
                }
            }
        }

        private void Update_Button_Click(object sender, EventArgs e)
        {
            if (_selectedDelivery == null)
            {
                MessageBox.Show("Please select a delivery to update.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(Delivery_Status.Text))
            {
                MessageBox.Show("Please select a delivery status.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool updateSuccess = _deliveryRepository.UpdateDeliveryStatus(
                    _selectedDelivery.DeliveryId.ToString(),
                    Delivery_Status.Text);

                if (updateSuccess)
                {
                    // If assigning a trip and order is unassigned, update assignment status
                    if (!string.IsNullOrEmpty(Delivery_Trip.Text) && _selectedDelivery.IsAssigned == 0)
                    {
                        _deliveryRepository.AssignTripToOrder(_selectedDelivery.OrderId);
                    }

                    MessageBox.Show("Delivery updated successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData(); // Refresh the data
                    ClearFormFields();
                }
                else
                {
                    MessageBox.Show("Failed to update delivery status.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating delivery: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            Delivery_Id.Clear();
            Order_Id.Clear();
            Order_Type.Clear();
            Order_Date.Clear();
            Delivery_Status.SelectedIndex = -1;
            Delivery_Trip.SelectedIndex = -1;
            _selectedDelivery = null;
        }

        private void FormDelivery_FormClosed(object sender, FormClosedEventArgs e)
        {
            _deliveryRepository?.Dispose();
        }

        // Implement search functionality if you have a search textbox
        private void Search_TextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox searchBox)
            {
                if (string.IsNullOrWhiteSpace(searchBox.Text))
                {
                    LoadData();
                }
                else
                {
                    try
                    {
                        var searchResults = _deliveryRepository.SearchDeliveries(searchBox.Text);

                        var unassignedResults = searchResults.Where(d => d.IsAssigned == 0).ToList();
                        var assignedResults = searchResults.Where(d => d.IsAssigned == 1).ToList();

                        Order_Table.DataSource = unassignedResults;
                        Delivery_Table.DataSource = assignedResults;

                        FormatDataGridViews();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error searching: {ex.Message}", "Search Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Other event handlers (keeping them empty as per your original code)
        private void Delivery_Id_TextChanged(object sender, EventArgs e) { }
        private void Order_Id_TextChanged(object sender, EventArgs e) { }
        private void Order_Type_TextChanged(object sender, EventArgs e) { }
        private void Order_Date_TextChanged(object sender, EventArgs e) { }
        private void Delivery_Status_SelectedIndexChanged(object sender, EventArgs e) { }
        private void Delivery_Trip_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}