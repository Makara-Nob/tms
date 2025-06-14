namespace tms.Forms
{
    partial class VehicleUpdateForm
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
            lblVehicleID = new Label();
            lblType = new Label();
            lblCapacity = new Label();
            lblLicensePlate = new Label();
            lblRouteID = new Label();
            lblStatus = new Label();
            txtVehicleID = new TextBox();
            cmbType = new ComboBox();
            txtCapacity = new TextBox();
            txtLicensePlate = new TextBox();
            cmbRouteID = new ComboBox();
            cmbStatus = new ComboBox();
            dtpMaintenanceDate = new DateTimePicker();
            chkHasMaintenanceDate = new CheckBox();
            btnUpdate = new Button();
            btnCancel = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // lblVehicleID
            // 
            lblVehicleID.ForeColor = Color.Black;
            lblVehicleID.Location = new Point(20, 20);
            lblVehicleID.Name = "lblVehicleID";
            lblVehicleID.Size = new Size(100, 23);
            lblVehicleID.TabIndex = 0;
            lblVehicleID.Text = "Vehicle ID";
            // 
            // lblType
            // 
            lblType.ForeColor = Color.Black;
            lblType.Location = new Point(20, 60);
            lblType.Name = "lblType";
            lblType.Size = new Size(100, 23);
            lblType.TabIndex = 2;
            lblType.Text = "Type *";
            // 
            // lblCapacity
            // 
            lblCapacity.ForeColor = Color.Black;
            lblCapacity.Location = new Point(20, 100);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(100, 23);
            lblCapacity.TabIndex = 4;
            lblCapacity.Text = "Capacity";
            // 
            // lblLicensePlate
            // 
            lblLicensePlate.ForeColor = Color.Black;
            lblLicensePlate.Location = new Point(20, 140);
            lblLicensePlate.Name = "lblLicensePlate";
            lblLicensePlate.Size = new Size(100, 23);
            lblLicensePlate.TabIndex = 6;
            lblLicensePlate.Text = "License Plate";
            // 
            // lblRouteID
            // 
            lblRouteID.ForeColor = Color.Black;
            lblRouteID.Location = new Point(20, 180);
            lblRouteID.Name = "lblRouteID";
            lblRouteID.Size = new Size(100, 23);
            lblRouteID.TabIndex = 8;
            lblRouteID.Text = "Route ID";
            // 
            // lblStatus
            // 
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(20, 220);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 23);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            // 
            // txtVehicleID
            // 
            txtVehicleID.BackColor = Color.LightGray;
            txtVehicleID.Location = new Point(140, 20);
            txtVehicleID.Name = "txtVehicleID";
            txtVehicleID.ReadOnly = true;
            txtVehicleID.Size = new Size(250, 23);
            txtVehicleID.TabIndex = 1;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.Location = new Point(140, 60);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(250, 23);
            cmbType.TabIndex = 3;
            // 
            // txtCapacity
            // 
            txtCapacity.BackColor = Color.White;
            txtCapacity.Location = new Point(140, 100);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(250, 23);
            txtCapacity.TabIndex = 5;
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.BackColor = Color.White;
            txtLicensePlate.Location = new Point(140, 140);
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(250, 23);
            txtLicensePlate.TabIndex = 7;
            // 
            // cmbRouteID
            // 
            cmbRouteID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRouteID.Location = new Point(140, 180);
            cmbRouteID.Name = "cmbRouteID";
            cmbRouteID.Size = new Size(250, 23);
            cmbRouteID.TabIndex = 9;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Location = new Point(140, 220);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(250, 23);
            cmbStatus.TabIndex = 11;
            // 
            // dtpMaintenanceDate
            // 
            dtpMaintenanceDate.Location = new Point(180, 260);
            dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            dtpMaintenanceDate.Size = new Size(210, 23);
            dtpMaintenanceDate.TabIndex = 13;
            // 
            // chkHasMaintenanceDate
            // 
            chkHasMaintenanceDate.ForeColor = Color.Black;
            chkHasMaintenanceDate.Location = new Point(20, 260);
            chkHasMaintenanceDate.Name = "chkHasMaintenanceDate";
            chkHasMaintenanceDate.Size = new Size(150, 23);
            chkHasMaintenanceDate.TabIndex = 12;
            chkHasMaintenanceDate.Text = "Set Maintenance Date";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.LightGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(140, 320);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 30);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(310, 320);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.LightBlue;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Location = new Point(225, 320);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 30);
            btnReset.TabIndex = 15;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // VehicleUpdateForm
            // 
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(450, 400);
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
            Controls.Add(chkHasMaintenanceDate);
            Controls.Add(dtpMaintenanceDate);
            Controls.Add(btnUpdate);
            Controls.Add(btnReset);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "VehicleUpdateForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Update Vehicle";
            Load += VehicleUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVehicleID;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblLicensePlate;
        private System.Windows.Forms.Label lblRouteID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtCapacity;
        private System.Windows.Forms.TextBox txtLicensePlate;
        private System.Windows.Forms.ComboBox cmbRouteID;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.DateTimePicker dtpMaintenanceDate;
        private System.Windows.Forms.CheckBox chkHasMaintenanceDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReset;
    }
}