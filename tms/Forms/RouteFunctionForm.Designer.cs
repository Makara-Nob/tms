namespace tms.Forms
{
    partial class RouteNewForm
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
            this.lblRouteID = new System.Windows.Forms.Label();
            this.lblStartPoint = new System.Windows.Forms.Label();
            this.lblEndPoint = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblEstimatedTime = new System.Windows.Forms.Label();
            this.lblVehicleAssigned = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.txtRouteID = new System.Windows.Forms.TextBox();
            this.txtStartPoint = new System.Windows.Forms.TextBox();
            this.txtEndPoint = new System.Windows.Forms.TextBox();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.txtEstimatedTime = new System.Windows.Forms.TextBox();
            this.cmbVehicleAssigned = new System.Windows.Forms.ComboBox();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.chkAvoidTolls = new System.Windows.Forms.CheckBox();
            this.chkEnableWeatherAlerts = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRouteID
            // 
            this.lblRouteID.ForeColor = System.Drawing.Color.Black;
            this.lblRouteID.Location = new System.Drawing.Point(20, 20);
            this.lblRouteID.Name = "lblRouteID";
            this.lblRouteID.Size = new System.Drawing.Size(120, 23);
            this.lblRouteID.TabIndex = 0;
            this.lblRouteID.Text = "Route ID *";
            // 
            // lblStartPoint
            // 
            this.lblStartPoint.ForeColor = System.Drawing.Color.Black;
            this.lblStartPoint.Location = new System.Drawing.Point(20, 60);
            this.lblStartPoint.Name = "lblStartPoint";
            this.lblStartPoint.Size = new System.Drawing.Size(120, 23);
            this.lblStartPoint.TabIndex = 2;
            this.lblStartPoint.Text = "Start Point *";
            // 
            // lblEndPoint
            // 
            this.lblEndPoint.ForeColor = System.Drawing.Color.Black;
            this.lblEndPoint.Location = new System.Drawing.Point(20, 100);
            this.lblEndPoint.Name = "lblEndPoint";
            this.lblEndPoint.Size = new System.Drawing.Size(120, 23);
            this.lblEndPoint.TabIndex = 4;
            this.lblEndPoint.Text = "End Point *";
            // 
            // lblDistance
            // 
            this.lblDistance.ForeColor = System.Drawing.Color.Black;
            this.lblDistance.Location = new System.Drawing.Point(20, 140);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(120, 23);
            this.lblDistance.TabIndex = 6;
            this.lblDistance.Text = "Distance (Km)";
            // 
            // lblEstimatedTime
            // 
            this.lblEstimatedTime.ForeColor = System.Drawing.Color.Black;
            this.lblEstimatedTime.Location = new System.Drawing.Point(20, 180);
            this.lblEstimatedTime.Name = "lblEstimatedTime";
            this.lblEstimatedTime.Size = new System.Drawing.Size(120, 23);
            this.lblEstimatedTime.TabIndex = 8;
            this.lblEstimatedTime.Text = "Estimated Time (min)";
            // 
            // lblVehicleAssigned
            // 
            this.lblVehicleAssigned.ForeColor = System.Drawing.Color.Black;
            this.lblVehicleAssigned.Location = new System.Drawing.Point(20, 220);
            this.lblVehicleAssigned.Name = "lblVehicleAssigned";
            this.lblVehicleAssigned.Size = new System.Drawing.Size(120, 23);
            this.lblVehicleAssigned.TabIndex = 10;
            this.lblVehicleAssigned.Text = "Vehicle Assigned";
            // 
            // lblPriority
            // 
            this.lblPriority.ForeColor = System.Drawing.Color.Black;
            this.lblPriority.Location = new System.Drawing.Point(20, 260);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(120, 23);
            this.lblPriority.TabIndex = 12;
            this.lblPriority.Text = "Priority";
            // 
            // txtRouteID
            // 
            this.txtRouteID.BackColor = System.Drawing.Color.White;
            this.txtRouteID.Location = new System.Drawing.Point(160, 20);
            this.txtRouteID.Name = "txtRouteID";
            this.txtRouteID.Size = new System.Drawing.Size(280, 23);
            this.txtRouteID.TabIndex = 1;
            // 
            // txtStartPoint
            // 
            this.txtStartPoint.BackColor = System.Drawing.Color.White;
            this.txtStartPoint.Location = new System.Drawing.Point(160, 60);
            this.txtStartPoint.Name = "txtStartPoint";
            this.txtStartPoint.Size = new System.Drawing.Size(280, 23);
            this.txtStartPoint.TabIndex = 3;
            // 
            // txtEndPoint
            // 
            this.txtEndPoint.BackColor = System.Drawing.Color.White;
            this.txtEndPoint.Location = new System.Drawing.Point(160, 100);
            this.txtEndPoint.Name = "txtEndPoint";
            this.txtEndPoint.Size = new System.Drawing.Size(280, 23);
            this.txtEndPoint.TabIndex = 5;
            // 
            // txtDistance
            // 
            this.txtDistance.BackColor = System.Drawing.Color.White;
            this.txtDistance.Location = new System.Drawing.Point(160, 140);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(280, 23);
            this.txtDistance.TabIndex = 7;
            // 
            // txtEstimatedTime
            // 
            this.txtEstimatedTime.BackColor = System.Drawing.Color.White;
            this.txtEstimatedTime.Location = new System.Drawing.Point(160, 180);
            this.txtEstimatedTime.Name = "txtEstimatedTime";
            this.txtEstimatedTime.Size = new System.Drawing.Size(280, 23);
            this.txtEstimatedTime.TabIndex = 9;
            // 
            // cmbVehicleAssigned
            // 
            this.cmbVehicleAssigned.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVehicleAssigned.Location = new System.Drawing.Point(160, 220);
            this.cmbVehicleAssigned.Name = "cmbVehicleAssigned";
            this.cmbVehicleAssigned.Size = new System.Drawing.Size(280, 23);
            this.cmbVehicleAssigned.TabIndex = 11;
            this.cmbVehicleAssigned.SelectedIndexChanged += new System.EventHandler(this.cmbVehicleAssigned_SelectedIndexChanged);
            // 
            // cmbPriority
            // 
            this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPriority.Items.AddRange(new object[] {
            "",
            "Low",
            "Medium",
            "High",
            "Critical"});
            this.cmbPriority.Location = new System.Drawing.Point(160, 260);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(280, 23);
            this.cmbPriority.TabIndex = 13;
            // 
            // chkAvoidTolls
            // 
            this.chkAvoidTolls.ForeColor = System.Drawing.Color.Black;
            this.chkAvoidTolls.Location = new System.Drawing.Point(20, 300);
            this.chkAvoidTolls.Name = "chkAvoidTolls";
            this.chkAvoidTolls.Size = new System.Drawing.Size(200, 23);
            this.chkAvoidTolls.TabIndex = 14;
            this.chkAvoidTolls.Text = "Avoid Tolls";
            // 
            // chkEnableWeatherAlerts
            // 
            this.chkEnableWeatherAlerts.ForeColor = System.Drawing.Color.Black;
            this.chkEnableWeatherAlerts.Location = new System.Drawing.Point(250, 300);
            this.chkEnableWeatherAlerts.Name = "chkEnableWeatherAlerts";
            this.chkEnableWeatherAlerts.Size = new System.Drawing.Size(200, 23);
            this.chkEnableWeatherAlerts.TabIndex = 15;
            this.chkEnableWeatherAlerts.Text = "Enable Weather Alerts";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(160, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(340, 350);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(250, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 30);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // RouteNewForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(484, 411);
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
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RouteNewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Route";
            this.Load += new System.EventHandler(this.RouteNewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRouteID;
        private System.Windows.Forms.Label lblStartPoint;
        private System.Windows.Forms.Label lblEndPoint;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblEstimatedTime;
        private System.Windows.Forms.Label lblVehicleAssigned;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.TextBox txtRouteID;
        private System.Windows.Forms.TextBox txtStartPoint;
        private System.Windows.Forms.TextBox txtEndPoint;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtEstimatedTime;
        private System.Windows.Forms.ComboBox cmbVehicleAssigned;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.CheckBox chkAvoidTolls;
        private System.Windows.Forms.CheckBox chkEnableWeatherAlerts;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
    }
}