using Booking_info.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            LoadBooking();
            WireGenderEvents(); 
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
        }


   
        private void ClearForm()
        {
            txtBox_Passenger.Clear();
            dgv_Trip.ClearSelection();
            comboBoxTrip.SelectedItem = null;
        }


    }
}
