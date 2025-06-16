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
            dgvTrips = new DataGridView();
            txtTripId = new TextBox();
            cmbVehicle = new ComboBox();
            cmbDriver = new ComboBox();
            cmbRoute = new ComboBox();
            dtpDepatureTime = new DateTimePicker();
            txtSearch = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnSearch = new Button();
            lblTripId = new Label();
            lblVehicle = new Label();
            lblDriver = new Label();
            lblRoute = new Label();
            lblDepatureTime = new Label();
            panelInput = new Panel();
            groupBoxTrip = new GroupBox();
            groupBox1 = new GroupBox();
            lbStatus = new Label();
            cmbStatus = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            gbSearch = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvTrips).BeginInit();
            panelInput.SuspendLayout();
            groupBoxTrip.SuspendLayout();
            groupBox1.SuspendLayout();
            gbSearch.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTrips
            // 
            dgvTrips.AllowUserToAddRows = false;
            dgvTrips.AllowUserToDeleteRows = false;
            dgvTrips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrips.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTrips.Location = new Point(53, 128);
            dgvTrips.Margin = new Padding(5, 6, 5, 6);
            dgvTrips.MultiSelect = false;
            dgvTrips.Name = "dgvTrips";
            dgvTrips.ReadOnly = true;
            dgvTrips.RowHeadersWidth = 62;
            dgvTrips.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrips.Size = new Size(968, 577);
            dgvTrips.TabIndex = 0;
            dgvTrips.SelectionChanged += DgvTrips_SelectionChanged;
            // 
            // txtTripId
            // 
            txtTripId.BackColor = Color.LightGray;
            txtTripId.Location = new Point(173, 35);
            txtTripId.Margin = new Padding(5, 6, 5, 6);
            txtTripId.Name = "txtTripId";
            txtTripId.ReadOnly = true;
            txtTripId.Size = new Size(260, 31);
            txtTripId.TabIndex = 1;
            txtTripId.TextChanged += txtTripId_TextChanged;
            // 
            // cmbVehicle
            // 
            cmbVehicle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicle.FormattingEnabled = true;
            cmbVehicle.Location = new Point(173, 83);
            cmbVehicle.Margin = new Padding(5, 6, 5, 6);
            cmbVehicle.Name = "cmbVehicle";
            cmbVehicle.Size = new Size(260, 33);
            cmbVehicle.TabIndex = 2;
            // 
            // cmbDriver
            // 
            cmbDriver.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDriver.FormattingEnabled = true;
            cmbDriver.Location = new Point(173, 128);
            cmbDriver.Margin = new Padding(5, 6, 5, 6);
            cmbDriver.Name = "cmbDriver";
            cmbDriver.Size = new Size(260, 33);
            cmbDriver.TabIndex = 3;
            // 
            // cmbRoute
            // 
            cmbRoute.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoute.FormattingEnabled = true;
            cmbRoute.Location = new Point(173, 173);
            cmbRoute.Margin = new Padding(5, 6, 5, 6);
            cmbRoute.Name = "cmbRoute";
            cmbRoute.Size = new Size(260, 33);
            cmbRoute.TabIndex = 4;
            // 
            // dtpDepatureTime
            // 
            dtpDepatureTime.Format = DateTimePickerFormat.Short;
            dtpDepatureTime.Location = new Point(173, 220);
            dtpDepatureTime.Margin = new Padding(5, 6, 5, 6);
            dtpDepatureTime.Name = "dtpDepatureTime";
            dtpDepatureTime.Size = new Size(260, 31);
            dtpDepatureTime.TabIndex = 5;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(53, 77);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(723, 31);
            txtSearch.TabIndex = 6;
            txtSearch.KeyPress += BtnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(19, 50);
            btnAdd.Margin = new Padding(5, 6, 5, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 58);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(154, 50);
            btnUpdate.Margin = new Padding(5, 6, 5, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 58);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(283, 50);
            btnDelete.Margin = new Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 58);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(19, 120);
            btnClear.Margin = new Padding(5, 6, 5, 6);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 58);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(786, 68);
            btnSearch.Margin = new Padding(5, 6, 5, 6);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 48);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += BtnSearch_Click;
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
            lblRoute.Location = new Point(22, 172);
            lblRoute.Margin = new Padding(5, 0, 5, 0);
            lblRoute.Name = "lblRoute";
            lblRoute.Size = new Size(62, 25);
            lblRoute.TabIndex = 15;
            lblRoute.Text = "Route:";
            // 
            // lblDepatureTime
            // 
            lblDepatureTime.AutoSize = true;
            lblDepatureTime.Location = new Point(22, 220);
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
            panelInput.Location = new Point(17, 19);
            panelInput.Margin = new Padding(5, 6, 5, 6);
            panelInput.Name = "panelInput";
            panelInput.Size = new Size(499, 767);
            panelInput.TabIndex = 18;
            // 
            // groupBoxTrip
            // 
            groupBoxTrip.Controls.Add(groupBox1);
            groupBoxTrip.Controls.Add(lbStatus);
            groupBoxTrip.Controls.Add(cmbStatus);
            groupBoxTrip.Controls.Add(lblTripId);
            groupBoxTrip.Controls.Add(txtTripId);
            groupBoxTrip.Controls.Add(lblVehicle);
            groupBoxTrip.Controls.Add(cmbVehicle);
            groupBoxTrip.Controls.Add(lblDriver);
            groupBoxTrip.Controls.Add(cmbDriver);
            groupBoxTrip.Controls.Add(lblRoute);
            groupBoxTrip.Controls.Add(cmbRoute);
            groupBoxTrip.Controls.Add(lblDepatureTime);
            groupBoxTrip.Controls.Add(dtpDepatureTime);
            groupBoxTrip.Dock = DockStyle.Fill;
            groupBoxTrip.Location = new Point(0, 0);
            groupBoxTrip.Margin = new Padding(5, 6, 5, 6);
            groupBoxTrip.Name = "groupBoxTrip";
            groupBoxTrip.Padding = new Padding(5, 6, 5, 6);
            groupBoxTrip.Size = new Size(497, 765);
            groupBoxTrip.TabIndex = 0;
            groupBoxTrip.TabStop = false;
            groupBoxTrip.Text = "Trip Information";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Location = new Point(22, 321);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 204);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Action";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(22, 263);
            lbStatus.Margin = new Padding(5, 0, 5, 0);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(64, 25);
            lbStatus.TabIndex = 18;
            lbStatus.Text = "Status:";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(173, 263);
            cmbStatus.Margin = new Padding(5, 6, 5, 6);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(260, 33);
            cmbStatus.TabIndex = 17;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(dgvTrips);
            gbSearch.Controls.Add(txtSearch);
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Location = new Point(550, 20);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(1071, 766);
            gbSearch.TabIndex = 19;
            gbSearch.TabStop = false;
            gbSearch.Text = "Search";
            // 
            // FormTrip
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1667, 829);
            Controls.Add(panelInput);
            Controls.Add(gbSearch);
            Margin = new Padding(5, 6, 5, 6);
            Name = "FormTrip";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trip Management";
            ((System.ComponentModel.ISupportInitialize)dgvTrips).EndInit();
            panelInput.ResumeLayout(false);
            groupBoxTrip.ResumeLayout(false);
            groupBoxTrip.PerformLayout();
            groupBox1.ResumeLayout(false);
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrips;
        private System.Windows.Forms.TextBox txtTripId;
        private System.Windows.Forms.ComboBox cmbVehicle;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.DateTimePicker dtpDepatureTime;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblTripId;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblRoute;
        private System.Windows.Forms.Label lblDepatureTime;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.GroupBox groupBoxTrip;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox gbSearch;
        private Label lbStatus;
        private ComboBox cmbStatus;
        private GroupBox groupBox1;
    }
}