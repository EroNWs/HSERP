namespace Hserp_UI
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            panel1 = new Panel();
            panel2 = new Panel();
            lblLogoTitle = new Label();
            btnLogin = new Button();
            btnRegister = new Button();
            btnCustomerList = new Button();
            btnCustomerDetail = new Button();
            btnStockListDetail = new Button();
            btnOrder = new Button();
            btnSettings = new Button();
            panel3 = new Panel();
            lblOrder = new Label();
            dgvCustomerList = new DataGridView();
            OrderDate = new DataGridViewTextBoxColumn();
            OrderNumber = new DataGridViewTextBoxColumn();
            OrderedBy = new DataGridViewTextBoxColumn();
            btnOrderDelete = new Button();
            btnOrderUpdate = new Button();
            btnOrderCreate = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(btnOrder);
            panel1.Controls.Add(btnStockListDetail);
            panel1.Controls.Add(btnCustomerDetail);
            panel1.Controls.Add(btnCustomerList);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 513);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(39, 39, 58);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(lblLogoTitle);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 80);
            panel2.TabIndex = 3;
            panel2.Tag = "panelLogo";
            // 
            // lblLogoTitle
            // 
            lblLogoTitle.AutoSize = true;
            lblLogoTitle.Font = new Font("Nunito Sans", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLogoTitle.ForeColor = Color.Gainsboro;
            lblLogoTitle.Location = new Point(24, 29);
            lblLogoTitle.Name = "lblLogoTitle";
            lblLogoTitle.Size = new Size(139, 35);
            lblLogoTitle.TabIndex = 0;
            lblLogoTitle.Tag = "logoText";
            lblLogoTitle.Text = "Hsref ERP";
            // 
            // btnLogin
            // 
            btnLogin.Dock = DockStyle.Top;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.Gainsboro;
            btnLogin.Location = new Point(0, 80);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 60);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log-in";
            btnLogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Dock = DockStyle.Top;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.Gainsboro;
            btnRegister.Location = new Point(0, 140);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(200, 60);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Register";
            btnRegister.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnCustomerList
            // 
            btnCustomerList.Dock = DockStyle.Top;
            btnCustomerList.FlatAppearance.BorderSize = 0;
            btnCustomerList.FlatStyle = FlatStyle.Flat;
            btnCustomerList.ForeColor = Color.Gainsboro;
            btnCustomerList.Location = new Point(0, 200);
            btnCustomerList.Name = "btnCustomerList";
            btnCustomerList.Size = new Size(200, 60);
            btnCustomerList.TabIndex = 8;
            btnCustomerList.Text = "Customer List";
            btnCustomerList.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomerList.UseVisualStyleBackColor = true;
            // 
            // btnCustomerDetail
            // 
            btnCustomerDetail.Dock = DockStyle.Top;
            btnCustomerDetail.FlatAppearance.BorderSize = 0;
            btnCustomerDetail.FlatStyle = FlatStyle.Flat;
            btnCustomerDetail.ForeColor = Color.Gainsboro;
            btnCustomerDetail.Location = new Point(0, 260);
            btnCustomerDetail.Name = "btnCustomerDetail";
            btnCustomerDetail.Size = new Size(200, 60);
            btnCustomerDetail.TabIndex = 9;
            btnCustomerDetail.Text = "Customer Detail";
            btnCustomerDetail.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomerDetail.UseVisualStyleBackColor = true;
            // 
            // btnStockListDetail
            // 
            btnStockListDetail.Dock = DockStyle.Top;
            btnStockListDetail.FlatAppearance.BorderSize = 0;
            btnStockListDetail.FlatStyle = FlatStyle.Flat;
            btnStockListDetail.ForeColor = Color.Gainsboro;
            btnStockListDetail.Location = new Point(0, 320);
            btnStockListDetail.Name = "btnStockListDetail";
            btnStockListDetail.Size = new Size(200, 60);
            btnStockListDetail.TabIndex = 10;
            btnStockListDetail.Text = "Stock List Detail";
            btnStockListDetail.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStockListDetail.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            btnOrder.Dock = DockStyle.Top;
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.ForeColor = Color.Gainsboro;
            btnOrder.Location = new Point(0, 380);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(200, 60);
            btnOrder.TabIndex = 11;
            btnOrder.Text = "Order";
            btnOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Top;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.Gainsboro;
            btnSettings.Location = new Point(0, 440);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(200, 60);
            btnSettings.TabIndex = 12;
            btnSettings.Text = "Order Details";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(lblOrder);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(746, 80);
            panel3.TabIndex = 6;
            panel3.Tag = "panelTitleBar";
            // 
            // lblOrder
            // 
            lblOrder.AutoSize = true;
            lblOrder.Font = new Font("Nunito Sans", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrder.ForeColor = SystemColors.ActiveCaptionText;
            lblOrder.Location = new Point(321, 29);
            lblOrder.Name = "lblOrder";
            lblOrder.Size = new Size(106, 35);
            lblOrder.TabIndex = 1;
            lblOrder.Tag = "logoText";
            lblOrder.Text = "ORDER";
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.BackgroundColor = SystemColors.ActiveCaption;
            dgvCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Columns.AddRange(new DataGridViewColumn[] { OrderDate, OrderNumber, OrderedBy });
            dgvCustomerList.Location = new Point(399, 130);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.RowTemplate.Height = 25;
            dgvCustomerList.Size = new Size(341, 280);
            dgvCustomerList.TabIndex = 7;
            // 
            // OrderDate
            // 
            OrderDate.HeaderText = "OrderDate";
            OrderDate.Name = "OrderDate";
            // 
            // OrderNumber
            // 
            OrderNumber.HeaderText = "OrderNumber";
            OrderNumber.Name = "OrderNumber";
            // 
            // OrderedBy
            // 
            OrderedBy.HeaderText = "OrderedBy";
            OrderedBy.Name = "OrderedBy";
            // 
            // btnOrderDelete
            // 
            btnOrderDelete.Location = new Point(635, 440);
            btnOrderDelete.Name = "btnOrderDelete";
            btnOrderDelete.Size = new Size(105, 40);
            btnOrderDelete.TabIndex = 10;
            btnOrderDelete.Text = "Delete";
            btnOrderDelete.UseVisualStyleBackColor = true;
            // 
            // btnOrderUpdate
            // 
            btnOrderUpdate.Location = new Point(517, 440);
            btnOrderUpdate.Name = "btnOrderUpdate";
            btnOrderUpdate.Size = new Size(105, 40);
            btnOrderUpdate.TabIndex = 9;
            btnOrderUpdate.Text = "Update";
            btnOrderUpdate.UseVisualStyleBackColor = true;
            // 
            // btnOrderCreate
            // 
            btnOrderCreate.Location = new Point(399, 440);
            btnOrderCreate.Name = "btnOrderCreate";
            btnOrderCreate.Size = new Size(105, 40);
            btnOrderCreate.TabIndex = 8;
            btnOrderCreate.Text = "Create";
            btnOrderCreate.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 513);
            Controls.Add(btnOrderDelete);
            Controls.Add(btnOrderUpdate);
            Controls.Add(btnOrderCreate);
            Controls.Add(dgvCustomerList);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Order";
            Text = "Order";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblLogoTitle;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnCustomerList;
        private Button btnCustomerDetail;
        private Button btnStockListDetail;
        private Button btnOrder;
        private Button btnSettings;
        private Panel panel3;
        private Label lblOrder;
        private DataGridView dgvCustomerList;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn OrderNumber;
        private DataGridViewTextBoxColumn OrderedBy;
        private Button btnOrderDelete;
        private Button btnOrderUpdate;
        private Button btnOrderCreate;
    }
}