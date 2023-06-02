namespace ERP
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            lblCreate = new Label();
            txtUserName = new TextBox();
            txtConfirmEmail = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtEmail = new TextBox();
            cbxCustomer = new CheckBox();
            cbxStock = new CheckBox();
            cbxOrder = new CheckBox();
            cbxReport = new CheckBox();
            btnSignUp = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblCreate
            // 
            lblCreate.AutoSize = true;
            lblCreate.BackColor = Color.Transparent;
            lblCreate.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreate.Location = new Point(600, 167);
            lblCreate.Name = "lblCreate";
            lblCreate.Size = new Size(296, 46);
            lblCreate.TabIndex = 0;
            lblCreate.Text = "Create an Account";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(624, 237);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name";
            txtUserName.Size = new Size(257, 41);
            txtUserName.TabIndex = 1;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtConfirmEmail
            // 
            txtConfirmEmail.Location = new Point(624, 355);
            txtConfirmEmail.Multiline = true;
            txtConfirmEmail.Name = "txtConfirmEmail";
            txtConfirmEmail.PlaceholderText = "Confirm E-Mail";
            txtConfirmEmail.Size = new Size(257, 41);
            txtConfirmEmail.TabIndex = 3;
            txtConfirmEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(624, 419);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(257, 41);
            txtPassword.TabIndex = 4;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(624, 484);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Confirm Password";
            txtConfirmPassword.Size = new Size(257, 41);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(624, 293);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-Mail";
            txtEmail.Size = new Size(257, 41);
            txtEmail.TabIndex = 2;
            txtEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxCustomer
            // 
            cbxCustomer.AutoSize = true;
            cbxCustomer.BackColor = Color.Transparent;
            cbxCustomer.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxCustomer.Location = new Point(654, 559);
            cbxCustomer.Name = "cbxCustomer";
            cbxCustomer.Size = new Size(96, 22);
            cbxCustomer.TabIndex = 6;
            cbxCustomer.Text = "Customer";
            cbxCustomer.UseVisualStyleBackColor = false;
            // 
            // cbxStock
            // 
            cbxStock.AutoSize = true;
            cbxStock.BackColor = Color.Transparent;
            cbxStock.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxStock.Location = new Point(780, 600);
            cbxStock.Name = "cbxStock";
            cbxStock.Size = new Size(69, 22);
            cbxStock.TabIndex = 9;
            cbxStock.Text = "Stock";
            cbxStock.UseVisualStyleBackColor = false;
            // 
            // cbxOrder
            // 
            cbxOrder.AutoSize = true;
            cbxOrder.BackColor = Color.Transparent;
            cbxOrder.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxOrder.Location = new Point(781, 559);
            cbxOrder.Name = "cbxOrder";
            cbxOrder.Size = new Size(68, 22);
            cbxOrder.TabIndex = 7;
            cbxOrder.Text = "Order";
            cbxOrder.UseVisualStyleBackColor = false;
            // 
            // cbxReport
            // 
            cbxReport.AutoSize = true;
            cbxReport.BackColor = Color.Transparent;
            cbxReport.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxReport.Location = new Point(654, 600);
            cbxReport.Name = "cbxReport";
            cbxReport.Size = new Size(75, 22);
            cbxReport.TabIndex = 8;
            cbxReport.Text = "Report";
            cbxReport.UseVisualStyleBackColor = false;
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignUp.Location = new Point(624, 645);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(257, 44);
            btnSignUp.TabIndex = 10;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(1048, 701);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 44);
            btnBack.TabIndex = 11;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1213, 757);
            Controls.Add(btnBack);
            Controls.Add(btnSignUp);
            Controls.Add(cbxReport);
            Controls.Add(cbxOrder);
            Controls.Add(cbxStock);
            Controls.Add(cbxCustomer);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtConfirmEmail);
            Controls.Add(txtUserName);
            Controls.Add(lblCreate);
            Name = "Register";
            Text = "Sign UP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreate;
        private TextBox txtUserName;
        private TextBox txtConfirmEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtEmail;
        private CheckBox cbxCustomer;
        private CheckBox cbxStock;
        private CheckBox cbxOrder;
        private CheckBox cbxReport;
        private Button btnSignUp;
        private Button btnBack;
    }
}