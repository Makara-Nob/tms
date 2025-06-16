namespace tms.Forms
{
    partial class FormBooking
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
            dtgv_booking = new DataGridView();
            gbBooking3 = new GroupBox();
            txtBookingSearch = new TextBox();
            gbBooking1 = new GroupBox();
            btnToSeat = new Button();
            chkFemale = new CheckBox();
            chkMale = new CheckBox();
            lblGender = new Label();
            txtBox_Passenger = new TextBox();
            label1 = new Label();
            groupBox4 = new GroupBox();
            btnDelete = new Button();
            btnBooking = new Button();
            btnUpdate = new Button();
            comboBoxTrip = new ComboBox();
            groupBox1 = new GroupBox();
            dgv_Trip = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgv_booking).BeginInit();
            gbBooking3.SuspendLayout();
            gbBooking1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Trip).BeginInit();
            SuspendLayout();
            // 
            // dtgv_booking
            // 
            dtgv_booking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_booking.Location = new Point(37, 93);
            dtgv_booking.Name = "dtgv_booking";
            dtgv_booking.RowHeadersWidth = 62;
            dtgv_booking.Size = new Size(1308, 147);
            dtgv_booking.TabIndex = 0;
            // 
            // gbBooking3
            // 
            gbBooking3.Controls.Add(txtBookingSearch);
            gbBooking3.Controls.Add(dtgv_booking);
            gbBooking3.Location = new Point(23, 588);
            gbBooking3.Name = "gbBooking3";
            gbBooking3.Size = new Size(1380, 273);
            gbBooking3.TabIndex = 1;
            gbBooking3.TabStop = false;
            gbBooking3.Text = "Booking's Info";
            // 
            // txtBookingSearch
            // 
            txtBookingSearch.Location = new Point(37, 44);
            txtBookingSearch.Name = "txtBookingSearch";
            txtBookingSearch.Size = new Size(1308, 31);
            txtBookingSearch.TabIndex = 1;
            // 
            // gbBooking1
            // 
            gbBooking1.Controls.Add(btnToSeat);
            gbBooking1.Controls.Add(chkFemale);
            gbBooking1.Controls.Add(chkMale);
            gbBooking1.Controls.Add(lblGender);
            gbBooking1.Controls.Add(txtBox_Passenger);
            gbBooking1.Controls.Add(label1);
            gbBooking1.Controls.Add(groupBox4);
            gbBooking1.Location = new Point(23, 300);
            gbBooking1.Name = "gbBooking1";
            gbBooking1.Size = new Size(1380, 267);
            gbBooking1.TabIndex = 2;
            gbBooking1.TabStop = false;
            gbBooking1.Text = "Passenger Info";
            // 
            // btnToSeat
            // 
            btnToSeat.Location = new Point(273, 215);
            btnToSeat.Name = "btnToSeat";
            btnToSeat.Size = new Size(157, 34);
            btnToSeat.TabIndex = 8;
            btnToSeat.Text = "Choose Seat";
            btnToSeat.UseVisualStyleBackColor = true;
            // 
            // chkFemale
            // 
            chkFemale.AutoSize = true;
            chkFemale.Location = new Point(640, 142);
            chkFemale.Name = "chkFemale";
            chkFemale.Size = new Size(94, 29);
            chkFemale.TabIndex = 7;
            chkFemale.Text = "Female";
            chkFemale.UseVisualStyleBackColor = true;
            // 
            // chkMale
            // 
            chkMale.AutoSize = true;
            chkMale.Location = new Point(470, 142);
            chkMale.Name = "chkMale";
            chkMale.Size = new Size(76, 29);
            chkMale.TabIndex = 6;
            chkMale.Text = "Male";
            chkMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(273, 142);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(69, 25);
            lblGender.TabIndex = 5;
            lblGender.Text = "Gender";
            // 
            // txtBox_Passenger
            // 
            txtBox_Passenger.Location = new Point(470, 81);
            txtBox_Passenger.Name = "txtBox_Passenger";
            txtBox_Passenger.Size = new Size(483, 31);
            txtBox_Passenger.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 81);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 3;
            label1.Text = "Passenger Contact";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnDelete);
            groupBox4.Controls.Add(btnBooking);
            groupBox4.Controls.Add(btnUpdate);
            groupBox4.Location = new Point(20, 45);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(188, 204);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            groupBox4.Text = "Action";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(34, 137);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnBooking
            // 
            btnBooking.Location = new Point(34, 36);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(112, 34);
            btnBooking.TabIndex = 9;
            btnBooking.Text = "Book";
            btnBooking.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(34, 88);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // comboBoxTrip
            // 
            comboBoxTrip.FormattingEnabled = true;
            comboBoxTrip.Location = new Point(37, 45);
            comboBoxTrip.Name = "comboBoxTrip";
            comboBoxTrip.Size = new Size(1320, 33);
            comboBoxTrip.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(comboBoxTrip);
            groupBox1.Controls.Add(dgv_Trip);
            groupBox1.Location = new Point(23, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1380, 266);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Trip";
            // 
            // dgv_Trip
            // 
            dgv_Trip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Trip.Location = new Point(37, 93);
            dgv_Trip.Name = "dgv_Trip";
            dgv_Trip.RowHeadersWidth = 62;
            dgv_Trip.Size = new Size(1320, 143);
            dgv_Trip.TabIndex = 0;
            // 
            // FormBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1432, 924);
            Controls.Add(groupBox1);
            Controls.Add(gbBooking1);
            Controls.Add(gbBooking3);
            Name = "FormBooking";
            Text = "FormBooking";
            ((System.ComponentModel.ISupportInitialize)dtgv_booking).EndInit();
            gbBooking3.ResumeLayout(false);
            gbBooking3.PerformLayout();
            gbBooking1.ResumeLayout(false);
            gbBooking1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Trip).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgv_booking;
        private GroupBox gbBooking3;
        private TextBox txtBookingSearch;
        private GroupBox gbBooking1;
        private TextBox txtBox_Passenger;
        private Label label1;
        private Label lblGender;
        private ComboBox comboBoxTrip;
        private GroupBox groupBox1;
        private DataGridView dgv_Trip;
        private CheckBox chkFemale;
        private CheckBox chkMale;
        private Button btnToSeat;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnBooking;
        private GroupBox groupBox4;
    }
}