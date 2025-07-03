namespace tms.Forms
{
    partial class FormTrip
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
                (tripRepository as IDisposable)?.Dispose();
                (vehicleRepository as IDisposable)?.Dispose();
                (driverRepository as IDisposable)?.Dispose();
                (routeRepository as IDisposable)?.Dispose();

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
            txtTripId = new TextBox();
            cmbVehicle = new ComboBox();
            cmbDriver = new ComboBox();
            cmbRoute = new ComboBox();
            dtpDepatureTime = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            lblTripId = new Label();
            lblVehicle = new Label();
            lblDriver = new Label();
            lblRoute = new Label();
            lblDepatureTime = new Label();
            panelInput = new Panel();
            groupBoxTrip = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            cmbStatus = new ComboBox();
            lbStatus = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvTrips = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            gbSearch = new GroupBox();
            gbTripList = new GroupBox();
            panelInput.SuspendLayout();
            groupBoxTrip.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrips).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            gbSearch.SuspendLayout();
            gbTripList.SuspendLayout();
            SuspendLayout();
            // 
            // txtTripId
            // 
            txtTripId.Dock = DockStyle.Fill;
            txtTripId.Location = new Point(291, 4);
            txtTripId.Margin = new Padding(4);
            txtTripId.Name = "txtTripId";
            txtTripId.ReadOnly = true;
            txtTripId.Size = new Size(279, 23);
            txtTripId.TabIndex = 1;
            txtTripId.TextChanged += txtTripId_TextChanged;
            // 
            // cmbVehicle
            // 
            cmbVehicle.Dock = DockStyle.Fill;
            cmbVehicle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicle.DropDownWidth = 250;
            cmbVehicle.FormattingEnabled = true;
            cmbVehicle.Location = new Point(291, 39);
            cmbVehicle.Margin = new Padding(4);
            cmbVehicle.MaxLength = 110;
            cmbVehicle.Name = "cmbVehicle";
            cmbVehicle.Size = new Size(279, 23);
            cmbVehicle.TabIndex = 2;
            // 
            // cmbDriver
            // 
            cmbDriver.Dock = DockStyle.Fill;
            cmbDriver.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDriver.DropDownWidth = 250;
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Location = new Point(291, 74);
            cmbDriver.Margin = new Padding(4);
            cmbDriver.MaxLength = 110;
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(279, 23);
            cmbDriver.TabIndex = 3;
            // 
            // cmbRoute
            // 
            cmbRoute.Dock = DockStyle.Fill;
            cmbRoute.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoute.DropDownWidth = 250;
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(865, 74);
            cmbRoute.Margin = new Padding(4);
            cmbRoute.MaxLength = 110;
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(280, 23);
            cmbRoute.TabIndex = 4;
            // 
            // dtpDepatureTime
            // 
            dtpDepatureTime.Dock = DockStyle.Fill;
            dtpDepatureTime.Format = DateTimePickerFormat.Short;
            dtpDepatureTime.Location = new Point(865, 4);
            dtpDepatureTime.Margin = new Padding(4);
            dtpDepatureTime.Name = "dtpDepatureTime";
            dtpDepatureTime.Size = new Size(280, 23);
            dtpDepatureTime.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(4, 109);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(291, 109);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 27);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(865, 109);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 27);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(578, 109);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 27);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // lblTripId
            // 
            lblTripId.AutoSize = true;
            lblTripId.Location = new Point(4, 0);
            lblTripId.Margin = new Padding(4, 0, 4, 0);
            lblTripId.Name = "lblTripId";
            lblTripId.Size = new Size(44, 15);
            lblTripId.TabIndex = 12;
            lblTripId.Text = "Trip ID:";
            // 
            // lblVehicle
            // 
            lblVehicle.AutoSize = true;
            lblVehicle.Location = new Point(4, 35);
            lblVehicle.Margin = new Padding(4, 0, 4, 0);
            lblVehicle.Name = "lblVehicle";
            lblVehicle.Size = new Size(47, 15);
            lblVehicle.TabIndex = 13;
            lblVehicle.Text = "Vehicle:";
            // 
            // lblDriver
            // 
            lblDriver.AutoSize = true;
            lblDriver.Location = new Point(4, 70);
            lblDriver.Margin = new Padding(4, 0, 4, 0);
            lblDriver.Name = "lblDriver";
            lblDriver.Size = new Size(41, 15);
            lblDriver.TabIndex = 14;
            lblDriver.Text = "Driver:";
            // 
            // lblRoute
            // 
            lblRoute.AutoSize = true;
            lblRoute.Location = new Point(578, 70);
            lblRoute.Margin = new Padding(4, 0, 4, 0);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(41, 15);
            lblRoute.TabIndex = 15;
            lblRoute.Text = "Route:";
            // 
            // lblDepatureTime
            // 
            lblDepatureTime.AutoSize = true;
            lblDepatureTime.Location = new Point(578, 0);
            lblDepatureTime.Margin = new Padding(4, 0, 4, 0);
            lblDepatureTime.Name = "lblDepatureTime";
            lblDepatureTime.Size = new Size(85, 15);
            lblDepatureTime.TabIndex = 16;
            lblDepatureTime.Text = "Depature Date:";
            // 
            // panelInput
            // 
            panelInput.BorderStyle = BorderStyle.FixedSingle;
            panelInput.Controls.Add(groupBoxTrip);
            panelInput.Dock = DockStyle.Fill;
            panelInput.Location = new Point(4, 4);
            panelInput.Margin = new Padding(4);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(1159, 176);
            panelInput.TabIndex = 18;
            // 
            // groupBoxTrip
            // 
            groupBoxTrip.Controls.Add(tableLayoutPanel2);
            groupBoxTrip.Dock = DockStyle.Fill;
            groupBoxTrip.ForeColor = Color.FromArgb(224, 224, 224);
            groupBoxTrip.Location = new Point(0, 0);
            groupBoxTrip.Margin = new Padding(4);
            groupBoxTrip.Name = "groupBoxTrip";
            groupBoxTrip.Padding = new Padding(4);
            groupBoxTrip.Size = new Size(1157, 174);
            groupBoxTrip.TabIndex = 0;
            groupBoxTrip.TabStop = false;
            groupBoxTrip.Text = "Trip Details";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(lblTripId, 0, 0);
            tableLayoutPanel2.Controls.Add(btnClear, 2, 3);
            tableLayoutPanel2.Controls.Add(btnAdd, 0, 3);
            tableLayoutPanel2.Controls.Add(dtpDepatureTime, 3, 0);
            tableLayoutPanel2.Controls.Add(cmbStatus, 3, 1);
            tableLayoutPanel2.Controls.Add(cmbRoute, 3, 2);
            tableLayoutPanel2.Controls.Add(btnUpdate, 1, 3);
            tableLayoutPanel2.Controls.Add(cmbDriver, 1, 2);
            tableLayoutPanel2.Controls.Add(cmbVehicle, 1, 1);
            tableLayoutPanel2.Controls.Add(txtTripId, 1, 0);
            tableLayoutPanel2.Controls.Add(btnDelete, 3, 3);
            tableLayoutPanel2.Controls.Add(lblDepatureTime, 2, 0);
            tableLayoutPanel2.Controls.Add(lblRoute, 2, 2);
            tableLayoutPanel2.Controls.Add(lbStatus, 2, 1);
            tableLayoutPanel2.Controls.Add(lblVehicle, 0, 1);
            tableLayoutPanel2.Controls.Add(lblDriver, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 20);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.9328F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.9327965F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.9327965F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.20161F));
            tableLayoutPanel2.Size = new Size(1149, 150);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(865, 39);
            cmbStatus.Margin = new Padding(4);
            cmbStatus.MaxLength = 110;
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(280, 23);
            cmbStatus.TabIndex = 17;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(578, 35);
            lbStatus.Margin = new Padding(4, 0, 4, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(42, 15);
            lbStatus.TabIndex = 18;
            lbStatus.Text = "Status:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(545, 25);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 24);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += BtnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(24, 28);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(507, 23);
            txtSearch.TabIndex = 6;
            txtSearch.KeyPress += BtnSearch_Click;
            // 
            // dgvTrips
            // 
            dgvTrips.AllowUserToAddRows = false;
            dgvTrips.AllowUserToDeleteRows = false;
            dgvTrips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrips.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTrips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTrips.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTrips.Dock = DockStyle.Fill;
            dgvTrips.Location = new Point(7, 22);
            dgvTrips.Margin = new Padding(4);
            dgvTrips.MultiSelect = false;
            dgvTrips.Name = "dgvTrips";
            dgvTrips.ReadOnly = true;
            dgvTrips.RowHeadersWidth = 62;
            dgvTrips.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrips.Size = new Size(1149, 235);
            dgvTrips.TabIndex = 0;
            dgvTrips.CellContentClick += dgvTrips_CellContentClick;
            dgvTrips.SelectionChanged += DgvTrips_SelectionChanged;
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
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0015945F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6105728F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.3878326F));
            tableLayoutPanel1.Size = new Size(1167, 560);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(txtSearch);
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Dock = DockStyle.Fill;
            gbSearch.ForeColor = Color.FromArgb(224, 224, 224);
            gbSearch.Location = new Point(2, 186);
            gbSearch.Margin = new Padding(2);
            gbSearch.Name = "gbSearch";
            gbSearch.Padding = new Padding(2);
            gbSearch.Size = new Size(1163, 105);
            gbSearch.TabIndex = 19;
            gbSearch.TabStop = false;
            gbSearch.Text = "Search";
            gbSearch.Enter += gbSearch_Enter;
            // 
            // gbTripList
            // 
            gbTripList.Controls.Add(dgvTrips);
            gbTripList.Dock = DockStyle.Fill;
            gbTripList.ForeColor = Color.FromArgb(224, 224, 224);
            gbTripList.Location = new Point(2, 295);
            gbTripList.Margin = new Padding(2);
            gbTripList.Name = "gbTripList";
            gbTripList.Padding = new Padding(7, 6, 7, 6);
            gbTripList.Size = new Size(1163, 263);
            gbTripList.TabIndex = 20;
            gbTripList.TabStop = false;
            gbTripList.Text = "Trip's List";
            // 
            // FormTrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 560);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            Name = "FormTrip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trip Management";
            WindowState = FormWindowState.Maximized;
            panelInput.ResumeLayout(false);
            groupBoxTrip.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrips).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            gbTripList.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox txtTripId;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.DateTimePicker dtpDepatureTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTripId;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label lblDepatureTime;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.GroupBox groupBoxTrip;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lbStatus;
        private ComboBox cmbStatus;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvTrips;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox gbSearch;
        private GroupBox gbTripList;
        private TableLayoutPanel tableLayoutPanel2;
    }
}