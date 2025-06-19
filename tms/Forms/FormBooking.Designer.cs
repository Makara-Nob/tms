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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            lsTrip = new ListBox();
            groupBox1 = new GroupBox();
            comboBoxTrip = new ComboBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            gbBooking3 = new GroupBox();
            dtgv_booking = new DataGridView();
            groupBox3 = new GroupBox();
            txtBookingSearch = new TextBox();
            gbBooking1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            chkFemale = new CheckBox();
            lblGender = new Label();
            chkMale = new CheckBox();
            txtBox_Passenger = new TextBox();
            btnSelectSeat = new Button();
            btnToSeat = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            gbBooking3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgv_booking).BeginInit();
            groupBox3.SuspendLayout();
            gbBooking1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.57988F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.42012F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1432, 1110);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel4.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 7.53098536F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 92.46901F));
            tableLayoutPanel4.Size = new Size(331, 1104);
            tableLayoutPanel4.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lsTrip);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 86);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(325, 1015);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Trip's list";
            // 
            // lsTrip
            // 
            lsTrip.Dock = DockStyle.Fill;
            lsTrip.FormattingEnabled = true;
            lsTrip.ItemHeight = 25;
            lsTrip.Location = new Point(3, 27);
            lsTrip.Name = "lsTrip";
            lsTrip.Size = new Size(319, 985);
            lsTrip.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(comboBoxTrip);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(325, 77);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Trip";
            // 
            // comboBoxTrip
            // 
            comboBoxTrip.Dock = DockStyle.Fill;
            comboBoxTrip.FormattingEnabled = true;
            comboBoxTrip.Location = new Point(3, 27);
            comboBoxTrip.Name = "comboBoxTrip";
            comboBoxTrip.Size = new Size(319, 33);
            comboBoxTrip.TabIndex = 6;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(gbBooking3, 0, 2);
            tableLayoutPanel5.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel5.Controls.Add(gbBooking1, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(340, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 23.8487377F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 6.90618944F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 69.24507F));
            tableLayoutPanel5.Size = new Size(1089, 1104);
            tableLayoutPanel5.TabIndex = 8;
            // 
            // gbBooking3
            // 
            gbBooking3.Controls.Add(dtgv_booking);
            gbBooking3.Dock = DockStyle.Fill;
            gbBooking3.Location = new Point(3, 342);
            gbBooking3.Name = "gbBooking3";
            gbBooking3.Size = new Size(1083, 759);
            gbBooking3.TabIndex = 1;
            gbBooking3.TabStop = false;
            gbBooking3.Text = "Booking's Info";
            // 
            // dtgv_booking
            // 
            dtgv_booking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_booking.Dock = DockStyle.Fill;
            dtgv_booking.Location = new Point(3, 27);
            dtgv_booking.Name = "dtgv_booking";
            dtgv_booking.RowHeadersWidth = 62;
            dtgv_booking.Size = new Size(1077, 729);
            dtgv_booking.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtBookingSearch);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 266);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1083, 70);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search";
            // 
            // txtBookingSearch
            // 
            txtBookingSearch.Dock = DockStyle.Fill;
            txtBookingSearch.Location = new Point(3, 27);
            txtBookingSearch.Name = "txtBookingSearch";
            txtBookingSearch.Size = new Size(1077, 31);
            txtBookingSearch.TabIndex = 1;
            // 
            // gbBooking1
            // 
            gbBooking1.Controls.Add(tableLayoutPanel2);
            gbBooking1.Dock = DockStyle.Fill;
            gbBooking1.Location = new Point(3, 3);
            gbBooking1.Name = "gbBooking1";
            gbBooking1.Size = new Size(1083, 257);
            gbBooking1.TabIndex = 2;
            gbBooking1.TabStop = false;
            gbBooking1.Text = "Form";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(chkFemale, 2, 1);
            tableLayoutPanel2.Controls.Add(lblGender, 0, 1);
            tableLayoutPanel2.Controls.Add(chkMale, 1, 1);
            tableLayoutPanel2.Controls.Add(txtBox_Passenger, 1, 0);
            tableLayoutPanel2.Controls.Add(btnSelectSeat, 0, 2);
            tableLayoutPanel2.Controls.Add(btnToSeat, 2, 0);
            tableLayoutPanel2.Controls.Add(btnUpdate, 1, 2);
            tableLayoutPanel2.Controls.Add(btnClear, 2, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 27);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(1077, 227);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 3;
            label1.Text = "Passenger Contact";
            // 
            // chkFemale
            // 
            chkFemale.AutoSize = true;
            chkFemale.Location = new Point(721, 78);
            chkFemale.Name = "chkFemale";
            chkFemale.Size = new Size(94, 29);
            chkFemale.TabIndex = 7;
            chkFemale.Text = "Female";
            chkFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(3, 75);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(69, 25);
            lblGender.TabIndex = 5;
            lblGender.Text = "Gender";
            // 
            // chkMale
            // 
            chkMale.AutoSize = true;
            chkMale.Location = new Point(362, 78);
            chkMale.Name = "chkMale";
            chkMale.Size = new Size(76, 29);
            chkMale.TabIndex = 6;
            chkMale.Text = "Male";
            chkMale.UseVisualStyleBackColor = true;
            // 
            // txtBox_Passenger
            // 
            txtBox_Passenger.Dock = DockStyle.Fill;
            txtBox_Passenger.Location = new Point(362, 3);
            txtBox_Passenger.Name = "txtBox_Passenger";
            txtBox_Passenger.Size = new Size(353, 31);
            txtBox_Passenger.TabIndex = 4;
            // 
            // btnSelectSeat
            // 
            btnSelectSeat.Location = new Point(3, 153);
            btnSelectSeat.Name = "btnSelectSeat";
            btnSelectSeat.Size = new Size(112, 34);
            btnSelectSeat.TabIndex = 1;
            btnSelectSeat.Text = "Select seat";
            btnSelectSeat.UseVisualStyleBackColor = true;
            // 
            // btnToSeat
            // 
            btnToSeat.Location = new Point(721, 3);
            btnToSeat.Name = "btnToSeat";
            btnToSeat.Size = new Size(66, 1);
            btnToSeat.TabIndex = 8;
            btnToSeat.Text = "Choose Seat";
            btnToSeat.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(362, 153);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(721, 153);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // FormBooking
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1432, 1110);
            Controls.Add(tableLayoutPanel1);
            Name = "FormBooking";
            Text = "FormBooking";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            gbBooking3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgv_booking).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            gbBooking1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox2;
        private ListBox lsTrip;
        private GroupBox groupBox1;
        private ComboBox comboBoxTrip;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox gbBooking3;
        private DataGridView dtgv_booking;
        private GroupBox groupBox3;
        private TextBox txtBookingSearch;
        private GroupBox gbBooking1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnToSeat;
        private Label label1;
        private CheckBox chkFemale;
        private Label lblGender;
        private CheckBox chkMale;
        private TextBox txtBox_Passenger;
        private Button btnSelectSeat;
        private Button btnUpdate;
        private Button btnClear;
    }
}