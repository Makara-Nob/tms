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
            Btn_formSeat = new Button();
            pictureSidebarBoxToggle = new PictureBox();
            btn_formStaff = new Button();
            btn_formDelivery = new Button();
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
            splitContainer1.Panel1.Controls.Add(btn_formDelivery);
            splitContainer1.Panel1.Controls.Add(Btn_formSeat);
            splitContainer1.Panel1.Controls.Add(pictureSidebarBoxToggle);
            splitContainer1.Panel1.Controls.Add(btn_formStaff);
            splitContainer1.Panel1.Cursor = Cursors.Cross;
            resources.ApplyResources(splitContainer1.Panel1, "splitContainer1.Panel1");
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.AppWorkspace;
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            // 
            // Btn_formSeat
            // 
            resources.ApplyResources(Btn_formSeat, "Btn_formSeat");
            Btn_formSeat.Name = "Btn_formSeat";
            Btn_formSeat.UseVisualStyleBackColor = true;
            Btn_formSeat.Click += Btn_formSeat_Click;
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
            btn_formStaff.Click += btn_formStaff_Click;
            // 
            // btn_formDelivery
            // 
            resources.ApplyResources(btn_formDelivery, "btn_formDelivery");
            btn_formDelivery.Name = "btn_formDelivery";
            btn_formDelivery.UseVisualStyleBackColor = true;
            btn_formDelivery.Click += btn_formDelivery_Click;
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
        private Button Btn_formSeat;
        private Button btn_formDelivery;
    }
}