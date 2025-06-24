using Seat_info.Model;
using System.Data;

namespace tms.Forms
{
    public partial class FormSeatPicking : Form
    {
        private List<Seat> seats;
        private Dictionary<int, Button> seatButtons;
        private List<Seat> selectedSeats;

        // Properties to return selected seat data
        public List<Seat> SelectedSeats { get; private set; }
        public bool SeatSelectionConfirmed { get; private set; }

        public FormSeatPicking(string vehicleId = null, List<string> occupiedSeats = null)
        {
            InitializeComponent();
            seats = new List<Seat>();
            seatButtons = new Dictionary<int, Button>();
            selectedSeats = new List<Seat>();
            SelectedSeats = new List<Seat>();
            SeatSelectionConfirmed = false;

            // Set vehicle ID if provided
            if (!string.IsNullOrEmpty(vehicleId))
            {
                SetVehicleId(vehicleId);
            }

            // Mark seats as occupied if provided
            if (occupiedSeats != null && occupiedSeats.Any())
            {
                MarkSeatsAsOccupied(occupiedSeats);
            }
        }

        private void SeatPickingForm_Load(object sender, EventArgs e)
        {
            vehicleComboBox.SelectedIndex = 0;
            seatTypeFilter.SelectedIndex = 0;
            CreateLegend();
            GenerateSeats();
        }

        private void CreateLegend()
        {
            var legendItems = new[]
            {
                new { Color = Color.LightGreen, Text = "Available", Pos = new Point(10, 25) },
                new { Color = Color.Yellow, Text = "Selected", Pos = new Point(100, 25) },
                new { Color = Color.Red, Text = "Occupied", Pos = new Point(190, 25) },
                new { Color = Color.Gray, Text = "Maintenance", Pos = new Point(280, 25) },
                new { Color = Color.Orange, Text = "Reserved", Pos = new Point(10, 55) }
            };

            foreach (var item in legendItems)
            {
                var colorBox = new Panel
                {
                    Size = new Size(20, 20),
                    Location = item.Pos,
                    BackColor = item.Color,
                    BorderStyle = BorderStyle.FixedSingle
                };

                var label = new Label
                {
                    Text = item.Text,
                    Location = new Point(item.Pos.X + 25, item.Pos.Y + 2),
                    Size = new Size(60, 16),
                    Font = new Font("Arial", 8)
                };

                legendGroup.Controls.AddRange(new Control[] { colorBox, label });
            }

            // Seat type indicators
            var typeLabel = new Label
            {
                Text = "Types: E=Economy, B=Business, F=First Class, P=Premium",
                Location = new Point(10, 85),
                Size = new Size(380, 20),
                Font = new Font("Arial", 8, FontStyle.Italic)
            };
            legendGroup.Controls.Add(typeLabel);
        }

        private void GenerateSeatsBtn_Click(object sender, EventArgs e)
        {
            GenerateSeats();
        }

        private void GenerateSeats()
        {
            seats.Clear();
            seatButtons.Clear();
            seatPanel.Controls.Clear();
            selectedSeats.Clear();

            string vehicleId = vehicleComboBox.SelectedItem?.ToString() ?? "NA";
            int rows = (int)rowsUpDown.Value;
            int seatsPerRow = (int)seatsPerRowUpDown.Value;

            Random rand = new Random();
            int seatId = 1;

            for (int row = 1; row <= rows; row++)
            {
                for (int seatInRow = 1; seatInRow <= seatsPerRow; seatInRow++)
                {
                    var seatType = GetSeatTypeByPosition(row, rows, seatInRow, seatsPerRow);
                    var seatStatus = GetRandomSeatStatus(rand);

                    var seat = new Seat
                    {
                        SeatId = seatId++,
                        VehicleID = vehicleId,
                        SeatNumber = $"{row:D2}{(char)('A' + seatInRow - 1)}",
                        SeatType = seatType,
                        seatStatus = seatStatus
                    };

                    seats.Add(seat);
                    CreateSeatButton(seat, row, seatInRow);
                }
            }

            UpdateStatusLabel();
        }

        private string GetSeatTypeByPosition(int row, int totalRows, int seatInRow, int seatsPerRow)
        {
            // First 2 rows are First Class
            if (row <= 2) return "FirstClass";
            // Next 3 rows are Business
            if (row <= 5) return "Business";
            // Last 2 rows are Premium
            if (row > totalRows - 2) return "Premium";
            // Rest are Economy
            return "Economy";
        }

        private string GetRandomSeatStatus(Random rand)
        {
            var statuses = new[] { "Available", "Available", "Available", "Occupied", "Reserved", "Maintenance" };
            return statuses[rand.Next(statuses.Length)];
        }

        private void CreateSeatButton(Seat seat, int row, int seatInRow)
        {
            var button = new Button
            {
                Size = new Size(50, 40),
                Location = new Point((seatInRow - 1) * 60 + 50, (row - 1) * 50 + 20),
                Text = $"{seat.SeatNumber}\n{GetSeatTypeAbbreviation(seat.SeatType)}",
                Font = new Font("Arial", 7, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Tag = seat.SeatId
            };

            button.Click += SeatButton_Click;
            UpdateSeatButtonAppearance(button, seat);

            seatButtons[seat.SeatId] = button;
            seatPanel.Controls.Add(button);

            // Add row number label
            if (seatInRow == 1)
            {
                var rowLabel = new Label
                {
                    Text = row.ToString("D2"),
                    Location = new Point(10, (row - 1) * 50 + 30),
                    Size = new Size(30, 20),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 8, FontStyle.Bold)
                };
                seatPanel.Controls.Add(rowLabel);
            }
        }

