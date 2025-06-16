namespace tms.Forms
{
    partial class FormVehicle
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
            btnClear = new Button();
            btnLogOut = new Button();
            groupBoxVehicle = new GroupBox();
            gbVehicle1 = new GroupBox();
            groupBoxVehicleInfo = new GroupBox();
            groupBoxVehicle.SuspendLayout();
            gbVehicle1.SuspendLayout();
            groupBoxVehicleInfo.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(24, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(369, 23);
            txtSearch.TabIndex = 1;
            // 
            // lstVehicles
            // 
            lstVehicles.ItemHeight = 15;
            lstVehicles.Location = new Point(24, 92);
            lstVehicles.Name = "lstVehicles";
            lstVehicles.Size = new Size(369, 394);
            lstVehicles.TabIndex = 2;
            // 
            // lblVehicleID
            // 
            lblVehicleID.BackColor = Color.Transparent;
            lblVehicleID.ForeColor = Color.Black;
            lblVehicleID.Location = new Point(49, 50);
            lblVehicleID.Name = "lblVehicleID";
            lblVehicleID.Size = new Size(100, 23);
            lblVehicleID.TabIndex = 3;
            lblVehicleID.Text = "VehicleID";
            // 
            // txtVehicleID
            // 
            txtVehicleID.Location = new Point(169, 50);
            txtVehicleID.Name = "txtVehicleID";
            txtVehicleID.Size = new Size(364, 23);
            txtVehicleID.TabIndex = 4;
            // 
            // lblType
            // 
            lblType.BackColor = Color.Transparent;
            lblType.ForeColor = Color.Black;
            lblType.Location = new Point(49, 93);
            lblType.Name = "lblType";
            lblType.Size = new Size(100, 23);
            lblType.TabIndex = 5;
            lblType.Text = "Type";
            // 
            // cmbType
            // 
            cmbType.Location = new Point(169, 93);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(364, 23);
            cmbType.TabIndex = 6;
            // 
            // lblCapacity
            // 
            lblCapacity.BackColor = Color.Transparent;
            lblCapacity.ForeColor = Color.Black;
            lblCapacity.Location = new Point(49, 133);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(100, 23);
            lblCapacity.TabIndex = 7;
            lblCapacity.Text = "Capacity";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(169, 133);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(364, 23);
            txtCapacity.TabIndex = 8;
            // 
            // lblLicensePlate
            // 
            lblLicensePlate.BackColor = Color.Transparent;
            lblLicensePlate.ForeColor = Color.Black;
            lblLicensePlate.Location = new Point(49, 176);
            lblLicensePlate.Name = "lblLicensePlate";
            lblLicensePlate.Size = new Size(100, 23);
            lblLicensePlate.TabIndex = 9;
            lblLicensePlate.Text = "Licence Plate";
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.Location = new Point(169, 173);
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(364, 23);
            txtLicensePlate.TabIndex = 10;
            // 
            // lblRouteID
            // 
            lblRouteID.BackColor = Color.Transparent;
            lblRouteID.ForeColor = Color.Black;
            lblRouteID.Location = new Point(49, 216);
            lblRouteID.Name = "lblRouteID";
            lblRouteID.Size = new Size(100, 23);
            lblRouteID.TabIndex = 11;
            lblRouteID.Text = "RouteID";
            // 
            // cmbRouteID
            // 
            cmbRouteID.Location = new Point(169, 216);
            cmbRouteID.Name = "cmbRouteID";
            cmbRouteID.Size = new Size(364, 23);
            cmbRouteID.TabIndex = 12;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(49, 272);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 23);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.Location = new Point(169, 269);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(364, 23);
            cmbStatus.TabIndex = 14;
            // 
            // lblMaintenanceDate
            // 
            lblMaintenanceDate.BackColor = Color.Transparent;
            lblMaintenanceDate.ForeColor = Color.Black;
            lblMaintenanceDate.Location = new Point(49, 324);
            lblMaintenanceDate.Name = "lblMaintenanceDate";
            lblMaintenanceDate.Size = new Size(100, 23);
            lblMaintenanceDate.TabIndex = 15;
            lblMaintenanceDate.Text = "Maintaining Data";
            // 
            // dtpMaintenanceDate
            // 
            dtpMaintenanceDate.Location = new Point(169, 324);
            dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            dtpMaintenanceDate.Size = new Size(364, 23);
            dtpMaintenanceDate.TabIndex = 16;
            // 
            // btnInsert
            // 
            btnInsert.ForeColor = Color.Black;
            btnInsert.Location = new Point(155, 40);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(132, 37);
            btnInsert.TabIndex = 17;
            btnInsert.Text = "Insert";
            // 
            // btnUpdate
            // 
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(17, 41);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 37);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            // 
            // btnClear
            // 
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(293, 41);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 37);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = SystemColors.ButtonHighlight;
            btnLogOut.Font = new Font("Arial", 9F);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(431, 41);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(132, 37);
            btnLogOut.TabIndex = 20;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // groupBoxVehicle
            // 
            groupBoxVehicle.Controls.Add(btnUpdate);
            groupBoxVehicle.Controls.Add(btnClear);
            groupBoxVehicle.Controls.Add(btnInsert);
            groupBoxVehicle.Controls.Add(btnLogOut);
            groupBoxVehicle.ForeColor = Color.Black;
            groupBoxVehicle.Location = new Point(469, 429);
            groupBoxVehicle.Name = "groupBoxVehicle";
            groupBoxVehicle.Size = new Size(582, 120);
            groupBoxVehicle.TabIndex = 21;
            groupBoxVehicle.TabStop = false;
            groupBoxVehicle.Text = "Action";
            // 
            // gbVehicle1
            // 
            gbVehicle1.Controls.Add(lblVehicleID);
            gbVehicle1.Controls.Add(txtCapacity);
            gbVehicle1.Controls.Add(txtVehicleID);
            gbVehicle1.Controls.Add(dtpMaintenanceDate);
            gbVehicle1.Controls.Add(lblType);
            gbVehicle1.Controls.Add(lblMaintenanceDate);
            gbVehicle1.Controls.Add(cmbType);
            gbVehicle1.Controls.Add(cmbStatus);
            gbVehicle1.Controls.Add(lblCapacity);
            gbVehicle1.Controls.Add(lblStatus);
            gbVehicle1.Controls.Add(cmbRouteID);
            gbVehicle1.Controls.Add(lblLicensePlate);
            gbVehicle1.Controls.Add(lblRouteID);
            gbVehicle1.Controls.Add(txtLicensePlate);
            gbVehicle1.ForeColor = Color.Black;
            gbVehicle1.Location = new Point(469, 32);
            gbVehicle1.Name = "gbVehicle1";
            gbVehicle1.Size = new Size(582, 380);
            gbVehicle1.TabIndex = 22;
            gbVehicle1.TabStop = false;
            gbVehicle1.Text = "Vehicle Form";
            // 
            // groupBoxVehicleInfo
            // 
            groupBoxVehicleInfo.Controls.Add(lstVehicles);
            groupBoxVehicleInfo.Controls.Add(txtSearch);
            groupBoxVehicleInfo.ForeColor = Color.Black;
            groupBoxVehicleInfo.Location = new Point(31, 32);
            groupBoxVehicleInfo.Name = "groupBoxVehicleInfo";
            groupBoxVehicleInfo.Size = new Size(415, 517);
            groupBoxVehicleInfo.TabIndex = 23;
            groupBoxVehicleInfo.TabStop = false;
            groupBoxVehicleInfo.Text = "Search";
            // 
            // FormVehicle
            // 
            ClientSize = new Size(1069, 607);
            Controls.Add(groupBoxVehicle);
            Controls.Add(gbVehicle1);
            Controls.Add(groupBoxVehicleInfo);
            ForeColor = Color.White;
            Name = "FormVehicle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehicle's Information";
            Load += FormVehicle_Load;
            groupBoxVehicle.ResumeLayout(false);
            gbVehicle1.ResumeLayout(false);
            gbVehicle1.PerformLayout();
            groupBoxVehicleInfo.ResumeLayout(false);
            groupBoxVehicleInfo.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLogOut;
        private GroupBox groupBoxVehicle;
        private GroupBox gbVehicle1;
        private GroupBox groupBoxVehicleInfo;
    }
}