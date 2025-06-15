namespace tms.Forms
{
    partial class FormPassenger
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
            btnSave = new Button();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtPassengerID = new TextBox();
            txtPassengerName = new TextBox();
            txtPersonal = new TextBox();
            txtEmail = new TextBox();
            cbInactive = new CheckBox();
            label6 = new Label();
            cbGender = new ComboBox();
            gbInfo = new GroupBox();
            btnRemove = new Button();
            btnAdd = new Button();
            txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            btnRefresh = new Button();
            groupBox2 = new GroupBox();
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Blue;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(8, 184);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(79, 30);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(92, 184);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(79, 30);
            btnClose.TabIndex = 18;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 40);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 0;
            label1.Text = "Passenger ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 40);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Passenger Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 86);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 132);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // txtPassengerID
            // 
            txtPassengerID.Location = new Point(147, 34);
            txtPassengerID.Margin = new Padding(3, 2, 3, 2);
            txtPassengerID.Name = "txtPassengerID";
            txtPassengerID.Size = new Size(271, 23);
            txtPassengerID.TabIndex = 5;
            // 
            // txtPassengerName
            // 
            txtPassengerName.Location = new Point(582, 34);
            txtPassengerName.Margin = new Padding(3, 2, 3, 2);
            txtPassengerName.Name = "txtPassengerName";
            txtPassengerName.Size = new Size(271, 23);
            txtPassengerName.TabIndex = 6;
            // 
            // txtPersonal
            // 
            txtPersonal.Location = new Point(582, 81);
            txtPersonal.Margin = new Padding(3, 2, 3, 2);
            txtPersonal.Name = "txtPersonal";
            txtPersonal.Size = new Size(271, 23);
            txtPersonal.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 127);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(271, 23);
            txtEmail.TabIndex = 9;
            // 
            // cbInactive
            // 
            cbInactive.AutoSize = true;
            cbInactive.Location = new Point(440, 132);
            cbInactive.Margin = new Padding(3, 2, 3, 2);
            cbInactive.Name = "cbInactive";
            cbInactive.Size = new Size(122, 19);
            cbInactive.TabIndex = 10;
            cbInactive.Text = "Inactive Customer";
            cbInactive.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(440, 86);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 11;
            label6.Text = "Personal Number";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(147, 81);
            cbGender.Margin = new Padding(3, 2, 3, 2);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(271, 23);
            cbGender.TabIndex = 12;
            // 
            // gbInfo
            // 
            gbInfo.Controls.Add(cbGender);
            gbInfo.Controls.Add(btnSave);
            gbInfo.Controls.Add(label6);
            gbInfo.Controls.Add(cbInactive);
            gbInfo.Controls.Add(btnClose);
            gbInfo.Controls.Add(txtEmail);
            gbInfo.Controls.Add(txtPersonal);
            gbInfo.Controls.Add(txtPassengerName);
            gbInfo.Controls.Add(txtPassengerID);
            gbInfo.Controls.Add(label5);
            gbInfo.Controls.Add(label3);
            gbInfo.Controls.Add(label2);
            gbInfo.Controls.Add(label1);
            gbInfo.Location = new Point(10, 27);
            gbInfo.Margin = new Padding(3, 2, 3, 2);
            gbInfo.Name = "gbInfo";
            gbInfo.Padding = new Padding(3, 2, 3, 2);
            gbInfo.Size = new Size(953, 223);
            gbInfo.TabIndex = 1;
            gbInfo.TabStop = false;
            gbInfo.Text = "Information";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(765, 19);
            btnRemove.Margin = new Padding(3, 2, 3, 2);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(88, 37);
            btnRemove.TabIndex = 15;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(672, 20);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(88, 37);
            btnAdd.TabIndex = 14;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(20, 28);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(411, 23);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(20, 60);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(914, 254);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Green;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(858, 20);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(77, 36);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRefresh);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Controls.Add(btnRemove);
            groupBox2.Location = new Point(10, 254);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(953, 331);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search";
            // 
            // FormPassenger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 669);
            Controls.Add(gbInfo);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormPassenger";
            Text = "Passenger_information";
            Load += FormPassenger_Load;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSave;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtPassengerID;
        private TextBox txtPassengerName;
        private TextBox txtPersonal;
        private TextBox txtEmail;
        private CheckBox cbInactive;
        private Label label6;
        private ComboBox cbGender;
        private GroupBox gbInfo;
        private Button btnRemove;
        private Button btnAdd;
        private TextBox txtSearch;
        private DataGridView dataGridView1;
        private Button btnRefresh;
        private GroupBox groupBox2;
    }
}