        private string GetSeatTypeAbbreviation(string seatType)
        {
            return seatType switch
            {
                "Economy" => "E",
                "Business" => "B",
                "FirstClass" => "F",
                "Premium" => "P",
                _ => "E"
            };
        }

        private void UpdateSeatButtonAppearance(Button button, Seat seat)
        {
            Color backColor = GetSeatStatusColor(seat.seatStatus);

            button.BackColor = backColor;
            button.ForeColor = GetContrastColor(backColor);
            button.Enabled = seat.seatStatus == "Available" || seat.seatStatus == "Selected";

            // Add border for selected seats
            if (seat.seatStatus == "Selected")
            {
                button.FlatAppearance.BorderColor = Color.DarkBlue;
                button.FlatAppearance.BorderSize = 2;
            }
            else
            {
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = Color.Black;
            }
        }

        private Color GetSeatStatusColor(string status)
        {
            return status switch
            {
                "Available" => Color.LightGreen,
                "Selected" => Color.Yellow,
                "Occupied" => Color.Red,
                "Maintenance" => Color.Gray,
                "Reserved" => Color.Orange,
                _ => Color.LightGray
            };
        }

        private Color GetContrastColor(Color backColor)
        {
            int brightness = (int)(backColor.R * 0.299 + backColor.G * 0.587 + backColor.B * 0.114);
            return brightness > 128 ? Color.Black : Color.White;
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            int seatId = (int)button.Tag;
            var seat = seats.FirstOrDefault(s => s.SeatId == seatId);

            if (seat == null) return;

            if (seat.seatStatus == "Available")
            {
                seat.seatStatus = "Selected";
                selectedSeats.Add(seat);
            }
            else if (seat.seatStatus == "Selected")
            {
                seat.seatStatus = "Available";
                selectedSeats.Remove(seat);
            }

            UpdateSeatButtonAppearance(button, seat);
            UpdateStatusLabel();
        }

        private void ClearSelectionBtn_Click(object sender, EventArgs e)
        {
            foreach (var seat in selectedSeats.ToList())
            {
                seat.seatStatus = "Available";
                if (seatButtons.TryGetValue(seat.SeatId, out Button button))
                {
                    UpdateSeatButtonAppearance(button, seat);
                }
            }
            selectedSeats.Clear();
            UpdateStatusLabel();
        }

        private void ConfirmSelectionBtn_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Please select at least one seat before confirming.", "No Seats Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string message = $"Confirm selection of {selectedSeats.Count} seat(s):\n" +
                           $"{string.Join(", ", selectedSeats.Select(s => s.SeatNumber))}";

            var result = MessageBox.Show(message, "Confirm Seat Selection",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SeatSelectionConfirmed = true;
                SelectedSeats = new List<Seat>(selectedSeats);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void SeatTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = seatTypeFilter.SelectedItem.ToString();

            foreach (var kvp in seatButtons)
            {
                var seat = seats.FirstOrDefault(s => s.SeatId == kvp.Key);
                if (seat != null)
                {
                    bool visible = selectedFilter == "All" || seat.SeatType == selectedFilter;
                    kvp.Value.Visible = visible;
                }
            }
        }

        private void UpdateStatusLabel()
        {
            int availableCount = seats.Count(s => s.seatStatus == "Available");
            int selectedCount = selectedSeats.Count;
            int occupiedCount = seats.Count(s => s.seatStatus == "Occupied");
            int totalSeats = seats.Count;

            statusLabel.Text = $"Total: {totalSeats} | Available: {availableCount} | Selected: {selectedCount} | Occupied: {occupiedCount} | " +
                              $"Selected Seats: {string.Join(", ", selectedSeats.Select(s => s.SeatNumber))}";
        }

        private void SetVehicleId(string vehicleId)
        {
            for (int i = 0; i < vehicleComboBox.Items.Count; i++)
            {
                if (vehicleComboBox.Items[i].ToString() == vehicleId)
                {
                    vehicleComboBox.SelectedIndex = i;
                    break;
                }
            }
        }

        private void MarkSeatsAsOccupied(List<string> occupiedSeatNumbers)
        {
            foreach (var seat in seats)
            {
                if (occupiedSeatNumbers.Contains(seat.SeatNumber))
                {
                    seat.seatStatus = "Occupied";
                    if (seatButtons.TryGetValue(seat.SeatId, out Button button))
                    {
                        UpdateSeatButtonAppearance(button, seat);
                    }
                }
            }
        }

        public static SeatSelectionResult ShowSeatPicker(string vehicleId = null, List<string> occupiedSeats = null)
        {
            using (var form = new FormSeatPicking(vehicleId, occupiedSeats))
            {
                var result = form.ShowDialog();
                return new SeatSelectionResult
                {
                    Success = result == DialogResult.OK && form.SeatSelectionConfirmed,
                    SelectedSeats = form.SelectedSeats,
                    VehicleId = form.vehicleComboBox.SelectedItem?.ToString()
                };
            }
        }
    }

    // Result class for seat selection
    public class SeatSelectionResult
    {
        public bool Success { get; set; }
        public List<Seat> SelectedSeats { get; set; } = new List<Seat>();
        public string VehicleId { get; set; }
    }

}
    