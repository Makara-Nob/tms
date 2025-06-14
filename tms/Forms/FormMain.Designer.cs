namespace tms.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            splitContainer1 = new SplitContainer();
            btn_vehicleForm = new Button();
            btn_routeForm = new Button();
            pictureSidebarBoxToggle = new PictureBox();
            btn_formStaff = new Button();
            btn_deliveryForm = new Button();
            btn_seatForm = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureSidebarBoxToggle).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.HighlightText;
            splitContainer1.Panel1.Controls.Add(btn_seatForm);
            splitContainer1.Panel1.Controls.Add(btn_deliveryForm);
            splitContainer1.Panel1.Controls.Add(btn_vehicleForm);
            splitContainer1.Panel1.Controls.Add(btn_routeForm);
            splitContainer1.Panel1.Controls.Add(pictureSidebarBoxToggle);
            splitContainer1.Panel1.Controls.Add(btn_formStaff);
            splitContainer1.Panel1.Cursor = Cursors.Cross;
            resources.ApplyResources(splitContainer1.Panel1, "splitContainer1.Panel1");
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.AppWorkspace;
            // 
            // btn_vehicleForm
            // 
            resources.ApplyResources(btn_vehicleForm, "btn_vehicleForm");
            btn_vehicleForm.Name = "btn_vehicleForm";
            btn_vehicleForm.UseVisualStyleBackColor = true;
            // 
            // btn_routeForm
            // 
            resources.ApplyResources(btn_routeForm, "btn_routeForm");
            btn_routeForm.Name = "btn_routeForm";
            btn_routeForm.UseVisualStyleBackColor = true;
            // 
            // pictureSidebarBoxToggle
            // 
            resources.ApplyResources(pictureSidebarBoxToggle, "pictureSidebarBoxToggle");
            pictureSidebarBoxToggle.Name = "pictureSidebarBoxToggle";
            pictureSidebarBoxToggle.TabStop = false;
            // 
            // btn_formStaff
            // 
            resources.ApplyResources(btn_formStaff, "btn_formStaff");
            btn_formStaff.Name = "btn_formStaff";
            btn_formStaff.UseVisualStyleBackColor = true;
            // 
            // btn_deliveryForm
            // 
            resources.ApplyResources(btn_deliveryForm, "btn_deliveryForm");
            btn_deliveryForm.Name = "btn_deliveryForm";
            btn_deliveryForm.UseVisualStyleBackColor = true;
            // 
            // btn_seatForm
            // 
            resources.ApplyResources(btn_seatForm, "btn_seatForm");
            btn_seatForm.Name = "btn_seatForm";
            btn_seatForm.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "FormMain";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureSidebarBoxToggle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btn_formStaff;
        private PictureBox pictureSidebarBoxToggle;
        private Button btn_routeForm;
        private Button btn_vehicleForm;
        private Button btn_deliveryForm;
        private Button btn_seatForm;
    }
}