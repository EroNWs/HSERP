namespace ERP
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnLogin = new Button();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            cbxRemember = new CheckBox();
            lnkLostPassword = new LinkLabel();
            lblLogin = new Label();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(510, 404);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(220, 53);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(510, 231);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "User Name";
            txtUserName.Size = new Size(220, 41);
            txtUserName.TabIndex = 1;
            txtUserName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(510, 296);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(220, 41);
            txtPassword.TabIndex = 2;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // cbxRemember
            // 
            cbxRemember.AutoSize = true;
            cbxRemember.Location = new Point(601, 359);
            cbxRemember.Name = "cbxRemember";
            cbxRemember.Size = new Size(129, 24);
            cbxRemember.TabIndex = 3;
            cbxRemember.Text = "Remember me";
            cbxRemember.UseVisualStyleBackColor = true;
            // 
            // lnkLostPassword
            // 
            lnkLostPassword.AutoSize = true;
            lnkLostPassword.BackColor = Color.Transparent;
            lnkLostPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lnkLostPassword.LinkColor = Color.SaddleBrown;
            lnkLostPassword.Location = new Point(1058, 694);
            lnkLostPassword.Name = "lnkLostPassword";
            lnkLostPassword.Size = new Size(130, 25);
            lnkLostPassword.TabIndex = 5;
            lnkLostPassword.TabStop = true;
            lnkLostPassword.Text = "Lost Password";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblLogin.Location = new Point(447, 145);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(353, 46);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "Login to Your Account";
            // 
            // btnSignUp
            // 
            btnSignUp.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignUp.Location = new Point(510, 476);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(220, 53);
            btnSignUp.TabIndex = 5;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1213, 757);
            Controls.Add(lblLogin);
            Controls.Add(lnkLostPassword);
            Controls.Add(cbxRemember);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(btnSignUp);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "User Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private CheckBox cbxRemember;
        private LinkLabel lnkLostPassword;
        private Label lblLogin;
        private Button btnSignUp;
    }
}