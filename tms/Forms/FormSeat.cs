using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Staff_info.Data;
using Seat_info.Model;


namespace tms.Forms
{
    public partial class FormSeat : Form
    {
        private AppDbContext? _context;
        private int selectedSeatId = -1;
        [Obsolete]
        public FormSeat()
        {
            InitializeComponent();
            LoadVehicles();
            LoadSeats();
            addOptionToSeatTypeComboBox();
            addOptionToSeatStatusComboBox();
        }

        [Obsolete]
        private void LoadSeats()
        {
            using var context = new AppDbContext();
            var seats = (from s in context.Seats
                         join v in context.Vehicles on s.VehivleId equals v.VehicleId
                         select new
                         {
                             s.SeatId,
                             v.VehicleType,
                             v.PlateNumber,
                             s.VehivleId,
                             s.SeatNumber,
                             s.SeatType,
                             s.seatStatus
                         }).ToList();

            tableSeat.DataSource = seats;

            // Optionally hide columns if not needed
            // tableSeat.Columns["SeatId"].Visible = false;
            // tableSeat.Columns["VehivleId"].Visible = false;
        }

        [Obsolete]
        private void LoadVehicles()
        {
            using var context = new AppDbContext();
            var vehicles = context.Vehicles.ToList();
            vehicleId.DataSource = vehicles;
            vehicleId.DisplayMember = "VehicleType";
            vehicleId.ValueMember = "VehicleId";
            vehicleId.SelectedIndex = -1;
        }

        [Obsolete]
        private void addBtn_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            if (vehicleId.SelectedIndex == -1 || string.IsNullOrWhiteSpace(seatNumber.Text) || seatType.SelectedIndex == 0 || seatStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }

            // Fix for CS8605: Ensure SelectedValue is not null before unboxing  
            if (vehicleId.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid vehicle.");
                return;
            }

            var newSeat = new Seat
            {
                VehivleId = (int)vehicleId.SelectedValue,
                SeatNumber = seatNumber.Text.Trim(),
                SeatType = seatType.SelectedItem?.ToString(),
                seatStatus = seatStatus.SelectedItem?.ToString()
            };

            context.Seats.Add(newSeat);
            context.SaveChanges();

            LoadSeats();
            ClearForm();
            MessageBox.Show("Seat added successfully.");
        }

        [Obsolete]
        private void updateBtn_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            if (selectedSeatId == -1 || vehicleId.SelectedIndex == -1 || string.IsNullOrWhiteSpace(seatNumber.Text) || seatType.SelectedIndex == 0 || seatStatus.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a seat and fill all fields correctly.");
                return;
            }
            if (vehicleId.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid vehicle.");
                return;
            }
            var seatToUpdate = context.Seats.Find(selectedSeatId);
            if (seatToUpdate == null)
            {
                MessageBox.Show("Seat not found.");
                return;
            }

            // Update the seat properties with the new values from the form
            seatToUpdate.VehivleId = (int)vehicleId.SelectedValue;
            seatToUpdate.SeatNumber = seatNumber.Text.Trim();
            seatToUpdate.SeatType = seatType.SelectedItem?.ToString();
            seatToUpdate.seatStatus = seatStatus.SelectedItem?.ToString();

            context.Seats.Update(seatToUpdate);
            context.SaveChanges();

            LoadSeats();
            ClearForm();
            MessageBox.Show("Seat updated successfully.");
        }


        [Obsolete]
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using var context = new AppDbContext();
            if (selectedSeatId == -1)
            {
                MessageBox.Show("Please select a seat to delete.");
                return;
            }
            var seatToDelete = context.Seats.Find(selectedSeatId);

            if (seatToDelete == null)
            {
                MessageBox.Show("Seat not found.");
                return;
            }
            context.Seats.Remove(seatToDelete);
            context.SaveChanges();
            LoadSeats();
            ClearForm();
            MessageBox.Show("Seat deleted successfully.");
        }

        private void tableSeat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && tableSeat.Rows[e.RowIndex].DataBoundItem != null)
            {
                var row = tableSeat.Rows[e.RowIndex];
                // Get values from the row
                selectedSeatId = int.TryParse(row.Cells["SeatId"].Value?.ToString(), out var id) ? id : -1;
                seatId.Text = row.Cells["SeatId"].Value?.ToString() ?? "";
                seatNumber.Text = row.Cells["SeatNumber"].Value?.ToString() ?? "";

                // Set vehicle ComboBox by value
                if (row.Cells["VehivleId"].Value != null)
                {
                    int vehicleIdValue = Convert.ToInt32(row.Cells["VehivleId"].Value);
                    vehicleId.SelectedValue = vehicleIdValue;
                }
                else
                {
                    vehicleId.SelectedIndex = -1;
                }

                // Set seatType ComboBox by text
                var seatTypeValue = row.Cells["SeatType"].Value?.ToString();
                if (!string.IsNullOrEmpty(seatTypeValue))
                {
                    int idx = seatType.Items.IndexOf(seatTypeValue);
                    seatType.SelectedIndex = idx >= 0 ? idx : 0;
                }
                else
                {
                    seatType.SelectedIndex = 0;
                }

                // Set seatStatus ComboBox by text
                var seatStatusValue = row.Cells["seatStatus"].Value?.ToString();
                if (!string.IsNullOrEmpty(seatStatusValue))
                {
                    int idx = seatStatus.Items.IndexOf(seatStatusValue);
                    seatStatus.SelectedIndex = idx >= 0 ? idx : 0;
                }
                else
                {
                    seatStatus.SelectedIndex = 0;
                }
            }
        }


        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit(); // or navigate back to login form
        }

        private void vehicleId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void seatId_TextChanged(object sender, EventArgs e)
        {
            seatId.ReadOnly = true;
        }

        private void seatNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void seatType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void seatStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        // Helper function :
        private void ClearForm()
        {
            vehicleId.SelectedIndex = -1; // Reset ComboBox
            seatNumber.Clear();          // Clear TextBox
            seatType.SelectedIndex = 0; // Reset ComboBox
            seatStatus.SelectedIndex = 0; // Reset ComboBox
            seatId.Clear();              // Optional: clear hidden ID field
        }

        private void addOptionToSeatTypeComboBox()
        {
            seatType.Items.Insert(0, "-- Select Seat Type --");
            seatType.Items.Add("Regular");
            seatType.Items.Add("Economy");
            seatType.Items.Add("Business");
            seatType.Items.Add("First Class");
            seatType.Items.Add("VIP");
            seatType.Items.Add("Standard");
            seatType.Items.Add("Window");
            seatType.Items.Add("Middle");
            seatType.Items.Add("Aisle");
            seatType.Items.Add("Extra Legroom");
            seatType.Items.Add("Recliner");
            seatType.Items.Add("Child Seat");
            seatType.Items.Add("Pet Friendly");
            seatType.SelectedIndex = 0; // No selection by default
        }

        private void addOptionToSeatStatusComboBox()
        {
            seatStatus.Items.Insert(0, "-- Select Seat Status --");
            seatStatus.Items.Add("Available");
            seatStatus.Items.Add("Reserved");
            seatStatus.Items.Add("Occupied");
            seatStatus.Items.Add("Maintenance");
            seatStatus.Items.Add("Unavailable");
            seatStatus.Items.Add("Booked");
            seatStatus.SelectedIndex = 0; // No selection by default
        }
    }
}
