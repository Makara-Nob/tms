using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Passenger_info.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tms.Repository;

namespace tms.Forms
{
    public partial class FormPassenger : Form
    {
        private readonly PassengerRepository _repository = new PassengerRepository();
        private BindingList<Passenger> _passengerList = new BindingList<Passenger>();

        public FormPassenger()
        {
            InitializeComponent();
        }

        private void FormPassenger_Load(object sender, EventArgs e)
        {
            BindData();
            cbGender.Items.AddRange(new string[] { "Male", "Female", "Other" });
        }

        private void BindData()
        {
            var passengers = _repository.GetAllPassengers();
            _passengerList = new BindingList<Passenger>(passengers);
            dataGridView1.DataSource = _passengerList;
        }
        private void ClearForm()
        {
            txtPassengerID.Clear();
            txtPassengerName.Clear();
            cbGender.SelectedIndex = -1;
            txtPersonal.Clear();
            txtEmail.Clear();
            cbInactive.Checked = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int.TryParse(txtPassengerID.Text, out int id);
            var passenger = new Passenger
            {
                PassengerID = id,
                PassengerName = txtPassengerName.Text.Trim(),
                Gender = cbGender.Text.Trim(),
                PersonalNumber = txtPersonal.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                IsActive = cbInactive.Checked ? 1 : 0
            };

            if (string.IsNullOrWhiteSpace(passenger.PassengerName) || string.IsNullOrWhiteSpace(passenger.Gender))
            {
                MessageBox.Show("Name and Gender are required.");
                return;
            }

            if (id == 0)
                _repository.AddPassenger(passenger);
            else
                _repository.UpdatePassenger(passenger);

            BindData();
            ClearForm();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0) // Ensure it's not a header row
                {
                    DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];

                    // Check if the row has data (not a new row)
                    if (!selectedRow.IsNewRow)
                    {
                        txtPassengerID.Text = selectedRow.Cells["PassengerID"].Value?.ToString() ?? "";
                        txtPassengerName.Text = selectedRow.Cells["PassengerName"].Value?.ToString() ?? "";
                        cbGender.Text = selectedRow.Cells["Gender"].Value?.ToString() ?? "";
                        txtPersonal.Text = selectedRow.Cells["PersonalNumber"].Value?.ToString() ?? "";
                        txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString() ?? "";

                        // Handle the IsActive/Inactive checkbox (adjust based on your actual data)
                        if (selectedRow.Cells["IsActive"].Value != null)
                        {
                            cbInactive.Checked = Convert.ToInt32(selectedRow.Cells["IsActive"].Value) == 0;
                        }
                        else
                        {
                            cbInactive.Checked = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading passenger data: {ex.Message}");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var keyword = txtSearch.Text.ToLower();
            var filtered = _passengerList
                .Where(p => p.PassengerName.ToLower().Contains(keyword) || p.Email.ToLower().Contains(keyword))
                .ToList();

            dataGridView1.DataSource = new BindingList<Passenger>(filtered);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PassengerID"].Value);
                _repository.DeletePassenger(id);
                BindData();
                ClearForm();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
