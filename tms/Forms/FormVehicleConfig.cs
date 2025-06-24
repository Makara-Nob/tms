using tms.Config;
using tms.Model;
using tms.Repository;

namespace tms.Forms
{
    public partial class FormVehicleConfig : Form
    {
        #region Fields and Properties

        private VehicleConfigurations currentConfig;
        private Panel seatTypePanel;
        private Panel previewPanel;

        // Form controls that will be referenced
        private NumericUpDown rowsUpDown;
        private NumericUpDown seatsUpDown;
        private ComboBox layoutCombo;

        private readonly SeatLayoutService _seatLayoutService;
        private readonly VehicleRepository _vehicleRepository;

        public VehicleConfigurations Result { get; private set; }

        // Seat type colors lookup
        private static readonly Dictionary<string, Color> SeatTypeColors = new(StringComparer.OrdinalIgnoreCase)
        {
            { "VIP Sleeper", Color.MediumPurple },
            { "Luxury Sleeper", Color.LightSeaGreen },
            { "Limousine", Color.SandyBrown },
            { "VIP Seated", Color.LightSkyBlue },
            { "Standard", Color.LightGray },
        };

        #endregion

        #region Constructor and Initialization

        public FormVehicleConfig(VehicleConfigurations existingConfig = null)
        {
            InitializeComponent();

            _vehicleRepository = new VehicleRepository();
            _seatLayoutService = new SeatLayoutService();

            currentConfig = existingConfig ?? new VehicleConfigurations();
            SetupDynamicControls();
            LoadConfiguration();
        }

        private void SetupDynamicControls()
        {
            SetupSeatTypePanel();
            SetupPreviewPanel();
            WireUpEvents();
            AssignControlReferences();
        }

        private void SetupSeatTypePanel()
        {
            seatTypePanel = new Panel
            {
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.FixedSingle,
                AutoScroll = true,
                Margin = new Padding(3)
            };
            seatTypeContainer.Controls.Add(seatTypePanel);
        }

        private void SetupPreviewPanel()
        {
            var previewLabel = new Label
            {
                Text = "Seat Layout Preview",
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Height = 30,
                BackColor = Color.FromArgb(45, 55, 70),
                ForeColor = Color.White
            };
            previewPanel.Controls.Add(previewLabel);
        }

        private void WireUpEvents()
        {
            previewLayoutButton.Click += PreviewBtn_Click;
            addSeatTypeButton.Click += AddSeatType_Click;
            saveButton.Click += SaveAndStayBtn_Click;
            cancelButton.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
        }

        private void AssignControlReferences()
        {
            rowsUpDown = rowsNumericUpDown;
            seatsUpDown = seatsNumericUpDown;
            layoutCombo = layoutComboBox;
        }

        #endregion

        #region Configuration Loading

        private void LoadConfiguration()
        {
            SetupStaticDropdowns();
            LoadVehicleComboBox();

            if (currentConfig?.VehicleId == null)
                return;

            LoadConfigurationValues();
            LoadSeatTypeConfigurations();
        }

        private void LoadConfigurationValues()
        {
            txtVehicleName.Text = currentConfig?.VehicleName ?? "";
            cmbType.Text = currentConfig?.VehicleType ?? "Bus";
            rowsUpDown.Value = currentConfig?.TotalRows > 0 ? currentConfig.TotalRows : 20;
            seatsUpDown.Value = currentConfig?.SeatsPerRow > 0 ? currentConfig.SeatsPerRow : 4;
            layoutCombo.Text = currentConfig?.SeatLayout ?? "2-2";
        }

        private void SetupStaticDropdowns()
        {
            SetupVehicleTypeDropdown();
            SetupLayoutDropdown();
        }

        private void SetupVehicleTypeDropdown()
        {
            cmbType.Items.Clear();
            cmbType.Items.AddRange(new string[]
            {
                "VIP Sleeper Bus",
                "Luxury Sleeper Bus",
                "VIP Seated Bus",
                "Limousine Minivan",
                "Standard Bus",
                "Courier Van",
                "Cargo Truck",
                "Motorbike Delivery",
                "Other"
            });

            if (cmbType.Items.Count > 0)
                cmbType.SelectedIndex = 0;
        }

