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
            btnNew.Location = new Point(4, 155);
            btnNew.Margin = new Padding(4, 5, 4, 5);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(111, 42);
            btnNew.TabIndex = 21;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(250, 155);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 42);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // gbRoute2
            // 
            gbRoute2.Controls.Add(tableLayoutPanel4);
            gbRoute2.Dock = DockStyle.Fill;
            gbRoute2.ForeColor = Color.FromArgb(224, 224, 224);
            gbRoute2.Location = new Point(4, 5);
            gbRoute2.Margin = new Padding(4, 5, 4, 5);
            gbRoute2.Name = "gbRoute2";
            gbRoute2.Padding = new Padding(10);
            gbRoute2.Size = new Size(1005, 263);
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
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(10, 34);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.Size = new Size(985, 219);
            tableLayoutPanel4.TabIndex = 30;
            // 
            // txtSupplierID
            // 
            txtSupplierID.Dock = DockStyle.Fill;
            txtSupplierID.Location = new Point(250, 5);
            txtSupplierID.Margin = new Padding(4, 5, 4, 5);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(238, 31);
            txtSupplierID.TabIndex = 4;
            // 
            // lblCustomerPosition
            // 
            lblCustomerPosition.BackColor = Color.Transparent;
            lblCustomerPosition.ForeColor = Color.FromArgb(224, 224, 224);
            lblCustomerPosition.Location = new Point(496, 0);
            lblCustomerPosition.Margin = new Padding(4, 0, 4, 0);
            lblCustomerPosition.Name = "lblCustomerPosition";
            lblCustomerPosition.Size = new Size(171, 38);
            lblCustomerPosition.TabIndex = 9;
            lblCustomerPosition.Text = "Customer Position";
            // 
            // lblSupplierID
            // 
            lblSupplierID.BackColor = Color.Transparent;
            lblSupplierID.ForeColor = Color.FromArgb(224, 224, 224);
            lblSupplierID.Location = new Point(4, 0);
            lblSupplierID.Margin = new Padding(4, 0, 4, 0);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(137, 38);
            lblSupplierID.TabIndex = 3;
            lblSupplierID.Text = "Supplier ID";
            lblSupplierID.Click += lblRouteID_Click;
            // 
            // txtCustomerPosition
            // 
            txtCustomerPosition.Dock = DockStyle.Fill;
            txtCustomerPosition.Location = new Point(742, 5);
            txtCustomerPosition.Margin = new Padding(4, 5, 4, 5);
            txtCustomerPosition.Name = "txtCustomerPosition";
            txtCustomerPosition.Size = new Size(239, 31);
            txtCustomerPosition.TabIndex = 12;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Dock = DockStyle.Fill;
            txtSupplierName.Location = new Point(250, 55);
            txtSupplierName.Margin = new Padding(4, 5, 4, 5);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(238, 31);
            txtSupplierName.TabIndex = 6;
            // 
            // lblSupplierName
            // 
            lblSupplierName.BackColor = Color.Transparent;
            lblSupplierName.ForeColor = Color.FromArgb(224, 224, 224);
            lblSupplierName.Location = new Point(4, 50);
            lblSupplierName.Margin = new Padding(4, 0, 4, 0);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(137, 38);
            lblSupplierName.TabIndex = 5;
            lblSupplierName.Text = "Supplier Name";
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.BackColor = Color.Transparent;
            lblCustomerAddress.ForeColor = Color.FromArgb(224, 224, 224);
            lblCustomerAddress.Location = new Point(496, 50);
            lblCustomerAddress.Margin = new Padding(4, 0, 4, 0);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(190, 38);
            lblCustomerAddress.TabIndex = 11;
            lblCustomerAddress.Text = "Customer Address";
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Dock = DockStyle.Fill;
            txtCustomerAddress.Location = new Point(742, 55);
            txtCustomerAddress.Margin = new Padding(4, 5, 4, 5);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(239, 31);
            txtCustomerAddress.TabIndex = 10;
            // 
            // lblSupplierDate
            // 
            lblSupplierDate.BackColor = Color.Transparent;
            lblSupplierDate.ForeColor = Color.FromArgb(224, 224, 224);
            lblSupplierDate.Location = new Point(4, 100);
            lblSupplierDate.Margin = new Padding(4, 0, 4, 0);
            lblSupplierDate.Name = "lblSupplierDate";
            lblSupplierDate.Size = new Size(154, 38);
            lblSupplierDate.TabIndex = 7;
            lblSupplierDate.Text = "Supplier Date";
            // 
            // dtSupplierDate
            // 
            dtSupplierDate.Dock = DockStyle.Fill;
            dtSupplierDate.Location = new Point(249, 103);
            dtSupplierDate.Name = "dtSupplierDate";
            dtSupplierDate.Size = new Size(240, 31);
            dtSupplierDate.TabIndex = 22;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(496, 155);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 42);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // gbRoute1
            // 
            gbRoute1.Controls.Add(IsTicket);
            gbRoute1.Dock = DockStyle.Fill;
            gbRoute1.ForeColor = Color.FromArgb(224, 224, 224);
            gbRoute1.Location = new Point(4, 100);
            gbRoute1.Margin = new Padding(4, 5, 4, 5);
            gbRoute1.Name = "gbRoute1";
            gbRoute1.Padding = new Padding(10);
            gbRoute1.Size = new Size(421, 881);
            gbRoute1.TabIndex = 28;
            gbRoute1.TabStop = false;
            gbRoute1.Text = "Ticket's List";
            gbRoute1.Enter += gbRoute1_Enter;
            // 
            // IsTicket
            // 
            IsTicket.Dock = DockStyle.Fill;
            IsTicket.ItemHeight = 25;
            IsTicket.Location = new Point(10, 34);
            IsTicket.Margin = new Padding(4, 5, 4, 5);
            IsTicket.Name = "IsTicket";
            IsTicket.Size = new Size(401, 837);
            IsTicket.TabIndex = 2;
            IsTicket.SelectedIndexChanged += lstRoutes_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(10, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(403, 31);
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1454, 992);
            tableLayoutPanel1.TabIndex = 29;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(gbRoute2, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(438, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 27.73429F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 72.26571F));
            tableLayoutPanel5.Size = new Size(1013, 986);
            tableLayoutPanel5.TabIndex = 30;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(gbRoute1, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.701504F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 90.2985F));
            tableLayoutPanel3.Size = new Size(429, 986);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(423, 89);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 28, 36);
            ClientSize = new Size(1454, 992);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
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
    }
}