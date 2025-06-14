namespace tms.Forms
{
    partial class VehicleInformationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblSearch = new Label();
            txtSearch = new TextBox();
            lstVehicles = new ListBox();
            lblVehicleID = new Label();
            txtVehicleID = new TextBox();
            lblType = new Label();
            cmbType = new ComboBox();
            lblCapacity = new Label();
            txtCapacity = new TextBox();
            lblLicensePlate = new Label();
            txtLicensePlate = new TextBox();
            lblRouteID = new Label();
            cmbRouteID = new ComboBox();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblMaintenanceDate = new Label();
            dtpMaintenanceDate = new DateTimePicker();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // lblSearch
            // 
            lblSearch.BackColor = Color.White;
            lblSearch.ForeColor = Color.Black;
            lblSearch.Location = new Point(12, 41);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(100, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(12, 81);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(369, 23);
            txtSearch.TabIndex = 1;
            // 
            // lstVehicles
            // 
            lstVehicles.ItemHeight = 15;
            lstVehicles.Location = new Point(12, 129);
            lstVehicles.Name = "lstVehicles";
            lstVehicles.Size = new Size(369, 304);
            lstVehicles.TabIndex = 2;
            // 
            // lblVehicleID
            // 
            lblVehicleID.BackColor = Color.White;
            lblVehicleID.ForeColor = Color.Black;
            lblVehicleID.Location = new Point(419, 41);
            lblVehicleID.Name = "lblVehicleID";
            lblVehicleID.Size = new Size(100, 23);
            lblVehicleID.TabIndex = 3;
            // 
            // txtVehicleID
            // 
            txtVehicleID.Location = new Point(539, 41);
            txtVehicleID.Name = "txtVehicleID";
            txtVehicleID.Size = new Size(334, 23);
            txtVehicleID.TabIndex = 4;
            txtVehicleID.Text = "Vehicle ID";
            // 
            // lblType
            // 
            lblType.BackColor = Color.White;
            lblType.ForeColor = Color.Black;
            lblType.Location = new Point(419, 84);
            lblType.Name = "lblType";
            lblType.Size = new Size(100, 23);
            lblType.TabIndex = 5;
            lblType.Text = "Type";
            // 
            // cmbType
            // 
            cmbType.Location = new Point(539, 84);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(334, 23);
            cmbType.TabIndex = 6;
            // 
            // lblCapacity
            // 
            lblCapacity.BackColor = Color.White;
            lblCapacity.ForeColor = Color.Black;
            lblCapacity.Location = new Point(419, 124);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(100, 23);
            lblCapacity.TabIndex = 7;
            lblCapacity.Text = "Capacity";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(539, 121);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(334, 23);
            txtCapacity.TabIndex = 8;
            // 
            // lblLicensePlate
            // 
            lblLicensePlate.BackColor = Color.White;
            lblLicensePlate.ForeColor = Color.Black;
            lblLicensePlate.Location = new Point(419, 167);
            lblLicensePlate.Name = "lblLicensePlate";
            lblLicensePlate.Size = new Size(100, 23);
            lblLicensePlate.TabIndex = 9;
            lblLicensePlate.Text = "Licence Plate";
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.Location = new Point(539, 164);
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(334, 23);
            txtLicensePlate.TabIndex = 10;
            // 
            // lblRouteID
            // 
            lblRouteID.BackColor = Color.White;
            lblRouteID.ForeColor = Color.Black;
            lblRouteID.Location = new Point(419, 207);
            lblRouteID.Name = "lblRouteID";
            lblRouteID.Size = new Size(100, 23);
            lblRouteID.TabIndex = 11;
            lblRouteID.Text = "RouteID";
            // 
            // cmbRouteID
            // 
            cmbRouteID.Location = new Point(539, 207);
            cmbRouteID.Name = "cmbRouteID";
            cmbRouteID.Size = new Size(334, 23);
            cmbRouteID.TabIndex = 12;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.White;
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(419, 263);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 23);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.Location = new Point(539, 263);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(334, 23);
            cmbStatus.TabIndex = 14;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // lblMaintenanceDate
            // 
            lblMaintenanceDate.BackColor = Color.White;
            lblMaintenanceDate.ForeColor = Color.Black;
            lblMaintenanceDate.Location = new Point(419, 315);
            lblMaintenanceDate.Name = "lblMaintenanceDate";
            lblMaintenanceDate.Size = new Size(100, 23);
            lblMaintenanceDate.TabIndex = 15;
            lblMaintenanceDate.Text = "Maintaining Data";
            // 
            // dtpMaintenanceDate
            // 
            dtpMaintenanceDate.Location = new Point(539, 315);
            dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            dtpMaintenanceDate.Size = new Size(334, 23);
            dtpMaintenanceDate.TabIndex = 16;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(395, 489);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 17;
            btnInsert.Text = "Insert";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(176, 489);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(284, 489);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 19;
            btnNew.Text = "New";
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(503, 489);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(75, 23);
            btnLogOut.TabIndex = 20;
            btnLogOut.Text = "Log Out";
            // 
            // VehicleInformationForm
            // 
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1609, 684);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(lstVehicles);
            Controls.Add(lblVehicleID);
            Controls.Add(txtVehicleID);
            Controls.Add(lblType);
            Controls.Add(cmbType);
            Controls.Add(lblCapacity);
            Controls.Add(txtCapacity);
            Controls.Add(lblLicensePlate);
            Controls.Add(txtLicensePlate);
            Controls.Add(lblRouteID);
            Controls.Add(cmbRouteID);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lblMaintenanceDate);
            Controls.Add(dtpMaintenanceDate);
            Controls.Add(btnInsert);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(btnLogOut);
            ForeColor = Color.White;
            Name = "VehicleInformationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehicle's Information";
            Load += VehicleInformationForm_Load_1;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstVehicles;
        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.Label lblRouteID;
        private System.Windows.Forms.ComboBox cmbRouteID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblMaintenanceDate;
        private System.Windows.Forms.DateTimePicker dtpMaintenanceDate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLogOut;
    }
}