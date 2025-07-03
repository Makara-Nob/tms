namespace tms.Forms
{
    partial class FormTicket
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
            gbRoute3 = new GroupBox();
            btnLogOut = new Button();
            btnNew = new Button();
            btnUpdate = new Button();
            gbRoute2 = new GroupBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblPaymentStatus = new Label();
            txtSupplierID = new TextBox();
            lblCustomerPosition = new Label();
            lblSupplierID = new Label();
            txtCustomerPosition = new TextBox();
            txtSupplierName = new TextBox();
            lblSupplierName = new Label();
            lblCustomerAddress = new Label();
            txtCustomerAddress = new TextBox();
            lblSupplierDate = new Label();
            dtSupplierDate = new DateTimePicker();
            btnClear = new Button();
            txtInvoiceNo = new ComboBox();
            label1 = new Label();
            gbRoute1 = new GroupBox();
            IsTicket = new ListBox();
            txtSearch = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            gbRoute3.SuspendLayout();
            gbRoute2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            gbRoute1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbRoute3
            // 
            gbRoute3.Controls.Add(btnLogOut);
            gbRoute3.ForeColor = Color.Black;
            gbRoute3.Location = new Point(343, 440);
            gbRoute3.Name = "gbRoute3";
            gbRoute3.Size = new Size(643, 112);
            gbRoute3.TabIndex = 26;
            gbRoute3.TabStop = false;
            gbRoute3.Text = "Action";
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.White;
            btnLogOut.ForeColor = Color.Black;
            btnLogOut.Location = new Point(356, 52);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(132, 37);
            btnLogOut.TabIndex = 22;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.White;
            btnNew.ForeColor = Color.Black;
            btnNew.Location = new Point(3, 93);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(78, 25);
            btnNew.TabIndex = 21;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(175, 93);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 25);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // gbRoute2
            // 
            gbRoute2.Controls.Add(tableLayoutPanel4);
            gbRoute2.Dock = DockStyle.Fill;
            gbRoute2.ForeColor = Color.FromArgb(224, 224, 224);
            gbRoute2.Location = new Point(3, 3);
            gbRoute2.Name = "gbRoute2";
            gbRoute2.Padding = new Padding(7, 6, 7, 6);
            gbRoute2.Size = new Size(703, 157);
            gbRoute2.TabIndex = 27;
            gbRoute2.TabStop = false;
            gbRoute2.Text = "Form";
            gbRoute2.Enter += gbRoute2_Enter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel4.Controls.Add(lblPaymentStatus, 3, 3);
            tableLayoutPanel4.Controls.Add(btnNew, 0, 3);
            tableLayoutPanel4.Controls.Add(txtSupplierID, 1, 0);
            tableLayoutPanel4.Controls.Add(lblCustomerPosition, 2, 0);
            tableLayoutPanel4.Controls.Add(lblSupplierID, 0, 0);
            tableLayoutPanel4.Controls.Add(txtCustomerPosition, 3, 0);
            tableLayoutPanel4.Controls.Add(txtSupplierName, 1, 1);
            tableLayoutPanel4.Controls.Add(lblSupplierName, 0, 1);
            tableLayoutPanel4.Controls.Add(lblCustomerAddress, 2, 1);
            tableLayoutPanel4.Controls.Add(txtCustomerAddress, 3, 1);
            tableLayoutPanel4.Controls.Add(lblSupplierDate, 0, 2);
            tableLayoutPanel4.Controls.Add(btnUpdate, 1, 3);
            tableLayoutPanel4.Controls.Add(dtSupplierDate, 1, 2);
            tableLayoutPanel4.Controls.Add(btnClear, 2, 3);
            tableLayoutPanel4.Controls.Add(txtInvoiceNo, 3, 2);
            tableLayoutPanel4.Controls.Add(label1, 2, 2);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(7, 22);
            tableLayoutPanel4.Margin = new Padding(2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.Size = new Size(689, 129);
            tableLayoutPanel4.TabIndex = 30;
            // 
            // lblPaymentStatus
            // 
            lblPaymentStatus.Dock = DockStyle.Fill;
            lblPaymentStatus.ForeColor = Color.White;
            lblPaymentStatus.Location = new Point(519, 90);
            lblPaymentStatus.Name = "lblPaymentStatus";
            lblPaymentStatus.Size = new Size(167, 39);
            lblPaymentStatus.TabIndex = 0;
            lblPaymentStatus.Text = "Status:";
            lblPaymentStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSupplierID
            // 
            txtSupplierID.Dock = DockStyle.Fill;
            txtSupplierID.Location = new Point(175, 3);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(166, 23);
            txtSupplierID.TabIndex = 4;
            // 
            // lblCustomerPosition
            // 
            lblCustomerPosition.BackColor = Color.Transparent;
            lblCustomerPosition.ForeColor = Color.FromArgb(224, 224, 224);
            lblCustomerPosition.Location = new Point(347, 0);
            lblCustomerPosition.Name = "lblCustomerPosition";
            lblCustomerPosition.Size = new Size(120, 23);
            lblCustomerPosition.TabIndex = 9;
            lblCustomerPosition.Text = "Customer Position";
            // 
            // lblSupplierID
            // 
            lblSupplierID.BackColor = Color.Transparent;
            lblSupplierID.ForeColor = Color.FromArgb(224, 224, 224);
            lblSupplierID.Location = new Point(3, 0);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(96, 23);
            lblSupplierID.TabIndex = 3;
            lblSupplierID.Text = "Supplier ID";
            // 
            // txtCustomerPosition
            // 
            txtCustomerPosition.Dock = DockStyle.Fill;
            txtCustomerPosition.Location = new Point(519, 3);
            txtCustomerPosition.Name = "txtCustomerPosition";
            txtCustomerPosition.Size = new Size(167, 23);
            txtCustomerPosition.TabIndex = 12;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Dock = DockStyle.Fill;
            txtSupplierName.Location = new Point(175, 33);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(166, 23);
            txtSupplierName.TabIndex = 6;
            // 
            // lblSupplierName
            // 
            lblSupplierName.BackColor = Color.Transparent;
            lblSupplierName.ForeColor = Color.FromArgb(224, 224, 224);
            lblSupplierName.Location = new Point(3, 30);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(96, 23);
            lblSupplierName.TabIndex = 5;
            lblSupplierName.Text = "Supplier Name";
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.BackColor = Color.Transparent;
            lblCustomerAddress.ForeColor = Color.FromArgb(224, 224, 224);
            lblCustomerAddress.Location = new Point(347, 30);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(133, 23);
            lblCustomerAddress.TabIndex = 11;
            lblCustomerAddress.Text = "Customer Address";
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Dock = DockStyle.Fill;
            txtCustomerAddress.Location = new Point(519, 33);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(167, 23);
            txtCustomerAddress.TabIndex = 10;
            // 
            // lblSupplierDate
            // 
            lblSupplierDate.BackColor = Color.Transparent;
            lblSupplierDate.ForeColor = Color.FromArgb(224, 224, 224);
            lblSupplierDate.Location = new Point(3, 60);
            lblSupplierDate.Name = "lblSupplierDate";
            lblSupplierDate.Size = new Size(108, 23);
            lblSupplierDate.TabIndex = 7;
            lblSupplierDate.Text = "Supplier Date";
            // 
            // dtSupplierDate
            // 
            dtSupplierDate.Dock = DockStyle.Fill;
            dtSupplierDate.Location = new Point(174, 62);
            dtSupplierDate.Margin = new Padding(2);
            dtSupplierDate.Name = "dtSupplierDate";
            dtSupplierDate.Size = new Size(168, 23);
            dtSupplierDate.TabIndex = 22;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(347, 93);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 25);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // txtInvoiceNo
            // 
            txtInvoiceNo.FormattingEnabled = true;
            txtInvoiceNo.Location = new Point(519, 63);
            txtInvoiceNo.Name = "txtInvoiceNo";
            txtInvoiceNo.Size = new Size(167, 23);
            txtInvoiceNo.TabIndex = 24;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(347, 60);
            label1.Name = "label1";
            label1.Size = new Size(133, 23);
            label1.TabIndex = 11;
            label1.Text = "Payment Status";
            // 
            // gbRoute1
            // 
            gbRoute1.Controls.Add(IsTicket);
            gbRoute1.Dock = DockStyle.Fill;
            gbRoute1.ForeColor = Color.FromArgb(224, 224, 224);
            gbRoute1.Location = new Point(3, 60);
            gbRoute1.Name = "gbRoute1";
            gbRoute1.Padding = new Padding(7, 6, 7, 6);
            gbRoute1.Size = new Size(295, 528);
            gbRoute1.TabIndex = 28;
            gbRoute1.TabStop = false;
            gbRoute1.Text = "Ticket's List";
            // 
            // IsTicket
            // 
            IsTicket.Dock = DockStyle.Fill;
            IsTicket.ItemHeight = 15;
            IsTicket.Location = new Point(7, 22);
            IsTicket.Name = "IsTicket";
            IsTicket.Size = new Size(281, 500);
            IsTicket.TabIndex = 2;
            IsTicket.SelectedIndexChanged += lstRoutes_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(7, 22);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(283, 23);
            txtSearch.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.9719887F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.0280151F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1018, 595);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(gbRoute2, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(307, 2);
            tableLayoutPanel5.Margin = new Padding(2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 27.73429F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 72.26571F));
            tableLayoutPanel5.Size = new Size(709, 591);
            tableLayoutPanel5.TabIndex = 30;
            tableLayoutPanel5.Paint += tableLayoutPanel5_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(gbRoute1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(2, 2);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.701504F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 90.2985F));
            tableLayoutPanel3.Size = new Size(301, 591);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(7, 6, 7, 6);
            groupBox1.Size = new Size(297, 53);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 28, 36);
            ClientSize = new Size(1018, 595);
            Controls.Add(tableLayoutPanel1);
            Name = "FormTicket";
            Text = "FormTicket";
            WindowState = FormWindowState.Maximized;
            Load += FormTicket_Load;
            gbRoute3.ResumeLayout(false);
            gbRoute2.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            gbRoute1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbRoute3;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnLogOut;
        private GroupBox gbRoute2;
        private Label lblCustomerPosition;
        private Label lblSupplierID;
        private TextBox txtSupplierID;
        private Label lblSupplierName;
        private TextBox txtSupplierName;
        private Label lblSupplierDate;
        private TextBox txtCustomerPosition;
        private TextBox txtSupplierDate;
        private Label lblCustomerAddress;
        private TextBox txtCustomerAddress;
        private GroupBox gbRoute1;
        private ListBox IsTicket;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupBox1;
        private TextBox txtSearch;
        private DateTimePicker dtSupplierDate;
        private Button btnClear;
        private ComboBox txtInvoiceNo;
        private Label label1;
        private Label lblPaymentStatus;
    }
}