        private void SetupLayoutDropdown()
        {
            layoutCombo.Items.Clear();
            layoutCombo.Items.AddRange(new string[] { "2-2", "3-3", "2-3-2", "1-2-1" });

            if (layoutCombo.Items.Count > 0)
                layoutCombo.SelectedIndex = 0;
        }

        private void LoadVehicleComboBox()
        {
            try
            {
                cmbVehicleId.Items.Clear();
                cmbVehicleId.Items.Add("");

                if (_vehicleRepository == null)
                {
                    MessageBox.Show("Vehicle repository not initialized");
                    return;
                }

                var vehicles = _vehicleRepository.GetAll();
                if (vehicles != null)
                {
                    foreach (var vehicle in vehicles)
                    {
                        if (vehicle?.VehicleID != null)
                        {
                            cmbVehicleId.Items.Add(vehicle.VehicleID);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicles: {ex.Message}");
            }
        }

        #endregion

        #region Seat Type Configuration Management

        private void LoadSeatTypeConfigurations()
        {
            seatTypePanel.Controls.Clear();

            if (currentConfig.SeatTypeConfigurations == null)
            {
                currentConfig.SeatTypeConfigurations = new List<SeatTypeConfigurations>
                {
                    new SeatTypeConfigurations
                    {
                        SeatType = "Standard",
                        FromRow = 1,
                        ToRow = 20,
                        BasePrice = 16,
                        IsActive = true
                    }
                };
            }

            int yPos = 0;
            foreach (var config in currentConfig.SeatTypeConfigurations)
            {
                AddSeatTypeControl(config, yPos);
                yPos += 35;
            }
        }

        private void AddSeatTypeControl(SeatTypeConfigurations config, int yPos)
        {
            var seatTypeTable = CreateSeatTypeTable(config, yPos);
            AddControlsToSeatTypeTable(seatTypeTable, config);
            seatTypePanel.Controls.Add(seatTypeTable);
        }

        private TableLayoutPanel CreateSeatTypeTable(SeatTypeConfigurations config, int yPos)
        {
            var seatTypeTable = new TableLayoutPanel
            {
                Location = new Point(0, yPos),
                Size = new Size(800, 30),
                BorderStyle = BorderStyle.FixedSingle,
                ColumnCount = 8,
                RowCount = 1,
                BackColor = Color.FromArgb(35, 45, 60)
            };

            ConfigureSeatTypeTableColumns(seatTypeTable);
            return seatTypeTable;
        }

        private void ConfigureSeatTypeTableColumns(TableLayoutPanel table)
        {
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F)); // Type
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));  // From label
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));  // From value
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));  // To label
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));  // To value
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F)); // Price
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));  // Spacer
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));  // Remove button
        }

        private void AddControlsToSeatTypeTable(TableLayoutPanel seatTypeTable, SeatTypeConfigurations config)
        {
            var typeCombo = CreateSeatTypeComboBox(config);
            var fromLabel = CreateLabel("From:", Color.White);
            var fromUpDown = CreateNumericUpDown(config.FromRow, 1, 50);
            var toLabel = CreateLabel("To:", Color.White);
            var toUpDown = CreateNumericUpDown(config.ToRow, 1, 50);
            var priceUpDown = CreatePriceNumericUpDown(config.BasePrice);
            var spacer = new Panel { Dock = DockStyle.Fill };
            var removeBtn = CreateRemoveButton(seatTypeTable);

            seatTypeTable.Controls.Add(typeCombo, 0, 0);
            seatTypeTable.Controls.Add(fromLabel, 1, 0);
            seatTypeTable.Controls.Add(fromUpDown, 2, 0);
            seatTypeTable.Controls.Add(toLabel, 3, 0);
            seatTypeTable.Controls.Add(toUpDown, 4, 0);
            seatTypeTable.Controls.Add(priceUpDown, 5, 0);
            seatTypeTable.Controls.Add(spacer, 6, 0);
            seatTypeTable.Controls.Add(removeBtn, 7, 0);
        }

        private ComboBox CreateSeatTypeComboBox(SeatTypeConfigurations config)
        {
            var typeCombo = new ComboBox
            {
                Dock = DockStyle.Fill,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Tag = config,
                Margin = new Padding(2)
            };
            typeCombo.Items.AddRange(new[] { "Standard", "VIP Sleeper", "Luxury Sleeper", "VIP Seated" });
            typeCombo.Text = config.SeatType;
            return typeCombo;
        }

        private Label CreateLabel(string text, Color foreColor)
        {
            return new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = foreColor,
                Margin = new Padding(1)
            };
        }

        private NumericUpDown CreateNumericUpDown(decimal value, decimal minimum, decimal maximum)
        {
            return new NumericUpDown
            {
                Dock = DockStyle.Fill,
                Minimum = minimum,
                Maximum = maximum,
                Value = value,
                Margin = new Padding(1)
            };
        }

        private NumericUpDown CreatePriceNumericUpDown(decimal value)
        {
            return new NumericUpDown
            {
                Dock = DockStyle.Fill,
                DecimalPlaces = 2,
                Minimum = 0,
                Maximum = 9999,
                Value = value,
                Margin = new Padding(1)
            };
        }

        private Button CreateRemoveButton(TableLayoutPanel seatTypeTable)
        {
            var removeBtn = new Button
            {
                Text = "×",
                Dock = DockStyle.Fill,
                Tag = seatTypeTable,
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Arial", 8, FontStyle.Bold),
                Margin = new Padding(1)
            };
            removeBtn.FlatAppearance.BorderSize = 0;
            removeBtn.Click += (s, e) => seatTypePanel.Controls.Remove(seatTypeTable);
            return removeBtn;
        }

        #endregion

        #region Event Handlers

        private void AddSeatType_Click(object sender, EventArgs e)
        {
            var newConfig = new SeatTypeConfigurations
            {
                SeatType = "Standard",
                FromRow = 1,
                ToRow = 5,
                BasePrice = 50,
                IsActive = true
            };

            AddSeatTypeControl(newConfig, seatTypePanel.Controls.Count * 35);
        }

        private void PreviewBtn_Click(object sender, EventArgs e)
        {
            var config = BuildConfigurationFromForm();
            ShowSeatPreview(config);
        }

        private async void SaveAndStayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                await SaveConfiguration();
            }
            catch (Exception ex)
            {
                HandleSaveError(ex);
            }
            finally
            {
                ResetSaveButton();
            }
        }

        #endregion

        #region Preview Generation

        private void ShowSeatPreview(VehicleConfigurations config)
        {
            ClearPreviewPanel();
            ShowSimplifiedPreview(config);
        }

        private void ClearPreviewPanel()
        {
            var titleLabel = previewPanel.Controls.Cast<Control>().FirstOrDefault(c => c is Label);
            previewPanel.Controls.Clear();
            if (titleLabel != null)
                previewPanel.Controls.Add(titleLabel);
        }

        private void ShowSimplifiedPreview(VehicleConfigurations config)
        {
            var previewContainer = CreatePreviewContainer(config);

            // Create seat rows
            for (int row = 1; row <= config.TotalRows; row++)
            {
                var rowPanel = CreateSeatRowPanel(row, config);
                previewContainer.Controls.Add(rowPanel, 0, row - 1);
            }

            // Add legend
            var legendPanel = CreateLegendPanel();
            previewContainer.Controls.Add(legendPanel, 0, config.TotalRows);

            previewPanel.Controls.Add(previewContainer);
        }

        private TableLayoutPanel CreatePreviewContainer(VehicleConfigurations config)
        {
            return new TableLayoutPanel
            {
                Location = new Point(20, 40),
                AutoSize = true,
                ColumnCount = 1,
                RowCount = config.TotalRows + 1,
                BackColor = Color.FromArgb(30, 40, 55)
            };
        }

        private Panel CreateSeatRowPanel(int rowNumber, VehicleConfigurations config)
        {
            var rowPanel = new TableLayoutPanel
            {
                Height = 25,
                Width = 300,
                ColumnCount = config.SeatsPerRow + 2,
                RowCount = 1,
                Margin = new Padding(1)
            };

            AddRowLabel(rowPanel, rowNumber);
            AddSeatButtons(rowPanel, rowNumber, config);

            return rowPanel;
        }

        private void AddRowLabel(TableLayoutPanel rowPanel, int rowNumber)
        {
            rowPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
            var rowLabel = new Label
            {
                Text = rowNumber.ToString("D2"),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font("Arial", 8, FontStyle.Bold)
            };
            rowPanel.Controls.Add(rowLabel, 0, 0);
        }

        private void AddSeatButtons(TableLayoutPanel rowPanel, int rowNumber, VehicleConfigurations config)
        {
            char seatLetter = 'A';
            int colIndex = 1;

            for (int seat = 1; seat <= config.SeatsPerRow; seat++)
            {
                var seatType = GetSeatTypeForRow(rowNumber, config.SeatTypeConfigurations);
                var seatBtn = CreateSeatButton(seatLetter, seatType);

                rowPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 25F));
                rowPanel.Controls.Add(seatBtn, colIndex, 0);

                colIndex++;
                seatLetter++;

                // Add aisle space if needed
                if (ShouldAddAisleSpace(seat, config.SeatLayout))
                {
                    rowPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 10F));
                    var aisleSpace = new Panel { Dock = DockStyle.Fill };
                    rowPanel.Controls.Add(aisleSpace, colIndex, 0);
                    colIndex++;
                }
            }
        }

        private Button CreateSeatButton(char seatLetter, string seatType)
        {
            return new Button
            {
                Text = seatLetter.ToString(),
                Dock = DockStyle.Fill,
                BackColor = GetSeatTypeColor(seatType),
                Font = new Font("Arial", 7),
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(1)
            };
        }

        private Panel CreateLegendPanel()
        {
            var legendTable = new TableLayoutPanel
            {
                Height = 50,
                Width = 300,
                ColumnCount = 4,
                RowCount = 2,
                Margin = new Padding(5)
            };

            AddLegendTitle(legendTable);
            AddLegendItems(legendTable);

            return legendTable;
        }

        private void AddLegendTitle(TableLayoutPanel legendTable)
        {
            var legendTitle = new Label
            {
                Text = "Legend:",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 9, FontStyle.Bold),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleLeft
            };
            legendTable.SetColumnSpan(legendTitle, 4);
            legendTable.Controls.Add(legendTitle, 0, 0);
        }

        private void AddLegendItems(TableLayoutPanel legendTable)
        {
            var legends = new[]
            {
                new { Color = Color.Gold, Text = "Luxury Sleeper" },
                new { Color = Color.LightBlue, Text = "VIP Seated" },
                new { Color = Color.LightGreen, Text = "VIP Sleeper" },
                new { Color = Color.LightGray, Text = "Standard" }
            };

            for (int i = 0; i < legends.Length; i++)
            {
                var legendItem = CreateLegendItem(legends[i].Color, legends[i].Text);
                legendTable.Controls.Add(legendItem, i, 1);
            }
        }

        private TableLayoutPanel CreateLegendItem(Color color, string text)
        {
            var legendItem = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Margin = new Padding(2)
            };

            legendItem.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 15F));
            legendItem.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            var colorBox = new Panel
            {
                BackColor = color,
                Dock = DockStyle.Fill,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(1)
            };

            var textLabel = new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 8),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleLeft
            };

            legendItem.Controls.Add(colorBox, 0, 0);
            legendItem.Controls.Add(textLabel, 1, 0);

            return legendItem;
        }

        #endregion

        #region Helper Methods

        private string GetSeatTypeForRow(int row, ICollection<SeatTypeConfigurations> seatTypes)
        {
            if (seatTypes == null) return "Standard";

            var seatType = seatTypes.FirstOrDefault(st => st.IsActive && row >= st.FromRow && row <= st.ToRow);
            return seatType?.SeatType ?? "Standard";
        }

        private bool ShouldAddAisleSpace(int seatNumber, string layout)
        {
            return layout switch
            {
                "2-2" => seatNumber == 2,
                "3-3" => seatNumber == 3,
                "2-3-2" => seatNumber == 2 || seatNumber == 5,
                "1-2-1" => seatNumber == 1 || seatNumber == 3,
                "2-1-2" => seatNumber == 2 || seatNumber == 3,
                _ => false
            };
        }

        private Color GetSeatTypeColor(string seatType)
        {
            if (string.IsNullOrWhiteSpace(seatType))
                return Color.White;

            return SeatTypeColors.TryGetValue(seatType.Trim(), out var color)
                ? color
                : Color.White;
        }

        #endregion

        #region Configuration Building and Saving

        private VehicleConfigurations BuildConfigurationFromForm()
        {
            var config = new VehicleConfigurations
            {
                VehicleId = cmbVehicleId.Text?.Trim(),
                VehicleName = txtVehicleName.Text?.Trim(),
                VehicleType = cmbType.Text?.Trim(),
                TotalRows = (int)rowsUpDown.Value,
                AislePositions = currentConfig.AislePositions,
                HasUpperDeck = currentConfig.HasUpperDeck,
                SeatExclusions = currentConfig.SeatExclusions,
                SeatsPerRow = (int)seatsUpDown.Value,
                SeatLayout = layoutCombo.Text?.Trim(),
                CreatedDate = DateTime.Now,
                CreatedBy = "Makara", // NOTE: Static, should be changed later when user model is available
                SeatTypeConfigurations = BuildSeatTypeConfigurations()
            };

            return config;
        }

        private List<SeatTypeConfigurations> BuildSeatTypeConfigurations()
        {
            var seatTypeConfigurations = new List<SeatTypeConfigurations>();

            foreach (Control control in seatTypePanel.Controls)
            {
                if (control is TableLayoutPanel seatTable)
                {
                    try
                    {
                        var seatTypeConfig = ExtractSeatTypeConfiguration(seatTable);
                        if (seatTypeConfig != null && !string.IsNullOrEmpty(seatTypeConfig.SeatType))
                        {
                            seatTypeConfigurations.Add(seatTypeConfig);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.Diagnostics.Debug.WriteLine($"Error processing seat type configuration: {ex.Message}");
                    }
                }
            }

            return seatTypeConfigurations;
        }

        private SeatTypeConfigurations ExtractSeatTypeConfiguration(TableLayoutPanel seatTable)
        {
            var typeCombo = seatTable.Controls.OfType<ComboBox>().FirstOrDefault();
            var numericControls = seatTable.Controls.OfType<NumericUpDown>().ToArray();

            if (typeCombo == null || numericControls.Length < 3)
                return null;

            return new SeatTypeConfigurations
            {
                SeatType = typeCombo.Text?.Trim(),
                FromRow = (int)numericControls[0].Value,
                ToRow = (int)numericControls[1].Value,
                BasePrice = numericControls[2].Value,
                IsActive = true
            };
        }

        private async Task SaveConfiguration()
        {
            var validate = new ValidateVehicleConfiguration();
            var config = BuildConfigurationFromForm();

            // Validate configuration
            var errors = validate.ValidateConfiguration(config);
            if (errors.Any())
            {
                ShowValidationErrors(errors);
                return;
            }

            PrepareSaveButton();

            // Save to database
            bool success = await _seatLayoutService.ConfigureVehicleLayoutAsync(
                config,
                config.SeatTypeConfigurations?.ToList() ?? new List<SeatTypeConfigurations>(),
                null // no exclusions for now
            );

            HandleSaveResult(success, config);
        }

        private void ShowValidationErrors(IEnumerable<string> errors)
        {
            MessageBox.Show($"Configuration errors:\n{string.Join("\n", errors)}",
                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void PrepareSaveButton()
        {
            saveButton.Enabled = false;
            saveButton.Text = "Saving...";
        }

        private void HandleSaveResult(bool success, VehicleConfigurations config)
        {
            if (success)
            {
                Result = config;
                currentConfig = config;
                MessageBox.Show("Configuration saved successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to save configuration. Please check your data and try again.",
                    "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HandleSaveError(Exception ex)
        {
            string errorDetails = BuildErrorMessage(ex);
            MessageBox.Show(errorDetails, "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string BuildErrorMessage(Exception ex)
        {
            string errorDetails = $"Error: {ex.Message}";
            if (ex.InnerException != null)
            {
                errorDetails += $"\n\nInner Exception: {ex.InnerException.Message}";
            }
            errorDetails += $"\n\nStack Trace: {ex.StackTrace}";
            return errorDetails;
        }

        private void ResetSaveButton()
        {
            saveButton.Enabled = true;
            saveButton.Text = "Save";
        }

        #endregion
    }
}