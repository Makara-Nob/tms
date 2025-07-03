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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            lsTrip = new ListBox();
            groupBox1 = new GroupBox();
            comboBoxTrip = new ComboBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            gbBooking3 = new GroupBox();
            btnNavigateToInvoice = new Button();
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
            btnUpdate = new Button();
            btnClear = new Button();
            btnSelectSeat = new Button();
            btnAdd = new Button();
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
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.Size = new Size(1443, 855);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel4.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(2, 2);
            tableLayoutPanel4.Margin = new Padding(2);
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
            groupBox2.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox2.Location = new Point(2, 66);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(7, 6, 7, 6);
            groupBox2.Size = new Size(332, 783);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Trip's list";
            // 
            // lsTrip
            // 
            lsTrip.Dock = DockStyle.Fill;
            lsTrip.FormattingEnabled = true;
            lsTrip.ItemHeight = 15;
            lsTrip.Location = new Point(7, 22);
            lsTrip.Margin = new Padding(2);
            lsTrip.Name = "lsTrip";
            lsTrip.Size = new Size(318, 755);
            lsTrip.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(comboBoxTrip);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(7, 6, 7, 6);
            groupBox1.Size = new Size(332, 60);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Trip";
            // 
            // comboBoxTrip
            // 
            comboBoxTrip.Dock = DockStyle.Fill;
            comboBoxTrip.FormattingEnabled = true;
            comboBoxTrip.Location = new Point(7, 22);
            comboBoxTrip.Margin = new Padding(2);
            comboBoxTrip.Name = "comboBoxTrip";
            comboBoxTrip.Size = new Size(318, 23);
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
            tableLayoutPanel5.Location = new Point(342, 2);
            tableLayoutPanel5.Margin = new Padding(2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 3;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 23.3811188F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 8.731558F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 67.88733F));
            tableLayoutPanel5.Size = new Size(1099, 851);
            tableLayoutPanel5.TabIndex = 8;
            // 
            // gbBooking3
            // 
            gbBooking3.Controls.Add(dtgv_booking);
            gbBooking3.Dock = DockStyle.Fill;
            gbBooking3.ForeColor = Color.FromArgb(224, 224, 224);
            gbBooking3.Location = new Point(2, 274);
            gbBooking3.Margin = new Padding(2);
            gbBooking3.Name = "gbBooking3";
            gbBooking3.Padding = new Padding(7, 6, 7, 6);
            gbBooking3.Size = new Size(1095, 575);
            gbBooking3.TabIndex = 1;
            gbBooking3.TabStop = false;
            gbBooking3.Text = "Booking's Info";
            // 
            // btnNavigateToInvoice
            // 
            btnNavigateToInvoice.ForeColor = Color.Black;
            btnNavigateToInvoice.Location = new Point(3, 135);
            btnNavigateToInvoice.Name = "btnNavigateToInvoice";
            btnNavigateToInvoice.Size = new Size(150, 28);
            btnNavigateToInvoice.TabIndex = 20;
            btnNavigateToInvoice.Text = "Create Invoice";
            btnNavigateToInvoice.UseVisualStyleBackColor = true;
            // 
            // dtgv_booking
            // 
            dtgv_booking.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgv_booking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgv_booking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_booking.Dock = DockStyle.Fill;
            dtgv_booking.Location = new Point(7, 22);
            dtgv_booking.Margin = new Padding(2);
            dtgv_booking.Name = "dtgv_booking";
            dtgv_booking.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dtgv_booking.Size = new Size(1081, 547);
            dtgv_booking.TabIndex = 0;
            dtgv_booking.CellContentClick += dtgv_booking_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtBookingSearch);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox3.Location = new Point(2, 200);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(7, 6, 7, 6);
            groupBox3.Size = new Size(1095, 70);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // txtBookingSearch
            // 
            txtBookingSearch.Dock = DockStyle.Fill;
            txtBookingSearch.Location = new Point(7, 22);
            txtBookingSearch.Margin = new Padding(2);
            txtBookingSearch.Name = "txtBookingSearch";
            txtBookingSearch.Size = new Size(1081, 23);
            txtBookingSearch.TabIndex = 1;
            // 
            // gbBooking1
            // 
            gbBooking1.Controls.Add(tableLayoutPanel2);
            gbBooking1.Dock = DockStyle.Fill;
            gbBooking1.ForeColor = Color.FromArgb(224, 224, 224);
            gbBooking1.Location = new Point(2, 2);
            gbBooking1.Margin = new Padding(2);
            gbBooking1.Name = "gbBooking1";
            gbBooking1.Padding = new Padding(7, 6, 7, 6);
            gbBooking1.Size = new Size(1095, 194);
            gbBooking1.TabIndex = 2;
            gbBooking1.TabStop = false;
            gbBooking1.Text = "Form";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.4239655F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.7880135F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.7880135F));
            tableLayoutPanel2.Controls.Add(btnNavigateToInvoice, 0, 3);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(chkFemale, 2, 1);
            tableLayoutPanel2.Controls.Add(lblGender, 0, 1);
            tableLayoutPanel2.Controls.Add(chkMale, 1, 1);
            tableLayoutPanel2.Controls.Add(txtBox_Passenger, 1, 0);
            tableLayoutPanel2.Controls.Add(btnUpdate, 1, 2);
            tableLayoutPanel2.Controls.Add(btnClear, 2, 2);
            tableLayoutPanel2.Controls.Add(btnSelectSeat, 2, 0);
            tableLayoutPanel2.Controls.Add(btnAdd, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(7, 22);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 33.33F));
            tableLayoutPanel2.Size = new Size(1081, 166);
            tableLayoutPanel2.TabIndex = 13;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 3;
            label1.Text = "Passenger Contact";
            // 
            // chkFemale
            // 
            chkFemale.AutoSize = true;
            chkFemale.Location = new Point(728, 46);
            chkFemale.Margin = new Padding(2);
            chkFemale.Name = "chkFemale";
            chkFemale.Size = new Size(64, 19);
            chkFemale.TabIndex = 7;
            chkFemale.Text = "Female";
            chkFemale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(2, 44);
            lblGender.Margin = new Padding(2, 0, 2, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 5;
            lblGender.Text = "Gender";
            // 
            // chkMale
            // 
            chkMale.AutoSize = true;
            chkMale.Location = new Point(374, 46);
            chkMale.Margin = new Padding(2);
            chkMale.Name = "chkMale";
            chkMale.Size = new Size(52, 19);
            chkMale.TabIndex = 6;
            chkMale.Text = "Male";
            chkMale.UseVisualStyleBackColor = true;
            // 
            // txtBox_Passenger
            // 
            txtBox_Passenger.Dock = DockStyle.Fill;
            txtBox_Passenger.Location = new Point(374, 2);
            txtBox_Passenger.Margin = new Padding(2);
            txtBox_Passenger.Name = "txtBox_Passenger";
            txtBox_Passenger.Size = new Size(350, 23);
            txtBox_Passenger.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(374, 90);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 27);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(728, 90);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(88, 27);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSelectSeat
            // 
            btnSelectSeat.BackColor = Color.White;
            btnSelectSeat.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectSeat.ForeColor = Color.Black;
            btnSelectSeat.Location = new Point(728, 2);
            btnSelectSeat.Margin = new Padding(2);
            btnSelectSeat.Name = "btnSelectSeat";
            btnSelectSeat.Size = new Size(88, 27);
            btnSelectSeat.TabIndex = 1;
            btnSelectSeat.Text = "Select seat";
            btnSelectSeat.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(2, 90);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 27);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // FormBooking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(22, 28, 36);
            ClientSize = new Size(1443, 855);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "FormBooking";
            Text = "FormBooking";
            WindowState = FormWindowState.Maximized;
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
        private Button btnAdd;
        private Label label1;
        private CheckBox chkFemale;
        private Label lblGender;
        private CheckBox chkMale;
        private TextBox txtBox_Passenger;
        private Button btnSelectSeat;
        private Button btnUpdate;
        private Button btnClear;
        private System.Windows.Forms.Button btnNavigateToInvoice;
    }
}