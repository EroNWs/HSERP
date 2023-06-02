namespace Hserp_UI
{
    partial class Log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
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
            lblLoginTitle = new Label();
            txtLoginID = new TextBox();
            txtLoginPassword = new TextBox();
            btnLoginCancel = new Button();
            btnLoginLogin = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Size = new Size(200, 501);
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
            panel2.TabIndex = 1;
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
            btnLogin.TabIndex = 2;
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
            btnRegister.TabIndex = 3;
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
            btnCustomerList.TabIndex = 4;
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
            btnCustomerDetail.TabIndex = 5;
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
            btnStockListDetail.TabIndex = 6;
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
            btnOrder.TabIndex = 7;
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
            btnSettings.TabIndex = 8;
            btnSettings.Text = "Order Details";
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Controls.Add(lblLoginTitle);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(749, 80);
            panel3.TabIndex = 2;
            panel3.Tag = "panelTitleBar";
            // 
            // lblLoginTitle
            // 
            lblLoginTitle.AutoSize = true;
            lblLoginTitle.Font = new Font("Nunito Sans", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoginTitle.ForeColor = SystemColors.ActiveCaptionText;
            lblLoginTitle.Location = new Point(312, 29);
            lblLoginTitle.Name = "lblLoginTitle";
            lblLoginTitle.Size = new Size(105, 35);
            lblLoginTitle.TabIndex = 1;
            lblLoginTitle.Tag = "logoText";
            lblLoginTitle.Text = "LOG-IN";
            lblLoginTitle.Click += lblHomeTitle_Click;
            // 
            // txtLoginID
            // 
            txtLoginID.Location = new Point(463, 177);
            txtLoginID.Name = "txtLoginID";
            txtLoginID.PlaceholderText = "Please enter your ID";
            txtLoginID.Size = new Size(195, 23);
            txtLoginID.TabIndex = 3;
            txtLoginID.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(463, 220);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '.';
            txtLoginPassword.PlaceholderText = "Please enter your Password";
            txtLoginPassword.Size = new Size(195, 23);
            txtLoginPassword.TabIndex = 3;
            txtLoginPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // btnLoginCancel
            // 
            btnLoginCancel.Location = new Point(463, 260);
            btnLoginCancel.Name = "btnLoginCancel";
            btnLoginCancel.Size = new Size(75, 23);
            btnLoginCancel.TabIndex = 4;
            btnLoginCancel.Text = "Cancel";
            btnLoginCancel.UseVisualStyleBackColor = true;
            // 
            // btnLoginLogin
            // 
            btnLoginLogin.Location = new Point(583, 260);
            btnLoginLogin.Name = "btnLoginLogin";
            btnLoginLogin.Size = new Size(75, 23);
            btnLoginLogin.TabIndex = 4;
            btnLoginLogin.Text = "Log-in";
            btnLoginLogin.UseVisualStyleBackColor = true;
            // 
            // Log_in
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 501);
            Controls.Add(btnLoginLogin);
            Controls.Add(btnLoginCancel);
            Controls.Add(txtLoginPassword);
            Controls.Add(txtLoginID);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Log_in";
            Text = "Log_in";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblLoginTitle;
        private TextBox txtLoginID;
        private TextBox txtLoginPassword;
        private Button btnLoginCancel;
        private Button btnLoginLogin;
    }
}