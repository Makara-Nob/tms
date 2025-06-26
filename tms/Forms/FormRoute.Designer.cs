namespace tms.Forms
{
    partial class FormRoute
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
            txtSearch = new TextBox();
            lblRouteID = new Label();
            txtRouteID = new TextBox();
            lblStartPoint = new Label();
            txtStartPoint = new TextBox();
            lblEndPoint = new Label();
            txtEndPoint = new TextBox();
            txtDistance = new TextBox();
            lblEstimatedTime = new Label();
            txtEstimatedTime = new TextBox();
            lblVehicleAssigned = new Label();
            cmbVehicleAssigned = new ComboBox();
            lblPriority = new Label();
            cmbPriority = new ComboBox();
            chkAvoidTolls = new CheckBox();
            chkEnableWeatherAlerts = new CheckBox();
            btnUpdate = new Button();
            btnNew = new Button();
            btnClear = new Button();
            lblDistance = new Label();
            gbRoute2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            gbRoute1 = new GroupBox();
            lstRoutes = new ListBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            gbRoute2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            gbRoute1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(3, 19);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(516, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lblRouteID
            // 
            lblRouteID.BackColor = Color.Transparent;
            lblRouteID.ForeColor = Color.FromArgb(224, 224, 224);
            lblRouteID.Location = new Point(7, 4);
            lblRouteID.Name = "lblRouteID";
            lblRouteID.Size = new Size(96, 23);
            lblRouteID.TabIndex = 3;
            lblRouteID.Text = "RouteID";
            // 
            // txtRouteID
            // 
            txtRouteID.Dock = DockStyle.Fill;
            txtRouteID.Location = new Point(133, 7);
            txtRouteID.Name = "txtRouteID";
            txtRouteID.ReadOnly = true;
            txtRouteID.Size = new Size(212, 23);
            txtRouteID.TabIndex = 4;
            // 
            // lblStartPoint
            // 
            lblStartPoint.BackColor = Color.Transparent;
            lblStartPoint.ForeColor = Color.FromArgb(224, 224, 224);
            lblStartPoint.Location = new Point(351, 4);
            lblStartPoint.Name = "lblStartPoint";
            lblStartPoint.Size = new Size(96, 23);
            lblStartPoint.TabIndex = 5;
            lblStartPoint.Text = "Start Point";
            // 
            // txtStartPoint
            // 
            txtStartPoint.Dock = DockStyle.Fill;
            txtStartPoint.Location = new Point(477, 7);
            txtStartPoint.Name = "txtStartPoint";
            txtStartPoint.Size = new Size(397, 23);
            txtStartPoint.TabIndex = 6;
            // 
            // lblEndPoint
            // 
            lblEndPoint.BackColor = Color.Transparent;
            lblEndPoint.ForeColor = Color.FromArgb(224, 224, 224);
            lblEndPoint.Location = new Point(351, 54);
            lblEndPoint.Name = "lblEndPoint";
            lblEndPoint.Size = new Size(108, 23);
            lblEndPoint.TabIndex = 7;
            lblEndPoint.Text = "End Point";
            // 
            // txtEndPoint
            // 
            txtEndPoint.Dock = DockStyle.Fill;
            txtEndPoint.Location = new Point(477, 57);
            txtEndPoint.Name = "txtEndPoint";
            txtEndPoint.Size = new Size(397, 23);
            txtEndPoint.TabIndex = 8;
            // 
            // txtDistance
            // 
            txtDistance.Dock = DockStyle.Fill;
            txtDistance.Location = new Point(477, 157);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(397, 23);
            txtDistance.TabIndex = 10;
            // 
            // lblEstimatedTime
            // 
            lblEstimatedTime.BackColor = Color.Transparent;
            lblEstimatedTime.ForeColor = Color.Black;
            lblEstimatedTime.Location = new Point(351, 154);
            lblEstimatedTime.Name = "lblEstimatedTime";
            lblEstimatedTime.Size = new Size(120, 23);
            lblEstimatedTime.TabIndex = 11;
            lblEstimatedTime.Text = "Estimated Time";
            // 
            // txtEstimatedTime
            // 
            txtEstimatedTime.Dock = DockStyle.Fill;
            txtEstimatedTime.Location = new Point(477, 107);
            txtEstimatedTime.Name = "txtEstimatedTime";
            txtEstimatedTime.Size = new Size(397, 23);
            txtEstimatedTime.TabIndex = 12;
            // 
            // lblVehicleAssigned
            // 
            lblVehicleAssigned.BackColor = Color.Transparent;
            lblVehicleAssigned.ForeColor = Color.FromArgb(224, 224, 224);
            lblVehicleAssigned.Location = new Point(7, 54);
            lblVehicleAssigned.Name = "lblVehicleAssigned";
            lblVehicleAssigned.Size = new Size(120, 23);
            lblVehicleAssigned.TabIndex = 13;
            lblVehicleAssigned.Text = "Vehicle Assigned";
            // 
            // cmbVehicleAssigned
            // 
            cmbVehicleAssigned.Dock = DockStyle.Fill;
            cmbVehicleAssigned.Location = new Point(133, 57);
            cmbVehicleAssigned.Name = "cmbVehicleAssigned";
            cmbVehicleAssigned.Size = new Size(212, 23);
            cmbVehicleAssigned.TabIndex = 14;
            // 
            // lblPriority
            // 
            lblPriority.BackColor = Color.Transparent;
            lblPriority.ForeColor = Color.FromArgb(224, 224, 224);
            lblPriority.Location = new Point(7, 104);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(100, 23);
            lblPriority.TabIndex = 15;
            lblPriority.Text = "Priority:";
            // 
            // cmbPriority
            // 
            cmbPriority.Dock = DockStyle.Fill;
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Critical" });
            cmbPriority.Location = new Point(133, 107);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(212, 23);
            cmbPriority.TabIndex = 16;
            // 
            // chkAvoidTolls
            // 
            chkAvoidTolls.BackColor = Color.Transparent;
            chkAvoidTolls.ForeColor = Color.FromArgb(224, 224, 224);
            chkAvoidTolls.Location = new Point(7, 157);
            chkAvoidTolls.Name = "chkAvoidTolls";
            chkAvoidTolls.Size = new Size(120, 24);
            chkAvoidTolls.TabIndex = 17;
            chkAvoidTolls.Text = "Avoid Toll";
            chkAvoidTolls.UseVisualStyleBackColor = false;
            // 
            // chkEnableWeatherAlerts
            // 
            chkEnableWeatherAlerts.BackColor = Color.Transparent;
            chkEnableWeatherAlerts.ForeColor = Color.FromArgb(224, 224, 224);
            chkEnableWeatherAlerts.Location = new Point(133, 157);
            chkEnableWeatherAlerts.Name = "chkEnableWeatherAlerts";
            chkEnableWeatherAlerts.Size = new Size(212, 24);
            chkEnableWeatherAlerts.TabIndex = 18;
            chkEnableWeatherAlerts.Text = "Enable Weather Alert";
            chkEnableWeatherAlerts.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(133, 207);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 37);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnEditRoute_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.White;
            btnNew.ForeColor = Color.Black;
            btnNew.Location = new Point(7, 207);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(120, 37);
            btnNew.TabIndex = 21;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(351, 207);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 37);
            btnClear.TabIndex = 22;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // lblDistance
            // 
            lblDistance.BackColor = Color.Transparent;
            lblDistance.ForeColor = Color.FromArgb(224, 224, 224);
            lblDistance.Location = new Point(351, 104);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(100, 23);
            lblDistance.TabIndex = 9;
            lblDistance.Text = "Distance";
            // 
            // gbRoute2
            // 
            gbRoute2.Controls.Add(tableLayoutPanel3);
            gbRoute2.Dock = DockStyle.Fill;
            gbRoute2.ForeColor = Color.FromArgb(224, 224, 224);
            gbRoute2.Location = new Point(537, 3);
            gbRoute2.Name = "gbRoute2";
            gbRoute2.Size = new Size(887, 990);
            gbRoute2.TabIndex = 24;
            gbRoute2.TabStop = false;
            gbRoute2.Text = "Form";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.Controls.Add(btnClear, 2, 4);
            tableLayoutPanel3.Controls.Add(btnUpdate, 1, 4);
            tableLayoutPanel3.Controls.Add(btnNew, 0, 4);
            tableLayoutPanel3.Controls.Add(chkEnableWeatherAlerts, 1, 3);
            tableLayoutPanel3.Controls.Add(lblDistance, 2, 2);
            tableLayoutPanel3.Controls.Add(chkAvoidTolls, 0, 3);
            tableLayoutPanel3.Controls.Add(txtRouteID, 1, 0);
            tableLayoutPanel3.Controls.Add(cmbPriority, 1, 2);
            tableLayoutPanel3.Controls.Add(txtStartPoint, 3, 0);
            tableLayoutPanel3.Controls.Add(lblPriority, 0, 2);
            tableLayoutPanel3.Controls.Add(lblRouteID, 0, 0);
            tableLayoutPanel3.Controls.Add(txtDistance, 3, 3);
            tableLayoutPanel3.Controls.Add(lblEstimatedTime, 2, 3);
            tableLayoutPanel3.Controls.Add(txtEstimatedTime, 3, 2);
            tableLayoutPanel3.Controls.Add(lblVehicleAssigned, 0, 1);
            tableLayoutPanel3.Controls.Add(lblEndPoint, 2, 1);
            tableLayoutPanel3.Controls.Add(cmbVehicleAssigned, 1, 1);
            tableLayoutPanel3.Controls.Add(lblStartPoint, 2, 0);
            tableLayoutPanel3.Controls.Add(txtEndPoint, 3, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.ForeColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(4);
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.Size = new Size(881, 968);
            tableLayoutPanel3.TabIndex = 27;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // gbRoute1
            // 
            gbRoute1.Controls.Add(txtSearch);
            gbRoute1.Dock = DockStyle.Fill;
            gbRoute1.ForeColor = Color.FromArgb(224, 224, 224);
            gbRoute1.Location = new Point(3, 3);
            gbRoute1.Name = "gbRoute1";
            gbRoute1.Size = new Size(522, 115);
            gbRoute1.TabIndex = 25;
            gbRoute1.TabStop = false;
            gbRoute1.Text = "Search";
            // 
            // lstRoutes
            // 
            lstRoutes.Dock = DockStyle.Fill;
            lstRoutes.ItemHeight = 15;
            lstRoutes.Location = new Point(3, 19);
            lstRoutes.Name = "lstRoutes";
            lstRoutes.Size = new Size(516, 841);
            lstRoutes.TabIndex = 2;
            lstRoutes.SelectedIndexChanged += lstRoutes_SelectedIndexChanged_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.4765549F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5234451F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(gbRoute2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1427, 996);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(gbRoute1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2807016F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 87.7193F));
            tableLayoutPanel2.Size = new Size(528, 990);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lstRoutes);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(3, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 863);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "Route's LIst";
            // 
            // FormRoute
            // 
            BackColor = Color.FromArgb(22, 28, 36);
            ClientSize = new Size(1427, 996);
            Controls.Add(tableLayoutPanel1);
            ForeColor = Color.White;
            Name = "FormRoute";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Route's Information";
            WindowState = FormWindowState.Maximized;
            gbRoute2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            gbRoute1.ResumeLayout(false);
            gbRoute1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblRouteID;
        private System.Windows.Forms.TextBox txtRouteID;
        private System.Windows.Forms.Label lblStartPoint;
        private System.Windows.Forms.TextBox txtStartPoint;
        private System.Windows.Forms.Label lblEndPoint;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblEstimatedTime;
        private System.Windows.Forms.TextBox txtEstimatedTime;
        private System.Windows.Forms.Label lblVehicleAssigned;
        private System.Windows.Forms.ComboBox cmbVehicleAssigned;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.CheckBox chkAvoidTolls;
        private System.Windows.Forms.CheckBox chkEnableWeatherAlerts;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClear;
        private Label lblDistance;
        private GroupBox gbRoute2;
        private GroupBox gbRoute1;
        private ListBox lstRoutes;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel3;
    }
}