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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            txtSearch = new TextBox();
            gbRoute2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            gbRoute1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.White;
            btnNew.ForeColor = Color.Black;
            btnNew.Location = new Point(4, 125);
            btnNew.Margin = new Padding(4, 5, 4, 5);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(112, 44);
            btnNew.TabIndex = 21;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(253, 125);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 44);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // gbRoute2
            // 
            gbRoute2.Controls.Add(tableLayoutPanel4);
            gbRoute2.Dock = DockStyle.Fill;
            gbRoute2.ForeColor = Color.Black;
            gbRoute2.Location = new Point(4, 5);
            gbRoute2.Margin = new Padding(4, 5, 4, 5);
            gbRoute2.Name = "gbRoute2";
            gbRoute2.Padding = new Padding(4, 5, 4, 5);
            gbRoute2.Size = new Size(1005, 263);
            gbRoute2.TabIndex = 27;
            gbRoute2.TabStop = false;
            gbRoute2.Text = "Form";
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
            tableLayoutPanel4.Location = new Point(4, 29);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(997, 229);
            tableLayoutPanel4.TabIndex = 30;
            // 
            // txtSupplierID
            // 
            txtSupplierID.Dock = DockStyle.Fill;
            txtSupplierID.Location = new Point(253, 5);
            txtSupplierID.Margin = new Padding(4, 5, 4, 5);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(241, 31);
            txtSupplierID.TabIndex = 4;
            // 
            // lblCustomerPosition
            // 
            lblCustomerPosition.BackColor = Color.Transparent;
            lblCustomerPosition.ForeColor = Color.Black;
            lblCustomerPosition.Location = new Point(502, 0);
            lblCustomerPosition.Margin = new Padding(4, 0, 4, 0);
            lblCustomerPosition.Name = "lblCustomerPosition";
            lblCustomerPosition.Size = new Size(171, 38);
            lblCustomerPosition.TabIndex = 9;
            lblCustomerPosition.Text = "Customer Position";
            // 
            // lblSupplierID
            // 
            lblSupplierID.BackColor = Color.WhiteSmoke;
            lblSupplierID.ForeColor = Color.Black;
            lblSupplierID.Location = new Point(4, 0);
            lblSupplierID.Margin = new Padding(4, 0, 4, 0);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(137, 38);
            lblSupplierID.TabIndex = 3;
            lblSupplierID.Text = "Supplier ID";
            // 
            // txtCustomerPosition
            // 
            txtCustomerPosition.Dock = DockStyle.Fill;
            txtCustomerPosition.Location = new Point(751, 5);
            txtCustomerPosition.Margin = new Padding(4, 5, 4, 5);
            txtCustomerPosition.Name = "txtCustomerPosition";
            txtCustomerPosition.Size = new Size(242, 31);
            txtCustomerPosition.TabIndex = 12;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Dock = DockStyle.Fill;
            txtSupplierName.Location = new Point(253, 46);
            txtSupplierName.Margin = new Padding(4, 5, 4, 5);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(241, 31);
            txtSupplierName.TabIndex = 6;
            // 
            // lblSupplierName
            // 
            lblSupplierName.BackColor = Color.Transparent;
            lblSupplierName.ForeColor = Color.Black;
            lblSupplierName.Location = new Point(4, 41);
            lblSupplierName.Margin = new Padding(4, 0, 4, 0);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(137, 38);
            lblSupplierName.TabIndex = 5;
            lblSupplierName.Text = "Supplier Name";
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.BackColor = Color.Transparent;
            lblCustomerAddress.ForeColor = Color.Black;
            lblCustomerAddress.Location = new Point(502, 41);
            lblCustomerAddress.Margin = new Padding(4, 0, 4, 0);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(190, 38);
            lblCustomerAddress.TabIndex = 11;
            lblCustomerAddress.Text = "Customer Address";
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Dock = DockStyle.Fill;
            txtCustomerAddress.Location = new Point(751, 46);
            txtCustomerAddress.Margin = new Padding(4, 5, 4, 5);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(242, 31);
            txtCustomerAddress.TabIndex = 10;
            // 
            // lblSupplierDate
            // 
            lblSupplierDate.BackColor = Color.Transparent;
            lblSupplierDate.ForeColor = Color.Black;
            lblSupplierDate.Location = new Point(4, 82);
            lblSupplierDate.Margin = new Padding(4, 0, 4, 0);
            lblSupplierDate.Name = "lblSupplierDate";
            lblSupplierDate.Size = new Size(154, 38);
            lblSupplierDate.TabIndex = 7;
            lblSupplierDate.Text = "Supplier Date";
            // 
            // dtSupplierDate
            // 
            dtSupplierDate.Dock = DockStyle.Fill;
            dtSupplierDate.Location = new Point(252, 85);
            dtSupplierDate.Name = "dtSupplierDate";
            dtSupplierDate.Size = new Size(243, 31);
            dtSupplierDate.TabIndex = 22;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(502, 125);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 44);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // gbRoute1
            // 
            gbRoute1.Controls.Add(IsTicket);
            gbRoute1.Dock = DockStyle.Fill;
            gbRoute1.ForeColor = Color.Black;
            gbRoute1.Location = new Point(4, 82);
            gbRoute1.Margin = new Padding(4, 5, 4, 5);
            gbRoute1.Name = "gbRoute1";
            gbRoute1.Padding = new Padding(4, 5, 4, 5);
            gbRoute1.Size = new Size(421, 899);
            gbRoute1.TabIndex = 28;
            gbRoute1.TabStop = false;
            gbRoute1.Text = "Ticket's List";
            // 
            // IsTicket
            // 
            IsTicket.Dock = DockStyle.Fill;
            IsTicket.ItemHeight = 25;
            IsTicket.Location = new Point(4, 29);
            IsTicket.Margin = new Padding(4, 5, 4, 5);
            IsTicket.Name = "IsTicket";
            IsTicket.Size = new Size(413, 865);
            IsTicket.TabIndex = 2;
            IsTicket.SelectedIndexChanged += lstRoutes_SelectedIndexChanged;
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
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7.895534F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 92.10446F));
            tableLayoutPanel3.Size = new Size(429, 986);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(423, 71);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(3, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(417, 31);
            txtSearch.TabIndex = 0;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1454, 992);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormTicket";
            Text = "FormTicket";
            Load += FormTicket_Load;
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
        private Button btnNew;
        private Button btnUpdate;
        private GroupBox gbRoute2;
        private Label lblCustomerPosition;
        private Label lblSupplierID;
        private TextBox txtSupplierID;
        private Label lblSupplierName;
        private TextBox txtSupplierName;
        private Label lblSupplierDate;
        private TextBox txtCustomerPosition;
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