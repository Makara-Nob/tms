using System;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;
using tms.Model;
using tms.Repository;

namespace tms.Forms
{
    public partial class FormBooking : Form
    {
        private readonly Action<Form> _loadFormCallback;
        private BookingRepository _bookingRepository;
        private List<Booking> allBookings;

        public FormBooking(Action<Form> loadFormCallback)
        {
            InitializeComponent();
            _bookingRepository = new BookingRepository();
            _loadFormCallback = loadFormCallback;
            LoadBooking();
            LoadTrips();
            WireGenderEvents();
        }

        private void LoadBooking()
        {
            try
            {
                allBookings = _bookingRepository?.GetAll() ?? new List<Booking>();
                dtgv_booking.DataSource = allBookings;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

        private void WireGenderEvents()
        {
            chkMale.CheckedChanged += (s, e) => { if (chkMale.Checked) chkFemale.Checked = false; };
            chkFemale.CheckedChanged += (s, e) => { if (chkFemale.Checked) chkMale.Checked = false; };

            chkFemale.CheckedChanged += (s, e) =>
            {
                if (chkFemale.Checked)
                    chkMale.Checked = false;
            };

            btnClear.Click += BtnClear_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnSelectSeat.Click += OpenSeatSelect;
            btnAdd.Click += BtnAddBooking_Click;
            txtBookingSearch.TextChanged += TxtSearch_TextChanged;
            btnNavigateToInvoice.Click += BtnNavigateToInvoice_Click;
        }

        private void BtnNavigateToInvoice_Click(object sender, EventArgs e)
        {
            _loadFormCallback?.Invoke(new InvoiceForm());
        }

        private void OpenSeatSelect(object sender, EventArgs e)
        {
            _loadFormCallback?.Invoke(new FormSeatPicking());
        }

        private async void LoadTrips()
        {
            try
            {
                var tripRepo = new TripRepository();
                var trips = await tripRepo.GetAllAsync();
                comboBoxTrip.DataSource = trips;
                comboBoxTrip.DisplayMember = "RouteName"; // Make sure Trip has a RouteName property
                comboBoxTrip.ValueMember = "TripID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading trips: {ex.Message}");
            }
        }

        private bool ValidateBookingInput()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBox_Passenger.Text))
                {
                    MessageBox.Show("Please enter passenger contact.");
                    return;
                }

            if (comboBoxTrip.SelectedValue == null)
            {
                MessageBox.Show("Please select a trip.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxTrip.Focus();
                return false;
            }

            return true;
        }

        private void BtnAddBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateBookingInput()) return;

                string gender = chkMale.Checked ? "Male" : (chkFemale.Checked ? "Female" : null);

                var book = new Booking
                {
                    BookingDate = DateTime.Now,
                    SeatNumber = "",
                    Status = "Pending",
                    PassengerContact = txtBox_Passenger.Text.Trim(),
                    Gender = gender,
                    StaffID = "S001",
                    TripID = comboBoxTrip.SelectedValue.ToString()
                };

                var newBookingId = _bookingRepository.Add(book);

                MessageBox.Show($"Booking added successfully with ID: {newBookingId}");
                LoadBooking();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding booking: " + ex.Message);
            }
        }

        private string GenerateBookingId()
        {
            return "BK-" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedBooking = GetSelectedBooking();
                if (selectedBooking == null)
                {
                    MessageBox.Show("Please select a booking to update.");
                    return;
                }

                selectedBooking.Status = "Updated";
                selectedBooking.StaffID = "S001";
                selectedBooking.TripID = (string)comboBoxTrip.SelectedValue;
                selectedBooking.SeatNumber = "01A";
                selectedBooking.BookingDate = DateTime.Now;

                _bookingRepository.Update(selectedBooking);
                LoadBooking();
                MessageBox.Show("Booking updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update failed: {ex.Message}");
            }
        }

        private async void BtnSelectSeat_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedBooking = GetSelectedBooking();
                if (selectedBooking == null)
                {
                    MessageBox.Show("Please select a booking first.", "No Booking Selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get the trip to get the vehicle ID
                var tripRepo = new TripRepository();
                var trip = await tripRepo.GetByIdAsync(selectedBooking.TripID);
                if (trip == null)
                {
                    MessageBox.Show("Associated trip not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get occupied seats for this trip
                var occupiedSeats = GetOccupiedSeatsForTrip(selectedBooking.TripID);

                // Show seat picker form as a dialog
                using (var seatForm = new FormSeatPicking(trip.VehicleID, occupiedSeats))
                {
                    var result = seatForm.ShowDialog();

                    if (result == DialogResult.OK && seatForm.SelectedSeats.Any())
                    {
                        // Update booking with selected seat
                        var firstSeat = seatForm.SelectedSeats.First();
                        selectedBooking.SeatNumber = firstSeat.SeatNumber;
                        selectedBooking.Status = "Confirmed";

                        // Update the booking in database
                        _bookingRepository.Update(selectedBooking);

                        // Refresh the grid
                        LoadBooking();

                        MessageBox.Show($"Seat {firstSeat.SeatNumber} selected successfully!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error selecting seat: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> GetOccupiedSeatsForTrip(string tripId)
        {
            try
            {
                var occupiedSeats = new List<string>();
                var bookingsForTrip = _bookingRepository.GetAll()
                    .Where(b => b.TripID == tripId && b.Status != "Cancelled")
                    .ToList();

                foreach (var booking in bookingsForTrip)
                {
                    if (!string.IsNullOrEmpty(booking.SeatNumber))
                    {
                        occupiedSeats.Add(booking.SeatNumber);
                    }
                }

                return occupiedSeats;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting occupied seats: {ex.Message}");
                return new List<string>();
            }
        }


        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtBookingSearch.Text.ToLower();
            var filtered = allBookings.Where(b => b.StaffID.ToLower().Contains(searchText)).ToList();
            dtgv_booking.DataSource = filtered;
        }

        private Booking? GetSelectedBooking()
        {
            if (dtgv_booking.CurrentRow?.DataBoundItem is Booking booking)
                return booking;
            return null;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtBox_Passenger.Clear();
            comboBoxTrip.SelectedItem = null;
            chkMale.Checked = false;
            chkFemale.Checked = false;
            txtBookingSearch.Clear();
        }

        private void dtgv_booking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}