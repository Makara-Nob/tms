namespace tms.Forms
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
            label1 = new Label();
            Delivery_Id = new TextBox();
            label2 = new Label();
            Order_Id = new TextBox();
            label4 = new Label();
            Order_Date = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Update_Button = new Button();
            Order_Table = new DataGridView();
            panelForm = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            groupBox5 = new GroupBox();
            Search_Delivery = new TextBox();
            groupBox4 = new GroupBox();
            Delivery_Table = new DataGridView();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            Delivery_Trip = new ComboBox();
            Delivery_Status = new ComboBox();
            Order_Type = new TextBox();
            label7 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            Search_Order = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Order_Table).BeginInit();
            panelForm.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Delivery_Table).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
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
            // Delivery_Id
            // 
            Delivery_Id.BorderStyle = BorderStyle.FixedSingle;
            Delivery_Id.Dock = DockStyle.Fill;
            Delivery_Id.Font = new Font("Segoe UI", 11F);
            Delivery_Id.Location = new Point(225, 3);
            Delivery_Id.Name = "Delivery_Id";
            Delivery_Id.Size = new Size(216, 27);
            Delivery_Id.TabIndex = 1;
            Delivery_Id.TextChanged += Delivery_Id_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(447, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 0;
            label2.Text = "Order ID";
            // 
            // Order_Id
            // 
            Order_Id.BorderStyle = BorderStyle.FixedSingle;
            Order_Id.Dock = DockStyle.Fill;
            Order_Id.Font = new Font("Segoe UI", 11F);
            Order_Id.Location = new Point(669, 3);
            Order_Id.Name = "Order_Id";
            Order_Id.Size = new Size(218, 27);
            Order_Id.TabIndex = 1;
            Order_Id.TextChanged += Order_Id_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(3, 109);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 0;
            label4.Text = "Order Type";
            // 
            // Order_Date
            // 
            Order_Date.BorderStyle = BorderStyle.FixedSingle;
            Order_Date.Dock = DockStyle.Fill;
            Order_Date.Font = new Font("Segoe UI", 11F);
            Order_Date.Location = new Point(669, 112);
            Order_Date.Name = "Order_Date";
            Order_Date.Size = new Size(218, 27);
            Order_Date.TabIndex = 1;
            Order_Date.TextChanged += Order_Date_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(447, 109);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 0;
            label5.Text = "Order Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(3, 218);
            label6.Name = "label6";
            label6.Size = new Size(99, 17);
            label6.TabIndex = 0;
            label6.Text = "Delivery Status";
            // 
            // Update_Button
            // 
            Update_Button.BackColor = Color.White;
            Update_Button.FlatAppearance.BorderSize = 0;
            Update_Button.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Update_Button.ForeColor = Color.Black;
            Update_Button.Location = new Point(3, 330);
            Update_Button.Name = "Update_Button";
            Update_Button.Size = new Size(125, 45);
            Update_Button.TabIndex = 3;
            Update_Button.Text = "Update";
            Update_Button.UseVisualStyleBackColor = false;
            Update_Button.Click += Update_Button_Click;
            // 
            // Order_Table
            // 
            Order_Table.AllowUserToAddRows = false;
            Order_Table.AllowUserToDeleteRows = false;
            Order_Table.AllowUserToResizeRows = false;
            Order_Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Order_Table.BackgroundColor = Color.White;
            Order_Table.BorderStyle = BorderStyle.Fixed3D;
            Order_Table.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            Order_Table.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Order_Table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            Order_Table.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            Order_Table.DefaultCellStyle = dataGridViewCellStyle2;
            Order_Table.Dock = DockStyle.Fill;
            Order_Table.EnableHeadersVisualStyles = false;
            Order_Table.GridColor = Color.FromArgb(224, 224, 224);
            Order_Table.Location = new Point(10, 26);
            Order_Table.Name = "Order_Table";
            Order_Table.ReadOnly = true;
            Order_Table.RowHeadersVisible = false;
            Order_Table.RowHeadersWidth = 62;
            Order_Table.RowTemplate.Height = 35;
            Order_Table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Order_Table.Size = new Size(429, 828);
            Order_Table.TabIndex = 4;
            Order_Table.CellContentClick += Order_Table_CellContentClick;
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
            panelForm.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1383, 958);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(groupBox5, 0, 1);
            tableLayoutPanel3.Controls.Add(groupBox4, 0, 2);
            tableLayoutPanel3.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(464, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50.4963F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 9.132957F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 40.3707428F));
            tableLayoutPanel3.Size = new Size(916, 952);
            tableLayoutPanel3.TabIndex = 7;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(Search_Delivery);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox5.Location = new Point(3, 483);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(10);
            groupBox5.Size = new Size(910, 80);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "Search";
            // 
            // Search_Delivery
            // 
            Search_Delivery.Dock = DockStyle.Fill;
            Search_Delivery.Location = new Point(10, 26);
            Search_Delivery.Name = "Search_Delivery";
            Search_Delivery.Size = new Size(890, 23);
            Search_Delivery.TabIndex = 10;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(Delivery_Table);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox4.Location = new Point(3, 569);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(10);
            groupBox4.Size = new Size(910, 380);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Delivery's List";
            // 
            // Delivery_Table
            // 
            Delivery_Table.BackgroundColor = Color.White;
            Delivery_Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Delivery_Table.Dock = DockStyle.Fill;
            Delivery_Table.Location = new Point(10, 26);
            Delivery_Table.Name = "Delivery_Table";
            Delivery_Table.RowHeadersWidth = 62;
            Delivery_Table.Size = new Size(890, 344);
            Delivery_Table.TabIndex = 0;
            Delivery_Table.CellContentClick += Delivery_Table_CellContentClick;
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
            groupBox1.TabIndex = 8;
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
            tableLayoutPanel2.Controls.Add(Delivery_Trip, 3, 2);
            tableLayoutPanel2.Controls.Add(Delivery_Status, 1, 2);
            tableLayoutPanel2.Controls.Add(Order_Type, 1, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(Delivery_Id, 1, 0);
            tableLayoutPanel2.Controls.Add(Order_Date, 3, 1);
            tableLayoutPanel2.Controls.Add(Order_Id, 3, 0);
            tableLayoutPanel2.Controls.Add(label2, 2, 0);
            tableLayoutPanel2.Controls.Add(label4, 0, 1);
            tableLayoutPanel2.Controls.Add(label5, 2, 1);
            tableLayoutPanel2.Controls.Add(label6, 0, 2);
            tableLayoutPanel2.Controls.Add(label7, 2, 2);
            tableLayoutPanel2.Controls.Add(Update_Button, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 26);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(890, 438);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // Delivery_Trip
            // 
            Delivery_Trip.Dock = DockStyle.Fill;
            Delivery_Trip.DropDownStyle = ComboBoxStyle.DropDownList;
            Delivery_Trip.Font = new Font("Segoe UI", 11F);
            Delivery_Trip.FormattingEnabled = true;
            Delivery_Trip.Location = new Point(669, 221);
            Delivery_Trip.Name = "Delivery_Trip";
            Delivery_Trip.Size = new Size(218, 28);
            Delivery_Trip.TabIndex = 8;
            Delivery_Trip.SelectedIndexChanged += Delivery_Trip_SelectedIndexChanged;
            // 
            // Delivery_Status
            // 
            Delivery_Status.Dock = DockStyle.Fill;
            Delivery_Status.DropDownStyle = ComboBoxStyle.DropDownList;
            Delivery_Status.Font = new Font("Segoe UI", 11F);
            Delivery_Status.FormattingEnabled = true;
            Delivery_Status.Location = new Point(225, 221);
            Delivery_Status.Name = "Delivery_Status";
            Delivery_Status.Size = new Size(216, 28);
            Delivery_Status.TabIndex = 7;
            Delivery_Status.SelectedIndexChanged += Delivery_Status_SelectedIndexChanged;
            // 
            // Order_Type
            // 
            Order_Type.BorderStyle = BorderStyle.FixedSingle;
            Order_Type.Dock = DockStyle.Fill;
            Order_Type.Font = new Font("Segoe UI", 11F);
            Order_Type.Location = new Point(225, 112);
            Order_Type.Name = "Order_Type";
            Order_Type.Size = new Size(216, 27);
            Order_Type.TabIndex = 6;
            Order_Type.TextChanged += Order_Type_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(447, 218);
            label7.Name = "label7";
            label7.Size = new Size(79, 17);
            label7.TabIndex = 5;
            label7.Text = "Choose Trip";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel4.Controls.Add(groupBox3, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 8.625729F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 91.37427F));
            tableLayoutPanel4.Size = new Size(455, 952);
            tableLayoutPanel4.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Order_Table);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox2.Location = new Point(3, 85);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(10);
            groupBox2.Size = new Size(449, 864);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Delivery's List";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(Search_Order);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.ForeColor = Color.FromArgb(224, 224, 224);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(10);
            groupBox3.Size = new Size(449, 76);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search";
            // 
            // Search_Order
            // 
            Search_Order.Dock = DockStyle.Fill;
            Search_Order.Location = new Point(10, 26);
            Search_Order.Name = "Search_Order";
            Search_Order.Size = new Size(429, 23);
            Search_Order.TabIndex = 10;
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
            ((System.ComponentModel.ISupportInitialize)Order_Table).EndInit();
            panelForm.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Delivery_Table).EndInit();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Delivery_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Order_Id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Order_Date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox orderDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox deliveryStatus;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.DataGridView Order_Table;
        private System.Windows.Forms.Panel panelForm;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel4;
        private GroupBox groupBox3;
        private TextBox Search_Order;
        private GroupBox groupBox5;
        private TextBox Search_Delivery;
        private GroupBox groupBox4;
        private DataGridView Delivery_Table;
        private Label label7;
        private ComboBox Delivery_Trip;
        private ComboBox Delivery_Status;
        private TextBox Order_Type;
    }
}