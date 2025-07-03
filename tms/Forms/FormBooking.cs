
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
            _loadFormCallback = loadFormCallback;

            InitializeRepositories();
            InitializeFormComponents();
        }

        private void InitializeRepositories()
        {
            try
            {
                _bookingRepository = new BookingRepository();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing booking repository: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _bookingRepository = null;
            }
        }

        private void InitializeFormComponents()
        {
            try
            {
                LoadTrips();
                WireGenderEvents();
                LoadBooking();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing form components: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private bool ValidateBookingInput()
        {
            if (string.IsNullOrWhiteSpace(txtBox_Passenger.Text))
            {
                MessageBox.Show("Please enter passenger contact.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBox_Passenger.Focus();
                return false;
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
                    BookingID = 1,
                    BookingDate = DateTime.Now,
                    SeatNumber = 0,
                    Status = "Pending",
                    PassengerContact = txtBox_Passenger.Text.Trim(),
                    Gender = gender,
                    StaffID = "S001",
                    TripID = comboBoxTrip.SelectedValue.ToString()
                };

                var newBookingId = _bookingRepository.Add(book);

                MessageBox.Show("Booking added successfully!");
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
                selectedBooking.TripID = comboBoxTrip.SelectedValue.ToString();
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
