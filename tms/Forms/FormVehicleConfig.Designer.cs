namespace tms.Forms
{
    partial class FormVehicleConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Form controls
        private TableLayoutPanel mainTableLayout;
        private TableLayoutPanel configTableLayout;
        private GroupBox vehicleInfoGroupBox;
        private GroupBox layoutConfigGroupBox;
        private GroupBox seatTypesGroupBox;
        private Panel buttonPanel;
        private Panel seatTypeContainer;
        private Button previewLayoutButton;
        private Button addSeatTypeButton;
        private Button saveButton;
        private Button cancelButton;

        // Vehicle Info Controls
        private TableLayoutPanel vehicleInfoTable;
        private Label vehicleIdLabel;

        // Layout Config Controls
        private TableLayoutPanel layoutConfigTable;
        private Label rowsLabel;
        private NumericUpDown rowsNumericUpDown;
        private Label seatsLabel;
        private NumericUpDown seatsNumericUpDown;
        private Label layoutLabel;
        private ComboBox layoutComboBox;

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
            mainTableLayout = new TableLayoutPanel();
            configTableLayout = new TableLayoutPanel();
            vehicleInfoGroupBox = new GroupBox();
            vehicleInfoTable = new TableLayoutPanel();
            cmbVehicleId = new ComboBox();
            label1 = new Label();
            txtVehicleName = new TextBox();
            lbType = new Label();
            vehicleIdLabel = new Label();
            cmbType = new ComboBox();
            layoutConfigGroupBox = new GroupBox();
            layoutConfigTable = new TableLayoutPanel();
            rowsLabel = new Label();
            rowsNumericUpDown = new NumericUpDown();
            seatsLabel = new Label();
            seatsNumericUpDown = new NumericUpDown();
            layoutLabel = new Label();
            layoutComboBox = new ComboBox();
            previewLayoutButton = new Button();
            seatTypesGroupBox = new GroupBox();
            seatTypesTable = new TableLayoutPanel();
            seatTypeContainer = new Panel();
            addSeatTypeButton = new Button();
            buttonPanel = new Panel();
            buttonTable = new TableLayoutPanel();
            saveButton = new Button();
            cancelButton = new Button();
            previewPanel = new Panel();
            mainTableLayout.SuspendLayout();
            configTableLayout.SuspendLayout();
            vehicleInfoGroupBox.SuspendLayout();
            vehicleInfoTable.SuspendLayout();
            layoutConfigGroupBox.SuspendLayout();
            layoutConfigTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rowsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)seatsNumericUpDown).BeginInit();
            seatTypesGroupBox.SuspendLayout();
            seatTypesTable.SuspendLayout();
            buttonPanel.SuspendLayout();
            buttonTable.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayout
            // 
            mainTableLayout.ColumnCount = 2;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            mainTableLayout.Controls.Add(configTableLayout, 0, 0);
            mainTableLayout.Controls.Add(previewPanel, 1, 0);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Margin = new Padding(2);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.Padding = new Padding(7, 6, 7, 6);
            mainTableLayout.RowCount = 1;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayout.Size = new Size(1024, 637);
            mainTableLayout.TabIndex = 0;
            // 
            // configTableLayout
            // 
            configTableLayout.ColumnCount = 1;
            configTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 601F));
            configTableLayout.Controls.Add(vehicleInfoGroupBox, 0, 0);
            configTableLayout.Controls.Add(layoutConfigGroupBox, 0, 1);
            configTableLayout.Controls.Add(seatTypesGroupBox, 0, 2);
            configTableLayout.Controls.Add(buttonPanel, 0, 3);
            configTableLayout.Dock = DockStyle.Fill;
            configTableLayout.Location = new Point(9, 8);
            configTableLayout.Margin = new Padding(2);
            configTableLayout.Name = "configTableLayout";
            configTableLayout.RowCount = 4;
            configTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            configTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 102F));
            configTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            configTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            configTableLayout.Size = new Size(602, 621);
            configTableLayout.TabIndex = 0;
            // 
            // vehicleInfoGroupBox
            // 
            vehicleInfoGroupBox.Controls.Add(vehicleInfoTable);
            vehicleInfoGroupBox.Dock = DockStyle.Fill;
            vehicleInfoGroupBox.ForeColor = Color.White;
            vehicleInfoGroupBox.Location = new Point(2, 2);
            vehicleInfoGroupBox.Margin = new Padding(2);
            vehicleInfoGroupBox.Name = "vehicleInfoGroupBox";
            vehicleInfoGroupBox.Padding = new Padding(7, 6, 7, 6);
            vehicleInfoGroupBox.Size = new Size(598, 98);
            vehicleInfoGroupBox.TabIndex = 0;
            vehicleInfoGroupBox.TabStop = false;
            vehicleInfoGroupBox.Text = "Vehicle Information";
            // 
            // vehicleInfoTable
            // 
            vehicleInfoTable.ColumnCount = 2;
            vehicleInfoTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            vehicleInfoTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            vehicleInfoTable.Controls.Add(cmbVehicleId, 1, 0);
            vehicleInfoTable.Controls.Add(label1, 0, 2);
            vehicleInfoTable.Controls.Add(txtVehicleName, 1, 1);
            vehicleInfoTable.Controls.Add(lbType, 0, 1);
            vehicleInfoTable.Controls.Add(vehicleIdLabel, 0, 0);
            vehicleInfoTable.Controls.Add(cmbType, 1, 2);
            vehicleInfoTable.Dock = DockStyle.Fill;
            vehicleInfoTable.Location = new Point(7, 22);
            vehicleInfoTable.Margin = new Padding(2);
            vehicleInfoTable.Name = "vehicleInfoTable";
            vehicleInfoTable.RowCount = 3;
            vehicleInfoTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            vehicleInfoTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            vehicleInfoTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            vehicleInfoTable.Size = new Size(584, 70);
            vehicleInfoTable.TabIndex = 0;
            // 
            // cmbVehicleId
            // 
            cmbVehicleId.Dock = DockStyle.Fill;
            cmbVehicleId.FormattingEnabled = true;
            cmbVehicleId.Location = new Point(72, 2);
            cmbVehicleId.Margin = new Padding(2);
            cmbVehicleId.Name = "cmbVehicleId";
            cmbVehicleId.Size = new Size(510, 23);
            cmbVehicleId.TabIndex = 6;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.ForeColor = Color.White;
            label1.Location = new Point(2, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 24);
            label1.TabIndex = 4;
            label1.Text = "Type:";
            // 
            // txtVehicleName
            // 
            txtVehicleName.Dock = DockStyle.Fill;
            txtVehicleName.Location = new Point(72, 25);
            txtVehicleName.Margin = new Padding(2);
            txtVehicleName.Name = "txtVehicleName";
            txtVehicleName.Size = new Size(510, 23);
            txtVehicleName.TabIndex = 3;
            // 
            // lbType
            // 
            lbType.Dock = DockStyle.Fill;
            lbType.ForeColor = Color.White;
            lbType.Location = new Point(2, 23);
            lbType.Margin = new Padding(2, 0, 2, 0);
            lbType.Name = "lbType";
            lbType.Size = new Size(66, 23);
            lbType.TabIndex = 2;
            lbType.Text = "Name:";
            // 
            // vehicleIdLabel
            // 
            vehicleIdLabel.Dock = DockStyle.Fill;
            vehicleIdLabel.ForeColor = Color.White;
            vehicleIdLabel.Location = new Point(2, 0);
            vehicleIdLabel.Margin = new Padding(2, 0, 2, 0);
            vehicleIdLabel.Name = "vehicleIdLabel";
            vehicleIdLabel.Size = new Size(66, 23);
            vehicleIdLabel.TabIndex = 0;
            vehicleIdLabel.Text = "Vehicle ID:";
            // 
            // cmbType
            // 
            cmbType.Dock = DockStyle.Fill;
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(72, 48);
            cmbType.Margin = new Padding(2);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(510, 23);
            cmbType.TabIndex = 5;
            // 
            // layoutConfigGroupBox
            // 
            layoutConfigGroupBox.Controls.Add(layoutConfigTable);
            layoutConfigGroupBox.Dock = DockStyle.Fill;
            layoutConfigGroupBox.ForeColor = Color.White;
            layoutConfigGroupBox.Location = new Point(2, 104);
            layoutConfigGroupBox.Margin = new Padding(2);
            layoutConfigGroupBox.Name = "layoutConfigGroupBox";
            layoutConfigGroupBox.Padding = new Padding(7, 6, 7, 6);
            layoutConfigGroupBox.Size = new Size(598, 98);
            layoutConfigGroupBox.TabIndex = 1;
            layoutConfigGroupBox.TabStop = false;
            layoutConfigGroupBox.Text = "Layout Configuration";
            // 
            // layoutConfigTable
            // 
            layoutConfigTable.ColumnCount = 3;
            layoutConfigTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98F));
            layoutConfigTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 63F));
            layoutConfigTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutConfigTable.Controls.Add(rowsLabel, 0, 0);
            layoutConfigTable.Controls.Add(rowsNumericUpDown, 1, 0);
            layoutConfigTable.Controls.Add(seatsLabel, 0, 1);
            layoutConfigTable.Controls.Add(seatsNumericUpDown, 1, 1);
            layoutConfigTable.Controls.Add(layoutLabel, 0, 2);
            layoutConfigTable.Controls.Add(layoutComboBox, 1, 2);
            layoutConfigTable.Controls.Add(previewLayoutButton, 2, 2);
            layoutConfigTable.Dock = DockStyle.Fill;
            layoutConfigTable.Location = new Point(7, 22);
            layoutConfigTable.Margin = new Padding(2);
            layoutConfigTable.Name = "layoutConfigTable";
            layoutConfigTable.RowCount = 3;
            layoutConfigTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.039444F));
            layoutConfigTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.9117622F));
            layoutConfigTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0487862F));
            layoutConfigTable.Size = new Size(584, 70);
            layoutConfigTable.TabIndex = 0;
            // 
            // rowsLabel
            // 
            rowsLabel.Dock = DockStyle.Fill;
            rowsLabel.ForeColor = Color.White;
            rowsLabel.Location = new Point(2, 0);
            rowsLabel.Margin = new Padding(2, 0, 2, 0);
            rowsLabel.Name = "rowsLabel";
            rowsLabel.Size = new Size(94, 23);
            rowsLabel.TabIndex = 0;
            rowsLabel.Text = "Total Rows:";
            rowsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rowsNumericUpDown
            // 
            rowsNumericUpDown.Dock = DockStyle.Fill;
            rowsNumericUpDown.Location = new Point(100, 2);
            rowsNumericUpDown.Margin = new Padding(2);
            rowsNumericUpDown.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            rowsNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            rowsNumericUpDown.Name = "rowsNumericUpDown";
            rowsNumericUpDown.Size = new Size(59, 23);
            rowsNumericUpDown.TabIndex = 1;
            rowsNumericUpDown.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // seatsLabel
            // 
            seatsLabel.Dock = DockStyle.Fill;
            seatsLabel.ForeColor = Color.White;
            seatsLabel.Location = new Point(2, 23);
            seatsLabel.Margin = new Padding(2, 0, 2, 0);
            seatsLabel.Name = "seatsLabel";
            seatsLabel.Size = new Size(94, 23);
            seatsLabel.TabIndex = 2;
            seatsLabel.Text = "Seats per Row:";
            seatsLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // seatsNumericUpDown
            // 
            seatsNumericUpDown.Dock = DockStyle.Fill;
            seatsNumericUpDown.Location = new Point(100, 25);
            seatsNumericUpDown.Margin = new Padding(2);
            seatsNumericUpDown.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            seatsNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            seatsNumericUpDown.Name = "seatsNumericUpDown";
            seatsNumericUpDown.Size = new Size(59, 23);
            seatsNumericUpDown.TabIndex = 3;
            seatsNumericUpDown.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // layoutLabel
            // 
            layoutLabel.Dock = DockStyle.Fill;
            layoutLabel.ForeColor = Color.White;
            layoutLabel.Location = new Point(2, 46);
            layoutLabel.Margin = new Padding(2, 0, 2, 0);
            layoutLabel.Name = "layoutLabel";
            layoutLabel.Size = new Size(94, 24);
            layoutLabel.TabIndex = 4;
            layoutLabel.Text = "Layout:";
            layoutLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // layoutComboBox
            // 
            layoutComboBox.Dock = DockStyle.Fill;
            layoutComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            layoutComboBox.Location = new Point(100, 48);
            layoutComboBox.Margin = new Padding(2);
            layoutComboBox.Name = "layoutComboBox";
            layoutComboBox.Size = new Size(59, 23);
            layoutComboBox.TabIndex = 5;
            // 
            // previewLayoutButton
            // 
            previewLayoutButton.BackColor = Color.FromArgb(0, 123, 255);
            previewLayoutButton.Dock = DockStyle.Fill;
            previewLayoutButton.FlatAppearance.BorderSize = 0;
            previewLayoutButton.FlatStyle = FlatStyle.Flat;
            previewLayoutButton.ForeColor = Color.White;
            previewLayoutButton.Location = new Point(163, 48);
            previewLayoutButton.Margin = new Padding(2);
            previewLayoutButton.Name = "previewLayoutButton";
            previewLayoutButton.Size = new Size(419, 20);
            previewLayoutButton.TabIndex = 6;
            previewLayoutButton.Text = "Preview Layout";
            previewLayoutButton.UseVisualStyleBackColor = false;
            // 
            // seatTypesGroupBox
            // 
            seatTypesGroupBox.Controls.Add(seatTypesTable);
            seatTypesGroupBox.Dock = DockStyle.Fill;
            seatTypesGroupBox.ForeColor = Color.White;
            seatTypesGroupBox.Location = new Point(2, 206);
            seatTypesGroupBox.Margin = new Padding(2);
            seatTypesGroupBox.Name = "seatTypesGroupBox";
            seatTypesGroupBox.Padding = new Padding(7, 6, 7, 6);
            seatTypesGroupBox.Size = new Size(598, 383);
            seatTypesGroupBox.TabIndex = 2;
            seatTypesGroupBox.TabStop = false;
            seatTypesGroupBox.Text = "Seat Type Configurations";
            // 
            // seatTypesTable
            // 
            seatTypesTable.ColumnCount = 1;
            seatTypesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 569F));
            seatTypesTable.Controls.Add(seatTypeContainer, 0, 0);
            seatTypesTable.Controls.Add(addSeatTypeButton, 0, 1);
            seatTypesTable.Dock = DockStyle.Fill;
            seatTypesTable.Location = new Point(7, 22);
            seatTypesTable.Margin = new Padding(2);
            seatTypesTable.Name = "seatTypesTable";
            seatTypesTable.Padding = new Padding(7, 6, 7, 6);
            seatTypesTable.RowCount = 2;
            seatTypesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            seatTypesTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 21F));
            seatTypesTable.Size = new Size(584, 355);
            seatTypesTable.TabIndex = 0;
            // 
            // seatTypeContainer
            // 
            seatTypeContainer.BackColor = Color.FromArgb(35, 45, 60);
            seatTypeContainer.BorderStyle = BorderStyle.FixedSingle;
            seatTypeContainer.Dock = DockStyle.Fill;
            seatTypeContainer.Location = new Point(9, 8);
            seatTypeContainer.Margin = new Padding(2);
            seatTypeContainer.Name = "seatTypeContainer";
            seatTypeContainer.Size = new Size(566, 318);
            seatTypeContainer.TabIndex = 0;
            // 
            // addSeatTypeButton
            // 
            addSeatTypeButton.BackColor = Color.FromArgb(40, 167, 69);
            addSeatTypeButton.Dock = DockStyle.Left;
            addSeatTypeButton.FlatAppearance.BorderSize = 0;
            addSeatTypeButton.FlatStyle = FlatStyle.Flat;
            addSeatTypeButton.ForeColor = Color.White;
            addSeatTypeButton.Location = new Point(9, 330);
            addSeatTypeButton.Margin = new Padding(2);
            addSeatTypeButton.Name = "addSeatTypeButton";
            addSeatTypeButton.Size = new Size(84, 17);
            addSeatTypeButton.TabIndex = 1;
            addSeatTypeButton.Text = "Add Seat Type";
            addSeatTypeButton.UseVisualStyleBackColor = false;
            // 
            // buttonPanel
            // 
            buttonPanel.Controls.Add(buttonTable);
            buttonPanel.Dock = DockStyle.Fill;
            buttonPanel.Location = new Point(2, 593);
            buttonPanel.Margin = new Padding(2);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.Size = new Size(598, 26);
            buttonPanel.TabIndex = 3;
            // 
            // buttonTable
            // 
            buttonTable.ColumnCount = 3;
            buttonTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 98F));
            buttonTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 70F));
            buttonTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            buttonTable.Controls.Add(saveButton, 0, 0);
            buttonTable.Controls.Add(cancelButton, 1, 0);
            buttonTable.Dock = DockStyle.Fill;
            buttonTable.Location = new Point(0, 0);
            buttonTable.Margin = new Padding(2);
            buttonTable.Name = "buttonTable";
            buttonTable.Padding = new Padding(1);
            buttonTable.RowCount = 1;
            buttonTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            buttonTable.Size = new Size(598, 26);
            buttonTable.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(40, 167, 69);
            saveButton.DialogResult = DialogResult.OK;
            saveButton.Dock = DockStyle.Fill;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Arial", 9F, FontStyle.Bold);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(3, 3);
            saveButton.Margin = new Padding(2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 20);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save Configuration";
            saveButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.FromArgb(220, 53, 69);
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Arial", 9F, FontStyle.Bold);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(101, 3);
            cancelButton.Margin = new Padding(2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(66, 20);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // previewPanel
            // 
            previewPanel.AutoScroll = true;
            previewPanel.BackColor = Color.FromArgb(30, 40, 55);
            previewPanel.BorderStyle = BorderStyle.FixedSingle;
            previewPanel.Dock = DockStyle.Fill;
            previewPanel.Location = new Point(615, 8);
            previewPanel.Margin = new Padding(2);
            previewPanel.Name = "previewPanel";
            previewPanel.Size = new Size(400, 621);
            previewPanel.TabIndex = 1;
            // 
            // FormVehicleConfig
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 28, 36);
            ClientSize = new Size(1024, 637);
            Controls.Add(mainTableLayout);
            ForeColor = Color.White;
            Margin = new Padding(4);
            MaximumSize = new Size(1394, 1023);
            MinimumSize = new Size(928, 662);
            Name = "FormVehicleConfig";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Vehicle Seat Configuration";
            WindowState = FormWindowState.Maximized;
            mainTableLayout.ResumeLayout(false);
            configTableLayout.ResumeLayout(false);
            vehicleInfoGroupBox.ResumeLayout(false);
            vehicleInfoTable.ResumeLayout(false);
            vehicleInfoTable.PerformLayout();
            layoutConfigGroupBox.ResumeLayout(false);
            layoutConfigTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rowsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)seatsNumericUpDown).EndInit();
            seatTypesGroupBox.ResumeLayout(false);
            seatTypesTable.ResumeLayout(false);
            buttonPanel.ResumeLayout(false);
            buttonTable.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel seatTypesTable;
        private TableLayoutPanel buttonTable;
        private TextBox txtVehicleName;
        private Label lbType;
        private Label label1;
        private ComboBox cmbType;
        private ComboBox cmbVehicleId;
    }
}