namespace tms.Forms
{
    partial class RouteInformationForm
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lstRoutes = new System.Windows.Forms.ListBox();
            this.lblRouteID = new System.Windows.Forms.Label();
            this.txtRouteID = new System.Windows.Forms.TextBox();
            this.lblStartPoint = new System.Windows.Forms.Label();
            this.txtStartPoint = new System.Windows.Forms.TextBox();
            this.lblEndPoint = new System.Windows.Forms.Label();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lblEstimatedTime = new System.Windows.Forms.Label();
            this.txtEstimatedTime = new System.Windows.Forms.TextBox();
            this.lblVehicleAssigned = new System.Windows.Forms.Label();
            this.cmbVehicleAssigned = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.chkAvoidTolls = new System.Windows.Forms.CheckBox();
            this.chkEnableWeatherAlerts = new System.Windows.Forms.CheckBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.White;
            this.lblSearch.Location = new System.Drawing.Point(12, 9);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(58, 23);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(261, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // lstRoutes
            // 
            this.lstRoutes.ItemHeight = 15;
            this.lstRoutes.Location = new System.Drawing.Point(12, 97);
            this.lstRoutes.Name = "lstRoutes";
            this.lstRoutes.Size = new System.Drawing.Size(261, 379);
            this.lstRoutes.TabIndex = 2;
            this.lstRoutes.SelectedIndexChanged += new System.EventHandler(this.LstRoutes_SelectedIndexChanged);
            // 
            // lblRouteID
            // 
            this.lblRouteID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblRouteID.ForeColor = System.Drawing.Color.Black;
            this.lblRouteID.Location = new System.Drawing.Point(297, 8);
            this.lblRouteID.Name = "lblRouteID";
            this.lblRouteID.Size = new System.Drawing.Size(186, 23);
            this.lblRouteID.TabIndex = 3;
            this.lblRouteID.Text = "RouteID";
            // 
            // txtRouteID
            // 
            this.txtRouteID.Location = new System.Drawing.Point(532, 8);
            this.txtRouteID.Name = "txtRouteID";
            this.txtRouteID.Size = new System.Drawing.Size(210, 23);
            this.txtRouteID.TabIndex = 4;
            // 
            // lblStartPoint
            // 
            this.lblStartPoint.BackColor = System.Drawing.Color.White;
            this.lblStartPoint.Location = new System.Drawing.Point(297, 48);
            this.lblStartPoint.Name = "lblStartPoint";
            this.lblStartPoint.Size = new System.Drawing.Size(186, 23);
            this.lblStartPoint.TabIndex = 5;
            this.lblStartPoint.Text = "Start Point";
            // 
            // txtStartPoint
            // 
            this.txtStartPoint.Location = new System.Drawing.Point(532, 48);
            this.txtStartPoint.Name = "txtStartPoint";
            this.txtStartPoint.Size = new System.Drawing.Size(100, 23);
            this.txtStartPoint.TabIndex = 6;
            // 
            // lblEndPoint
            // 
            this.lblEndPoint.BackColor = System.Drawing.Color.White;
            this.lblEndPoint.Location = new System.Drawing.Point(297, 97);
            this.lblEndPoint.Name = "lblEndPoint";
            this.lblEndPoint.Size = new System.Drawing.Size(186, 23);
            this.lblEndPoint.TabIndex = 7;
            this.lblEndPoint.Text = "End Point";
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.Location = new System.Drawing.Point(532, 97);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(100, 23);
            this.txtEndPoint.TabIndex = 8;
            this.txtEndPoint.TextChanged += new System.EventHandler(this.txtEndPoint_TextChanged);
            // 
            // lblDistance
            // 
            this.lblDistance.BackColor = System.Drawing.Color.White;
            this.lblDistance.Location = new System.Drawing.Point(532, 144);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(100, 23);
            this.lblDistance.TabIndex = 9;
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(293, 144);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(190, 23);
            this.txtDistance.TabIndex = 10;
            this.txtDistance.Text = "Distance (Km)";
            this.txtDistance.TextChanged += new System.EventHandler(this.txtDistance_TextChanged);
            // 
            // lblEstimatedTime
            // 
            this.lblEstimatedTime.BackColor = System.Drawing.Color.White;
            this.lblEstimatedTime.Location = new System.Drawing.Point(293, 188);
            this.lblEstimatedTime.Name = "lblEstimatedTime";
            this.lblEstimatedTime.Size = new System.Drawing.Size(190, 23);
            this.lblEstimatedTime.TabIndex = 11;
            this.lblEstimatedTime.Text = "Estimated Time";
            // 
            // txtEstimatedTime
            // 
            this.txtEstimatedTime.Location = new System.Drawing.Point(532, 188);
            this.txtEstimatedTime.Name = "txtEstimatedTime";
            this.txtEstimatedTime.Size = new System.Drawing.Size(100, 23);
            this.txtEstimatedTime.TabIndex = 12;
            // 
            // lblVehicleAssigned
            // 
            this.lblVehicleAssigned.BackColor = System.Drawing.Color.White;
            this.lblVehicleAssigned.Location = new System.Drawing.Point(293, 251);
            this.lblVehicleAssigned.Name = "lblVehicleAssigned";
            this.lblVehicleAssigned.Size = new System.Drawing.Size(190, 23);
            this.lblVehicleAssigned.TabIndex = 13;
            this.lblVehicleAssigned.Text = "Vehicle Assigned";
            // 
            // cmbVehicleAssigned
            // 
            this.cmbVehicleAssigned.Location = new System.Drawing.Point(532, 251);
            this.cmbVehicleAssigned.Name = "cmbVehicleAssigned";
            this.cmbVehicleAssigned.Size = new System.Drawing.Size(121, 23);
            this.cmbVehicleAssigned.TabIndex = 14;
            // 
            // lblPriority
            // 
            this.lblPriority.BackColor = System.Drawing.Color.White;
            this.lblPriority.Location = new System.Drawing.Point(293, 364);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(100, 23);
            this.lblPriority.TabIndex = 15;
            this.lblPriority.Text = "Priority:";
            // 
            // cmbPriority
            // 
            this.cmbPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Critical"});
            this.cmbPriority.Location = new System.Drawing.Point(429, 361);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(121, 23);
            this.cmbPriority.TabIndex = 16;
            // 
            // chkAvoidTolls
            // 
            this.chkAvoidTolls.BackColor = System.Drawing.Color.White;
            this.chkAvoidTolls.Location = new System.Drawing.Point(293, 409);
            this.chkAvoidTolls.Name = "chkAvoidTolls";
            this.chkAvoidTolls.Size = new System.Drawing.Size(104, 24);
            this.chkAvoidTolls.TabIndex = 17;
            this.chkAvoidTolls.Text = "Avoid Toll";
            this.chkAvoidTolls.UseVisualStyleBackColor = false;
            // 
            // chkEnableWeatherAlerts
            // 
            this.chkEnableWeatherAlerts.BackColor = System.Drawing.Color.White;
            this.chkEnableWeatherAlerts.Location = new System.Drawing.Point(293, 453);
            this.chkEnableWeatherAlerts.Name = "chkEnableWeatherAlerts";
            this.chkEnableWeatherAlerts.Size = new System.Drawing.Size(104, 24);
            this.chkEnableWeatherAlerts.TabIndex = 18;
            this.chkEnableWeatherAlerts.Text = "Enable Weather Alert";
            this.chkEnableWeatherAlerts.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(151, 539);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(234, 539);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(70, 539);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 21;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(315, 539);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 22;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // RouteInformationForm
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1620, 613);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstRoutes);
            this.Controls.Add(this.lblRouteID);
            this.Controls.Add(this.txtRouteID);
            this.Controls.Add(this.lblStartPoint);
            this.Controls.Add(this.txtStartPoint);
            this.Controls.Add(this.lblEndPoint);
            this.Controls.Add(this.txtEndPoint);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblEstimatedTime);
            this.Controls.Add(this.txtEstimatedTime);
            this.Controls.Add(this.lblVehicleAssigned);
            this.Controls.Add(this.cmbVehicleAssigned);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.chkAvoidTolls);
            this.Controls.Add(this.chkEnableWeatherAlerts);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnLogOut);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "RouteInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Route\'s Information";
            this.Load += new System.EventHandler(this.RouteInformationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox lstRoutes;
        private System.Windows.Forms.Label lblRouteID;
        private System.Windows.Forms.TextBox txtRouteID;
        private System.Windows.Forms.Label lblStartPoint;
        private System.Windows.Forms.TextBox txtStartPoint;
        private System.Windows.Forms.Label lblEndPoint;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.Label lblEstimatedTime;
        private System.Windows.Forms.TextBox txtEstimatedTime;
        private System.Windows.Forms.Label lblVehicleAssigned;
        private System.Windows.Forms.ComboBox cmbVehicleAssigned;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.CheckBox chkAvoidTolls;
        private System.Windows.Forms.CheckBox chkEnableWeatherAlerts;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnLogOut;
    }
}