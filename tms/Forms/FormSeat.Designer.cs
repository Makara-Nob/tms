namespace tms.Forms
{
    partial class FormSeat
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
        [Obsolete]
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            tableSeat = new DataGridView();
            groupBox2 = new GroupBox();
            txtSearch = new TextBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            vehicleId = new ComboBox();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            seatStatus = new ComboBox();
            label4 = new Label();
            seatType = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            seatId = new TextBox();
            seatNumber = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label6 = new Label();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableSeat).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 47);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.20403F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.503809F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40.29216F));
            tableLayoutPanel2.Size = new Size(1435, 937);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tableSeat);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(3, 562);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10);
            groupBox3.Size = new Size(1429, 372);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Seat's List";
            // 
            // tableSeat
            // 
            tableSeat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tableSeat.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tableSeat.BackgroundColor = Color.White;
            tableSeat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableSeat.DefaultCellStyle = dataGridViewCellStyle1;
            tableSeat.Dock = DockStyle.Fill;
            tableSeat.Location = new Point(10, 26);
            tableSeat.Name = "tableSeat";
            tableSeat.RowHeadersWidth = 62;
            tableSeat.Size = new Size(1409, 336);
            tableSeat.TabIndex = 7;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(3, 473);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(1429, 83);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(10, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(1409, 23);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1429, 464);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(vehicleId, 1, 0);
            tableLayoutPanel1.Controls.Add(deleteBtn, 2, 3);
            tableLayoutPanel1.Controls.Add(updateBtn, 1, 3);
            tableLayoutPanel1.Controls.Add(addBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(seatStatus, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(seatType, 3, 1);
            tableLayoutPanel1.Controls.Add(label5, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(seatId, 3, 0);
            tableLayoutPanel1.Controls.Add(seatNumber, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222233F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222233F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Size = new Size(1423, 442);
            tableLayoutPanel1.TabIndex = 7;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(13, 10);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Vehicle Number";
            // 
            // vehicleId
            // 
            vehicleId.Dock = DockStyle.Fill;
            vehicleId.DropDownStyle = ComboBoxStyle.DropDownList;
            vehicleId.Font = new Font("Segoe UI", 11F);
            vehicleId.FormattingEnabled = true;
            vehicleId.Location = new Point(363, 13);
            vehicleId.Name = "vehicleId";
            vehicleId.Size = new Size(344, 28);
            vehicleId.TabIndex = 5;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(229, 57, 53);
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(713, 292);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(109, 46);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(0, 122, 204);
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(363, 292);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(117, 46);
            updateBtn.TabIndex = 3;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(0, 122, 204);
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(13, 292);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(122, 46);
            addBtn.TabIndex = 3;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // seatStatus
            // 
            seatStatus.Dock = DockStyle.Fill;
            seatStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            seatStatus.Font = new Font("Segoe UI", 11F);
            seatStatus.FormattingEnabled = true;
            seatStatus.Location = new Point(363, 199);
            seatStatus.Name = "seatStatus";
            seatStatus.Size = new Size(344, 28);
            seatStatus.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(13, 196);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 0;
            label4.Text = "Seat Status";
            // 
            // seatType
            // 
            seatType.Dock = DockStyle.Fill;
            seatType.DropDownStyle = ComboBoxStyle.DropDownList;
            seatType.Font = new Font("Segoe UI", 11F);
            seatType.FormattingEnabled = true;
            seatType.Location = new Point(1063, 106);
            seatType.Name = "seatType";
            seatType.Size = new Size(347, 28);
            seatType.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(713, 10);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 0;
            label5.Text = "Seat ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(713, 103);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 0;
            label3.Text = "Seat Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(13, 103);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 0;
            label2.Text = "Seat Number";
            // 
            // seatId
            // 
            seatId.BorderStyle = BorderStyle.FixedSingle;
            seatId.Dock = DockStyle.Fill;
            seatId.Font = new Font("Segoe UI", 11F);
            seatId.Location = new Point(1063, 13);
            seatId.Name = "seatId";
            seatId.Size = new Size(347, 27);
            seatId.TabIndex = 1;
            // 
            // seatNumber
            // 
            seatNumber.BorderStyle = BorderStyle.FixedSingle;
            seatNumber.Dock = DockStyle.Fill;
            seatNumber.Font = new Font("Segoe UI", 11F);
            seatNumber.Location = new Point(363, 106);
            seatNumber.Name = "seatNumber";
            seatNumber.Size = new Size(344, 27);
            seatNumber.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label6, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 4.531035F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 95.46896F));
            tableLayoutPanel3.Size = new Size(1441, 987);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(5);
            label6.Size = new Size(1435, 44);
            label6.TabIndex = 0;
            label6.Text = "Seat Management \U0001fa91";
            // 
            // FormSeat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 28, 36);
            ClientSize = new Size(1441, 987);
            Controls.Add(tableLayoutPanel3);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormSeat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seat Management System";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableSeat).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox3;
        private DataGridView tableSeat;
        private GroupBox groupBox2;
        private TextBox txtSearch;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private ComboBox vehicleId;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
        private ComboBox seatStatus;
        private Label label4;
        private ComboBox seatType;
        private Label label5;
        private Label label3;
        private Label label2;
        private TextBox seatId;
        private TextBox seatNumber;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label6;
    }
}