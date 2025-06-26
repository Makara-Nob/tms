namespace tms
{
    partial class FormStaff
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            mainTableLayout = new TableLayoutPanel();
            staffInfoPanel = new Panel();
            grpStaffInfo = new GroupBox();
            staffInfoTableLayout = new TableLayoutPanel();
            lblStaffId = new Label();
            txtStaffId = new TextBox();
            lblStaffName = new Label();
            txtStaffName = new TextBox();
            photoPanel = new Panel();
            picStaffPhoto = new PictureBox();
            btnBrowsePhoto = new Button();
            btnRemovePhoto = new Button();
            lblGender = new Label();
            genderPanel = new Panel();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            lblBirthDate = new Label();
            dtBirthDate = new DateTimePicker();
            lblAddress = new Label();
            txtAddress = new TextBox();
            lblContactNumber = new Label();
            txtContactNumber = new TextBox();
            lblPersonalNumber = new Label();
            txtPersonalNumber = new TextBox();
            lblPosition = new Label();
            cmbPosition = new ComboBox();
            lblSalary = new Label();
            txtSalary = new TextBox();
            lblHiredDate = new Label();
            dtHiredDate = new DateTimePicker();
            lblStatus = new Label();
            statusPanel = new Panel();
            rbActive = new RadioButton();
            rbInactive = new RadioButton();
            actionButtonPanel = new Panel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            searchPanel = new Panel();
            grpSearch = new GroupBox();
            searchTableLayout = new TableLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            dataGridPanel = new Panel();
            grpStaffList = new GroupBox();
            dgvStaff = new DataGridView();
            errorProvider = new ErrorProvider(components);
            toolTip = new ToolTip(components);
            mainTableLayout.SuspendLayout();
            staffInfoPanel.SuspendLayout();
            grpStaffInfo.SuspendLayout();
            staffInfoTableLayout.SuspendLayout();
            photoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picStaffPhoto).BeginInit();
            genderPanel.SuspendLayout();
            statusPanel.SuspendLayout();
            actionButtonPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            grpSearch.SuspendLayout();
            searchTableLayout.SuspendLayout();
            dataGridPanel.SuspendLayout();
            grpStaffList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // mainTableLayout
            // 
            mainTableLayout.BackColor = Color.FromArgb(22, 28, 36);
            mainTableLayout.ColumnCount = 1;
            mainTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayout.Controls.Add(staffInfoPanel, 0, 0);
            mainTableLayout.Controls.Add(searchPanel, 0, 1);
            mainTableLayout.Controls.Add(dataGridPanel, 0, 2);
            mainTableLayout.Dock = DockStyle.Fill;
            mainTableLayout.Location = new Point(0, 0);
            mainTableLayout.Margin = new Padding(7, 6, 7, 6);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.Padding = new Padding(7, 6, 7, 6);
            mainTableLayout.RowCount = 3;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 49.9999962F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            mainTableLayout.Size = new Size(1347, 637);
            mainTableLayout.TabIndex = 0;
            // 
            // staffInfoPanel
            // 
            staffInfoPanel.Controls.Add(grpStaffInfo);
            staffInfoPanel.Dock = DockStyle.Fill;
            staffInfoPanel.Location = new Point(11, 9);
            staffInfoPanel.Margin = new Padding(4, 3, 4, 3);
            staffInfoPanel.Name = "staffInfoPanel";
            staffInfoPanel.Size = new Size(1325, 270);
            staffInfoPanel.TabIndex = 0;
            // 
            // grpStaffInfo
            // 
            grpStaffInfo.BackColor = Color.FromArgb(22, 28, 36);
            grpStaffInfo.Controls.Add(staffInfoTableLayout);
            grpStaffInfo.Dock = DockStyle.Fill;
            grpStaffInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpStaffInfo.ForeColor = Color.FromArgb(224, 224, 224);
            grpStaffInfo.Location = new Point(0, 0);
            grpStaffInfo.Margin = new Padding(4, 3, 4, 3);
            grpStaffInfo.Name = "grpStaffInfo";
            grpStaffInfo.Padding = new Padding(10, 9, 10, 9);
            grpStaffInfo.Size = new Size(1325, 270);
            grpStaffInfo.TabIndex = 0;
            grpStaffInfo.TabStop = false;
            grpStaffInfo.Text = "Staff Information";
            // 
            // staffInfoTableLayout
            // 
            staffInfoTableLayout.ColumnCount = 5;
            staffInfoTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.64706F));
            staffInfoTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5294113F));
            staffInfoTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5294113F));
            staffInfoTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.6470585F));
            staffInfoTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.6470585F));
            staffInfoTableLayout.Controls.Add(lblStaffId, 0, 0);
            staffInfoTableLayout.Controls.Add(txtStaffId, 1, 0);
            staffInfoTableLayout.Controls.Add(lblStaffName, 2, 0);
            staffInfoTableLayout.Controls.Add(txtStaffName, 3, 0);
            staffInfoTableLayout.Controls.Add(photoPanel, 4, 0);
            staffInfoTableLayout.Controls.Add(lblGender, 0, 1);
            staffInfoTableLayout.Controls.Add(genderPanel, 1, 1);
            staffInfoTableLayout.Controls.Add(lblBirthDate, 2, 1);
            staffInfoTableLayout.Controls.Add(dtBirthDate, 3, 1);
            staffInfoTableLayout.Controls.Add(lblAddress, 0, 2);
            staffInfoTableLayout.Controls.Add(txtAddress, 1, 2);
            staffInfoTableLayout.Controls.Add(lblContactNumber, 2, 2);
            staffInfoTableLayout.Controls.Add(txtContactNumber, 3, 2);
            staffInfoTableLayout.Controls.Add(lblPersonalNumber, 0, 3);
            staffInfoTableLayout.Controls.Add(txtPersonalNumber, 1, 3);
            staffInfoTableLayout.Controls.Add(lblPosition, 2, 3);
            staffInfoTableLayout.Controls.Add(cmbPosition, 3, 3);
            staffInfoTableLayout.Controls.Add(lblSalary, 0, 4);
            staffInfoTableLayout.Controls.Add(txtSalary, 1, 4);
            staffInfoTableLayout.Controls.Add(lblHiredDate, 2, 4);
            staffInfoTableLayout.Controls.Add(dtHiredDate, 3, 4);
            staffInfoTableLayout.Controls.Add(lblStatus, 0, 5);
            staffInfoTableLayout.Controls.Add(statusPanel, 1, 5);
            staffInfoTableLayout.Controls.Add(actionButtonPanel, 2, 5);
            staffInfoTableLayout.Dock = DockStyle.Fill;
            staffInfoTableLayout.Location = new Point(10, 27);
            staffInfoTableLayout.Margin = new Padding(3, 2, 3, 2);
            staffInfoTableLayout.Name = "staffInfoTableLayout";
            staffInfoTableLayout.RowCount = 6;
            staffInfoTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6711388F));
            staffInfoTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6657734F));
            staffInfoTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6657734F));
            staffInfoTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6657734F));
            staffInfoTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6657734F));
            staffInfoTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6657734F));
            staffInfoTableLayout.Size = new Size(1305, 234);
            staffInfoTableLayout.TabIndex = 0;
            // 
            // lblStaffId
            // 
            lblStaffId.AutoSize = true;
            lblStaffId.BackColor = Color.Transparent;
            lblStaffId.Font = new Font("Segoe UI", 9F);
            lblStaffId.ForeColor = Color.Gainsboro;
            lblStaffId.Location = new Point(3, 0);
            lblStaffId.Name = "lblStaffId";
            lblStaffId.Size = new Size(48, 15);
            lblStaffId.TabIndex = 0;
            lblStaffId.Text = "Staff ID:";
            lblStaffId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStaffId
            // 
            txtStaffId.BackColor = Color.FromArgb(245, 245, 245);
            txtStaffId.Font = new Font("Segoe UI", 9F);
            txtStaffId.Location = new Point(233, 2);
            txtStaffId.Margin = new Padding(3, 2, 3, 2);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.ReadOnly = true;
            txtStaffId.Size = new Size(176, 23);
            txtStaffId.TabIndex = 0;
            toolTip.SetToolTip(txtStaffId, "Staff ID is auto-generated");
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("Segoe UI", 9F);
            lblStaffName.ForeColor = Color.FromArgb(224, 224, 224);
            lblStaffName.Location = new Point(540, 0);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(69, 15);
            lblStaffName.TabIndex = 1;
            lblStaffName.Text = "Staff Name:";
            lblStaffName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Segoe UI", 9F);
            txtStaffName.Location = new Point(847, 2);
            txtStaffName.Margin = new Padding(3, 2, 3, 2);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(176, 23);
            txtStaffName.TabIndex = 1;
            toolTip.SetToolTip(txtStaffName, "Enter full name of the staff member");
            // 
            // photoPanel
            // 
            photoPanel.BorderStyle = BorderStyle.FixedSingle;
            photoPanel.Controls.Add(picStaffPhoto);
            photoPanel.Controls.Add(btnBrowsePhoto);
            photoPanel.Controls.Add(btnRemovePhoto);
            photoPanel.Location = new Point(1077, 2);
            photoPanel.Margin = new Padding(3, 2, 3, 2);
            photoPanel.Name = "photoPanel";
            staffInfoTableLayout.SetRowSpan(photoPanel, 5);
            photoPanel.Size = new Size(158, 151);
            photoPanel.TabIndex = 11;
            // 
            // picStaffPhoto
            // 
            picStaffPhoto.BackColor = Color.FromArgb(250, 250, 250);
            picStaffPhoto.Location = new Point(4, 4);
            picStaffPhoto.Margin = new Padding(3, 2, 3, 2);
            picStaffPhoto.Name = "picStaffPhoto";
            picStaffPhoto.Size = new Size(148, 99);
            picStaffPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picStaffPhoto.TabIndex = 0;
            picStaffPhoto.TabStop = false;
            // 
            // btnBrowsePhoto
            // 
            btnBrowsePhoto.Font = new Font("Segoe UI", 8F);
            btnBrowsePhoto.Location = new Point(4, 113);
            btnBrowsePhoto.Margin = new Padding(3, 2, 3, 2);
            btnBrowsePhoto.Name = "btnBrowsePhoto";
            btnBrowsePhoto.Size = new Size(70, 19);
            btnBrowsePhoto.TabIndex = 0;
            btnBrowsePhoto.Text = "Browse";
            toolTip.SetToolTip(btnBrowsePhoto, "Browse for staff photo");
            btnBrowsePhoto.UseVisualStyleBackColor = true;
            btnBrowsePhoto.Click += btnUpload_Click;
            // 
            // btnRemovePhoto
            // 
            btnRemovePhoto.Font = new Font("Segoe UI", 8F);
            btnRemovePhoto.Location = new Point(83, 113);
            btnRemovePhoto.Margin = new Padding(3, 2, 3, 2);
            btnRemovePhoto.Name = "btnRemovePhoto";
            btnRemovePhoto.Size = new Size(70, 19);
            btnRemovePhoto.TabIndex = 1;
            btnRemovePhoto.Text = "Remove";
            toolTip.SetToolTip(btnRemovePhoto, "Remove current photo");
            btnRemovePhoto.UseVisualStyleBackColor = true;
            btnRemovePhoto.Click += BtnRemovePhoto_Click;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI", 9F);
            lblGender.ForeColor = Color.FromArgb(224, 224, 224);
            lblGender.Location = new Point(3, 39);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(48, 15);
            lblGender.TabIndex = 2;
            lblGender.Text = "Gender:";
            lblGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // genderPanel
            // 
            genderPanel.Controls.Add(rbMale);
            genderPanel.Controls.Add(rbFemale);
            genderPanel.Location = new Point(233, 41);
            genderPanel.Margin = new Padding(3, 2, 3, 2);
            genderPanel.Name = "genderPanel";
            genderPanel.Size = new Size(175, 23);
            genderPanel.TabIndex = 2;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI", 9F);
            rbMale.Location = new Point(3, 2);
            rbMale.Margin = new Padding(3, 2, 3, 2);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 0;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 9F);
            rbFemale.Location = new Point(74, 2);
            rbFemale.Margin = new Padding(3, 2, 3, 2);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 1;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 9F);
            lblBirthDate.ForeColor = Color.FromArgb(224, 224, 224);
            lblBirthDate.Location = new Point(540, 39);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(62, 15);
            lblBirthDate.TabIndex = 3;
            lblBirthDate.Text = "Birth Date:";
            lblBirthDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtBirthDate
            // 
            dtBirthDate.Font = new Font("Segoe UI", 9F);
            dtBirthDate.Format = DateTimePickerFormat.Short;
            dtBirthDate.Location = new Point(847, 41);
            dtBirthDate.Margin = new Padding(3, 2, 3, 2);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(176, 23);
            dtBirthDate.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F);
            lblAddress.ForeColor = Color.FromArgb(224, 224, 224);
            lblAddress.Location = new Point(3, 77);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            lblAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9F);
            txtAddress.Location = new Point(233, 79);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(176, 31);
            txtAddress.TabIndex = 4;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Font = new Font("Segoe UI", 9F);
            lblContactNumber.ForeColor = Color.FromArgb(224, 224, 224);
            lblContactNumber.Location = new Point(540, 77);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(99, 15);
            lblContactNumber.TabIndex = 5;
            lblContactNumber.Text = "Contact Number:";
            lblContactNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Segoe UI", 9F);
            txtContactNumber.Location = new Point(847, 79);
            txtContactNumber.Margin = new Padding(3, 2, 3, 2);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(176, 23);
            txtContactNumber.TabIndex = 5;
            toolTip.SetToolTip(txtContactNumber, "Enter valid phone number");
            // 
            // lblPersonalNumber
            // 
            lblPersonalNumber.AutoSize = true;
            lblPersonalNumber.Font = new Font("Segoe UI", 9F);
            lblPersonalNumber.ForeColor = Color.FromArgb(224, 224, 224);
            lblPersonalNumber.Location = new Point(3, 115);
            lblPersonalNumber.Name = "lblPersonalNumber";
            lblPersonalNumber.Size = new Size(102, 15);
            lblPersonalNumber.TabIndex = 6;
            lblPersonalNumber.Text = "Personal Number:";
            lblPersonalNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPersonalNumber
            // 
            txtPersonalNumber.Font = new Font("Segoe UI", 9F);
            txtPersonalNumber.Location = new Point(233, 117);
            txtPersonalNumber.Margin = new Padding(3, 2, 3, 2);
            txtPersonalNumber.Name = "txtPersonalNumber";
            txtPersonalNumber.Size = new Size(176, 23);
            txtPersonalNumber.TabIndex = 6;
            toolTip.SetToolTip(txtPersonalNumber, "Enter personal identification number");
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 9F);
            lblPosition.ForeColor = Color.FromArgb(224, 224, 224);
            lblPosition.Location = new Point(540, 115);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(53, 15);
            lblPosition.TabIndex = 7;
            lblPosition.Text = "Position:";
            lblPosition.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbPosition
            // 
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.Font = new Font("Segoe UI", 9F);
            cmbPosition.Location = new Point(847, 117);
            cmbPosition.Margin = new Padding(3, 2, 3, 2);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(176, 23);
            cmbPosition.TabIndex = 7;
            toolTip.SetToolTip(cmbPosition, "Select staff position");
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 9F);
            lblSalary.ForeColor = Color.FromArgb(224, 224, 224);
            lblSalary.Location = new Point(3, 153);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(41, 15);
            lblSalary.TabIndex = 8;
            lblSalary.Text = "Salary:";
            lblSalary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 9F);
            txtSalary.Location = new Point(233, 155);
            txtSalary.Margin = new Padding(3, 2, 3, 2);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(176, 23);
            txtSalary.TabIndex = 8;
            toolTip.SetToolTip(txtSalary, "Enter salary amount (numbers only)");
            // 
            // lblHiredDate
            // 
            lblHiredDate.AutoSize = true;
            lblHiredDate.Font = new Font("Segoe UI", 9F);
            lblHiredDate.ForeColor = Color.FromArgb(224, 224, 224);
            lblHiredDate.Location = new Point(540, 153);
            lblHiredDate.Name = "lblHiredDate";
            lblHiredDate.Size = new Size(66, 15);
            lblHiredDate.TabIndex = 9;
            lblHiredDate.Text = "Hired Date:";
            lblHiredDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtHiredDate
            // 
            dtHiredDate.Font = new Font("Segoe UI", 9F);
            dtHiredDate.Format = DateTimePickerFormat.Short;
            dtHiredDate.Location = new Point(847, 155);
            dtHiredDate.Margin = new Padding(3, 2, 3, 2);
            dtHiredDate.Name = "dtHiredDate";
            dtHiredDate.Size = new Size(176, 23);
            dtHiredDate.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.Gainsboro;
            lblStatus.Location = new Point(3, 191);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(42, 15);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status:";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusPanel
            // 
            statusPanel.Controls.Add(rbActive);
            statusPanel.Controls.Add(rbInactive);
            statusPanel.Dock = DockStyle.Fill;
            statusPanel.Location = new Point(233, 193);
            statusPanel.Margin = new Padding(3, 2, 3, 2);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(301, 39);
            statusPanel.TabIndex = 10;
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Checked = true;
            rbActive.Font = new Font("Segoe UI", 9F);
            rbActive.ForeColor = Color.Green;
            rbActive.Location = new Point(3, 2);
            rbActive.Margin = new Padding(3, 2, 3, 2);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(58, 19);
            rbActive.TabIndex = 0;
            rbActive.TabStop = true;
            rbActive.Text = "Active";
            rbActive.UseVisualStyleBackColor = true;
            // 
            // rbInactive
            // 
            rbInactive.AutoSize = true;
            rbInactive.Font = new Font("Segoe UI", 9F);
            rbInactive.ForeColor = Color.Red;
            rbInactive.Location = new Point(74, 2);
            rbInactive.Margin = new Padding(3, 2, 3, 2);
            rbInactive.Name = "rbInactive";
            rbInactive.Size = new Size(66, 19);
            rbInactive.TabIndex = 1;
            rbInactive.Text = "Inactive";
            rbInactive.UseVisualStyleBackColor = true;
            // 
            // actionButtonPanel
            // 
            staffInfoTableLayout.SetColumnSpan(actionButtonPanel, 2);
            actionButtonPanel.Controls.Add(btnAdd);
            actionButtonPanel.Controls.Add(btnUpdate);
            actionButtonPanel.Controls.Add(btnClear);
            actionButtonPanel.Controls.Add(btnSave);
            actionButtonPanel.Controls.Add(btnCancel);
            actionButtonPanel.Dock = DockStyle.Fill;
            actionButtonPanel.Location = new Point(540, 193);
            actionButtonPanel.Margin = new Padding(3, 2, 3, 2);
            actionButtonPanel.Name = "actionButtonPanel";
            actionButtonPanel.Size = new Size(531, 39);
            actionButtonPanel.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(4, 4);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(78, 26);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAddStaff_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(92, 4);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(78, 26);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += BtnEditStaff_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(176, 4);
            btnClear.Margin = new Padding(3, 2, 3, 2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(78, 26);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(354, 4);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(78, 26);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(189, 195, 199);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(442, 4);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(78, 26);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            // 
            // searchPanel
            // 
            searchPanel.Controls.Add(grpSearch);
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.Location = new Point(11, 285);
            searchPanel.Margin = new Padding(4, 3, 4, 3);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(1325, 66);
            searchPanel.TabIndex = 1;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(searchTableLayout);
            grpSearch.Dock = DockStyle.Fill;
            grpSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpSearch.ForeColor = Color.FromArgb(224, 224, 224);
            grpSearch.Location = new Point(0, 0);
            grpSearch.Margin = new Padding(3, 2, 3, 2);
            grpSearch.Name = "grpSearch";
            grpSearch.Padding = new Padding(10, 9, 10, 9);
            grpSearch.Size = new Size(1325, 66);
            grpSearch.TabIndex = 0;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search Staff";
            // 
            // searchTableLayout
            // 
            searchTableLayout.ColumnCount = 4;
            searchTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            searchTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            searchTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            searchTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            searchTableLayout.Controls.Add(lblSearch, 0, 0);
            searchTableLayout.Controls.Add(txtSearch, 1, 0);
            searchTableLayout.Controls.Add(btnSearch, 2, 0);
            searchTableLayout.Controls.Add(btnRefresh, 3, 0);
            searchTableLayout.Dock = DockStyle.Fill;
            searchTableLayout.Location = new Point(10, 27);
            searchTableLayout.Margin = new Padding(3, 2, 3, 2);
            searchTableLayout.Name = "searchTableLayout";
            searchTableLayout.RowCount = 1;
            searchTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            searchTableLayout.Size = new Size(1305, 30);
            searchTableLayout.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F);
            lblSearch.ForeColor = Color.FromArgb(224, 224, 224);
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(45, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(91, 2);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by ID, Name, Position, or Contact...";
            txtSearch.Size = new Size(350, 23);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(52, 152, 219);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(942, 2);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 26);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(46, 204, 113);
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1124, 2);
            btnRefresh.Margin = new Padding(3, 2, 3, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(70, 26);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dataGridPanel
            // 
            dataGridPanel.Controls.Add(grpStaffList);
            dataGridPanel.Dock = DockStyle.Fill;
            dataGridPanel.Location = new Point(11, 357);
            dataGridPanel.Margin = new Padding(4, 3, 4, 3);
            dataGridPanel.Name = "dataGridPanel";
            dataGridPanel.Size = new Size(1325, 271);
            dataGridPanel.TabIndex = 2;
            // 
            // grpStaffList
            // 
            grpStaffList.Controls.Add(dgvStaff);
            grpStaffList.Dock = DockStyle.Fill;
            grpStaffList.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpStaffList.ForeColor = Color.FromArgb(224, 224, 224);
            grpStaffList.Location = new Point(0, 0);
            grpStaffList.Margin = new Padding(3, 2, 3, 2);
            grpStaffList.Name = "grpStaffList";
            grpStaffList.Padding = new Padding(10, 9, 10, 9);
            grpStaffList.Size = new Size(1325, 271);
            grpStaffList.TabIndex = 0;
            grpStaffList.TabStop = false;
            grpStaffList.Text = "Staff List";
            // 
            // dgvStaff
            // 
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.AllowUserToDeleteRows = false;
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.BackgroundColor = Color.White;
            dgvStaff.BorderStyle = BorderStyle.None;
            dgvStaff.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvStaff.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvStaff.ColumnHeadersHeight = 40;
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(221, 221, 221);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvStaff.DefaultCellStyle = dataGridViewCellStyle2;
            dgvStaff.Dock = DockStyle.Fill;
            dgvStaff.EnableHeadersVisualStyles = false;
            dgvStaff.GridColor = Color.FromArgb(221, 221, 221);
            dgvStaff.Location = new Point(10, 27);
            dgvStaff.Margin = new Padding(3, 2, 3, 2);
            dgvStaff.MultiSelect = false;
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersVisible = false;
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.RowTemplate.Height = 35;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new Size(1305, 235);
            dgvStaff.TabIndex = 0;
            dgvStaff.CellClick += Dgv_staff_CellClick;
            dgvStaff.CellContentClick += dgvStaff_CellContentClick;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // toolTip
            // 
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 1000;
            toolTip.ReshowDelay = 500;
            // 
            // FormStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(1347, 637);
            Controls.Add(mainTableLayout);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1051, 607);
            Name = "FormStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff Management System";
            WindowState = FormWindowState.Maximized;
            mainTableLayout.ResumeLayout(false);
            staffInfoPanel.ResumeLayout(false);
            grpStaffInfo.ResumeLayout(false);
            staffInfoTableLayout.ResumeLayout(false);
            staffInfoTableLayout.PerformLayout();
            photoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picStaffPhoto).EndInit();
            genderPanel.ResumeLayout(false);
            genderPanel.PerformLayout();
            statusPanel.ResumeLayout(false);
            statusPanel.PerformLayout();
            actionButtonPanel.ResumeLayout(false);
            searchPanel.ResumeLayout(false);
            grpSearch.ResumeLayout(false);
            searchTableLayout.ResumeLayout(false);
            searchTableLayout.PerformLayout();
            dataGridPanel.ResumeLayout(false);
            grpStaffList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Main layout containers
        private TableLayoutPanel mainTableLayout;
        private Panel staffInfoPanel;
        private Panel searchPanel;
        private Panel dataGridPanel;

        // Staff Information Group
        private GroupBox grpStaffInfo;
        private TableLayoutPanel staffInfoTableLayout;

        // Basic Information Controls
        private Label lblStaffId;
        private TextBox txtStaffId;
        private Label lblStaffName;
        private TextBox txtStaffName;
        private Label lblGender;
        private Panel genderPanel;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Label lblBirthDate;
        private DateTimePicker dtBirthDate;

        // Contact Information Controls
        private Label lblAddress;
        private TextBox txtAddress;
        private Label lblContactNumber;
        private TextBox txtContactNumber;
        private Label lblPersonalNumber;
        private TextBox txtPersonalNumber;

        // Employment Information Controls
        private Label lblPosition;
        private ComboBox cmbPosition;
        private Label lblSalary;
        private TextBox txtSalary;
        private Label lblHiredDate;
        private DateTimePicker dtHiredDate;
        private Label lblStatus;
        private Panel statusPanel;
        private RadioButton rbActive;
        private RadioButton rbInactive;

        // Photo Controls
        private Panel photoPanel;
        private PictureBox picStaffPhoto;
        private Button btnBrowsePhoto;
        private Button btnRemovePhoto;

        // Action Buttons
        private Panel actionButtonPanel;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnClear;
        private Button btnSave;
        private Button btnCancel;

        // Search Controls
        private GroupBox grpSearch;
        private TableLayoutPanel searchTableLayout;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;

        // Data Grid
        private GroupBox grpStaffList;
        private DataGridView dgvStaff;

        // Utility Controls
        private ErrorProvider errorProvider;
        private ToolTip toolTip;

        // Event handlers (you'll need to implement these)
  
    }
}