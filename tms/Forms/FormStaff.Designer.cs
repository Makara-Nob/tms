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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            mainTableLayout.Margin = new Padding(10);
            mainTableLayout.Name = "mainTableLayout";
            mainTableLayout.Padding = new Padding(10);
            mainTableLayout.RowCount = 3;
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 49.9999962F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            mainTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            mainTableLayout.Size = new Size(2250, 1250);
            mainTableLayout.TabIndex = 0;
            // 
            // staffInfoPanel
            // 
            staffInfoPanel.Controls.Add(grpStaffInfo);
            staffInfoPanel.Dock = DockStyle.Fill;
            staffInfoPanel.Location = new Point(15, 15);
            staffInfoPanel.Margin = new Padding(5);
            staffInfoPanel.Name = "staffInfoPanel";
            staffInfoPanel.Size = new Size(2220, 544);
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
            grpStaffInfo.Margin = new Padding(5);
            grpStaffInfo.Name = "grpStaffInfo";
            grpStaffInfo.Padding = new Padding(15);
            grpStaffInfo.Size = new Size(2220, 544);
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
            staffInfoTableLayout.Location = new Point(15, 42);
            staffInfoTableLayout.Margin = new Padding(4);
            staffInfoTableLayout.Name = "staffInfoTableLayout";
            staffInfoTableLayout.RowCount = 6;
            staffInfoTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6711388F));
            staffInfoTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6657734F));
            staffInfoTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6657734F));
            staffInfoTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6657734F));
            staffInfoTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6657734F));
            staffInfoTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6657734F));
            staffInfoTableLayout.Size = new Size(2190, 487);
            staffInfoTableLayout.TabIndex = 0;
            // 
            // lblStaffId
            // 
            lblStaffId.AutoSize = true;
            lblStaffId.BackColor = Color.Transparent;
            lblStaffId.Font = new Font("Segoe UI", 9F);
            lblStaffId.ForeColor = Color.Gainsboro;
            lblStaffId.Location = new Point(4, 0);
            lblStaffId.Margin = new Padding(4, 0, 4, 0);
            lblStaffId.Name = "lblStaffId";
            lblStaffId.Size = new Size(75, 25);
            lblStaffId.TabIndex = 0;
            lblStaffId.Text = "Staff ID:";
            lblStaffId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStaffId
            // 
            txtStaffId.BackColor = Color.FromArgb(245, 245, 245);
            txtStaffId.Font = new Font("Segoe UI", 9F);
            txtStaffId.Location = new Point(390, 4);
            txtStaffId.Margin = new Padding(4);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.ReadOnly = true;
            txtStaffId.Size = new Size(249, 31);
            txtStaffId.TabIndex = 0;
            toolTip.SetToolTip(txtStaffId, "Staff ID is auto-generated");
            // 
            // lblStaffName
            // 
            lblStaffName.AutoSize = true;
            lblStaffName.Font = new Font("Segoe UI", 9F);
            lblStaffName.ForeColor = Color.FromArgb(224, 224, 224);
            lblStaffName.Location = new Point(905, 0);
            lblStaffName.Margin = new Padding(4, 0, 4, 0);
            lblStaffName.Name = "lblStaffName";
            lblStaffName.Size = new Size(104, 25);
            lblStaffName.TabIndex = 1;
            lblStaffName.Text = "Staff Name:";
            lblStaffName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Segoe UI", 9F);
            txtStaffName.Location = new Point(1420, 4);
            txtStaffName.Margin = new Padding(4);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(249, 31);
            txtStaffName.TabIndex = 1;
            toolTip.SetToolTip(txtStaffName, "Enter full name of the staff member");
            // 
            // photoPanel
            // 
            photoPanel.BorderStyle = BorderStyle.FixedSingle;
            photoPanel.Controls.Add(picStaffPhoto);
            photoPanel.Controls.Add(btnBrowsePhoto);
            photoPanel.Controls.Add(btnRemovePhoto);
            photoPanel.Location = new Point(1806, 4);
            photoPanel.Margin = new Padding(4);
            photoPanel.Name = "photoPanel";
            staffInfoTableLayout.SetRowSpan(photoPanel, 5);
            photoPanel.Size = new Size(225, 250);
            photoPanel.TabIndex = 11;
            // 
            // picStaffPhoto
            // 
            picStaffPhoto.BackColor = Color.FromArgb(250, 250, 250);
            picStaffPhoto.Location = new Point(6, 6);
            picStaffPhoto.Margin = new Padding(4);
            picStaffPhoto.Name = "picStaffPhoto";
            picStaffPhoto.Size = new Size(212, 165);
            picStaffPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picStaffPhoto.TabIndex = 0;
            picStaffPhoto.TabStop = false;
            // 
            // btnBrowsePhoto
            // 
            btnBrowsePhoto.Font = new Font("Segoe UI", 8F);
            btnBrowsePhoto.Location = new Point(6, 188);
            btnBrowsePhoto.Margin = new Padding(4);
            btnBrowsePhoto.Name = "btnBrowsePhoto";
            btnBrowsePhoto.Size = new Size(100, 31);
            btnBrowsePhoto.TabIndex = 0;
            btnBrowsePhoto.Text = "Browse";
            toolTip.SetToolTip(btnBrowsePhoto, "Browse for staff photo");
            btnBrowsePhoto.UseVisualStyleBackColor = true;
            btnBrowsePhoto.Click += btnUpload_Click;
            // 
            // btnRemovePhoto
            // 
            btnRemovePhoto.Font = new Font("Segoe UI", 8F);
            btnRemovePhoto.Location = new Point(119, 188);
            btnRemovePhoto.Margin = new Padding(4);
            btnRemovePhoto.Name = "btnRemovePhoto";
            btnRemovePhoto.Size = new Size(100, 31);
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
            lblGender.Location = new Point(4, 81);
            lblGender.Margin = new Padding(4, 0, 4, 0);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(73, 25);
            lblGender.TabIndex = 2;
            lblGender.Text = "Gender:";
            lblGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // genderPanel
            // 
            genderPanel.Controls.Add(rbMale);
            genderPanel.Controls.Add(rbFemale);
            genderPanel.Location = new Point(390, 85);
            genderPanel.Margin = new Padding(4);
            genderPanel.Name = "genderPanel";
            genderPanel.Size = new Size(250, 38);
            genderPanel.TabIndex = 2;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Segoe UI", 9F);
            rbMale.Location = new Point(4, 4);
            rbMale.Margin = new Padding(4);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(75, 29);
            rbMale.TabIndex = 0;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Segoe UI", 9F);
            rbFemale.Location = new Point(106, 4);
            rbFemale.Margin = new Padding(4);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(93, 29);
            rbFemale.TabIndex = 1;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 9F);
            lblBirthDate.ForeColor = Color.FromArgb(224, 224, 224);
            lblBirthDate.Location = new Point(905, 81);
            lblBirthDate.Margin = new Padding(4, 0, 4, 0);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(94, 25);
            lblBirthDate.TabIndex = 3;
            lblBirthDate.Text = "Birth Date:";
            lblBirthDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtBirthDate
            // 
            dtBirthDate.Font = new Font("Segoe UI", 9F);
            dtBirthDate.Format = DateTimePickerFormat.Short;
            dtBirthDate.Location = new Point(1420, 85);
            dtBirthDate.Margin = new Padding(4);
            dtBirthDate.Name = "dtBirthDate";
            dtBirthDate.Size = new Size(249, 31);
            dtBirthDate.TabIndex = 3;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 9F);
            lblAddress.ForeColor = Color.FromArgb(224, 224, 224);
            lblAddress.Location = new Point(4, 162);
            lblAddress.Margin = new Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(81, 25);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address:";
            lblAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9F);
            txtAddress.Location = new Point(390, 166);
            txtAddress.Margin = new Padding(4);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(249, 49);
            txtAddress.TabIndex = 4;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Font = new Font("Segoe UI", 9F);
            lblContactNumber.ForeColor = Color.FromArgb(224, 224, 224);
            lblContactNumber.Location = new Point(905, 162);
            lblContactNumber.Margin = new Padding(4, 0, 4, 0);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(147, 25);
            lblContactNumber.TabIndex = 5;
            lblContactNumber.Text = "Contact Number:";
            lblContactNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Font = new Font("Segoe UI", 9F);
            txtContactNumber.Location = new Point(1420, 166);
            txtContactNumber.Margin = new Padding(4);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(249, 31);
            txtContactNumber.TabIndex = 5;
            toolTip.SetToolTip(txtContactNumber, "Enter valid phone number");
            // 
            // lblPersonalNumber
            // 
            lblPersonalNumber.AutoSize = true;
            lblPersonalNumber.Font = new Font("Segoe UI", 9F);
            lblPersonalNumber.ForeColor = Color.FromArgb(224, 224, 224);
            lblPersonalNumber.Location = new Point(4, 243);
            lblPersonalNumber.Margin = new Padding(4, 0, 4, 0);
            lblPersonalNumber.Name = "lblPersonalNumber";
            lblPersonalNumber.Size = new Size(152, 25);
            lblPersonalNumber.TabIndex = 6;
            lblPersonalNumber.Text = "Personal Number:";
            lblPersonalNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPersonalNumber
            // 
            txtPersonalNumber.Font = new Font("Segoe UI", 9F);
            txtPersonalNumber.Location = new Point(390, 247);
            txtPersonalNumber.Margin = new Padding(4);
            txtPersonalNumber.Name = "txtPersonalNumber";
            txtPersonalNumber.Size = new Size(249, 31);
            txtPersonalNumber.TabIndex = 6;
            toolTip.SetToolTip(txtPersonalNumber, "Enter personal identification number");
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 9F);
            lblPosition.ForeColor = Color.FromArgb(224, 224, 224);
            lblPosition.Location = new Point(905, 243);
            lblPosition.Margin = new Padding(4, 0, 4, 0);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(79, 25);
            lblPosition.TabIndex = 7;
            lblPosition.Text = "Position:";
            lblPosition.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbPosition
            // 
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.Font = new Font("Segoe UI", 9F);
            cmbPosition.Location = new Point(1420, 247);
            cmbPosition.Margin = new Padding(4);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(249, 33);
            cmbPosition.TabIndex = 7;
            toolTip.SetToolTip(cmbPosition, "Select staff position");
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 9F);
            lblSalary.ForeColor = Color.FromArgb(224, 224, 224);
            lblSalary.Location = new Point(4, 324);
            lblSalary.Margin = new Padding(4, 0, 4, 0);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(63, 25);
            lblSalary.TabIndex = 8;
            lblSalary.Text = "Salary:";
            lblSalary.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI", 9F);
            txtSalary.Location = new Point(390, 328);
            txtSalary.Margin = new Padding(4);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(249, 31);
            txtSalary.TabIndex = 8;
            toolTip.SetToolTip(txtSalary, "Enter salary amount (numbers only)");
            // 
            // lblHiredDate
            // 
            lblHiredDate.AutoSize = true;
            lblHiredDate.Font = new Font("Segoe UI", 9F);
            lblHiredDate.ForeColor = Color.FromArgb(224, 224, 224);
            lblHiredDate.Location = new Point(905, 324);
            lblHiredDate.Margin = new Padding(4, 0, 4, 0);
            lblHiredDate.Name = "lblHiredDate";
            lblHiredDate.Size = new Size(101, 25);
            lblHiredDate.TabIndex = 9;
            lblHiredDate.Text = "Hired Date:";
            lblHiredDate.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtHiredDate
            // 
            dtHiredDate.Font = new Font("Segoe UI", 9F);
            dtHiredDate.Format = DateTimePickerFormat.Short;
            dtHiredDate.Location = new Point(1420, 328);
            dtHiredDate.Margin = new Padding(4);
            dtHiredDate.Name = "dtHiredDate";
            dtHiredDate.Size = new Size(249, 31);
            dtHiredDate.TabIndex = 9;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F);
            lblStatus.ForeColor = Color.Gainsboro;
            lblStatus.Location = new Point(4, 405);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 25);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status:";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // statusPanel
            // 
            statusPanel.Controls.Add(rbActive);
            statusPanel.Controls.Add(rbInactive);
            statusPanel.Dock = DockStyle.Fill;
            statusPanel.Location = new Point(390, 409);
            statusPanel.Margin = new Padding(4);
            statusPanel.Name = "statusPanel";
            statusPanel.Size = new Size(507, 74);
            statusPanel.TabIndex = 10;
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Checked = true;
            rbActive.Font = new Font("Segoe UI", 9F);
            rbActive.ForeColor = Color.Green;
            rbActive.Location = new Point(4, 4);
            rbActive.Margin = new Padding(4);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(85, 29);
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
            rbInactive.Location = new Point(106, 4);
            rbInactive.Margin = new Padding(4);
            rbInactive.Name = "rbInactive";
            rbInactive.Size = new Size(97, 29);
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
            actionButtonPanel.Location = new Point(905, 409);
            actionButtonPanel.Margin = new Padding(4);
            actionButtonPanel.Name = "actionButtonPanel";
            actionButtonPanel.Size = new Size(893, 74);
            actionButtonPanel.TabIndex = 12;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(6, 6);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(112, 44);
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
            btnUpdate.Location = new Point(131, 6);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 44);
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
            btnClear.Location = new Point(251, 6);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 44);
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
            btnSave.Location = new Point(506, 6);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 44);
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
            btnCancel.Location = new Point(631, 6);
            btnCancel.Margin = new Padding(4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 44);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            // 
            // searchPanel
            // 
            searchPanel.Controls.Add(grpSearch);
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.Location = new Point(15, 569);
            searchPanel.Margin = new Padding(5);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(2220, 110);
            searchPanel.TabIndex = 1;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(searchTableLayout);
            grpSearch.Dock = DockStyle.Fill;
            grpSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpSearch.ForeColor = Color.FromArgb(224, 224, 224);
            grpSearch.Location = new Point(0, 0);
            grpSearch.Margin = new Padding(4);
            grpSearch.Name = "grpSearch";
            grpSearch.Padding = new Padding(15);
            grpSearch.Size = new Size(2220, 110);
            grpSearch.TabIndex = 0;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search Staff";
            // 
            // searchTableLayout
            // 
            searchTableLayout.ColumnCount = 4;
            searchTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 125F));
            searchTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            searchTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            searchTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            searchTableLayout.Controls.Add(lblSearch, 0, 0);
            searchTableLayout.Controls.Add(txtSearch, 1, 0);
            searchTableLayout.Controls.Add(btnSearch, 2, 0);
            searchTableLayout.Controls.Add(btnRefresh, 3, 0);
            searchTableLayout.Dock = DockStyle.Fill;
            searchTableLayout.Location = new Point(15, 42);
            searchTableLayout.Margin = new Padding(4);
            searchTableLayout.Name = "searchTableLayout";
            searchTableLayout.RowCount = 1;
            searchTableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            searchTableLayout.Size = new Size(2190, 53);
            searchTableLayout.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F);
            lblSearch.ForeColor = Color.FromArgb(224, 224, 224);
            lblSearch.Location = new Point(4, 0);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 25);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            lblSearch.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(129, 4);
            txtSearch.Margin = new Padding(4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search by ID, Name, Position, or Contact...";
            txtSearch.Size = new Size(499, 31);
            txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(52, 152, 219);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1574, 4);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(140, 45);
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
            btnRefresh.Location = new Point(1883, 4);
            btnRefresh.Margin = new Padding(4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 45);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dataGridPanel
            // 
            dataGridPanel.Controls.Add(grpStaffList);
            dataGridPanel.Dock = DockStyle.Fill;
            dataGridPanel.Location = new Point(15, 689);
            dataGridPanel.Margin = new Padding(5);
            dataGridPanel.Name = "dataGridPanel";
            dataGridPanel.Size = new Size(2220, 546);
            dataGridPanel.TabIndex = 2;
            // 
            // grpStaffList
            // 
            grpStaffList.Controls.Add(dgvStaff);
            grpStaffList.Dock = DockStyle.Fill;
            grpStaffList.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpStaffList.ForeColor = Color.FromArgb(224, 224, 224);
            grpStaffList.Location = new Point(0, 0);
            grpStaffList.Margin = new Padding(4);
            grpStaffList.Name = "grpStaffList";
            grpStaffList.Padding = new Padding(15);
            grpStaffList.Size = new Size(2220, 546);
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
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvStaff.ColumnHeadersHeight = 40;
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(221, 221, 221);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvStaff.DefaultCellStyle = dataGridViewCellStyle6;
            dgvStaff.Dock = DockStyle.Fill;
            dgvStaff.EnableHeadersVisualStyles = false;
            dgvStaff.GridColor = Color.FromArgb(221, 221, 221);
            dgvStaff.Location = new Point(15, 42);
            dgvStaff.Margin = new Padding(4);
            dgvStaff.MultiSelect = false;
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersVisible = false;
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.RowTemplate.Height = 35;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new Size(2190, 489);
            dgvStaff.TabIndex = 0;
            dgvStaff.CellClick += Dgv_staff_CellClick;
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 249, 250);
            ClientSize = new Size(2250, 1250);
            Controls.Add(mainTableLayout);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(4);
            MinimumSize = new Size(1494, 986);
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