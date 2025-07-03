// Forms/FormOrder.Designer.cs
namespace tms.Forms
{
    partial class FormOrder
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblOrderID = new Label();
            txtOrderID = new TextBox();
            lblCustomerID = new Label();
            txtSender = new TextBox();
            lblOrderType = new Label();
            txtOrderType = new TextBox();
            lblOrderDate = new Label();
            dtpOrderDate = new DateTimePicker();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridViewOrders = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtReciever = new TextBox();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            textBox1 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblOrderID
            // 
            lblOrderID.AutoSize = true;
            lblOrderID.Location = new Point(4, 0);
            lblOrderID.Margin = new Padding(4, 0, 4, 0);
            lblOrderID.Name = "lblOrderID";
<<<<<<< HEAD
            lblOrderID.Size = new Size(54, 15);
=======
            lblOrderID.Size = new Size(69, 20);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            lblOrderID.TabIndex = 0;
            lblOrderID.Text = "Order ID:";
            // 
            // txtOrderID
            // 
            txtOrderID.Dock = DockStyle.Fill;
<<<<<<< HEAD
            txtOrderID.Location = new Point(249, 4);
            txtOrderID.Margin = new Padding(4);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(237, 23);
=======
            txtOrderID.Location = new Point(284, 5);
            txtOrderID.Margin = new Padding(4, 5, 4, 5);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(272, 27);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            txtOrderID.TabIndex = 1;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
<<<<<<< HEAD
            lblCustomerID.Location = new Point(494, 0);
            lblCustomerID.Margin = new Padding(4, 0, 4, 0);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(46, 15);
=======
            lblCustomerID.Location = new Point(564, 0);
            lblCustomerID.Margin = new Padding(4, 0, 4, 0);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(58, 20);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            lblCustomerID.TabIndex = 2;
            lblCustomerID.Text = "Sender:";
            // 
            // txtSender
            // 
            txtSender.Dock = DockStyle.Fill;
<<<<<<< HEAD
            txtSender.Location = new Point(739, 4);
            txtSender.Margin = new Padding(4);
            txtSender.Name = "txtSender";
            txtSender.Size = new Size(239, 23);
=======
            txtSender.Location = new Point(844, 5);
            txtSender.Margin = new Padding(4, 5, 4, 5);
            txtSender.Name = "txtSender";
            txtSender.Size = new Size(275, 27);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            txtSender.TabIndex = 3;
            // 
            // lblOrderType
            // 
            lblOrderType.AutoSize = true;
<<<<<<< HEAD
            lblOrderType.Location = new Point(4, 30);
            lblOrderType.Margin = new Padding(4, 0, 4, 0);
            lblOrderType.Name = "lblOrderType";
            lblOrderType.Size = new Size(68, 15);
=======
            lblOrderType.Location = new Point(4, 40);
            lblOrderType.Margin = new Padding(4, 0, 4, 0);
            lblOrderType.Name = "lblOrderType";
            lblOrderType.Size = new Size(85, 20);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            lblOrderType.TabIndex = 4;
            lblOrderType.Text = "Order Type:";
            // 
            // txtOrderType
            // 
            txtOrderType.Dock = DockStyle.Fill;
<<<<<<< HEAD
            txtOrderType.Location = new Point(249, 34);
            txtOrderType.Margin = new Padding(4);
            txtOrderType.Name = "txtOrderType";
            txtOrderType.Size = new Size(237, 23);
=======
            txtOrderType.Location = new Point(284, 45);
            txtOrderType.Margin = new Padding(4, 5, 4, 5);
            txtOrderType.Name = "txtOrderType";
            txtOrderType.Size = new Size(272, 27);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            txtOrderType.TabIndex = 5;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
<<<<<<< HEAD
            lblOrderDate.Location = new Point(4, 60);
            lblOrderDate.Margin = new Padding(4, 0, 4, 0);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(67, 15);
=======
            lblOrderDate.Location = new Point(4, 80);
            lblOrderDate.Margin = new Padding(4, 0, 4, 0);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(86, 20);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            lblOrderDate.TabIndex = 6;
            lblOrderDate.Text = "Order Date:";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Dock = DockStyle.Fill;
            dtpOrderDate.Format = DateTimePickerFormat.Short;
<<<<<<< HEAD
            dtpOrderDate.Location = new Point(249, 64);
            dtpOrderDate.Margin = new Padding(4);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(237, 23);
=======
            dtpOrderDate.Location = new Point(284, 85);
            dtpOrderDate.Margin = new Padding(4, 5, 4, 5);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(272, 27);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            dtpOrderDate.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.ForeColor = Color.Black;
<<<<<<< HEAD
            btnSave.Location = new Point(4, 94);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(88, 26);
=======
            btnSave.Location = new Point(4, 125);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.Black;
<<<<<<< HEAD
            btnUpdate.Location = new Point(249, 94);
            btnUpdate.Margin = new Padding(4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(88, 26);
=======
            btnUpdate.Location = new Point(284, 125);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(100, 35);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.ForeColor = Color.Black;
<<<<<<< HEAD
            btnDelete.Location = new Point(494, 94);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(88, 26);
=======
            btnDelete.Location = new Point(564, 125);
            btnDelete.Margin = new Padding(4, 5, 4, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 35);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AllowUserToAddRows = false;
            dataGridViewOrders.AllowUserToDeleteRows = false;
            dataGridViewOrders.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Dock = DockStyle.Fill;
<<<<<<< HEAD
            dataGridViewOrders.Location = new Point(7, 22);
            dataGridViewOrders.Margin = new Padding(4);
=======
            dataGridViewOrders.Location = new Point(8, 28);
            dataGridViewOrders.Margin = new Padding(4, 5, 4, 5);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.RowHeadersWidth = 62;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
<<<<<<< HEAD
            dataGridViewOrders.Size = new Size(982, 244);
=======
            dataGridViewOrders.Size = new Size(1123, 328);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            dataGridViewOrders.TabIndex = 11;
            dataGridViewOrders.CellClick += dataGridViewOrders_CellClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(txtReciever, 3, 1);
            tableLayoutPanel1.Controls.Add(lblOrderID, 0, 0);
            tableLayoutPanel1.Controls.Add(txtOrderID, 1, 0);
            tableLayoutPanel1.Controls.Add(txtSender, 3, 0);
            tableLayoutPanel1.Controls.Add(lblCustomerID, 2, 0);
            tableLayoutPanel1.Controls.Add(lblOrderType, 0, 1);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 3);
            tableLayoutPanel1.Controls.Add(btnUpdate, 1, 3);
            tableLayoutPanel1.Controls.Add(btnDelete, 2, 3);
            tableLayoutPanel1.Controls.Add(txtOrderType, 1, 1);
            tableLayoutPanel1.Controls.Add(lblOrderDate, 0, 2);
            tableLayoutPanel1.Controls.Add(dtpOrderDate, 1, 2);
            tableLayoutPanel1.Controls.Add(label1, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
<<<<<<< HEAD
            tableLayoutPanel1.Location = new Point(7, 22);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(982, 242);
=======
            tableLayoutPanel1.Location = new Point(8, 28);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.Size = new Size(1123, 326);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            tableLayoutPanel1.TabIndex = 12;
            // 
            // txtReciever
            // 
            txtReciever.Dock = DockStyle.Fill;
<<<<<<< HEAD
            txtReciever.Location = new Point(739, 34);
            txtReciever.Margin = new Padding(4);
            txtReciever.Name = "txtReciever";
            txtReciever.Size = new Size(239, 23);
=======
            txtReciever.Location = new Point(844, 45);
            txtReciever.Margin = new Padding(4, 5, 4, 5);
            txtReciever.Name = "txtReciever";
            txtReciever.Size = new Size(275, 27);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            txtReciever.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.Location = new Point(494, 30);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
=======
            label1.Location = new Point(564, 40);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            label1.TabIndex = 11;
            label1.Text = "Reciever:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupBox3, 0, 1);
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Controls.Add(groupBox2, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.4954872F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.00902F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.4954872F));
<<<<<<< HEAD
            tableLayoutPanel2.Size = new Size(1000, 604);
=======
            tableLayoutPanel2.Size = new Size(1143, 806);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            tableLayoutPanel2.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = Color.FromArgb(224, 224, 224);
<<<<<<< HEAD
            groupBox3.Location = new Point(2, 276);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(7, 6, 7, 6);
            groupBox3.Size = new Size(996, 50);
=======
            groupBox3.Location = new Point(2, 368);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(8);
            groupBox3.Size = new Size(1139, 68);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
<<<<<<< HEAD
            textBox1.Location = new Point(7, 22);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(982, 23);
=======
            textBox1.Location = new Point(8, 28);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1123, 27);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(2, 2);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
<<<<<<< HEAD
            groupBox1.Padding = new Padding(7, 6, 7, 6);
            groupBox1.Size = new Size(996, 270);
=======
            groupBox1.Padding = new Padding(8);
            groupBox1.Size = new Size(1139, 362);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewOrders);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.FromArgb(224, 224, 224);
<<<<<<< HEAD
            groupBox2.Location = new Point(2, 330);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(7, 6, 7, 6);
            groupBox2.Size = new Size(996, 272);
=======
            groupBox2.Location = new Point(2, 440);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(8);
            groupBox2.Size = new Size(1139, 364);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order's List";
            // 
            // FormOrder
            // 
<<<<<<< HEAD
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 28, 36);
            ClientSize = new Size(1000, 604);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(4);
=======
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 28, 36);
            ClientSize = new Size(1143, 806);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(4, 5, 4, 5);
>>>>>>> 9d4e42f4213ec08287d7af2e90687d4183cb36ed
            Name = "FormOrder";
            Text = "Order Management";
            WindowState = FormWindowState.Maximized;
            Load += FormOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.TextBox txtOrderType;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox txtReciever;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBox1;
    }
}