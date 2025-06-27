namespace tms.Forms
{
    partial class PaymentForm
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
            panel1 = new Panel();
            lstPayments = new ListBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            panel2 = new Panel();
            btnClear = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            cmbPaymentDate = new ComboBox();
            lblPaymentDate = new Label();
            txtAmountPaid = new TextBox();
            lblAmountPaid = new Label();
            cmbStaffID = new ComboBox();
            lblStaffID = new Label();
            cmbPaymentMethod = new ComboBox();
            lblPaymentMethod = new Label();
            cmbInvoiceNo = new ComboBox(); // Changed from TextBox to ComboBox
            lblInvoiceNo = new Label();
            txtPaymentID = new TextBox();
            lblPaymentID = new Label();
            lblPaymentForm = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lstPayments);
            panel1.Controls.Add(lblSearch);
            panel1.Controls.Add(txtSearch);
            panel1.Location = new Point(14, 14);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 692);
            panel1.TabIndex = 0;
            // 
            // lstPayments
            // 
            lstPayments.BackColor = Color.White;
            lstPayments.BorderStyle = BorderStyle.FixedSingle;
            lstPayments.Font = new Font("Microsoft Sans Serif", 9F);
            lstPayments.FormattingEnabled = true;
            lstPayments.ItemHeight = 15;
            lstPayments.Location = new Point(18, 81);
            lstPayments.Margin = new Padding(4, 3, 4, 3);
            lstPayments.Name = "lstPayments";
            lstPayments.Size = new Size(431, 587);
            lstPayments.TabIndex = 2;
            lstPayments.SelectedIndexChanged += lstPayments_SelectedIndexChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.FromArgb(45, 45, 48);
            lblSearch.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblSearch.ForeColor = Color.White;
            lblSearch.Location = new Point(18, 17);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(52, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Microsoft Sans Serif", 9F);
            txtSearch.Location = new Point(18, 40);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(431, 21);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 45, 48);
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnInsert);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(cmbStatus);
            panel2.Controls.Add(lblStatus);
            panel2.Controls.Add(cmbPaymentDate);
            panel2.Controls.Add(lblPaymentDate);
            panel2.Controls.Add(txtAmountPaid);
            panel2.Controls.Add(lblAmountPaid);
            panel2.Controls.Add(cmbStaffID);
            panel2.Controls.Add(lblStaffID);
            panel2.Controls.Add(cmbPaymentMethod);
            panel2.Controls.Add(lblPaymentMethod);
            panel2.Controls.Add(cmbInvoiceNo); // Changed from txtInvoiceNo
            panel2.Controls.Add(lblInvoiceNo);
            panel2.Controls.Add(txtPaymentID);
            panel2.Controls.Add(lblPaymentID);
            panel2.Controls.Add(lblPaymentForm);
            panel2.Location = new Point(496, 14);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(642, 692);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(70, 70, 70);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Microsoft Sans Serif", 9F);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(303, 438);
            btnClear.Margin = new Padding(4, 3, 4, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 35);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(70, 70, 70);
            btnInsert.FlatAppearance.BorderSize = 0;
            btnInsert.FlatStyle = FlatStyle.Flat;
            btnInsert.Font = new Font("Microsoft Sans Serif", 9F);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(163, 438);
            btnInsert.Margin = new Padding(4, 3, 4, 3);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(117, 35);
            btnInsert.TabIndex = 16;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(70, 70, 70);
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 9F);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(23, 438);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(117, 35);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Microsoft Sans Serif", 9F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Pending", "Completed", "Failed", "Cancelled", "Refunded" });
            cmbStatus.Location = new Point(338, 162);
            cmbStatus.Margin = new Padding(4, 3, 4, 3);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(279, 23);
            cmbStatus.TabIndex = 14;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 9F);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(338, 138);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(41, 15);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status";
            // 
            // cmbPaymentDate
            // 
            cmbPaymentDate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentDate.Font = new Font("Microsoft Sans Serif", 9F);
            cmbPaymentDate.FormattingEnabled = true;
            cmbPaymentDate.Location = new Point(338, 92);
            cmbPaymentDate.Margin = new Padding(4, 3, 4, 3);
            cmbPaymentDate.Name = "cmbPaymentDate";
            cmbPaymentDate.Size = new Size(279, 23);
            cmbPaymentDate.TabIndex = 12;
            // 
            // lblPaymentDate
            // 
            lblPaymentDate.AutoSize = true;
            lblPaymentDate.Font = new Font("Microsoft Sans Serif", 9F);
            lblPaymentDate.ForeColor = Color.White;
            lblPaymentDate.Location = new Point(338, 69);
            lblPaymentDate.Margin = new Padding(4, 0, 4, 0);
            lblPaymentDate.Name = "lblPaymentDate";
            lblPaymentDate.Size = new Size(84, 15);
            lblPaymentDate.TabIndex = 11;
            lblPaymentDate.Text = "Payment Date";
            // 
            // txtAmountPaid
            // 
            txtAmountPaid.Font = new Font("Microsoft Sans Serif", 9F);
            txtAmountPaid.Location = new Point(23, 369);
            txtAmountPaid.Margin = new Padding(4, 3, 4, 3);
            txtAmountPaid.Name = "txtAmountPaid";
            txtAmountPaid.Size = new Size(291, 21);
            txtAmountPaid.TabIndex = 10;
            // 
            // lblAmountPaid
            // 
            lblAmountPaid.AutoSize = true;
            lblAmountPaid.Font = new Font("Microsoft Sans Serif", 9F);
            lblAmountPaid.ForeColor = Color.White;
            lblAmountPaid.Location = new Point(23, 346);
            lblAmountPaid.Margin = new Padding(4, 0, 4, 0);
            lblAmountPaid.Name = "lblAmountPaid";
            lblAmountPaid.Size = new Size(77, 15);
            lblAmountPaid.TabIndex = 9;
            lblAmountPaid.Text = "Amount Paid";
            // 
            // cmbStaffID
            // 
            cmbStaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStaffID.Font = new Font("Microsoft Sans Serif", 9F);
            cmbStaffID.FormattingEnabled = true;
            cmbStaffID.Location = new Point(23, 300);
            cmbStaffID.Margin = new Padding(4, 3, 4, 3);
            cmbStaffID.Name = "cmbStaffID";
            cmbStaffID.Size = new Size(291, 23);
            cmbStaffID.TabIndex = 8;
            // 
            // lblStaffID
            // 
            lblStaffID.AutoSize = true;
            lblStaffID.Font = new Font("Microsoft Sans Serif", 9F);
            lblStaffID.ForeColor = Color.White;
            lblStaffID.Location = new Point(23, 277);
            lblStaffID.Margin = new Padding(4, 0, 4, 0);
            lblStaffID.Name = "lblStaffID";
            lblStaffID.Size = new Size(46, 15);
            lblStaffID.TabIndex = 7;
            lblStaffID.Text = "Staff ID";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Font = new Font("Microsoft Sans Serif", 9F);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Credit Card", "Debit Card", "Bank Transfer", "Check" });
            cmbPaymentMethod.Location = new Point(23, 231);
            cmbPaymentMethod.Margin = new Padding(4, 3, 4, 3);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(291, 23);
            cmbPaymentMethod.TabIndex = 6;
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Microsoft Sans Serif", 9F);
            lblPaymentMethod.ForeColor = Color.White;
            lblPaymentMethod.Location = new Point(23, 208);
            lblPaymentMethod.Margin = new Padding(4, 0, 4, 0);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(100, 15);
            lblPaymentMethod.TabIndex = 5;
            lblPaymentMethod.Text = "Payment Method";
            // 
            // cmbInvoiceNo
            // 
            cmbInvoiceNo.DropDownStyle = ComboBoxStyle.DropDownList; // New ComboBox for Invoice No
            cmbInvoiceNo.Font = new Font("Microsoft Sans Serif", 9F);
            cmbInvoiceNo.FormattingEnabled = true;
            cmbInvoiceNo.Location = new Point(23, 162);
            cmbInvoiceNo.Margin = new Padding(4, 3, 4, 3);
            cmbInvoiceNo.Name = "cmbInvoiceNo";
            cmbInvoiceNo.Size = new Size(291, 23);
            cmbInvoiceNo.TabIndex = 4;
            // 
            // lblInvoiceNo
            // 
            lblInvoiceNo.AutoSize = true;
            lblInvoiceNo.Font = new Font("Microsoft Sans Serif", 9F);
            lblInvoiceNo.ForeColor = Color.White;
            lblInvoiceNo.Location = new Point(23, 138);
            lblInvoiceNo.Margin = new Padding(4, 0, 4, 0);
            lblInvoiceNo.Name = "lblInvoiceNo";
            lblInvoiceNo.Size = new Size(64, 15);
            lblInvoiceNo.TabIndex = 3;
            lblInvoiceNo.Text = "Invoice No";
            // 
            // txtPaymentID
            // 
            txtPaymentID.Font = new Font("Microsoft Sans Serif", 9F);
            txtPaymentID.Location = new Point(23, 92);
            txtPaymentID.Margin = new Padding(4, 3, 4, 3);
            txtPaymentID.Name = "txtPaymentID";
            txtPaymentID.Size = new Size(291, 21);
            txtPaymentID.TabIndex = 2;
            // 
            // lblPaymentID
            // 
            lblPaymentID.AutoSize = true;
            lblPaymentID.Font = new Font("Microsoft Sans Serif", 9F);
            lblPaymentID.ForeColor = Color.White;
            lblPaymentID.Location = new Point(23, 69);
            lblPaymentID.Margin = new Padding(4, 0, 4, 0);
            lblPaymentID.Name = "lblPaymentID";
            lblPaymentID.Size = new Size(70, 15);
            lblPaymentID.TabIndex = 1;
            lblPaymentID.Text = "Payment ID";
            // 
            // lblPaymentForm
            // 
            lblPaymentForm.AutoSize = true;
            lblPaymentForm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblPaymentForm.ForeColor = Color.White;
            lblPaymentForm.Location = new Point(23, 17);
            lblPaymentForm.Margin = new Padding(4, 0, 4, 0);
            lblPaymentForm.Name = "lblPaymentForm";
            lblPaymentForm.Size = new Size(124, 20);
            lblPaymentForm.TabIndex = 0;
            lblPaymentForm.Text = "Payment Form";
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1152, 720);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment Information";
            Load += PaymentForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox lstPayments;
        private Label lblSearch;
        private TextBox txtSearch;
        private Panel panel2;
        private Button btnClear;
        private Button btnInsert;
        private Button btnUpdate;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private ComboBox cmbPaymentDate;
        private Label lblPaymentDate;
        private TextBox txtAmountPaid;
        private Label lblAmountPaid;
        private ComboBox cmbStaffID;
        private Label lblStaffID;
        private ComboBox cmbPaymentMethod;
        private Label lblPaymentMethod;
        private ComboBox cmbInvoiceNo; // Changed from TextBox to ComboBox
        private Label lblInvoiceNo;
        private TextBox txtPaymentID;
        private Label lblPaymentID;
        private Label lblPaymentForm;
    }
}