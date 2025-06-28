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
            gbVehicle1 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBoxVehicleInfo = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            gbVehicle1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBoxVehicleInfo.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(24, 46);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(369, 31);
            txtSearch.TabIndex = 1;
            // 
            // lstVehicles
            // 
            lstVehicles.Dock = DockStyle.Fill;
            lstVehicles.ItemHeight = 25;
            lstVehicles.Location = new Point(3, 27);
            lstVehicles.Name = "lstVehicles";
            lstVehicles.Size = new Size(413, 1025);
            lstVehicles.TabIndex = 2;
            lstVehicles.SelectedIndexChanged += lstVehicles_SelectedIndexChanged_1;
            // 
            // lblVehicleID
            // 
            lblVehicleID.BackColor = Color.Transparent;
            lblVehicleID.ForeColor = Color.White;
            lblVehicleID.Location = new Point(3, 0);
            lblVehicleID.Name = "lblVehicleID";
            lblVehicleID.Size = new Size(100, 23);
            lblVehicleID.TabIndex = 3;
            lblVehicleID.Text = "VehicleID";
            // 
            // txtVehicleID
            // 
            txtVehicleID.Dock = DockStyle.Fill;
            txtVehicleID.Location = new Point(374, 3);
            txtVehicleID.Name = "txtVehicleID";
            txtVehicleID.Size = new Size(365, 31);
            txtVehicleID.TabIndex = 4;
            // 
            // lblType
            // 
            lblType.BackColor = Color.Transparent;
            lblType.ForeColor = Color.White;
            lblType.Location = new Point(745, 0);
            lblType.Name = "lblType";
            lblType.Size = new Size(100, 23);
            lblType.TabIndex = 5;
            lblType.Text = "Type";
            // 
            // cmbType
            // 
            cmbType.Dock = DockStyle.Fill;
            cmbType.Location = new Point(1116, 3);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(368, 33);
            cmbType.TabIndex = 6;
            // 
            // lblCapacity
            // 
            lblCapacity.BackColor = Color.Transparent;
            lblCapacity.ForeColor = Color.White;
            lblCapacity.Location = new Point(3, 50);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(100, 23);
            lblCapacity.TabIndex = 7;
            lblCapacity.Text = "Capacity";
            // 
            // txtCapacity
            // 
            txtCapacity.Dock = DockStyle.Fill;
            txtCapacity.Location = new Point(374, 53);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(365, 31);
            txtCapacity.TabIndex = 8;
            // 
            // lblLicensePlate
            // 
            lblLicensePlate.BackColor = Color.Transparent;
            lblLicensePlate.ForeColor = Color.White;
            lblLicensePlate.Location = new Point(745, 50);
            lblLicensePlate.Name = "lblLicensePlate";
            lblLicensePlate.Size = new Size(100, 23);
            lblLicensePlate.TabIndex = 9;
            lblLicensePlate.Text = "Licence Plate";
            // 
            // txtLicensePlate
            // 
            txtLicensePlate.Dock = DockStyle.Fill;
            txtLicensePlate.Location = new Point(1116, 53);
            txtLicensePlate.Name = "txtLicensePlate";
            txtLicensePlate.Size = new Size(368, 31);
            txtLicensePlate.TabIndex = 10;
            // 
            // lblRouteID
            // 
            lblRouteID.BackColor = Color.Transparent;
            lblRouteID.ForeColor = Color.White;
            lblRouteID.Location = new Point(3, 100);
            lblRouteID.Name = "lblRouteID";
            lblRouteID.Size = new Size(100, 23);
            lblRouteID.TabIndex = 11;
            lblRouteID.Text = "RouteID";
            // 
            // cmbRouteID
            // 
            cmbRouteID.Dock = DockStyle.Fill;
            cmbRouteID.Location = new Point(374, 103);
            cmbRouteID.Name = "cmbRouteID";
            cmbRouteID.Size = new Size(365, 33);
            cmbRouteID.TabIndex = 12;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(745, 100);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 23);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.Location = new Point(1116, 103);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(368, 33);
            cmbStatus.TabIndex = 14;
            // 
            // lblMaintenanceDate
            // 
            lblMaintenanceDate.BackColor = Color.Transparent;
            lblMaintenanceDate.ForeColor = Color.White;
            lblMaintenanceDate.Location = new Point(3, 150);
            lblMaintenanceDate.Name = "lblMaintenanceDate";
            lblMaintenanceDate.Size = new Size(100, 23);
            lblMaintenanceDate.TabIndex = 15;
            lblMaintenanceDate.Text = "Maintaining Data";
            // 
            // dtpMaintenanceDate
            // 
            dtpMaintenanceDate.Dock = DockStyle.Fill;
            dtpMaintenanceDate.Location = new Point(374, 153);
            dtpMaintenanceDate.Name = "dtpMaintenanceDate";
            dtpMaintenanceDate.Size = new Size(365, 31);
            dtpMaintenanceDate.TabIndex = 16;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(224, 224, 224);
            btnInsert.ForeColor = Color.Black;
            btnInsert.Location = new Point(374, 203);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(132, 37);
            btnInsert.TabIndex = 17;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(224, 224, 224);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(3, 203);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 37);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(224, 224, 224);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(745, 203);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 37);
            btnClear.TabIndex = 19;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(224, 224, 224);
            btnLogOut.Font = new Font("Arial", 9F);
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(1116, 203);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(132, 37);
            btnLogOut.TabIndex = 20;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // gbVehicle1
            // 
            gbVehicle1.Controls.Add(tableLayoutPanel3);
            gbVehicle1.Dock = DockStyle.Fill;
            gbVehicle1.ForeColor = Color.LightGray;
            gbVehicle1.Location = new Point(428, 3);
            gbVehicle1.Name = "gbVehicle1";
            gbVehicle1.Size = new Size(1493, 1055);
            gbVehicle1.TabIndex = 22;
            gbVehicle1.TabStop = false;
            gbVehicle1.Text = "Vehicle Form";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(btnLogOut, 3, 4);
            tableLayoutPanel3.Controls.Add(btnClear, 2, 4);
            tableLayoutPanel3.Controls.Add(btnUpdate, 0, 4);
            tableLayoutPanel3.Controls.Add(btnInsert, 1, 4);
            tableLayoutPanel3.Controls.Add(lblVehicleID, 0, 0);
            tableLayoutPanel3.Controls.Add(dtpMaintenanceDate, 1, 3);
            tableLayoutPanel3.Controls.Add(txtCapacity, 1, 1);
            tableLayoutPanel3.Controls.Add(lblMaintenanceDate, 0, 3);
            tableLayoutPanel3.Controls.Add(txtVehicleID, 1, 0);
            tableLayoutPanel3.Controls.Add(cmbStatus, 3, 2);
            tableLayoutPanel3.Controls.Add(lblType, 2, 0);
            tableLayoutPanel3.Controls.Add(lblStatus, 2, 2);
            tableLayoutPanel3.Controls.Add(cmbType, 3, 0);
            tableLayoutPanel3.Controls.Add(cmbRouteID, 1, 2);
            tableLayoutPanel3.Controls.Add(lblCapacity, 0, 1);
            tableLayoutPanel3.Controls.Add(lblRouteID, 0, 2);
            tableLayoutPanel3.Controls.Add(lblLicensePlate, 2, 1);
            tableLayoutPanel3.Controls.Add(txtLicensePlate, 3, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 27);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(1487, 1025);
            tableLayoutPanel3.TabIndex = 17;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // groupBoxVehicleInfo
            // 
            groupBoxVehicleInfo.BackColor = Color.Transparent;
            groupBoxVehicleInfo.Controls.Add(lstVehicles);
            groupBoxVehicleInfo.Controls.Add(txtSearch);
            groupBoxVehicleInfo.Dock = DockStyle.Fill;
            groupBoxVehicleInfo.ForeColor = Color.LightGray;
            groupBoxVehicleInfo.Location = new Point(3, 3);
            groupBoxVehicleInfo.Name = "groupBoxVehicleInfo";
            groupBoxVehicleInfo.Size = new Size(419, 1055);
            groupBoxVehicleInfo.TabIndex = 23;
            groupBoxVehicleInfo.TabStop = false;
            groupBoxVehicleInfo.Text = "Search";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(22, 28, 36);
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.1183815F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.88162F));
            tableLayoutPanel1.Controls.Add(gbVehicle1, 1, 0);
            tableLayoutPanel1.Controls.Add(groupBoxVehicleInfo, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1924, 1061);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // FormVehicle
            // 
            AutoSize = true;
            BackColor = Color.FromArgb(15, 15, 23);
            ClientSize = new Size(1924, 1061);
            Controls.Add(tableLayoutPanel1);
            ForeColor = Color.White;
            Name = "FormVehicle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vehicle's Information";
            WindowState = FormWindowState.Maximized;
            gbVehicle1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            groupBoxVehicleInfo.ResumeLayout(false);
            groupBoxVehicleInfo.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
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
        private GroupBox gbVehicle1;
        private GroupBox groupBoxVehicleInfo;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
    }
}