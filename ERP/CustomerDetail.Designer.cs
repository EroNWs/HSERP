namespace ERP
{
    partial class CustomerDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerDetail));
            dgvCustomerDetail = new DataGridView();
            btnDisplay = new Button();
            txtHeadOfficeCountry = new TextBox();
            txtHeadOfficeCity = new TextBox();
            txtHeadOfficeAddress = new TextBox();
            txtTaxOffice = new TextBox();
            txtTaxNumber = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerCode = new TextBox();
            btnBack = new Button();
            dtpOrderDate = new DateTimePicker();
            txtPhoneNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomerDetail
            // 
            dgvCustomerDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerDetail.Location = new Point(23, 12);
            dgvCustomerDetail.Name = "dgvCustomerDetail";
            dgvCustomerDetail.RowHeadersWidth = 51;
            dgvCustomerDetail.RowTemplate.Height = 29;
            dgvCustomerDetail.Size = new Size(809, 486);
            dgvCustomerDetail.TabIndex = 0;
            // 
            // btnDisplay
            // 
            btnDisplay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisplay.Location = new Point(133, 514);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(166, 49);
            btnDisplay.TabIndex = 10;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // txtHeadOfficeCountry
            // 
            txtHeadOfficeCountry.Location = new Point(237, 699);
            txtHeadOfficeCountry.Multiline = true;
            txtHeadOfficeCountry.Name = "txtHeadOfficeCountry";
            txtHeadOfficeCountry.PlaceholderText = "Head Office Country";
            txtHeadOfficeCountry.Size = new Size(166, 42);
            txtHeadOfficeCountry.TabIndex = 6;
            txtHeadOfficeCountry.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHeadOfficeCity
            // 
            txtHeadOfficeCity.Location = new Point(237, 641);
            txtHeadOfficeCity.Multiline = true;
            txtHeadOfficeCity.Name = "txtHeadOfficeCity";
            txtHeadOfficeCity.PlaceholderText = "Head Office City";
            txtHeadOfficeCity.Size = new Size(166, 42);
            txtHeadOfficeCity.TabIndex = 5;
            txtHeadOfficeCity.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHeadOfficeAddress
            // 
            txtHeadOfficeAddress.Location = new Point(442, 641);
            txtHeadOfficeAddress.Multiline = true;
            txtHeadOfficeAddress.Name = "txtHeadOfficeAddress";
            txtHeadOfficeAddress.PlaceholderText = "Head Office Address";
            txtHeadOfficeAddress.Size = new Size(390, 100);
            txtHeadOfficeAddress.TabIndex = 8;
            // 
            // txtTaxOffice
            // 
            txtTaxOffice.Location = new Point(237, 584);
            txtTaxOffice.Multiline = true;
            txtTaxOffice.Name = "txtTaxOffice";
            txtTaxOffice.PlaceholderText = "Tax Office";
            txtTaxOffice.Size = new Size(166, 42);
            txtTaxOffice.TabIndex = 4;
            txtTaxOffice.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTaxNumber
            // 
            txtTaxNumber.Location = new Point(23, 699);
            txtTaxNumber.Multiline = true;
            txtTaxNumber.Name = "txtTaxNumber";
            txtTaxNumber.PlaceholderText = "Tax Number";
            txtTaxNumber.Size = new Size(166, 42);
            txtTaxNumber.TabIndex = 3;
            txtTaxNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(23, 641);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Customer Name";
            txtCustomerName.Size = new Size(166, 42);
            txtCustomerName.TabIndex = 2;
            txtCustomerName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCustomerCode
            // 
            txtCustomerCode.Location = new Point(23, 584);
            txtCustomerCode.Multiline = true;
            txtCustomerCode.Name = "txtCustomerCode";
            txtCustomerCode.PlaceholderText = "Customer Code";
            txtCustomerCode.Size = new Size(166, 42);
            txtCustomerCode.TabIndex = 1;
            txtCustomerCode.TextAlign = HorizontalAlignment.Center;
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
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(331, 525);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(250, 27);
            dtpOrderDate.TabIndex = 9;
            dtpOrderDate.Value = new DateTime(2023, 6, 1, 14, 7, 11, 0);
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(442, 584);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(166, 42);
            txtPhoneNumber.TabIndex = 7;
            txtPhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // CustomerDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1213, 757);
            Controls.Add(dtpOrderDate);
            Controls.Add(btnBack);
            Controls.Add(txtHeadOfficeCountry);
            Controls.Add(txtHeadOfficeCity);
            Controls.Add(txtHeadOfficeAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtTaxOffice);
            Controls.Add(txtTaxNumber);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerCode);
            Controls.Add(btnDisplay);
            Controls.Add(dgvCustomerDetail);
            Name = "CustomerDetail";
            Text = "Customer Detail";
            Load += CustomerDetail_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomerDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomerDetail;
        private Button btnDisplay;
        private TextBox txtHeadOfficeCountry;
        private TextBox txtHeadOfficeCity;
        private TextBox txtHeadOfficeAddress;
        private TextBox txtTaxOffice;
        private TextBox txtTaxNumber;
        private TextBox txtCustomerName;
        private TextBox txtCustomerCode;
        private Button btnBack;
        private DateTimePicker dtpOrderDate;
        private TextBox txtPhoneNumber;
    }
}