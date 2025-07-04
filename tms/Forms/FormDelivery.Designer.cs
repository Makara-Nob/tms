﻿namespace tms.Forms
{
    partial class FormDelivery
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            label1 = new Label();
            deliveryId = new TextBox();
            label2 = new Label();
            cmbOrder = new ComboBox();
            label3 = new Label();
            customerId = new TextBox();
            label4 = new Label();
            orderType = new TextBox();
            label5 = new Label();
            orderDate = new TextBox();
            label6 = new Label();
            deliveryStatus = new ComboBox();
            btnSaveDelivery = new Button();
            tableDelivery = new DataGridView();
            panelForm = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox3 = new GroupBox();
            txtSearch = new TextBox();
            groupBox2 = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox5 = new GroupBox();
            textBox1 = new TextBox();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tableDelivery).BeginInit();
            panelForm.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 0;
            label1.Text = "Delivery ID";
            // 
            // deliveryId
            // 
            deliveryId.BorderStyle = BorderStyle.FixedSingle;
            deliveryId.Dock = DockStyle.Fill;
            deliveryId.Font = new Font("Segoe UI", 11F);
            deliveryId.Location = new Point(225, 3);
            deliveryId.Name = "deliveryId";
            deliveryId.Size = new Size(216, 27);
            deliveryId.TabIndex = 1;
            deliveryId.TextChanged += deliveryId_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(447, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 2;
            label2.Text = "Order ID";
            // 
            // cmbOrder
            // 
            cmbOrder.Dock = DockStyle.Fill;
            cmbOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrder.Font = new Font("Segoe UI", 11F);
            cmbOrder.FormattingEnabled = true;
            cmbOrder.Location = new Point(669, 3);
            cmbOrder.Name = "cmbOrder";
            cmbOrder.Size = new Size(218, 28);
            cmbOrder.TabIndex = 3;
            cmbOrder.SelectedIndexChanged += cmbOrder_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(3, 109);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 4;
            label3.Text = "Customer ID";
            // 
            // customerId
            // 
            customerId.BorderStyle = BorderStyle.FixedSingle;
            customerId.Dock = DockStyle.Fill;
            customerId.Font = new Font("Segoe UI", 11F);
            customerId.Location = new Point(225, 112);
            customerId.Name = "customerId";
            customerId.Size = new Size(216, 27);
            customerId.TabIndex = 5;
            customerId.TextChanged += customerId_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(447, 109);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 6;
            label4.Text = "Order Type";
            // 
            // orderType
            // 
            orderType.BorderStyle = BorderStyle.FixedSingle;
            orderType.Dock = DockStyle.Fill;
            orderType.Font = new Font("Segoe UI", 11F);
            orderType.Location = new Point(669, 112);
            orderType.Name = "orderType";
            orderType.Size = new Size(218, 27);
            orderType.TabIndex = 7;
            orderType.TextChanged += orderType_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(3, 218);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 8;
            label5.Text = "Order Date";
            // 
            // orderDate
            // 
            orderDate.BorderStyle = BorderStyle.FixedSingle;
            orderDate.Dock = DockStyle.Fill;
            orderDate.Font = new Font("Segoe UI", 11F);
            orderDate.Location = new Point(225, 221);
            orderDate.Name = "orderDate";
            orderDate.Size = new Size(216, 27);
            orderDate.TabIndex = 9;
            orderDate.TextChanged += orderDate_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(447, 218);
            label6.Name = "label6";
            label6.Size = new Size(99, 17);
            label6.TabIndex = 10;
            label6.Text = "Delivery Status";
            // 
            // deliveryStatus
            // 
            deliveryStatus.Dock = DockStyle.Fill;
            deliveryStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            deliveryStatus.Font = new Font("Segoe UI", 11F);
            deliveryStatus.FormattingEnabled = true;
            deliveryStatus.Location = new Point(669, 221);
            deliveryStatus.Name = "deliveryStatus";
            deliveryStatus.Size = new Size(218, 28);
            deliveryStatus.TabIndex = 11;
            deliveryStatus.SelectedIndexChanged += deliveryStatus_SelectedIndexChanged;
            // 
            // btnSaveDelivery
            // 
            btnSaveDelivery.BackColor = Color.White;
            tableLayoutPanel2.SetColumnSpan(btnSaveDelivery, 4);
            btnSaveDelivery.FlatAppearance.BorderSize = 0;
            btnSaveDelivery.FlatStyle = FlatStyle.Flat;
            btnSaveDelivery.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveDelivery.ForeColor = Color.Black;
            btnSaveDelivery.Location = new Point(3, 330);
            btnSaveDelivery.Name = "btnSaveDelivery";
            btnSaveDelivery.Size = new Size(884, 45);
            btnSaveDelivery.TabIndex = 12;
            btnSaveDelivery.Text = "Save Delivery";
            btnSaveDelivery.UseVisualStyleBackColor = false;
            btnSaveDelivery.Click += btnSaveDelivery_Click;
            // 
            // tableDelivery
            // 
            tableDelivery.AllowUserToAddRows = false;
            tableDelivery.AllowUserToDeleteRows = false;
            tableDelivery.AllowUserToResizeRows = false;
            tableDelivery.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableDelivery.BackgroundColor = Color.White;
            tableDelivery.BorderStyle = BorderStyle.Fixed3D;
            tableDelivery.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            tableDelivery.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tableDelivery.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tableDelivery.DefaultCellStyle = dataGridViewCellStyle2;
            tableDelivery.Dock = DockStyle.Fill;
            tableDelivery.EnableHeadersVisualStyles = false;
            tableDelivery.GridColor = Color.FromArgb(224, 224, 224);
            tableDelivery.Location = new Point(10, 26);
            tableDelivery.Name = "tableDelivery";
            tableDelivery.ReadOnly = true;
            tableDelivery.RowHeadersVisible = false;
            tableDelivery.RowHeadersWidth = 62;
            tableDelivery.RowTemplate.Height = 35;
            tableDelivery.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableDelivery.Size = new Size(429, 828);
            tableDelivery.TabIndex = 13;
            tableDelivery.CellClick += tableDelivery_CellClick;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(22, 28, 36);
            panelForm.Controls.Add(tableLayoutPanel1);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 0);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(20);
            panelForm.Size = new Size(1423, 998);
            panelForm.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1383, 958);
            tableLayoutPanel1.TabIndex = 15;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel4.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.625729F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 91.37427F));
            tableLayoutPanel4.Size = new Size(455, 952);
            tableLayoutPanel4.TabIndex = 23;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(txtSearch);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10);
            groupBox3.Size = new Size(449, 76);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(10, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(429, 27);
            txtSearch.TabIndex = 26;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tableDelivery);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox2.Location = new Point(3, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(449, 864);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delivery's List";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Controls.Add(groupBox5, 0, 1);
            tableLayoutPanel3.Controls.Add(groupBox4, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(464, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.4963F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.132957F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40.3707428F));
            tableLayoutPanel3.Size = new Size(916, 952);
            tableLayoutPanel3.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(910, 474);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Form";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(deliveryId, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 2, 0);
            tableLayoutPanel2.Controls.Add(cmbOrder, 3, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(customerId, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 2, 1);
            tableLayoutPanel2.Controls.Add(orderType, 3, 1);
            tableLayoutPanel2.Controls.Add(label5, 0, 2);
            tableLayoutPanel2.Controls.Add(orderDate, 1, 2);
            tableLayoutPanel2.Controls.Add(label6, 2, 2);
            tableLayoutPanel2.Controls.Add(deliveryStatus, 3, 2);
            tableLayoutPanel2.Controls.Add(btnSaveDelivery, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Size = new Size(890, 438);
            tableLayoutPanel2.TabIndex = 22;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox1);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox5.Location = new Point(3, 483);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10);
            groupBox5.Size = new Size(910, 80);
            groupBox5.TabIndex = 17;
            groupBox5.TabStop = false;
            groupBox5.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(10, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(890, 27);
            textBox1.TabIndex = 18;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox4.Location = new Point(3, 569);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10);
            groupBox4.Size = new Size(910, 380);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "Delivery's List";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.ColumnHeadersHeight = 40;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            dataGridView1.Location = new Point(10, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 35;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(890, 344);
            dataGridView1.TabIndex = 20;
            // 
            // FormDelivery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1423, 998);
            Controls.Add(panelForm);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormDelivery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delivery Management System";
            WindowState = FormWindowState.Maximized;
            Load += FormDelivery_Load;
            ((System.ComponentModel.ISupportInitialize)tableDelivery).EndInit();
            panelForm.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox deliveryId;
        private Label label2;
        private ComboBox cmbOrder;
        private Label label3;
        private TextBox customerId;
        private Label label4;
        private TextBox orderType;
        private Label label5;
        private TextBox orderDate;
        private Label label6;
        private ComboBox deliveryStatus;
        private Button btnSaveDelivery;
        private DataGridView tableDelivery;
        private Panel panelForm;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox txtSearch;
        private TextBox textBox1;
        private DataGridView dataGridView1;
    }
}