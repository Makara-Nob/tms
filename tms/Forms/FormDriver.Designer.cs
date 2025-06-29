namespace tms.Forms
{
    partial class FormDriver
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
                    // Clean up repositories if they implement IDisposable
                    (staffRepository as IDisposable)?.Dispose();
                    (driverRepository as IDisposable)?.Dispose();
             
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtDriverID = new TextBox();
            cmbStaff = new ComboBox();
            cmbAvailability = new ComboBox();
            dtpLicenseExpiryDate = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            lblTripId = new Label();
            lblVehicle = new Label();
            lblStatus = new Label();
            lblRoute = new Label();
            lblDepatureTime = new Label();
            panelInput = new Panel();
            groupBoxTrip = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtLicenseType = new TextBox();
            txtLicenseNumber = new TextBox();
            lbLicenseType = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtSearch = new TextBox();
            dgvDrivers = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            gbSearch = new GroupBox();
            gbTripList = new GroupBox();
            panelInput.SuspendLayout();
            groupBoxTrip.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            gbSearch.SuspendLayout();
            gbTripList.SuspendLayout();
            SuspendLayout();
            // 
            // txtDriverID
            // 
            txtDriverID.Dock = DockStyle.Fill;
            txtDriverID.Font = new Font("Segoe UI", 14F);
            txtDriverID.Location = new Point(333, 6);
            txtDriverID.Margin = new Padding(5, 6, 5, 6);
            txtDriverID.Name = "txtDriverID";
            txtDriverID.ReadOnly = true;
            txtDriverID.Size = new Size(318, 39);
            txtDriverID.TabIndex = 1;
            // 
            // cmbStaff
            // 
            cmbStaff.Dock = DockStyle.Fill;
            cmbStaff.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStaff.Font = new Font("Segoe UI", 12F);
            cmbStaff.FormattingEnabled = true;
            cmbStaff.Location = new Point(333, 60);
            cmbStaff.Margin = new Padding(5, 6, 5, 6);
            cmbStaff.Name = "cmbStaff";
            cmbStaff.Size = new Size(318, 36);
            cmbStaff.TabIndex = 2;
            // 
            // cmbAvailability
            // 
            cmbAvailability.Dock = DockStyle.Fill;
            cmbAvailability.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvailability.Font = new Font("Segoe UI", 12F);
            cmbAvailability.FormattingEnabled = true;
            cmbAvailability.Location = new Point(333, 114);
            cmbAvailability.Margin = new Padding(5, 6, 5, 6);
            cmbAvailability.Name = "cmbAvailability";
            cmbAvailability.Size = new Size(318, 36);
            cmbAvailability.TabIndex = 3;
            // 
            // dtpLicenseExpiryDate
            // 
            dtpLicenseExpiryDate.Dock = DockStyle.Fill;
            dtpLicenseExpiryDate.Font = new Font("Segoe UI", 11F);
            dtpLicenseExpiryDate.Format = DateTimePickerFormat.Short;
            dtpLicenseExpiryDate.Location = new Point(989, 114);
            dtpLicenseExpiryDate.Margin = new Padding(5, 6, 5, 6);
            dtpLicenseExpiryDate.Name = "dtpLicenseExpiryDate";
            dtpLicenseExpiryDate.Size = new Size(318, 32);
            dtpLicenseExpiryDate.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(5, 168);
            btnAdd.Margin = new Padding(5, 6, 5, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(101, 36);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(333, 168);
            btnUpdate.Margin = new Padding(5, 6, 5, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(101, 36);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(661, 168);
            btnClear.Margin = new Padding(5, 6, 5, 6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(101, 36);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // lblTripId
            // 
            lblTripId.AutoSize = true;
            lblTripId.Location = new Point(5, 0);
            lblTripId.Margin = new Padding(5, 0, 5, 0);
            lblTripId.Name = "lblTripId";
            lblTripId.Size = new Size(71, 20);
            lblTripId.TabIndex = 12;
            lblTripId.Text = "Driver ID:";
            // 
            // lblVehicle
            // 
            lblVehicle.AutoSize = true;
            lblVehicle.Location = new Point(5, 54);
            lblVehicle.Margin = new Padding(5, 0, 5, 0);
            lblVehicle.Name = "lblVehicle";
            lblVehicle.Size = new Size(43, 20);
            lblVehicle.TabIndex = 13;
            lblVehicle.Text = "Staff:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(5, 108);
            lblStatus.Margin = new Padding(5, 0, 5, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(52, 20);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Status:";
            // 
            // lblRoute
            // 
            lblRoute.AutoSize = true;
            lblRoute.Location = new Point(661, 108);
            lblRoute.Margin = new Padding(5, 0, 5, 0);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(141, 20);
            lblRoute.TabIndex = 15;
            lblRoute.Text = "License Expire Date:";
            // 
            // lblDepatureTime
            // 
            lblDepatureTime.AutoSize = true;
            lblDepatureTime.Location = new Point(661, 54);
            lblDepatureTime.Margin = new Padding(5, 0, 5, 0);
            lblDepatureTime.Name = "lblDepatureTime";
            lblDepatureTime.Size = new Size(118, 20);
            lblDepatureTime.TabIndex = 16;
            lblDepatureTime.Text = "License Number:";
            // 
            // panelInput
            // 
            panelInput.BorderStyle = BorderStyle.FixedSingle;
            panelInput.Controls.Add(groupBoxTrip);
            panelInput.Dock = DockStyle.Fill;
            panelInput.Location = new Point(5, 6);
            panelInput.Margin = new Padding(5, 6, 5, 6);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(1324, 261);
            panelInput.TabIndex = 18;
            // 
            // groupBoxTrip
            // 
            groupBoxTrip.Controls.Add(tableLayoutPanel2);
            groupBoxTrip.Dock = DockStyle.Fill;
            groupBoxTrip.ForeColor = Color.FromArgb(224, 224, 224);
            groupBoxTrip.Location = new Point(0, 0);
            groupBoxTrip.Margin = new Padding(5, 6, 5, 6);
            groupBoxTrip.Name = "groupBoxTrip";
            groupBoxTrip.Padding = new Padding(5, 6, 5, 6);
            groupBoxTrip.Size = new Size(1322, 259);
            groupBoxTrip.TabIndex = 0;
            groupBoxTrip.TabStop = false;
            groupBoxTrip.Text = "Driver Form";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(txtLicenseType, 3, 0);
            tableLayoutPanel2.Controls.Add(lblTripId, 0, 0);
            tableLayoutPanel2.Controls.Add(btnClear, 2, 3);
            tableLayoutPanel2.Controls.Add(lblVehicle, 0, 1);
            tableLayoutPanel2.Controls.Add(btnAdd, 0, 3);
            tableLayoutPanel2.Controls.Add(lblStatus, 0, 2);
            tableLayoutPanel2.Controls.Add(btnUpdate, 1, 3);
            tableLayoutPanel2.Controls.Add(cmbAvailability, 1, 2);
            tableLayoutPanel2.Controls.Add(cmbStaff, 1, 1);
            tableLayoutPanel2.Controls.Add(txtDriverID, 1, 0);
            tableLayoutPanel2.Controls.Add(txtLicenseNumber, 3, 1);
            tableLayoutPanel2.Controls.Add(dtpLicenseExpiryDate, 3, 2);
            tableLayoutPanel2.Controls.Add(lblRoute, 2, 2);
            tableLayoutPanel2.Controls.Add(lbLicenseType, 2, 0);
            tableLayoutPanel2.Controls.Add(lblDepatureTime, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 26);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.9328F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.9327965F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.9327965F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.20161F));
            tableLayoutPanel2.Size = new Size(1312, 227);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // txtLicenseType
            // 
            txtLicenseType.Dock = DockStyle.Fill;
            txtLicenseType.Font = new Font("Segoe UI", 14F);
            txtLicenseType.Location = new Point(986, 2);
            txtLicenseType.Margin = new Padding(2);
            txtLicenseType.Name = "txtLicenseType";
            txtLicenseType.Size = new Size(324, 39);
            txtLicenseType.TabIndex = 20;
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Dock = DockStyle.Fill;
            txtLicenseNumber.Font = new Font("Segoe UI", 14F);
            txtLicenseNumber.Location = new Point(986, 56);
            txtLicenseNumber.Margin = new Padding(2);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(324, 39);
            txtLicenseNumber.TabIndex = 19;
            // 
            // lbLicenseType
            // 
            lbLicenseType.AutoSize = true;
            lbLicenseType.Location = new Point(661, 0);
            lbLicenseType.Margin = new Padding(5, 0, 5, 0);
            lbLicenseType.Name = "lbLicenseType";
            lbLicenseType.Size = new Size(91, 20);
            lbLicenseType.TabIndex = 18;
            lbLicenseType.Text = "LicenseType:";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(8, 28);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1314, 27);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += PerformSearch;
            // 
            // dgvDrivers
            // 
            dgvDrivers.AllowUserToAddRows = false;
            dgvDrivers.AllowUserToDeleteRows = false;
            dgvDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDrivers.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDrivers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDrivers.Dock = DockStyle.Fill;
            dgvDrivers.Location = new Point(8, 28);
            dgvDrivers.Margin = new Padding(5, 6, 5, 6);
            dgvDrivers.MultiSelect = false;
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.ReadOnly = true;
            dgvDrivers.RowHeadersWidth = 62;
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvDrivers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrivers.Size = new Size(1314, 354);
            dgvDrivers.TabIndex = 0;
            dgvDrivers.SelectionChanged += DgvDrivers_SelectionChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(22, 28, 36);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(gbSearch, 0, 1);
            tableLayoutPanel1.Controls.Add(panelInput, 0, 0);
            tableLayoutPanel1.Controls.Add(gbTripList, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.66867F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.677846F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.6534843F));
            tableLayoutPanel1.Size = new Size(1334, 746);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(txtSearch);
            gbSearch.Dock = DockStyle.Fill;
            gbSearch.ForeColor = Color.FromArgb(224, 224, 224);
            gbSearch.Location = new Point(2, 275);
            gbSearch.Margin = new Padding(2);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(8);
            gbSearch.Size = new Size(1330, 75);
            gbSearch.TabIndex = 19;
            gbSearch.TabStop = false;
            gbSearch.Text = "Search";
            // 
            // gbTripList
            // 
            gbTripList.Controls.Add(dgvDrivers);
            gbTripList.Dock = DockStyle.Fill;
            gbTripList.ForeColor = Color.FromArgb(224, 224, 224);
            gbTripList.Location = new Point(2, 354);
            gbTripList.Margin = new Padding(2);
            gbTripList.Name = "gbTripList";
            gbTripList.Padding = new Padding(8);
            gbTripList.Size = new Size(1330, 390);
            gbTripList.TabIndex = 20;
            gbTripList.TabStop = false;
            gbTripList.Text = "Driver's List";
            // 
            // FormDriver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 746);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormDriver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trip Management";
            WindowState = FormWindowState.Maximized;
            panelInput.ResumeLayout(false);
            groupBoxTrip.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            gbTripList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtDriverID;
        private System.Windows.Forms.ComboBox cmbStaff;
        private System.Windows.Forms.ComboBox cmbAvailability;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.DateTimePicker dtpLicenseExpiryDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTripId;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label lblDepatureTime;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.GroupBox groupBoxTrip;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lbLicenseType;
        private ComboBox cmbStatus;
        private TextBox txtSearch;
        private DataGridView dgvDrivers;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox gbSearch;
        private GroupBox gbTripList;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox txtLicenseNumber;
        private TextBox txtLicenseType;
    }
}