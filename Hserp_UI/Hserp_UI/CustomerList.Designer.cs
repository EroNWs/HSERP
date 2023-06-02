namespace Hserp_UI
{
    partial class CustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerList));
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
            lblCustomerList = new Label();
            dgvCustomerList = new DataGridView();
            CustomerID = new DataGridViewTextBoxColumn();
            CustomerName = new DataGridViewTextBoxColumn();
            CustomerTaxID = new DataGridViewTextBoxColumn();
            Country = new DataGridViewTextBoxColumn();
            City = new DataGridViewTextBoxColumn();
            btnCustomerCreate = new Button();
            btnCustomerUpdate = new Button();
            btnCustomerDelete = new Button();
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
            panel2.TabIndex = 2;
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
            btnLogin.TabIndex = 3;
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
            btnRegister.TabIndex = 4;
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
            btnCustomerList.TabIndex = 5;
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
            btnCustomerDetail.TabIndex = 6;
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
            btnStockListDetail.TabIndex = 7;
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
            btnOrder.TabIndex = 8;
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
            btnSettings.TabIndex = 9;
            btnSettings.Text = "Order Details";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(lblCustomerList);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(738, 80);
            panel3.TabIndex = 3;
            panel3.Tag = "panelTitleBar";
            // 
            // lblCustomerList
            // 
            lblCustomerList.AutoSize = true;
            lblCustomerList.Font = new Font("Nunito Sans", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCustomerList.ForeColor = SystemColors.ActiveCaptionText;
            lblCustomerList.Location = new Point(258, 29);
            lblCustomerList.Name = "lblCustomerList";
            lblCustomerList.Size = new Size(219, 35);
            lblCustomerList.TabIndex = 1;
            lblCustomerList.Tag = "logoText";
            lblCustomerList.Text = "CUSTOMER LIST";
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.BackgroundColor = SystemColors.ActiveCaption;
            dgvCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Columns.AddRange(new DataGridViewColumn[] { CustomerID, CustomerName, CustomerTaxID, Country, City });
            dgvCustomerList.Location = new Point(275, 121);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.RowTemplate.Height = 25;
            dgvCustomerList.Size = new Size(540, 280);
            dgvCustomerList.TabIndex = 4;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "CustomerID";
            CustomerID.Name = "CustomerID";
            // 
            // CustomerName
            // 
            CustomerName.HeaderText = "CustomerName";
            CustomerName.Name = "CustomerName";
            // 
            // CustomerTaxID
            // 
            CustomerTaxID.HeaderText = "CustomerTaxID";
            CustomerTaxID.Name = "CustomerTaxID";
            // 
            // Country
            // 
            Country.HeaderText = "Country";
            Country.Name = "Country";
            // 
            // City
            // 
            City.HeaderText = "City";
            City.Name = "City";
            // 
            // btnCustomerCreate
            // 
            btnCustomerCreate.Location = new Point(275, 430);
            btnCustomerCreate.Name = "btnCustomerCreate";
            btnCustomerCreate.Size = new Size(105, 40);
            btnCustomerCreate.TabIndex = 5;
            btnCustomerCreate.Text = "Create";
            btnCustomerCreate.UseVisualStyleBackColor = true;
            // 
            // btnCustomerUpdate
            // 
            btnCustomerUpdate.Location = new Point(492, 430);
            btnCustomerUpdate.Name = "btnCustomerUpdate";
            btnCustomerUpdate.Size = new Size(105, 40);
            btnCustomerUpdate.TabIndex = 6;
            btnCustomerUpdate.Text = "Update";
            btnCustomerUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCustomerDelete
            // 
            btnCustomerDelete.Location = new Point(710, 430);
            btnCustomerDelete.Name = "btnCustomerDelete";
            btnCustomerDelete.Size = new Size(105, 40);
            btnCustomerDelete.TabIndex = 6;
            btnCustomerDelete.Text = "Delete";
            btnCustomerDelete.UseVisualStyleBackColor = true;
            // 
            // CustomerList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 513);
            Controls.Add(btnCustomerDelete);
            Controls.Add(btnCustomerUpdate);
            Controls.Add(btnCustomerCreate);
            Controls.Add(dgvCustomerList);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CustomerList";
            Text = "CustomerList";
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
        private Label lblCustomerList;
        private DataGridView dgvCustomerList;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn CustomerName;
        private DataGridViewTextBoxColumn CustomerTaxID;
        private DataGridViewTextBoxColumn Country;
        private DataGridViewTextBoxColumn City;
        private Button btnCustomerCreate;
        private Button btnCustomerUpdate;
        private Button btnCustomerDelete;
    }
}