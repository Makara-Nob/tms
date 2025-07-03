namespace tms.Forms
{
    partial class FormSeatPicking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            configGroup = new GroupBox();
            filterLabel = new Label();
            seatsLabel = new Label();
            rowsLabel = new Label();
            vehicleLabel = new Label();
            seatTypeFilter = new ComboBox();
            confirmSelectionBtn = new Button();
            clearSelectionBtn = new Button();
            generateSeatsBtn = new Button();
            seatsPerRowUpDown = new NumericUpDown();
            rowsUpDown = new NumericUpDown();
            vehicleComboBox = new ComboBox();
            legendGroup = new GroupBox();
            seatPanel = new Panel();
            statusLabel = new Label();
            configGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)seatsPerRowUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rowsUpDown).BeginInit();
            SuspendLayout();
            // 
            // configGroup
            // 
            configGroup.BackColor = Color.Gainsboro;
            configGroup.Controls.Add(filterLabel);
            configGroup.Controls.Add(seatsLabel);
            configGroup.Controls.Add(rowsLabel);
            configGroup.Controls.Add(vehicleLabel);
            configGroup.Controls.Add(seatTypeFilter);
            configGroup.Controls.Add(confirmSelectionBtn);
            configGroup.Controls.Add(clearSelectionBtn);
            configGroup.Controls.Add(generateSeatsBtn);
            configGroup.Controls.Add(seatsPerRowUpDown);
            configGroup.Controls.Add(rowsUpDown);
            configGroup.Controls.Add(vehicleComboBox);
            configGroup.Location = new Point(12, 11);
            configGroup.Margin = new Padding(4, 4, 4, 4);
            configGroup.Name = "configGroup";
            configGroup.Padding = new Padding(4, 4, 4, 4);
            configGroup.Size = new Size(432, 139);
            configGroup.TabIndex = 0;
            configGroup.TabStop = false;
            configGroup.Text = "Configuration";
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Location = new Point(12, 99);
            filterLabel.Margin = new Padding(4, 0, 4, 0);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(36, 15);
            filterLabel.TabIndex = 10;
            filterLabel.Text = "Filter:";
            // 
            // seatsLabel
            // 
            seatsLabel.AutoSize = true;
            seatsLabel.Location = new Point(12, 65);
            seatsLabel.Margin = new Padding(4, 0, 4, 0);
            seatsLabel.Name = "seatsLabel";
            seatsLabel.Size = new Size(65, 15);
            seatsLabel.TabIndex = 9;
            seatsLabel.Text = "Seats/Row:";
            // 
            // rowsLabel
            // 
            rowsLabel.AutoSize = true;
            rowsLabel.Location = new Point(233, 30);
            rowsLabel.Margin = new Padding(4, 0, 4, 0);
            rowsLabel.Name = "rowsLabel";
            rowsLabel.Size = new Size(38, 15);
            rowsLabel.TabIndex = 8;
            rowsLabel.Text = "Rows:";
            // 
            // vehicleLabel
            // 
            vehicleLabel.AutoSize = true;
            vehicleLabel.Location = new Point(12, 30);
            vehicleLabel.Margin = new Padding(4, 0, 4, 0);
            vehicleLabel.Name = "vehicleLabel";
            vehicleLabel.Size = new Size(61, 15);
            vehicleLabel.TabIndex = 7;
            vehicleLabel.Text = "Vehicle ID:";
            // 
            // seatTypeFilter
            // 
            seatTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            seatTypeFilter.FormattingEnabled = true;
            seatTypeFilter.Items.AddRange(new object[] { "All", "Economy", "Business", "FirstClass", "Premium" });
            seatTypeFilter.Location = new Point(64, 96);
            seatTypeFilter.Margin = new Padding(4, 4, 4, 4);
            seatTypeFilter.Name = "seatTypeFilter";
            seatTypeFilter.Size = new Size(93, 23);
            seatTypeFilter.TabIndex = 6;
            seatTypeFilter.SelectedIndexChanged += SeatTypeFilter_SelectedIndexChanged;
            // 
            // confirmSelectionBtn
            // 
            confirmSelectionBtn.BackColor = Color.Green;
            confirmSelectionBtn.FlatStyle = FlatStyle.Flat;
            confirmSelectionBtn.ForeColor = Color.White;
            confirmSelectionBtn.Location = new Point(298, 96);
            confirmSelectionBtn.Margin = new Padding(4, 4, 4, 4);
            confirmSelectionBtn.Name = "confirmSelectionBtn";
            confirmSelectionBtn.Size = new Size(117, 29);
            confirmSelectionBtn.TabIndex = 5;
            confirmSelectionBtn.Text = "Confirm Selection";
            confirmSelectionBtn.UseVisualStyleBackColor = false;
            confirmSelectionBtn.Click += ConfirmSelectionBtn_Click;
            // 
            // clearSelectionBtn
            // 
            clearSelectionBtn.BackColor = Color.Orange;
            clearSelectionBtn.FlatStyle = FlatStyle.Flat;
            clearSelectionBtn.ForeColor = Color.White;
            clearSelectionBtn.Location = new Point(175, 96);
            clearSelectionBtn.Margin = new Padding(4, 4, 4, 4);
            clearSelectionBtn.Name = "clearSelectionBtn";
            clearSelectionBtn.Size = new Size(117, 29);
            clearSelectionBtn.TabIndex = 4;
            clearSelectionBtn.Text = "Clear Selection";
            clearSelectionBtn.UseVisualStyleBackColor = false;
            clearSelectionBtn.Click += ClearSelectionBtn_Click;
            // 
            // generateSeatsBtn
            // 
            generateSeatsBtn.BackColor = Color.DodgerBlue;
            generateSeatsBtn.FlatStyle = FlatStyle.Flat;
            generateSeatsBtn.ForeColor = Color.White;
            generateSeatsBtn.Location = new Point(175, 61);
            generateSeatsBtn.Margin = new Padding(4, 4, 4, 4);
            generateSeatsBtn.Name = "generateSeatsBtn";
            generateSeatsBtn.Size = new Size(117, 29);
            generateSeatsBtn.TabIndex = 3;
            generateSeatsBtn.Text = "Generate Seats";
            generateSeatsBtn.UseVisualStyleBackColor = false;
            generateSeatsBtn.Click += GenerateSeatsBtn_Click;
            // 
            // seatsPerRowUpDown
            // 
            seatsPerRowUpDown.Location = new Point(99, 61);
            seatsPerRowUpDown.Margin = new Padding(4, 4, 4, 4);
            seatsPerRowUpDown.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            seatsPerRowUpDown.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            seatsPerRowUpDown.Name = "seatsPerRowUpDown";
            seatsPerRowUpDown.Size = new Size(58, 23);
            seatsPerRowUpDown.TabIndex = 2;
            seatsPerRowUpDown.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // rowsUpDown
            // 
            rowsUpDown.Location = new Point(286, 26);
            rowsUpDown.Margin = new Padding(4, 4, 4, 4);
            rowsUpDown.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            rowsUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            rowsUpDown.Name = "rowsUpDown";
            rowsUpDown.Size = new Size(58, 23);
            rowsUpDown.TabIndex = 1;
            rowsUpDown.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // vehicleComboBox
            // 
            vehicleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            vehicleComboBox.FormattingEnabled = true;
            vehicleComboBox.Items.AddRange(new object[] { "BUS001", "BUS002", "FLIGHT001", "TRAIN001" });
            vehicleComboBox.Location = new Point(99, 26);
            vehicleComboBox.Margin = new Padding(4, 4, 4, 4);
            vehicleComboBox.Name = "vehicleComboBox";
            vehicleComboBox.Size = new Size(116, 23);
            vehicleComboBox.TabIndex = 0;
            // 
            // legendGroup
            // 
            legendGroup.BackColor = Color.Silver;
            legendGroup.Location = new Point(455, 11);
            legendGroup.Margin = new Padding(4, 4, 4, 4);
            legendGroup.Name = "legendGroup";
            legendGroup.Padding = new Padding(4, 4, 4, 4);
            legendGroup.Size = new Size(467, 139);
            legendGroup.TabIndex = 1;
            legendGroup.TabStop = false;
            legendGroup.Text = "Legend";
            // 
            // seatPanel
            // 
            seatPanel.AutoScroll = true;
            seatPanel.BackColor = Color.LightGray;
            seatPanel.BorderStyle = BorderStyle.FixedSingle;
            seatPanel.Location = new Point(12, 161);
            seatPanel.Margin = new Padding(4, 4, 4, 4);
            seatPanel.Name = "seatPanel";
            seatPanel.Size = new Size(1120, 577);
            seatPanel.TabIndex = 2;
            seatPanel.Paint += seatPanel_Paint;
            // 
            // statusLabel
            // 
            statusLabel.BackColor = Color.LightGray;
            statusLabel.Location = new Point(12, 750);
            statusLabel.Margin = new Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Padding = new Padding(12, 6, 12, 6);
            statusLabel.Size = new Size(1143, 35);
            statusLabel.TabIndex = 3;
            statusLabel.Text = "Ready to generate seats";
            statusLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormSeatPicking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 28, 36);
            ClientSize = new Size(1167, 637);
            Controls.Add(statusLabel);
            Controls.Add(seatPanel);
            Controls.Add(legendGroup);
            Controls.Add(configGroup);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FormSeatPicking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seat Picking System";
            WindowState = FormWindowState.Maximized;
            Load += SeatPickingForm_Load;
            configGroup.ResumeLayout(false);
            configGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)seatsPerRowUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)rowsUpDown).EndInit();
            ResumeLayout(false);

        }


        private System.Windows.Forms.GroupBox configGroup;
        private System.Windows.Forms.ComboBox vehicleComboBox;
        private System.Windows.Forms.NumericUpDown rowsUpDown;
        private System.Windows.Forms.NumericUpDown seatsPerRowUpDown;
        private System.Windows.Forms.Button generateSeatsBtn;
        private System.Windows.Forms.Button clearSelectionBtn;
        private System.Windows.Forms.Button confirmSelectionBtn;
        private System.Windows.Forms.ComboBox seatTypeFilter;
        private System.Windows.Forms.Label vehicleLabel;
        private System.Windows.Forms.Label rowsLabel;
        private System.Windows.Forms.Label seatsLabel;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.GroupBox legendGroup;
        private System.Windows.Forms.Panel seatPanel;
        private System.Windows.Forms.Label statusLabel;
#endregion
    }
}