﻿namespace tms
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            splitContainer1 = new SplitContainer();
            pictureBox4 = new PictureBox();
            lbDelivery = new Label();
            pictureBox3 = new PictureBox();
            lbRoute = new Label();
            pictureBox2 = new PictureBox();
            lbVehicle = new Label();
            pictureBox1 = new PictureBox();
            lbStaff = new Label();
            imageList1 = new ImageList(components);
            pictureBox5 = new PictureBox();
            lbSeat = new Label();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(pictureBox6);
            splitContainer1.Panel1.Controls.Add(pictureBox5);
            splitContainer1.Panel1.Controls.Add(lbSeat);
            splitContainer1.Panel1.Controls.Add(pictureBox4);
            splitContainer1.Panel1.Controls.Add(lbDelivery);
            splitContainer1.Panel1.Controls.Add(pictureBox3);
            splitContainer1.Panel1.Controls.Add(lbRoute);
            splitContainer1.Panel1.Controls.Add(pictureBox2);
            splitContainer1.Panel1.Controls.Add(lbVehicle);
            splitContainer1.Panel1.Controls.Add(pictureBox1);
            splitContainer1.Panel1.Controls.Add(lbStaff);
            splitContainer1.Panel1.Cursor = Cursors.Cross;
            resources.ApplyResources(splitContainer1.Panel1, "splitContainer1.Panel1");
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            // 
            // pictureBox4
            // 
            resources.ApplyResources(pictureBox4, "pictureBox4");
            pictureBox4.Name = "pictureBox4";
            pictureBox4.TabStop = false;
            // 
            // lbDelivery
            // 
            resources.ApplyResources(lbDelivery, "lbDelivery");
            lbDelivery.Name = "lbDelivery";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // lbRoute
            // 
            resources.ApplyResources(lbRoute, "lbRoute");
            lbRoute.Name = "lbRoute";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // lbVehicle
            // 
            resources.ApplyResources(lbVehicle, "lbVehicle");
            lbVehicle.Name = "lbVehicle";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.staffIcon;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // lbStaff
            // 
            resources.ApplyResources(lbStaff, "lbStaff");
            lbStaff.Name = "lbStaff";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            resources.ApplyResources(imageList1, "imageList1");
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox5
            // 
            resources.ApplyResources(pictureBox5, "pictureBox5");
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            // 
            // lbSeat
            // 
            resources.ApplyResources(lbSeat, "lbSeat");
            lbSeat.Name = "lbSeat";
            // 
            // pictureBox6
            // 
            resources.ApplyResources(pictureBox6, "pictureBox6");
            pictureBox6.Name = "pictureBox6";
            pictureBox6.TabStop = false;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(splitContainer1);
            Name = "FormMain";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label lbStaff;
        private PictureBox pictureBox2;
        private Label lbVehicle;
        private PictureBox pictureBox3;
        private Label lbRoute;
        private PictureBox pictureBox4;
        private Label lbDelivery;
        private PictureBox pictureBox5;
        private Label lbSeat;
        private PictureBox pictureBox6;
    }
}