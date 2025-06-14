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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            seatId = new TextBox();
            seatNumber = new TextBox();
            label5 = new Label();
            seatStatus = new ComboBox();
            addBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            logoutBtn = new Button();
            tableSeat = new DataGridView();
            seatType = new ComboBox();
            vehicleId = new ComboBox();
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)tableSeat).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 0;
            label1.Text = "Vehicle Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(59, 127);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 0;
            label2.Text = "Seat Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(84, 178);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 0;
            label3.Text = "Seat Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(75, 229);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 0;
            label4.Text = "Seat Status";
            // 
            // seatId
            // 
            seatId.BorderStyle = BorderStyle.FixedSingle;
            seatId.Font = new Font("Segoe UI", 13F);
            seatId.Location = new Point(195, 74);
            seatId.Name = "seatId";
            seatId.Size = new Size(762, 31);
            seatId.TabIndex = 1;
            seatId.TextChanged += seatId_TextChanged;
            // 
            // seatNumber
            // 
            seatNumber.BorderStyle = BorderStyle.FixedSingle;
            seatNumber.Font = new Font("Segoe UI", 13F);
            seatNumber.Location = new Point(195, 123);
            seatNumber.Name = "seatNumber";
            seatNumber.Size = new Size(762, 31);
            seatNumber.TabIndex = 1;
            seatNumber.TextChanged += seatNumber_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(101, 78);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 0;
            label5.Text = "Seat ID";
            // 
            // seatStatus
            // 
            seatStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            seatStatus.Font = new Font("Segoe UI", 13F);
            seatStatus.FormattingEnabled = true;
            seatStatus.Location = new Point(195, 224);
            seatStatus.Name = "seatStatus";
            seatStatus.Size = new Size(762, 31);
            seatStatus.TabIndex = 2;
            seatStatus.SelectedIndexChanged += seatStatus_SelectedIndexChanged;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(0, 122, 204);
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(32, 293);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(148, 42);
            addBtn.TabIndex = 3;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(0, 122, 204);
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(296, 293);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(148, 42);
            updateBtn.TabIndex = 3;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(229, 57, 53);
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(562, 293);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(145, 42);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(64, 64, 64);
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(812, 293);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(145, 42);
            logoutBtn.TabIndex = 3;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // tableSeat
            // 
            tableSeat.AllowUserToAddRows = false;
            tableSeat.AllowUserToDeleteRows = false;
            tableSeat.AllowUserToResizeRows = false;
            tableSeat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableSeat.BackgroundColor = Color.White;
            tableSeat.BorderStyle = BorderStyle.Fixed3D;
            tableSeat.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tableSeat.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableSeat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tableSeat.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tableSeat.DefaultCellStyle = dataGridViewCellStyle2;
            tableSeat.EnableHeadersVisualStyles = false;
            tableSeat.GridColor = Color.FromArgb(224, 224, 224);
            tableSeat.Location = new Point(32, 370);
            tableSeat.Name = "tableSeat";
            tableSeat.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tableSeat.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tableSeat.RowHeadersVisible = false;
            tableSeat.RowTemplate.Height = 35;
            tableSeat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableSeat.Size = new Size(925, 365);
            tableSeat.TabIndex = 4;
            tableSeat.CellClick += tableSeat_CellClick;
            // 
            // seatType
            // 
            seatType.DropDownStyle = ComboBoxStyle.DropDownList;
            seatType.Font = new Font("Segoe UI", 13F);
            seatType.FormattingEnabled = true;
            seatType.Location = new Point(195, 173);
            seatType.Name = "seatType";
            seatType.Size = new Size(762, 31);
            seatType.TabIndex = 5;
            seatType.SelectedIndexChanged += seatType_SelectedIndexChanged;
            // 
            // vehicleId
            // 
            vehicleId.DropDownStyle = ComboBoxStyle.DropDownList;
            vehicleId.Font = new Font("Segoe UI", 13F);
            vehicleId.FormattingEnabled = true;
            vehicleId.Location = new Point(195, 20);
            vehicleId.Name = "vehicleId";
            vehicleId.Size = new Size(762, 31);
            vehicleId.TabIndex = 5;
            vehicleId.SelectedIndexChanged += vehicleId_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 60);
            panel1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(20, 15);
            label6.Name = "label6";
            label6.Size = new Size(196, 25);
            label6.TabIndex = 0;
            label6.Text = "Seat Management \U0001fa91";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(vehicleId);
            panel2.Controls.Add(seatType);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(seatId);
            panel2.Controls.Add(seatNumber);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(seatStatus);
            panel2.Controls.Add(addBtn);
            panel2.Controls.Add(updateBtn);
            panel2.Controls.Add(deleteBtn);
            panel2.Controls.Add(logoutBtn);
            panel2.Controls.Add(tableSeat);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(20);
            panel2.Size = new Size(1000, 750);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // FormSeat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1000, 810);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormSeat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Seat Management System";
            ((System.ComponentModel.ISupportInitialize)tableSeat).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox seatId;
        private System.Windows.Forms.TextBox seatNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox seatStatus;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.DataGridView tableSeat;
        private System.Windows.Forms.ComboBox seatType;
        private System.Windows.Forms.ComboBox vehicleId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}