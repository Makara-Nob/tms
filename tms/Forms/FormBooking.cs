using System.Windows.Forms;
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
            LoadBooking();
            LoadTrips();
            WireGenderEvents();
            LoadBooking();
            _loadFormCallback = loadFormCallback;   
        }

        private void LoadBooking()
        {
            try
            {
                allBookings = _bookingRepository.GetAll();
                dtgv_booking.DataSource = allBookings;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}");
            }
        }

     


        private void WireGenderEvents()
        {
            chkMale.CheckedChanged += (s, e) =>
            {
                if (chkMale.Checked)
                    chkFemale.Checked = false;
            };

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

        }

        private void OpenSeatSelect(object sender, EventArgs e)
        {
            _loadFormCallback?.Invoke(new FormSeatPicking());
        }

        private void LoadTrips()
        {
            var tripRepo = new TripRepository();
            comboBoxTrip.DataSource = tripRepo.GetAll();
            comboBoxTrip.DisplayMember = "RouteName"; 
            comboBoxTrip.ValueMember = "TripID";
        }

        private void BtnAddBooking_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields here, for example:
                if (string.IsNullOrWhiteSpace(txtBox_Passenger.Text))
                {
                    MessageBox.Show("Please enter passenger contact.");
                    return;
                }

                if (comboBoxTrip.SelectedValue == null)
                {
                    MessageBox.Show("Please select a trip.");
                    return;
                }

                string gender = chkMale.Checked ? "Male" : (chkFemale.Checked ? "Female" : null);

                var book = new Booking
                {
                    BookingID = 1,  // This will be set by SP output
                    BookingDate = DateTime.Now,  // or from a date picker
                    SeatNumber = 0,  // initially 0 or null until seat is picked
                    Status = "Pending",  // or any default status
                    PassengerContact = txtBox_Passenger.Text.Trim(),
                    Gender = gender,
                    StaffID = "S001",  // or current logged-in staff
                    TripID = comboBoxTrip.SelectedValue.ToString()
                };

                var newBookingId = _bookingRepository.Add(book);

                MessageBox.Show($"Booking added successfully!");

                LoadBooking();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding booking: " + ex.Message);
            }
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
                selectedBooking.SeatNumber = 1; 
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
        private void BtnSelectSeat_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected booking to determine vehicle/trip
                var selectedBooking = GetSelectedBooking();
                if (selectedBooking == null)
                {
                    MessageBox.Show("Please select a booking first.", "No Booking Selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string vehicleId = selectedBooking.TripID.ToString();

                // Get already occupied seats for this trip
                var occupiedSeats = GetOccupiedSeatsForTrip(vehicleId);

                // Show seat picker dialog
                var seatResult = FormSeatPicking.ShowSeatPicker(vehicleId, occupiedSeats);

                if (seatResult.Success && seatResult.SelectedSeats.Any())
                {
                    // Update the booking with selected seat information
                    var firstSeat = seatResult.SelectedSeats.First();
                    selectedBooking.SeatNumber = int.Parse(firstSeat.SeatNumber.Substring(0, 2)); // Extract row number

                    // Update the booking in database
                    _bookingRepository.Update(selectedBooking);
                    LoadBooking();

                    // Show confirmation
                    string message = $"Selected seats: {string.Join(", ", seatResult.SelectedSeats.Select(s => s.SeatNumber))}\n" +
                                   $"Vehicle: {seatResult.VehicleId}";
                    MessageBox.Show(message, "Seats Selected Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening seat selection: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> GetOccupiedSeatsForTrip(string vehicleId)
        {
            try
            {
                var occupiedSeats = new List<string>();
                var bookingsForTrip = _bookingRepository.GetAll()
                    .Where(b => b.TripID.ToString() == vehicleId && b.Status != "Cancelled")
                    .ToList();

                // Convert seat numbers back to seat format
                foreach (var booking in bookingsForTrip)
                {
                    if (booking.SeatNumber > 0)
                    {
                        // Adjust this conversion based on your seat numbering system
                        string seatNumber = $"{booking.SeatNumber:D2}A";
                        occupiedSeats.Add(seatNumber);
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

    }
}
