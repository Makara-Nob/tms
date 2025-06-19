using tms.Model;
using tms.Repository;

namespace tms.Forms
{
    public partial class FormBooking : Form
    {
        private BookingRepository _bookingRepository;
        private List<Booking> allBookings;
        public FormBooking()
        {
            InitializeComponent();
            _bookingRepository = new BookingRepository();
            LoadBooking();
            WireGenderEvents();
            LoadBooking();
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
            btnSelectSeat.Click += BtnSelectSeat_Click;
            txtBookingSearch.TextChanged += TxtSearch_TextChanged;

        }

        private void LoadTrips()
        {
            var tripRepo = new TripRepository();
            comboBoxTrip.DataSource = tripRepo.GetAll();
            comboBoxTrip.DisplayMember = "TripName"; // change based on your model
            comboBoxTrip.ValueMember = "TripID";
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
                selectedBooking.TripID = (int)comboBoxTrip.SelectedValue;
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
            MessageBox.Show("Seat selection functionality goes here.");
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
