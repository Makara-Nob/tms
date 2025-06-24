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
            txtTripId.Location = new Point(416, 6);
            txtTripId.Margin = new Padding(5, 6, 5, 6);
            txtTripId.Name = "txtTripId";
            txtTripId.ReadOnly = true;
            txtTripId.Size = new Size(401, 31);
            txtTripId.TabIndex = 1;
            txtTripId.TextChanged += txtTripId_TextChanged;
            // 
            // cmbVehicle
            // 
            cmbVehicle.Dock = DockStyle.Fill;
            cmbVehicle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicle.FormattingEnabled = true;
            cmbVehicle.Location = new Point(416, 67);
            cmbVehicle.Margin = new Padding(5, 6, 5, 6);
            cmbVehicle.Name = "cmbVehicle";
            cmbVehicle.Size = new Size(401, 33);
            cmbVehicle.TabIndex = 2;
            // 
            // cmbDriver
            // 
            cmbDriver.Dock = DockStyle.Fill;
            cmbDriver.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Location = new Point(416, 128);
            cmbDriver.Margin = new Padding(5, 6, 5, 6);
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(401, 33);
            cmbDriver.TabIndex = 3;
            // 
            // cmbRoute
            // 
            cmbRoute.Dock = DockStyle.Fill;
            cmbRoute.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(1238, 128);
            cmbRoute.Margin = new Padding(5, 6, 5, 6);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(402, 33);
            cmbRoute.TabIndex = 4;
            // 
            // dtpDepatureTime
            // 
            dtpDepatureTime.Dock = DockStyle.Fill;
            dtpDepatureTime.Format = DateTimePickerFormat.Short;
            dtpDepatureTime.Location = new Point(1238, 6);
            dtpDepatureTime.Margin = new Padding(5, 6, 5, 6);
            dtpDepatureTime.Name = "dtpDepatureTime";
            dtpDepatureTime.Size = new Size(402, 31);
            dtpDepatureTime.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(5, 189);
            btnAdd.Margin = new Padding(5, 6, 5, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 45);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(416, 189);
            btnUpdate.Margin = new Padding(5, 6, 5, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 45);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(1238, 189);
            btnDelete.Margin = new Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 45);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(827, 189);
            btnClear.Margin = new Padding(5, 6, 5, 6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 45);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // lblTripId
            // 
            lblTripId.AutoSize = true;
            lblTripId.Location = new Point(22, 41);
            lblTripId.Margin = new Padding(5, 0, 5, 0);
            lblTripId.Name = "lblTripId";
            lblTripId.Size = new Size(67, 25);
            lblTripId.TabIndex = 12;
            lblTripId.Text = "Trip ID:";
            // 
            // lblVehicle
            // 
            lblVehicle.AutoSize = true;
            lblVehicle.Location = new Point(22, 83);
            lblVehicle.Margin = new Padding(5, 0, 5, 0);
            lblVehicle.Name = "lblVehicle";
            lblVehicle.Size = new Size(70, 25);
            lblVehicle.TabIndex = 13;
            lblVehicle.Text = "Vehicle:";
            // 
            // lblDriver
            // 
            lblDriver.AutoSize = true;
            lblDriver.Location = new Point(22, 128);
            lblDriver.Margin = new Padding(5, 0, 5, 0);
            lblDriver.Name = "lblDriver";
            lblDriver.Size = new Size(63, 25);
            lblDriver.TabIndex = 14;
            lblDriver.Text = "Driver:";
            // 
            // lblRoute
            // 
            lblRoute.AutoSize = true;
            lblRoute.Location = new Point(827, 0);
            lblRoute.Margin = new Padding(5, 0, 5, 0);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(62, 25);
            lblRoute.TabIndex = 15;
            lblRoute.Text = "Route:";
            // 
            // lblDepatureTime
            // 
            lblDepatureTime.AutoSize = true;
            lblDepatureTime.Location = new Point(827, 61);
            lblDepatureTime.Margin = new Padding(5, 0, 5, 0);
            lblDepatureTime.Name = "lblDepatureTime";
            lblDepatureTime.Size = new Size(131, 25);
            lblDepatureTime.TabIndex = 16;
            lblDepatureTime.Text = "Depature Date:";
            // 
            // panelInput
            // 
            panelInput.BorderStyle = BorderStyle.FixedSingle;
            panelInput.Controls.Add(groupBoxTrip);
            panelInput.Dock = DockStyle.Fill;
            panelInput.Location = new Point(5, 6);
            panelInput.Margin = new Padding(5, 6, 5, 6);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(1657, 296);
            panelInput.TabIndex = 18;
            // 
            // groupBoxTrip
            // 
            groupBoxTrip.Controls.Add(lblTripId);
            groupBoxTrip.Controls.Add(lblVehicle);
            groupBoxTrip.Controls.Add(lblDriver);
            groupBoxTrip.Controls.Add(tableLayoutPanel2);
            groupBoxTrip.Dock = DockStyle.Fill;
            groupBoxTrip.ForeColor = Color.FromArgb(224, 224, 224);
            groupBoxTrip.Location = new Point(0, 0);
            groupBoxTrip.Margin = new Padding(5, 6, 5, 6);
            groupBoxTrip.Name = "groupBoxTrip";
            groupBoxTrip.Padding = new Padding(5, 6, 5, 6);
            groupBoxTrip.Size = new Size(1655, 294);
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
            tableLayoutPanel2.Controls.Add(btnClear, 2, 3);
            tableLayoutPanel2.Controls.Add(btnAdd, 0, 3);
            tableLayoutPanel2.Controls.Add(dtpDepatureTime, 3, 0);
            tableLayoutPanel2.Controls.Add(cmbStatus, 3, 1);
            tableLayoutPanel2.Controls.Add(cmbRoute, 3, 2);
            tableLayoutPanel2.Controls.Add(btnUpdate, 1, 3);
            tableLayoutPanel2.Controls.Add(lbStatus, 2, 2);
            tableLayoutPanel2.Controls.Add(lblRoute, 2, 0);
            tableLayoutPanel2.Controls.Add(lblDepatureTime, 2, 1);
            tableLayoutPanel2.Controls.Add(cmbDriver, 1, 2);
            tableLayoutPanel2.Controls.Add(cmbVehicle, 1, 1);
            tableLayoutPanel2.Controls.Add(txtTripId, 1, 0);
            tableLayoutPanel2.Controls.Add(btnDelete, 3, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(5, 30);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.9328F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.9327965F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.9327965F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.20161F));
            tableLayoutPanel2.Size = new Size(1645, 258);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(1238, 67);
            cmbStatus.Margin = new Padding(5, 6, 5, 6);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(402, 33);
            cmbStatus.TabIndex = 17;
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(827, 122);
            lbStatus.Margin = new Padding(5, 0, 5, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(64, 25);
            lbStatus.TabIndex = 18;
            lbStatus.Text = "Status:";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.White;
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(779, 41);
            btnSearch.Margin = new Padding(5, 6, 5, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 40);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += BtnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(34, 46);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(723, 31);
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
            dgvTrips.Location = new Point(10, 34);
            dgvTrips.Margin = new Padding(5, 6, 5, 6);
            dgvTrips.MultiSelect = false;
            dgvTrips.Name = "dgvTrips";
            dgvTrips.ReadOnly = true;
            dgvTrips.RowHeadersWidth = 62;
            dgvTrips.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrips.Size = new Size(1641, 393);
            dgvTrips.TabIndex = 0;
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.0015945F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.6105728F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 47.3878326F));
            tableLayoutPanel1.Size = new Size(1667, 934);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(txtSearch);
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Dock = DockStyle.Fill;
            gbSearch.ForeColor = Color.FromArgb(224, 224, 224);
            gbSearch.Location = new Point(3, 311);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(1661, 177);
            gbSearch.TabIndex = 19;
            gbSearch.TabStop = false;
            gbSearch.Text = "Search";
            // 
            // gbTripList
            // 
            gbTripList.Controls.Add(dgvTrips);
            gbTripList.Dock = DockStyle.Fill;
            gbTripList.ForeColor = Color.FromArgb(224, 224, 224);
            gbTripList.Location = new Point(3, 494);
            gbTripList.Name = "gbTripList";
            gbTripList.Padding = new Padding(10);
            gbTripList.Size = new Size(1661, 437);
            gbTripList.TabIndex = 20;
            gbTripList.TabStop = false;
            gbTripList.Text = "Trip's List";
            // 
            // FormTrip
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1667, 934);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormTrip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trip Management";
            WindowState = FormWindowState.Maximized;
            panelInput.ResumeLayout(false);
            groupBoxTrip.ResumeLayout(false);
            groupBoxTrip.PerformLayout();
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