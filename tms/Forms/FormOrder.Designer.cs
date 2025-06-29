﻿// Forms/FormOrder.Designer.cs
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
            lblOrderID.Location = new Point(5, 0);
            lblOrderID.Margin = new Padding(5, 0, 5, 0);
            lblOrderID.Name = "lblOrderID";
            lblOrderID.Size = new Size(85, 25);
            lblOrderID.TabIndex = 0;
            lblOrderID.Text = "Order ID:";
            // 
            // txtOrderID
            // 
            txtOrderID.Dock = DockStyle.Fill;
            txtOrderID.Location = new Point(355, 6);
            txtOrderID.Margin = new Padding(5, 6, 5, 6);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(340, 31);
            txtOrderID.TabIndex = 1;
            // 
            // lblCustomerID
            // 
            lblCustomerID.AutoSize = true;
            lblCustomerID.Location = new Point(705, 0);
            lblCustomerID.Margin = new Padding(5, 0, 5, 0);
            lblCustomerID.Name = "lblCustomerID";
            lblCustomerID.Size = new Size(71, 25);
            lblCustomerID.TabIndex = 2;
            lblCustomerID.Text = "Sender:";
            // 
            // txtSender
            // 
            txtSender.Dock = DockStyle.Fill;
            txtSender.Location = new Point(1055, 6);
            txtSender.Margin = new Padding(5, 6, 5, 6);
            txtSender.Name = "txtSender";
            txtSender.Size = new Size(343, 31);
            txtSender.TabIndex = 3;
            // 
            // lblOrderType
            // 
            lblOrderType.AutoSize = true;
            lblOrderType.Location = new Point(5, 50);
            lblOrderType.Margin = new Padding(5, 0, 5, 0);
            lblOrderType.Name = "lblOrderType";
            lblOrderType.Size = new Size(104, 25);
            lblOrderType.TabIndex = 4;
            lblOrderType.Text = "Order Type:";
            // 
            // txtOrderType
            // 
            txtOrderType.Dock = DockStyle.Fill;
            txtOrderType.Location = new Point(355, 56);
            txtOrderType.Margin = new Padding(5, 6, 5, 6);
            txtOrderType.Name = "txtOrderType";
            txtOrderType.Size = new Size(340, 31);
            txtOrderType.TabIndex = 5;
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(5, 100);
            lblOrderDate.Margin = new Padding(5, 0, 5, 0);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(104, 25);
            lblOrderDate.TabIndex = 6;
            lblOrderDate.Text = "Order Date:";
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Dock = DockStyle.Fill;
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(355, 106);
            dtpOrderDate.Margin = new Padding(5, 6, 5, 6);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(340, 31);
            dtpOrderDate.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(5, 156);
            btnSave.Margin = new Padding(5, 6, 5, 6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 44);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.White;
            btnUpdate.ForeColor = Color.Black;
            btnUpdate.Location = new Point(355, 156);
            btnUpdate.Margin = new Padding(5, 6, 5, 6);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 44);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(705, 156);
            btnDelete.Margin = new Padding(5, 6, 5, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 44);
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
            dataGridViewOrders.Location = new Point(10, 34);
            dataGridViewOrders.Margin = new Padding(5, 6, 5, 6);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.ReadOnly = true;
            dataGridViewOrders.RowHeadersWidth = 62;
            dataGridViewOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrders.Size = new Size(1403, 409);
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
            tableLayoutPanel1.Location = new Point(10, 34);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(1403, 408);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // txtReciever
            // 
            txtReciever.Dock = DockStyle.Fill;
            txtReciever.Location = new Point(1055, 56);
            txtReciever.Margin = new Padding(5, 6, 5, 6);
            txtReciever.Name = "txtReciever";
            txtReciever.Size = new Size(343, 31);
            txtReciever.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(705, 50);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
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
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.4954872F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.00902F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 45.4954872F));
            tableLayoutPanel2.Size = new Size(1429, 1007);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox1);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox3.Location = new Point(3, 461);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10);
            groupBox3.Size = new Size(1423, 84);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(10, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1403, 31);
            textBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(1423, 452);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridViewOrders);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox2.Location = new Point(3, 551);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(1423, 453);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Order's List";
            // 
            // FormOrder
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 28, 36);
            ClientSize = new Size(1429, 1007);
            Controls.Add(tableLayoutPanel2);
            Margin = new Padding(5, 6, 5, 6);
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