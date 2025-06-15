namespace tms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            splitContainer1 = new SplitContainer();
            lblTitle = new Label();
            btn_formStaff = new Button();
            btnRouteInfo = new Button();
            btnVehicleInfo = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(lblTitle);
            splitContainer1.Panel1.Controls.Add(btn_formStaff);
            splitContainer1.Panel1.Controls.Add(btnRouteInfo);
            splitContainer1.Panel1.Controls.Add(btnVehicleInfo);
            splitContainer1.Panel1.Controls.Add(btnExit);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint_1;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.ForeColor = Color.Black;
            lblTitle.Name = "lblTitle";
            // 
            // btn_formStaff
            // 
            btn_formStaff.ForeColor = Color.Black;
            resources.ApplyResources(btn_formStaff, "btn_formStaff");
            btn_formStaff.Name = "btn_formStaff";
            // 
            // btnRouteInfo
            // 
            btnRouteInfo.ForeColor = Color.Black;
            resources.ApplyResources(btnRouteInfo, "btnRouteInfo");
            btnRouteInfo.Name = "btnRouteInfo";
            // 
            // btnVehicleInfo
            // 
            btnVehicleInfo.ForeColor = Color.Black;
            resources.ApplyResources(btnVehicleInfo, "btnVehicleInfo");
            btnVehicleInfo.Name = "btnVehicleInfo";
            // 
            // btnExit
            // 
            btnExit.ForeColor = Color.Black;
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.Name = "btnExit";
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(splitContainer1);
            Name = "FormMain";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn_formStaff;
        private System.Windows.Forms.Button btnRouteInfo;
        private System.Windows.Forms.Button btnVehicleInfo;
        private System.Windows.Forms.Button btnExit;
    }
}