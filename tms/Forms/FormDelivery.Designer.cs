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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            deliveryId = new TextBox();
            label2 = new Label();
            orderId = new TextBox();
            label3 = new Label();
            customerId = new TextBox();
            label4 = new Label();
            orderType = new TextBox();
            label5 = new Label();
            orderDate = new TextBox();
            label6 = new Label();
            deliveryStatus = new ComboBox();
            updateBtn = new Button();
            logoutBtn = new Button();
            tableDelivery = new DataGridView();
            panelHeader = new Panel();
            labelTitle = new Label();
            panelForm = new Panel();
            ((System.ComponentModel.ISupportInitialize)tableDelivery).BeginInit();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(74, 17);
            label1.TabIndex = 0;
            label1.Text = "Delivery ID";
            // 
            // deliveryId
            // 
            deliveryId.BorderStyle = BorderStyle.FixedSingle;
            deliveryId.Font = new Font("Segoe UI", 13F);
            deliveryId.Location = new Point(140, 20);
            deliveryId.Name = "deliveryId";
            deliveryId.Size = new Size(823, 31);
            deliveryId.TabIndex = 1;
            deliveryId.TextChanged += deliveryId_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(20, 66);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 0;
            label2.Text = "Order ID";
            // 
            // orderId
            // 
            orderId.BorderStyle = BorderStyle.FixedSingle;
            orderId.Font = new Font("Segoe UI", 13F);
            orderId.Location = new Point(140, 66);
            orderId.Name = "orderId";
            orderId.Size = new Size(823, 31);
            orderId.TabIndex = 1;
            orderId.TextChanged += orderId_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(20, 111);
            label3.Name = "label3";
            label3.Size = new Size(84, 17);
            label3.TabIndex = 0;
            label3.Text = "Customer ID";
            // 
            // customerId
            // 
            customerId.BorderStyle = BorderStyle.FixedSingle;
            customerId.Font = new Font("Segoe UI", 13F);
            customerId.Location = new Point(140, 111);
            customerId.Name = "customerId";
            customerId.Size = new Size(823, 31);
            customerId.TabIndex = 1;
            customerId.TextChanged += customerId_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(20, 159);
            label4.Name = "label4";
            label4.Size = new Size(75, 17);
            label4.TabIndex = 0;
            label4.Text = "Order Type";
            // 
            // orderType
            // 
            orderType.BorderStyle = BorderStyle.FixedSingle;
            orderType.Font = new Font("Segoe UI", 13F);
            orderType.Location = new Point(140, 159);
            orderType.Name = "orderType";
            orderType.Size = new Size(823, 31);
            orderType.TabIndex = 1;
            orderType.TextChanged += orderType_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(64, 64, 64);
            label5.Location = new Point(20, 209);
            label5.Name = "label5";
            label5.Size = new Size(75, 17);
            label5.TabIndex = 0;
            label5.Text = "Order Date";
            // 
            // orderDate
            // 
            orderDate.BorderStyle = BorderStyle.FixedSingle;
            orderDate.Font = new Font("Segoe UI", 13F);
            orderDate.Location = new Point(140, 209);
            orderDate.Name = "orderDate";
            orderDate.Size = new Size(823, 31);
            orderDate.TabIndex = 1;
            orderDate.TextChanged += orderDate_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(64, 64, 64);
            label6.Location = new Point(20, 255);
            label6.Name = "label6";
            label6.Size = new Size(99, 17);
            label6.TabIndex = 0;
            label6.Text = "Delivery Status";
            // 
            // deliveryStatus
            // 
            deliveryStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            deliveryStatus.Font = new Font("Segoe UI", 13F);
            deliveryStatus.FormattingEnabled = true;
            deliveryStatus.Location = new Point(140, 255);
            deliveryStatus.Name = "deliveryStatus";
            deliveryStatus.Size = new Size(823, 31);
            deliveryStatus.TabIndex = 2;
            deliveryStatus.SelectedIndexChanged += deliveryStatus_SelectedIndexChanged;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(0, 122, 204);
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(729, 307);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(100, 35);
            updateBtn.TabIndex = 3;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(64, 64, 64);
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoutBtn.ForeColor = Color.White;
            logoutBtn.Location = new Point(863, 307);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(100, 35);
            logoutBtn.TabIndex = 3;
            logoutBtn.Text = "Sign Out";
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 122, 204);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tableDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tableDelivery.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tableDelivery.DefaultCellStyle = dataGridViewCellStyle2;
            tableDelivery.EnableHeadersVisualStyles = false;
            tableDelivery.GridColor = Color.FromArgb(224, 224, 224);
            tableDelivery.Location = new Point(20, 367);
            tableDelivery.Name = "tableDelivery";
            tableDelivery.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            tableDelivery.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            tableDelivery.RowHeadersVisible = false;
            tableDelivery.RowTemplate.Height = 35;
            tableDelivery.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tableDelivery.Size = new Size(943, 353);
            tableDelivery.TabIndex = 4;
            this.tableDelivery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDelivery_CellClick);
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(labelTitle);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(989, 60);
            panelHeader.TabIndex = 5;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.FromArgb(64, 64, 64);
            labelTitle.Location = new Point(20, 15);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(231, 25);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Delivery Management 🚚";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(deliveryId);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(orderId);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(customerId);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(orderType);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(orderDate);
            panelForm.Controls.Add(label6);
            panelForm.Controls.Add(deliveryStatus);
            panelForm.Controls.Add(updateBtn);
            panelForm.Controls.Add(logoutBtn);
            panelForm.Controls.Add(tableDelivery);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(20);
            panelForm.Size = new Size(989, 740);
            panelForm.TabIndex = 6;
            // 
            // FormDelivery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(989, 800);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormDelivery";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delivery Management System";
            ((System.ComponentModel.ISupportInitialize)tableDelivery).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deliveryId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox orderId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox customerId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox orderType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox orderDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox deliveryStatus;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.DataGridView tableDelivery;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelForm;
    }
}