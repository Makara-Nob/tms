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
            btnNew = new Button();
            btnUpdate = new Button();
            btnLogOut = new Button();
            gbRoute2 = new GroupBox();
            lblCustomerPosition = new Label();
            lblSupplierID = new Label();
            txtSupplierID = new TextBox();
            lblSupplierName = new Label();
            txtSupplierName = new TextBox();
            lblSupplierDate = new Label();
            txtCustomerPosition = new TextBox();
            txtSupplierDate = new TextBox();
            lblCustomerAddress = new Label();
            txtCustomerAddress = new TextBox();
            gbRoute1 = new GroupBox();
            txtSearch = new TextBox();
            IsTicket = new ListBox();
            gbRoute3.SuspendLayout();
            gbRoute2.SuspendLayout();
            gbRoute1.SuspendLayout();
            SuspendLayout();
            // 
            // gbRoute3
            // 
            gbRoute3.Controls.Add(btnNew);
            gbRoute3.Controls.Add(btnUpdate);
            gbRoute3.Controls.Add(btnLogOut);
            gbRoute3.ForeColor = Color.Black;
            gbRoute3.Location = new Point(343, 440);
            gbRoute3.Name = "gbRoute3";
            gbRoute3.Size = new Size(643, 112);
            gbRoute3.TabIndex = 26;
            gbRoute3.TabStop = false;
            gbRoute3.Text = "Action";
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.White;
            btnNew.ForeColor = Color.Black;
            btnNew.Location = new Point(25, 52);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(132, 37);
            btnNew.TabIndex = 21;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(193, 52);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(132, 37);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
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
            // gbRoute2
            // 
            gbRoute2.Controls.Add(lblCustomerPosition);
            gbRoute2.Controls.Add(lblSupplierID);
            gbRoute2.Controls.Add(txtSupplierID);
            gbRoute2.Controls.Add(lblSupplierName);
            gbRoute2.Controls.Add(txtSupplierName);
            gbRoute2.Controls.Add(lblSupplierDate);
            gbRoute2.Controls.Add(txtCustomerPosition);
            gbRoute2.Controls.Add(txtSupplierDate);
            gbRoute2.Controls.Add(lblCustomerAddress);
            gbRoute2.Controls.Add(txtCustomerAddress);
            gbRoute2.ForeColor = Color.Black;
            gbRoute2.Location = new Point(343, 11);
            gbRoute2.Name = "gbRoute2";
            gbRoute2.Size = new Size(643, 410);
            gbRoute2.TabIndex = 27;
            gbRoute2.TabStop = false;
            gbRoute2.Text = "Form";
            gbRoute2.Enter += gbRoute2_Enter;
            // 
            // lblCustomerPosition
            // 
            lblCustomerPosition.BackColor = Color.Transparent;
            lblCustomerPosition.ForeColor = Color.Black;
            lblCustomerPosition.Location = new Point(24, 176);
            lblCustomerPosition.Name = "lblCustomerPosition";
            lblCustomerPosition.Size = new Size(120, 23);
            lblCustomerPosition.TabIndex = 9;
            lblCustomerPosition.Text = "Customer Position";
            // 
            // lblSupplierID
            // 
            lblSupplierID.BackColor = Color.WhiteSmoke;
            lblSupplierID.ForeColor = Color.Black;
            lblSupplierID.Location = new Point(24, 40);
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Size = new Size(96, 23);
            lblSupplierID.TabIndex = 3;
            lblSupplierID.Text = "Supplier ID";
            lblSupplierID.Click += lblRouteID_Click;
            // 
            // txtSupplierID
            // 
            txtSupplierID.Location = new Point(193, 37);
            txtSupplierID.Name = "txtSupplierID";
            txtSupplierID.Size = new Size(398, 23);
            txtSupplierID.TabIndex = 4;
            // 
            // lblSupplierName
            // 
            lblSupplierName.BackColor = Color.Transparent;
            lblSupplierName.ForeColor = Color.Black;
            lblSupplierName.Location = new Point(24, 79);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(96, 23);
            lblSupplierName.TabIndex = 5;
            lblSupplierName.Text = "Supplier Name";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(193, 79);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(398, 23);
            txtSupplierName.TabIndex = 6;
            // 
            // lblSupplierDate
            // 
            lblSupplierDate.BackColor = Color.Transparent;
            lblSupplierDate.ForeColor = Color.Black;
            lblSupplierDate.Location = new Point(24, 128);
            lblSupplierDate.Name = "lblSupplierDate";
            lblSupplierDate.Size = new Size(108, 23);
            lblSupplierDate.TabIndex = 7;
            lblSupplierDate.Text = "Supplier Date";
            // 
            // txtCustomerPosition
            // 
            txtCustomerPosition.Location = new Point(193, 173);
            txtCustomerPosition.Name = "txtCustomerPosition";
            txtCustomerPosition.Size = new Size(398, 23);
            txtCustomerPosition.TabIndex = 12;
            // 
            // txtSupplierDate
            // 
            txtSupplierDate.Location = new Point(193, 125);
            txtSupplierDate.Name = "txtSupplierDate";
            txtSupplierDate.Size = new Size(398, 23);
            txtSupplierDate.TabIndex = 8;
            // 
            // lblCustomerAddress
            // 
            lblCustomerAddress.BackColor = Color.Transparent;
            lblCustomerAddress.ForeColor = Color.Black;
            lblCustomerAddress.Location = new Point(24, 219);
            lblCustomerAddress.Name = "lblCustomerAddress";
            lblCustomerAddress.Size = new Size(133, 23);
            lblCustomerAddress.TabIndex = 11;
            lblCustomerAddress.Text = "Customer Address";
            // 
            // txtCustomerAddress
            // 
            txtCustomerAddress.Location = new Point(193, 216);
            txtCustomerAddress.Name = "txtCustomerAddress";
            txtCustomerAddress.Size = new Size(398, 23);
            txtCustomerAddress.TabIndex = 10;
            // 
            // gbRoute1
            // 
            gbRoute1.Controls.Add(txtSearch);
            gbRoute1.Controls.Add(IsTicket);
            gbRoute1.ForeColor = Color.Black;
            gbRoute1.Location = new Point(10, 11);
            gbRoute1.Name = "gbRoute1";
            gbRoute1.Size = new Size(300, 541);
            gbRoute1.TabIndex = 28;
            gbRoute1.TabStop = false;
            gbRoute1.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(261, 23);
            txtSearch.TabIndex = 1;
            // 
            // IsTicket
            // 
            IsTicket.ItemHeight = 15;
            IsTicket.Location = new Point(16, 89);
            IsTicket.Name = "IsTicket";
            IsTicket.Size = new Size(261, 424);
            IsTicket.TabIndex = 2;
            IsTicket.SelectedIndexChanged += lstRoutes_SelectedIndexChanged;
            // 
            // FormTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 595);
            Controls.Add(gbRoute3);
            Controls.Add(gbRoute2);
            Controls.Add(gbRoute1);
            Name = "FormTicket";
            Text = "FormTicket";
            Load += FormTicket_Load;
            gbRoute3.ResumeLayout(false);
            gbRoute2.ResumeLayout(false);
            gbRoute2.PerformLayout();
            gbRoute1.ResumeLayout(false);
            gbRoute1.PerformLayout();
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
        private TextBox txtSearch;
        private ListBox IsTicket;
    }
}