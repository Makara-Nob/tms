using System.Windows.Forms;

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
            headerPanel = new Panel();
            pictureBox2 = new PictureBox();
            lbLogout = new Label();
            dashboardCardsPanel = new Panel();
            staffCard = new Panel();
            iconStaff = new Label();
            lbStaff = new Label();
            tripCard = new Panel();
            iconTrip = new Label();
            lbTrip = new Label();
            bookingCard = new Panel();
            iconBooking = new Label();
            lbBooking = new Label();
            deliveryCard = new Panel();
            iconDelivery = new Label();
            lbDelivery = new Label();
            activeTripsCard = new Panel();
            routeCard = new Panel();
            iconRoute = new Label();
            lbRoute = new Label();
            vehicleCard = new Panel();
            iconVehicle = new Label();
            lbVehicle = new Label();
            seatCard = new Panel();
            iconSeat = new Label();
            lbSeat = new Label();
            ticketCard = new Panel();
            iconTicket = new Label();
            lbTicket = new Label();
            revenueCard = new Panel();
            pictureBox1 = new PictureBox();
            mainPanel = new Panel();
            sidebarPanel = new Panel();
            contentPanel = new Panel();
            passengerCard = new Panel();
            iconPassenger = new Label();
            load_formPassenger = new Label();
            userProfilePanel = new Panel();
            logoutButton = new Button();
            userNameLabel = new Label();
            statsPanel = new Panel();
            totalVehiclesCard = new Panel();
            totalBookingsCard = new Panel();
            label1 = new Label();
            lbOrder = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            dashboardCardsPanel.SuspendLayout();
            staffCard.SuspendLayout();
            tripCard.SuspendLayout();
            bookingCard.SuspendLayout();
            deliveryCard.SuspendLayout();
            routeCard.SuspendLayout();
            vehicleCard.SuspendLayout();
            seatCard.SuspendLayout();
            ticketCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            passengerCard.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(splitContainer1, "splitContainer1");
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.FromArgb(22, 28, 36);
            splitContainer1.Panel1.Controls.Add(headerPanel);
            splitContainer1.Panel1.Controls.Add(dashboardCardsPanel);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.FromArgb(15, 15, 23);
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(22, 28, 36);
            headerPanel.Controls.Add(pictureBox2);
            headerPanel.Controls.Add(lbLogout);
            resources.ApplyResources(headerPanel, "headerPanel");
            headerPanel.Name = "headerPanel";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // lbLogout
            // 
            resources.ApplyResources(lbLogout, "lbLogout");
            lbLogout.Cursor = Cursors.Hand;
            lbLogout.ForeColor = Color.FromArgb(239, 68, 68);
            lbLogout.Name = "lbLogout";
            // 
            // dashboardCardsPanel
            // 
            resources.ApplyResources(dashboardCardsPanel, "dashboardCardsPanel");
            dashboardCardsPanel.BackColor = Color.FromArgb(22, 28, 36);
            dashboardCardsPanel.Controls.Add(panel1);
            dashboardCardsPanel.Controls.Add(staffCard);
            dashboardCardsPanel.Controls.Add(tripCard);
            dashboardCardsPanel.Controls.Add(bookingCard);
            dashboardCardsPanel.Controls.Add(deliveryCard);
            dashboardCardsPanel.Controls.Add(activeTripsCard);
            dashboardCardsPanel.Controls.Add(routeCard);
            dashboardCardsPanel.Controls.Add(vehicleCard);
            dashboardCardsPanel.Controls.Add(seatCard);
            dashboardCardsPanel.Controls.Add(ticketCard);
            dashboardCardsPanel.Controls.Add(revenueCard);
            dashboardCardsPanel.Name = "dashboardCardsPanel";
            // 
            // staffCard
            // 
            staffCard.BackColor = Color.FromArgb(31, 41, 55);
            staffCard.Controls.Add(iconStaff);
            staffCard.Controls.Add(lbStaff);
            staffCard.Cursor = Cursors.Hand;
            resources.ApplyResources(staffCard, "staffCard");
            staffCard.Name = "staffCard";
            // 
            // iconStaff
            // 
            iconStaff.BackColor = Color.Transparent;
            iconStaff.Cursor = Cursors.Hand;
            resources.ApplyResources(iconStaff, "iconStaff");
            iconStaff.ForeColor = Color.FromArgb(59, 130, 246);
            iconStaff.Name = "iconStaff";
            // 
            // lbStaff
            // 
            resources.ApplyResources(lbStaff, "lbStaff");
            lbStaff.Cursor = Cursors.Hand;
            lbStaff.ForeColor = Color.White;
            lbStaff.Name = "lbStaff";
            // 
            // tripCard
            // 
            tripCard.BackColor = Color.FromArgb(31, 41, 55);
            tripCard.Controls.Add(iconTrip);
            tripCard.Controls.Add(lbTrip);
            tripCard.Cursor = Cursors.Hand;
            resources.ApplyResources(tripCard, "tripCard");
            tripCard.Name = "tripCard";
            // 
            // iconTrip
            // 
            iconTrip.BackColor = Color.Transparent;
            iconTrip.Cursor = Cursors.Hand;
            resources.ApplyResources(iconTrip, "iconTrip");
            iconTrip.ForeColor = Color.FromArgb(245, 158, 11);
            iconTrip.Name = "iconTrip";
            // 
            // lbTrip
            // 
            resources.ApplyResources(lbTrip, "lbTrip");
            lbTrip.Cursor = Cursors.Hand;
            lbTrip.ForeColor = Color.White;
            lbTrip.Name = "lbTrip";
            // 
            // bookingCard
            // 
            bookingCard.BackColor = Color.FromArgb(31, 41, 55);
            bookingCard.Controls.Add(iconBooking);
            bookingCard.Controls.Add(lbBooking);
            bookingCard.Cursor = Cursors.Hand;
            resources.ApplyResources(bookingCard, "bookingCard");
            bookingCard.Name = "bookingCard";
            // 
            // iconBooking
            // 
            iconBooking.BackColor = Color.Transparent;
            iconBooking.Cursor = Cursors.Hand;
            resources.ApplyResources(iconBooking, "iconBooking");
            iconBooking.ForeColor = Color.FromArgb(34, 197, 94);
            iconBooking.Name = "iconBooking";
            // 
            // lbBooking
            // 
            resources.ApplyResources(lbBooking, "lbBooking");
            lbBooking.Cursor = Cursors.Hand;
            lbBooking.ForeColor = Color.White;
            lbBooking.Name = "lbBooking";
            // 
            // deliveryCard
            // 
            deliveryCard.BackColor = Color.FromArgb(31, 41, 55);
            deliveryCard.Controls.Add(iconDelivery);
            deliveryCard.Controls.Add(lbDelivery);
            deliveryCard.Cursor = Cursors.Hand;
            resources.ApplyResources(deliveryCard, "deliveryCard");
            deliveryCard.Name = "deliveryCard";
            // 
            // iconDelivery
            // 
            iconDelivery.BackColor = Color.Transparent;
            iconDelivery.Cursor = Cursors.Hand;
            resources.ApplyResources(iconDelivery, "iconDelivery");
            iconDelivery.ForeColor = Color.FromArgb(168, 85, 247);
            iconDelivery.Name = "iconDelivery";
            // 
            // lbDelivery
            // 
            resources.ApplyResources(lbDelivery, "lbDelivery");
            lbDelivery.Cursor = Cursors.Hand;
            lbDelivery.ForeColor = Color.White;
            lbDelivery.Name = "lbDelivery";
            // 
            // activeTripsCard
            // 
            resources.ApplyResources(activeTripsCard, "activeTripsCard");
            activeTripsCard.Name = "activeTripsCard";
            // 
            // routeCard
            // 
            routeCard.BackColor = Color.FromArgb(31, 41, 55);
            routeCard.Controls.Add(iconRoute);
            routeCard.Controls.Add(lbRoute);
            routeCard.Cursor = Cursors.Hand;
            resources.ApplyResources(routeCard, "routeCard");
            routeCard.Name = "routeCard";
            // 
            // iconRoute
            // 
            iconRoute.BackColor = Color.Transparent;
            iconRoute.Cursor = Cursors.Hand;
            resources.ApplyResources(iconRoute, "iconRoute");
            iconRoute.ForeColor = Color.FromArgb(139, 92, 246);
            iconRoute.Name = "iconRoute";
            // 
            // lbRoute
            // 
            resources.ApplyResources(lbRoute, "lbRoute");
            lbRoute.Cursor = Cursors.Hand;
            lbRoute.ForeColor = Color.White;
            lbRoute.Name = "lbRoute";
            // 
            // vehicleCard
            // 
            vehicleCard.BackColor = Color.FromArgb(31, 41, 55);
            vehicleCard.Controls.Add(iconVehicle);
            vehicleCard.Controls.Add(lbVehicle);
            vehicleCard.Cursor = Cursors.Hand;
            resources.ApplyResources(vehicleCard, "vehicleCard");
            vehicleCard.Name = "vehicleCard";
            // 
            // iconVehicle
            // 
            iconVehicle.BackColor = Color.Transparent;
            iconVehicle.Cursor = Cursors.Hand;
            resources.ApplyResources(iconVehicle, "iconVehicle");
            iconVehicle.ForeColor = Color.FromArgb(16, 185, 129);
            iconVehicle.Name = "iconVehicle";
            // 
            // lbVehicle
            // 
            resources.ApplyResources(lbVehicle, "lbVehicle");
            lbVehicle.Cursor = Cursors.Hand;
            lbVehicle.ForeColor = Color.White;
            lbVehicle.Name = "lbVehicle";
            // 
            // seatCard
            // 
            seatCard.BackColor = Color.FromArgb(31, 41, 55);
            seatCard.Controls.Add(iconSeat);
            seatCard.Controls.Add(lbSeat);
            seatCard.Cursor = Cursors.Hand;
            resources.ApplyResources(seatCard, "seatCard");
            seatCard.Name = "seatCard";
            // 
            // iconSeat
            // 
            iconSeat.BackColor = Color.Transparent;
            iconSeat.Cursor = Cursors.Hand;
            resources.ApplyResources(iconSeat, "iconSeat");
            iconSeat.ForeColor = Color.FromArgb(236, 72, 153);
            iconSeat.Name = "iconSeat";
            // 
            // lbSeat
            // 
            resources.ApplyResources(lbSeat, "lbSeat");
            lbSeat.Cursor = Cursors.Hand;
            lbSeat.ForeColor = Color.White;
            lbSeat.Name = "lbSeat";
            // 
            // ticketCard
            // 
            ticketCard.BackColor = Color.FromArgb(31, 41, 55);
            ticketCard.Controls.Add(iconTicket);
            ticketCard.Controls.Add(lbTicket);
            ticketCard.Cursor = Cursors.Hand;
            resources.ApplyResources(ticketCard, "ticketCard");
            ticketCard.Name = "ticketCard";
            // 
            // iconTicket
            // 
            iconTicket.BackColor = Color.Transparent;
            iconTicket.Cursor = Cursors.Hand;
            resources.ApplyResources(iconTicket, "iconTicket");
            iconTicket.ForeColor = Color.FromArgb(251, 146, 60);
            iconTicket.Name = "iconTicket";
            // 
            // lbTicket
            // 
            resources.ApplyResources(lbTicket, "lbTicket");
            lbTicket.Cursor = Cursors.Hand;
            lbTicket.ForeColor = Color.White;
            lbTicket.Name = "lbTicket";
            // 
            // revenueCard
            // 
            resources.ApplyResources(revenueCard, "revenueCard");
            revenueCard.Name = "revenueCard";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            resources.ApplyResources(mainPanel, "mainPanel");
            mainPanel.Name = "mainPanel";
            // 
            // sidebarPanel
            // 
            resources.ApplyResources(sidebarPanel, "sidebarPanel");
            sidebarPanel.Name = "sidebarPanel";
            // 
            // contentPanel
            // 
            resources.ApplyResources(contentPanel, "contentPanel");
            contentPanel.Name = "contentPanel";
            // 
            // passengerCard
            // 
            passengerCard.BackColor = Color.FromArgb(31, 41, 55);
            passengerCard.Controls.Add(iconPassenger);
            passengerCard.Controls.Add(load_formPassenger);
            passengerCard.Cursor = Cursors.Hand;
            resources.ApplyResources(passengerCard, "passengerCard");
            passengerCard.Name = "passengerCard";
            // 
            // iconPassenger
            // 
            iconPassenger.BackColor = Color.Transparent;
            iconPassenger.Cursor = Cursors.Hand;
            resources.ApplyResources(iconPassenger, "iconPassenger");
            iconPassenger.ForeColor = Color.FromArgb(14, 165, 233);
            iconPassenger.Name = "iconPassenger";
            // 
            // load_formPassenger
            // 
            resources.ApplyResources(load_formPassenger, "load_formPassenger");
            load_formPassenger.Cursor = Cursors.Hand;
            load_formPassenger.ForeColor = Color.White;
            load_formPassenger.Name = "load_formPassenger";
            // 
            // userProfilePanel
            // 
            resources.ApplyResources(userProfilePanel, "userProfilePanel");
            userProfilePanel.Name = "userProfilePanel";
            // 
            // logoutButton
            // 
            resources.ApplyResources(logoutButton, "logoutButton");
            logoutButton.Name = "logoutButton";
            // 
            // userNameLabel
            // 
            resources.ApplyResources(userNameLabel, "userNameLabel");
            userNameLabel.Name = "userNameLabel";
            // 
            // statsPanel
            // 
            resources.ApplyResources(statsPanel, "statsPanel");
            statsPanel.Name = "statsPanel";
            // 
            // totalVehiclesCard
            // 
            resources.ApplyResources(totalVehiclesCard, "totalVehiclesCard");
            totalVehiclesCard.Name = "totalVehiclesCard";
            // 
            // totalBookingsCard
            // 
            resources.ApplyResources(totalBookingsCard, "totalBookingsCard");
            totalBookingsCard.Name = "totalBookingsCard";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Cursor = Cursors.Hand;
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(139, 92, 246);
            label1.Name = "label1";
            // 
            // lbOrder
            // 
            resources.ApplyResources(lbOrder, "lbOrder");
            lbOrder.Cursor = Cursors.Hand;
            lbOrder.ForeColor = Color.White;
            lbOrder.Name = "lbOrder";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(31, 41, 55);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lbOrder);
            panel1.Cursor = Cursors.Hand;
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // FormMain
            // 
            BackColor = Color.FromArgb(15, 15, 23);
            resources.ApplyResources(this, "$this");
            Controls.Add(splitContainer1);
            Name = "FormMain";
            WindowState = FormWindowState.Maximized;
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            dashboardCardsPanel.ResumeLayout(false);
            staffCard.ResumeLayout(false);
            staffCard.PerformLayout();
            tripCard.ResumeLayout(false);
            tripCard.PerformLayout();
            bookingCard.ResumeLayout(false);
            bookingCard.PerformLayout();
            deliveryCard.ResumeLayout(false);
            deliveryCard.PerformLayout();
            routeCard.ResumeLayout(false);
            routeCard.PerformLayout();
            vehicleCard.ResumeLayout(false);
            vehicleCard.PerformLayout();
            seatCard.ResumeLayout(false);
            seatCard.PerformLayout();
            ticketCard.ResumeLayout(false);
            ticketCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            passengerCard.ResumeLayout(false);
            passengerCard.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }


        private void SetupStatsCards()
        {
            // This method can be called if you want to add stats cards later
            // For now, keeping it simple to maintain compatibility
        }

        // Remove the old NavigationCard_Click method since your existing wire() method handles clicks

 

        #endregion

        // Control declarations - matching your existing code structure
        private SplitContainer splitContainer1; // Main container your code expects

        private Label iconStaff;
        private Label iconVehicle;
        private Label iconTrip;
        private Label iconDelivery;
        private Label iconSeat;
        private Label iconPassenger;
        private Label iconBooking;
        private Label iconTicket;
        private Label iconRoute;

        // Panel declarations
        private Panel mainPanel;
        private Panel sidebarPanel;
        private Panel headerPanel;
        private Panel contentPanel;
        private Panel dashboardCardsPanel;
        private Panel staffCard;
        private Panel vehicleCard;
        private Panel tripCard;

        // Navigation Labels - exactly matching your existing code
        private Label lbStaff;
        private Label lbVehicle;
        private Label lbTrip;
        private Label lbDelivery;
        private Label lbSeat;
        private Label load_formPassenger; // This matches your existing code
        private Label lbBooking;
        private Label lbTicket;
        private Label lbRoute;
        private Label lbLogout; // This matches your existing code
        private PictureBox pictureBox1;
        private Panel userProfilePanel;
        private Button logoutButton;
        private Label userNameLabel;

        // Stats elements
        private Panel statsPanel;
        private Panel totalVehiclesCard;
        private Panel activeTripsCard;
        private Panel totalBookingsCard;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel revenueCard;
        private Panel deliveryCard;
        private Panel seatCard;
        private Panel passengerCard;
        private Panel bookingCard;
        private Panel ticketCard;
        private Panel routeCard;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label1;
        private Label lbOrder;
    }
}