namespace ERP
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
            dgvCustomerList = new DataGridView();
            btnUpdate = new Button();
            btnNewRecord = new Button();
            btnDelete = new Button();
            textBox7 = new TextBox();
            txtHeadOfficeCity = new TextBox();
            txtHeadOfficeAddress = new TextBox();
            txtTaxOffice = new TextBox();
            txtTaxNumber = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerCode = new TextBox();
            btnCustomerDetails = new Button();
            txtHeadOfficeCountry = new TextBox();
            btnBack = new Button();
            txtPhoneNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomerList
            // 
            dgvCustomerList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomerList.Location = new Point(12, 12);
            dgvCustomerList.Name = "dgvCustomerList";
            dgvCustomerList.RowHeadersWidth = 51;
            dgvCustomerList.RowTemplate.Height = 29;
            dgvCustomerList.Size = new Size(809, 505);
            dgvCustomerList.TabIndex = 0;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(226, 523);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(166, 49);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNewRecord
            // 
            btnNewRecord.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewRecord.Location = new Point(12, 523);
            btnNewRecord.Name = "btnNewRecord";
            btnNewRecord.Size = new Size(166, 49);
            btnNewRecord.TabIndex = 9;
            btnNewRecord.Text = "New Record";
            btnNewRecord.UseVisualStyleBackColor = true;
            btnNewRecord.Click += button2_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(431, 523);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(166, 49);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(70, 779);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Head Office Country";
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 3;
            // 
            // txtHeadOfficeCity
            // 
            txtHeadOfficeCity.Location = new Point(226, 645);
            txtHeadOfficeCity.Multiline = true;
            txtHeadOfficeCity.Name = "txtHeadOfficeCity";
            txtHeadOfficeCity.PlaceholderText = "Head Office City";
            txtHeadOfficeCity.Size = new Size(166, 42);
            txtHeadOfficeCity.TabIndex = 5;
            txtHeadOfficeCity.TextAlign = HorizontalAlignment.Center;
            // 
            // txtHeadOfficeAddress
            // 
            txtHeadOfficeAddress.Location = new Point(431, 645);
            txtHeadOfficeAddress.Multiline = true;
            txtHeadOfficeAddress.Name = "txtHeadOfficeAddress";
            txtHeadOfficeAddress.PlaceholderText = "Head Office Address";
            txtHeadOfficeAddress.Size = new Size(390, 100);
            txtHeadOfficeAddress.TabIndex = 8;
            // 
            // txtTaxOffice
            // 
            txtTaxOffice.Location = new Point(226, 588);
            txtTaxOffice.Multiline = true;
            txtTaxOffice.Name = "txtTaxOffice";
            txtTaxOffice.PlaceholderText = "Tax Office";
            txtTaxOffice.Size = new Size(166, 42);
            txtTaxOffice.TabIndex = 4;
            txtTaxOffice.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTaxNumber
            // 
            txtTaxNumber.Location = new Point(12, 703);
            txtTaxNumber.Multiline = true;
            txtTaxNumber.Name = "txtTaxNumber";
            txtTaxNumber.PlaceholderText = "Tax Number";
            txtTaxNumber.Size = new Size(166, 42);
            txtTaxNumber.TabIndex = 3;
            txtTaxNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(12, 645);
            txtCustomerName.Multiline = true;
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Customer Name";
            txtCustomerName.Size = new Size(166, 42);
            txtCustomerName.TabIndex = 2;
            txtCustomerName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCustomerCode
            // 
            txtCustomerCode.Location = new Point(12, 588);
            txtCustomerCode.Multiline = true;
            txtCustomerCode.Name = "txtCustomerCode";
            txtCustomerCode.PlaceholderText = "Customer Code";
            txtCustomerCode.Size = new Size(166, 42);
            txtCustomerCode.TabIndex = 1;
            txtCustomerCode.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCustomerDetails
            // 
            btnCustomerDetails.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomerDetails.Location = new Point(655, 523);
            btnCustomerDetails.Name = "btnCustomerDetails";
            btnCustomerDetails.Size = new Size(166, 49);
            btnCustomerDetails.TabIndex = 12;
            btnCustomerDetails.Text = "Details";
            btnCustomerDetails.UseVisualStyleBackColor = true;
            btnCustomerDetails.Click += btnCustomerDetails_Click;
            // 
            // txtHeadOfficeCountry
            // 
            txtHeadOfficeCountry.Location = new Point(226, 703);
            txtHeadOfficeCountry.Multiline = true;
            txtHeadOfficeCountry.Name = "txtHeadOfficeCountry";
            txtHeadOfficeCountry.PlaceholderText = "Head Office Country";
            txtHeadOfficeCountry.Size = new Size(166, 42);
            txtHeadOfficeCountry.TabIndex = 6;
            txtHeadOfficeCountry.TextAlign = HorizontalAlignment.Center;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(1048, 701);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 44);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(431, 588);
            txtPhoneNumber.Multiline = true;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(166, 42);
            txtPhoneNumber.TabIndex = 7;
            txtPhoneNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // CustomerList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1213, 757);
            Controls.Add(btnBack);
            Controls.Add(textBox7);
            Controls.Add(txtHeadOfficeCountry);
            Controls.Add(txtHeadOfficeCity);
            Controls.Add(txtHeadOfficeAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtTaxOffice);
            Controls.Add(txtTaxNumber);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerCode);
            Controls.Add(btnNewRecord);
            Controls.Add(btnCustomerDetails);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvCustomerList);
            Name = "CustomerList";
            Text = "Customer List";
            ((System.ComponentModel.ISupportInitialize)dgvCustomerList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomerList;
        private Button btnUpdate;
        private Button btnNewRecord;
        private Button btnDelete;
        private TextBox textBox7;
        private TextBox txtHeadOfficeCity;
        private TextBox txtHeadOfficeAddress;
        private TextBox txtTaxOffice;
        private TextBox txtTaxNumber;
        private TextBox txtCustomerName;
        private TextBox txtCustomerCode;
        private Button btnCustomerDetails;
        private TextBox txtHeadOfficeCountry;
        private Button btnBack;
        private TextBox txtPhoneNumber;
    }
}