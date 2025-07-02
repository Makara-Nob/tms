namespace tms.Forms
{
    partial class InvoiceForm : Form
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
            lblInvoiceId = new Label();
            lblInvoiceDate = new Label();
            lblStaffId = new Label();
            lblTotalAmount = new Label();
            txtInvoiceId = new TextBox();
            dtpInvoiceDate = new DateTimePicker();
            cmbStaffId = new ComboBox();
            txtTotalAmount = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            dgvInvoices = new DataGridView();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            SuspendLayout();
            // 
            // lblInvoiceId
            // 
            lblInvoiceId.AutoSize = true;
            lblInvoiceId.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblInvoiceId.ForeColor = SystemColors.ButtonHighlight;
            lblInvoiceId.Location = new Point(30, 30);
            lblInvoiceId.Name = "lblInvoiceId";
            lblInvoiceId.Size = new Size(81, 16);
            lblInvoiceId.TabIndex = 0;
            lblInvoiceId.Text = "Invoice ID:";
            // 
            // lblInvoiceDate
            // 
            lblInvoiceDate.AutoSize = true;
            lblInvoiceDate.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblInvoiceDate.ForeColor = SystemColors.ButtonHighlight;
            lblInvoiceDate.Location = new Point(30, 70);
            lblInvoiceDate.Name = "lblInvoiceDate";
            lblInvoiceDate.Size = new Size(99, 16);
            lblInvoiceDate.TabIndex = 1;
            lblInvoiceDate.Text = "Invoice Date:";
            // 
            // lblStaffId
            // 
            lblStaffId.AutoSize = true;
            lblStaffId.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblStaffId.ForeColor = SystemColors.ButtonHighlight;
            lblStaffId.Location = new Point(30, 110);
            lblStaffId.Name = "lblStaffId";
            lblStaffId.Size = new Size(61, 16);
            lblStaffId.TabIndex = 2;
            lblStaffId.Text = "Staff ID:";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTotalAmount.ForeColor = SystemColors.ButtonFace;
            lblTotalAmount.Location = new Point(30, 150);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(100, 16);
            lblTotalAmount.TabIndex = 3;
            lblTotalAmount.Text = "Total Amount:";
            // 
            // txtInvoiceId
            // 
            txtInvoiceId.Font = new Font("Arial", 10F);
            txtInvoiceId.Location = new Point(150, 27);
            txtInvoiceId.Name = "txtInvoiceId";
            txtInvoiceId.Size = new Size(400, 23);
            txtInvoiceId.TabIndex = 4;
            // 
            // dtpInvoiceDate
            // 
            dtpInvoiceDate.Font = new Font("Arial", 10F);
            dtpInvoiceDate.Format = DateTimePickerFormat.Short;
            dtpInvoiceDate.Location = new Point(150, 67);
            dtpInvoiceDate.Name = "dtpInvoiceDate";
            dtpInvoiceDate.Size = new Size(400, 23);
            dtpInvoiceDate.TabIndex = 5;
            // 
            // cmbStaffId
            // 
            cmbStaffId.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStaffId.Font = new Font("Arial", 10F);
            cmbStaffId.FormattingEnabled = true;
            cmbStaffId.Location = new Point(150, 107);
            cmbStaffId.Name = "cmbStaffId";
            cmbStaffId.Size = new Size(400, 24);
            cmbStaffId.TabIndex = 6;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Arial", 10F);
            txtTotalAmount.Location = new Point(150, 147);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(400, 23);
            txtTotalAmount.TabIndex = 7;
            txtTotalAmount.KeyPress += txtTotalAmount_KeyPress;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DodgerBlue;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(50, 200);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 35);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(170, 200);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(290, 200);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Gray;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(410, 200);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 35);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvInvoices
            // 
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToDeleteRows = false;
            dgvInvoices.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.BackgroundColor = Color.White;
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.Location = new Point(580, 50);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.ReadOnly = true;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.Size = new Size(800, 556);
            dgvInvoices.TabIndex = 12;
            dgvInvoices.CellClick += dgvInvoices_CellClick;
            dgvInvoices.CellContentClick += dgvInvoices_CellContentClick;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MediumSeaGreen;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1000, 7);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 35);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Arial", 10F);
            txtSearch.Location = new Point(700, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(290, 23);
            txtSearch.TabIndex = 15;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblSearch.ForeColor = SystemColors.ButtonHighlight;
            lblSearch.Location = new Point(580, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(116, 16);
            lblSearch.TabIndex = 16;
            lblSearch.Text = "Search Invoice:";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Orange;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Arial", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(50, 264);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 35);
            btnClear.TabIndex = 17;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // InvoiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1400, 656);
            Controls.Add(btnClear);
            Controls.Add(lblSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(dgvInvoices);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtTotalAmount);
            Controls.Add(cmbStaffId);
            Controls.Add(dtpInvoiceDate);
            Controls.Add(txtInvoiceId);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblStaffId);
            Controls.Add(lblInvoiceDate);
            Controls.Add(lblInvoiceId);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "InvoiceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Invoice Management";
            Load += InvoiceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblInvoiceId;
        private System.Windows.Forms.Label lblInvoiceDate;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.TextBox txtInvoiceId;
        private System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        private System.Windows.Forms.ComboBox cmbStaffId; // Changed from TextBox to ComboBox
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnClear;
    }
}