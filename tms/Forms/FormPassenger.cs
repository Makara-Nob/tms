using Passenger_info.Model;
using System.ComponentModel;
using System.Data;
using tms.Repository;

namespace tms.Forms
{
    public partial class FormPassenger : Form
    {
        private readonly PassengerRepository _repository = new PassengerRepository();
        private BindingList<Passenger> _passengerList = new BindingList<Passenger>();
        private static HashSet<string> existingPassengerIds = new HashSet<string>();

        // Store current PassengerID when editing
        private string currentPassengerID = null;

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
            currentPassengerID = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var passenger = new Passenger
            {
                // Use existing PassengerID if editing, otherwise generate new
                PassengerID = currentPassengerID ?? GeneratePassengerID(),
                PassengerName = txtPassengerName.Text.Trim(),
                Gender = cbGender.Text.Trim(),
                PersonalNumber = txtPersonal.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                IsActive = cbInactive.Checked ? 0 : 1 // Assuming 0 = inactive, 1 = active
            };

            if (string.IsNullOrWhiteSpace(passenger.PassengerName) || string.IsNullOrWhiteSpace(passenger.Gender))
            {
                MessageBox.Show("Name and Gender are required.");
                return;
            }

            try
            {
                if (currentPassengerID == null)
                    _repository.AddPassenger(passenger);
                else
                    _repository.UpdatePassenger(passenger);

                BindData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving passenger: {ex.Message}");
            }
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

                    if (!selectedRow.IsNewRow)
                    {
                        currentPassengerID = selectedRow.Cells["PassengerID"].Value?.ToString();
                        txtPassengerID.Text = currentPassengerID;
                        txtPassengerName.Text = selectedRow.Cells["PassengerName"].Value?.ToString() ?? "";
                        cbGender.Text = selectedRow.Cells["Gender"].Value?.ToString() ?? "";
                        txtPersonal.Text = selectedRow.Cells["PersonalNumber"].Value?.ToString() ?? "";
                        txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString() ?? "";

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

        private string GeneratePassengerID()
        {
            string passengerId;

            do
            {
                passengerId = "PS:" + Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
            } while (existingPassengerIds.Contains(passengerId));

            existingPassengerIds.Add(passengerId);
            return passengerId;
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
                // Get PassengerID as string
                var id = dataGridView1.CurrentRow.Cells["PassengerID"].Value?.ToString();
                if (!string.IsNullOrEmpty(id))
                {
                    try
                    {
                        _repository.DeletePassenger(id);
                        BindData();
                        ClearForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting passenger: {ex.Message}");
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindData();
        }
    }
}
