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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            splitContainer1 = new SplitContainer();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lbLogout = new Label();
            pictureBox10 = new PictureBox();
            pictureBox6 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lbTicket = new Label();
            lbBooking = new Label();
            load_formPassenger = new Label();
            pictureBox9 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbVehicle = new Label();
            lbStaff = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            lbSeat = new Label();
            lbTrip = new Label();
            pictureBox4 = new PictureBox();
            lbDelivery = new Label();
            imageList1 = new ImageList(components);
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            lbRoute = new Label();
            pictureBox11 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel1.Cursor = Cursors.Cross;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel2.Controls.Add(pictureBox6, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Controls.Add(lbLogout, 1, 0);
            tableLayoutPanel3.Controls.Add(pictureBox10, 0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // lbLogout
            // 
            resources.ApplyResources(lbLogout, "lbLogout");
            lbLogout.Name = "lbLogout";
            // 
            // pictureBox10
            // 
            resources.ApplyResources(pictureBox10, "pictureBox10");
            pictureBox10.Name = "pictureBox10";
            pictureBox10.TabStop = false;
            // 
            // pictureBox6
            // 
            resources.ApplyResources(pictureBox6, "pictureBox6");
            pictureBox6.Name = "pictureBox6";
            pictureBox6.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(lbTicket, 1, 8);
            tableLayoutPanel1.Controls.Add(lbBooking, 1, 1);
            tableLayoutPanel1.Controls.Add(load_formPassenger, 1, 6);
            tableLayoutPanel1.Controls.Add(pictureBox9, 0, 8);
            tableLayoutPanel1.Controls.Add(pictureBox8, 0, 1);
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 2);
            tableLayoutPanel1.Controls.Add(lbVehicle, 1, 2);
            tableLayoutPanel1.Controls.Add(lbStaff, 1, 7);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 7);
            tableLayoutPanel1.Controls.Add(pictureBox3, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox5, 0, 5);
            tableLayoutPanel1.Controls.Add(pictureBox7, 0, 6);
            tableLayoutPanel1.Controls.Add(lbSeat, 1, 5);
            tableLayoutPanel1.Controls.Add(lbTrip, 1, 3);
            tableLayoutPanel1.Controls.Add(pictureBox4, 0, 4);
            tableLayoutPanel1.Controls.Add(lbDelivery, 1, 4);
            tableLayoutPanel1.Controls.Add(lbRoute, 1, 9);
            tableLayoutPanel1.Controls.Add(pictureBox11, 0, 9);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // lbTicket
            // 
            resources.ApplyResources(lbTicket, "lbTicket");
            lbTicket.Name = "lbTicket";
            // 
            // lbBooking
            // 
            resources.ApplyResources(lbBooking, "lbBooking");
            lbBooking.Name = "lbBooking";
            // 
            // load_formPassenger
            // 
            resources.ApplyResources(load_formPassenger, "load_formPassenger");
            load_formPassenger.Name = "load_formPassenger";
            load_formPassenger.Click += load_formPassenger_Click;
            // 
            // pictureBox9
            // 
            resources.ApplyResources(pictureBox9, "pictureBox9");
            pictureBox9.Name = "pictureBox9";
            pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            resources.ApplyResources(pictureBox8, "pictureBox8");
            pictureBox8.Name = "pictureBox8";
            pictureBox8.TabStop = false;
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
            // lbStaff
            // 
            resources.ApplyResources(lbStaff, "lbStaff");
            lbStaff.Name = "lbStaff";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.staffIcon;
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            resources.ApplyResources(pictureBox5, "pictureBox5");
            pictureBox5.Name = "pictureBox5";
            pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            resources.ApplyResources(pictureBox7, "pictureBox7");
            pictureBox7.Name = "pictureBox7";
            pictureBox7.TabStop = false;
            // 
            // lbSeat
            // 
            resources.ApplyResources(lbSeat, "lbSeat");
            lbSeat.Name = "lbSeat";
            // 
            // lbTrip
            // 
            resources.ApplyResources(lbTrip, "lbTrip");
            lbTrip.Name = "lbTrip";
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
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            resources.ApplyResources(imageList1, "imageList1");
            imageList1.TransparentColor = Color.Transparent;
            // 
            // lbRoute
            // 
            resources.ApplyResources(lbRoute, "lbRoute");
            lbRoute.Name = "lbRoute";
            // 
            // pictureBox11
            // 
            resources.ApplyResources(pictureBox11, "pictureBox11");
            pictureBox11.Name = "pictureBox11";
            pictureBox11.TabStop = false;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(splitContainer1);
            Name = "FormMain";
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
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
        private PictureBox pictureBox4;
        private Label lbDelivery;
        private PictureBox pictureBox5;
        private Label lbSeat;
        private PictureBox pictureBox6;
        private Label load_formPassenger;
        private PictureBox pictureBox7;
        private Label lbBooking;
        private PictureBox pictureBox8;
        private Label lbTrip;
        private PictureBox pictureBox9;
        private Label lbTicket;
        private PictureBox pictureBox10;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lbLogout;
        private Label lbRoute;
        private PictureBox pictureBox11;
    }
}