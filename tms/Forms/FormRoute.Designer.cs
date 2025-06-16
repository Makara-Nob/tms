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
            btnLogOut = new Button();
            gbRoute3 = new GroupBox();
            lblDistance = new Label();
            gbRoute2 = new GroupBox();
            gbRoute1 = new GroupBox();
            lstRoutes = new ListBox();
            gbRoute3.SuspendLayout();
            gbRoute2.SuspendLayout();
            gbRoute1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(261, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lblRouteID
            // 
            lblRouteID.BackColor = Color.WhiteSmoke;
            lblRouteID.ForeColor = Color.Black;
            lblRouteID.Location = new Point(24, 40);
            lblRouteID.Name = "lblRouteID";
            lblRouteID.Size = new Size(96, 23);
            lblRouteID.TabIndex = 3;
            lblRouteID.Text = "RouteID";
            // 
            // txtRouteID
            // 
            txtRouteID.Location = new Point(193, 37);
            txtRouteID.Name = "txtRouteID";
            txtRouteID.Size = new Size(398, 23);
            txtRouteID.TabIndex = 4;
            // 
            // lblStartPoint
            // 
            lblStartPoint.BackColor = Color.Transparent;
            lblStartPoint.ForeColor = Color.Black;
            lblStartPoint.Location = new Point(24, 79);
            lblStartPoint.Name = "lblStartPoint";
            lblStartPoint.Size = new Size(96, 23);
            lblStartPoint.TabIndex = 5;
            lblStartPoint.Text = "Start Point";
            // 
            // txtStartPoint
            // 
            txtStartPoint.Location = new Point(193, 79);
            txtStartPoint.Name = "txtStartPoint";
            txtStartPoint.Size = new Size(398, 23);
            txtStartPoint.TabIndex = 6;
            // 
            // lblEndPoint
            // 
            lblEndPoint.BackColor = Color.Transparent;
            lblEndPoint.ForeColor = Color.Black;
            lblEndPoint.Location = new Point(24, 128);
            lblEndPoint.Name = "lblEndPoint";
            lblEndPoint.Size = new Size(108, 23);
            lblEndPoint.TabIndex = 7;
            lblEndPoint.Text = "End Point";
            // 
            // txtEndPoint
            // 
            txtEndPoint.Location = new Point(193, 125);
            txtEndPoint.Name = "txtEndPoint";
            txtEndPoint.Size = new Size(398, 23);
            txtEndPoint.TabIndex = 8;
            txtEndPoint.TextChanged += txtEndPoint_TextChanged;
            // 
            // txtDistance
            // 
            txtDistance.Location = new Point(193, 216);
            txtDistance.Name = "txtDistance";
            txtDistance.Size = new Size(398, 23);
            txtDistance.TabIndex = 10;
            txtDistance.TextChanged += txtDistance_TextChanged;
            // 
            // lblEstimatedTime
            // 
            lblEstimatedTime.BackColor = Color.Transparent;
            lblEstimatedTime.ForeColor = Color.Black;
            lblEstimatedTime.Location = new Point(24, 219);
            lblEstimatedTime.Name = "lblEstimatedTime";
            lblEstimatedTime.Size = new Size(133, 23);
            lblEstimatedTime.TabIndex = 11;
            lblEstimatedTime.Text = "Estimated Time";
            // 
            // txtEstimatedTime
            // 
            txtEstimatedTime.Location = new Point(193, 173);
            txtEstimatedTime.Name = "txtEstimatedTime";
            txtEstimatedTime.Size = new Size(398, 23);
            txtEstimatedTime.TabIndex = 12;
            // 
            // lblVehicleAssigned
            // 
            lblVehicleAssigned.BackColor = Color.Transparent;
            lblVehicleAssigned.ForeColor = Color.Black;
            lblVehicleAssigned.Location = new Point(24, 262);
            lblVehicleAssigned.Name = "lblVehicleAssigned";
            lblVehicleAssigned.Size = new Size(150, 23);
            lblVehicleAssigned.TabIndex = 13;
            lblVehicleAssigned.Text = "Vehicle Assigned";
            // 
            // cmbVehicleAssigned
            // 
            cmbVehicleAssigned.Location = new Point(193, 262);
            cmbVehicleAssigned.Name = "cmbVehicleAssigned";
            cmbVehicleAssigned.Size = new Size(398, 23);
            cmbVehicleAssigned.TabIndex = 14;
            // 
            // lblPriority
            // 
            lblPriority.BackColor = Color.Transparent;
            lblPriority.ForeColor = Color.Black;
            lblPriority.Location = new Point(24, 310);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(100, 23);
            lblPriority.TabIndex = 15;
            lblPriority.Text = "Priority:";
            // 
            // cmbPriority
            // 
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Critical" });
            cmbPriority.Location = new Point(193, 310);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(398, 23);
            cmbPriority.TabIndex = 16;
            // 
            // chkAvoidTolls
            // 
            chkAvoidTolls.BackColor = Color.Transparent;
            chkAvoidTolls.ForeColor = Color.Black;
            chkAvoidTolls.Location = new Point(193, 368);
            chkAvoidTolls.Name = "chkAvoidTolls";
            chkAvoidTolls.Size = new Size(123, 24);
            chkAvoidTolls.TabIndex = 17;
            chkAvoidTolls.Text = "Avoid Toll";
            chkAvoidTolls.UseVisualStyleBackColor = false;
            // 
            // chkEnableWeatherAlerts
            // 
            chkEnableWeatherAlerts.BackColor = Color.Transparent;
            chkEnableWeatherAlerts.ForeColor = Color.Black;
            chkEnableWeatherAlerts.Location = new Point(322, 368);
            chkEnableWeatherAlerts.Name = "chkEnableWeatherAlerts";
            chkEnableWeatherAlerts.Size = new Size(210, 24);
            chkEnableWeatherAlerts.TabIndex = 18;
            chkEnableWeatherAlerts.Text = "Enable Weather Alert";
            chkEnableWeatherAlerts.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(193, 52);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 37);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnEditRoute_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.White;
            btnNew.ForeColor = Color.Black;
            btnNew.Location = new Point(25, 52);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(132, 37);
            btnNew.TabIndex = 21;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.White;
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(356, 52);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(132, 37);
            btnLogOut.TabIndex = 22;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // gbRoute3
            // 
            gbRoute3.Controls.Add(btnNew);
            gbRoute3.Controls.Add(btnUpdate);
            gbRoute3.Controls.Add(btnLogOut);
            gbRoute3.ForeColor = Color.Black;
            gbRoute3.Location = new Point(357, 473);
            gbRoute3.Name = "gbRoute3";
            gbRoute3.Size = new Size(643, 112);
            gbRoute3.TabIndex = 23;
            gbRoute3.TabStop = false;
            gbRoute3.Text = "Action";
            gbRoute3.Enter += gbRoute3_Enter;
            // 
            // lblDistance
            // 
            lblDistance.BackColor = Color.Transparent;
            lblDistance.ForeColor = Color.Black;
            lblDistance.Location = new Point(24, 176);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(100, 23);
            lblDistance.TabIndex = 9;
            lblDistance.Text = "Distance";
            // 
            // gbRoute2
            // 
            gbRoute2.Controls.Add(lblDistance);
            gbRoute2.Controls.Add(chkEnableWeatherAlerts);
            gbRoute2.Controls.Add(chkAvoidTolls);
            gbRoute2.Controls.Add(lblRouteID);
            gbRoute2.Controls.Add(cmbPriority);
            gbRoute2.Controls.Add(txtRouteID);
            gbRoute2.Controls.Add(lblPriority);
            gbRoute2.Controls.Add(lblStartPoint);
            gbRoute2.Controls.Add(cmbVehicleAssigned);
            gbRoute2.Controls.Add(txtStartPoint);
            gbRoute2.Controls.Add(lblVehicleAssigned);
            gbRoute2.Controls.Add(lblEndPoint);
            gbRoute2.Controls.Add(txtEstimatedTime);
            gbRoute2.Controls.Add(txtEndPoint);
            gbRoute2.Controls.Add(lblEstimatedTime);
            gbRoute2.Controls.Add(txtDistance);
            gbRoute2.ForeColor = Color.Black;
            gbRoute2.Location = new Point(357, 44);
            gbRoute2.Name = "gbRoute2";
            gbRoute2.Size = new Size(643, 410);
            gbRoute2.TabIndex = 24;
            gbRoute2.TabStop = false;
            gbRoute2.Text = "Form";
            // 
            // gbRoute1
            // 
            gbRoute1.Controls.Add(txtSearch);
            gbRoute1.Controls.Add(lstRoutes);
            gbRoute1.ForeColor = Color.Black;
            gbRoute1.Location = new Point(24, 44);
            gbRoute1.Name = "gbRoute1";
            gbRoute1.Size = new Size(300, 541);
            gbRoute1.TabIndex = 25;
            gbRoute1.TabStop = false;
            gbRoute1.Text = "Search";
            // 
            // lstRoutes
            // 
            lstRoutes.ItemHeight = 15;
            lstRoutes.Location = new Point(16, 89);
            lstRoutes.Name = "lstRoutes";
            lstRoutes.Size = new Size(261, 424);
            lstRoutes.TabIndex = 2;
            // 
            // FormRoute
            // 
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1035, 607);
            Controls.Add(gbRoute3);
            Controls.Add(gbRoute2);
            Controls.Add(gbRoute1);
            ForeColor = Color.White;
            Name = "FormRoute";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Route's Information";
            Load += RouteInformationForm_Load;
            gbRoute3.ResumeLayout(false);
            gbRoute2.ResumeLayout(false);
            gbRoute2.PerformLayout();
            gbRoute1.ResumeLayout(false);
            gbRoute1.PerformLayout();
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
        private System.Windows.Forms.Button btnLogOut;
        private GroupBox gbRoute3;
        private Label lblDistance;
        private GroupBox gbRoute2;
        private GroupBox gbRoute1;
        private ListBox lstRoutes;
    }
}