namespace ERP
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
            dgvOrder = new DataGridView();
            btnDisplay = new Button();
            dgvOrderDetails = new DataGridView();
            btnDisplay2 = new Button();
            txtOrderDate = new TextBox();
            txtOrderNumber = new TextBox();
            txtCustomer = new TextBox();
            txtOrderId = new TextBox();
            txtOrderLineId = new TextBox();
            txtProductId = new TextBox();
            txtProductNumber = new TextBox();
            btnUpdate = new Button();
            btnUpdate2 = new Button();
            btnBack = new Button();
            btnCreate = new Button();
            txtIdentification = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(25, 12);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(499, 368);
            dgvOrder.TabIndex = 0;
            // 
            // btnDisplay
            // 
            btnDisplay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisplay.Location = new Point(81, 409);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(166, 49);
            btnDisplay.TabIndex = 9;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Location = new Point(690, 12);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.RowHeadersWidth = 51;
            dgvOrderDetails.RowTemplate.Height = 29;
            dgvOrderDetails.Size = new Size(499, 368);
            dgvOrderDetails.TabIndex = 7;
            // 
            // btnDisplay2
            // 
            btnDisplay2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisplay2.Location = new Point(763, 409);
            btnDisplay2.Name = "btnDisplay2";
            btnDisplay2.Size = new Size(166, 49);
            btnDisplay2.TabIndex = 11;
            btnDisplay2.Text = "Display";
            btnDisplay2.UseVisualStyleBackColor = true;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(174, 546);
            txtOrderDate.Multiline = true;
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.PlaceholderText = "Order Date";
            txtOrderDate.Size = new Size(166, 42);
            txtOrderDate.TabIndex = 2;
            txtOrderDate.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOrderNumber
            // 
            txtOrderNumber.Location = new Point(174, 602);
            txtOrderNumber.Multiline = true;
            txtOrderNumber.Name = "txtOrderNumber";
            txtOrderNumber.PlaceholderText = "Order Number";
            txtOrderNumber.Size = new Size(166, 42);
            txtOrderNumber.TabIndex = 3;
            txtOrderNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(174, 661);
            txtCustomer.Multiline = true;
            txtCustomer.Name = "txtCustomer";
            txtCustomer.PlaceholderText = "Customer";
            txtCustomer.Size = new Size(166, 42);
            txtCustomer.TabIndex = 4;
            txtCustomer.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(865, 484);
            txtOrderId.Multiline = true;
            txtOrderId.Name = "txtOrderId";
            txtOrderId.PlaceholderText = "Order Id";
            txtOrderId.Size = new Size(166, 42);
            txtOrderId.TabIndex = 5;
            txtOrderId.TextAlign = HorizontalAlignment.Center;
            // 
            // txtOrderLineId
            // 
            txtOrderLineId.Location = new Point(865, 546);
            txtOrderLineId.Multiline = true;
            txtOrderLineId.Name = "txtOrderLineId";
            txtOrderLineId.PlaceholderText = "Order Line  Id";
            txtOrderLineId.Size = new Size(166, 42);
            txtOrderLineId.TabIndex = 6;
            txtOrderLineId.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(865, 602);
            txtProductId.Multiline = true;
            txtProductId.Name = "txtProductId";
            txtProductId.PlaceholderText = "Product Id";
            txtProductId.Size = new Size(166, 42);
            txtProductId.TabIndex = 7;
            txtProductId.TextAlign = HorizontalAlignment.Center;
            // 
            // txtProductNumber
            // 
            txtProductNumber.Location = new Point(865, 661);
            txtProductNumber.Multiline = true;
            txtProductNumber.Name = "txtProductNumber";
            txtProductNumber.PlaceholderText = "Product Number";
            txtProductNumber.Size = new Size(166, 42);
            txtProductNumber.TabIndex = 8;
            txtProductNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(281, 409);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(166, 49);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUpdate2
            // 
            btnUpdate2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate2.Location = new Point(965, 409);
            btnUpdate2.Name = "btnUpdate2";
            btnUpdate2.Size = new Size(166, 49);
            btnUpdate2.TabIndex = 12;
            btnUpdate2.Text = "Update";
            btnUpdate2.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(1048, 701);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 44);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(523, 696);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(166, 49);
            btnCreate.TabIndex = 13;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtIdentification
            // 
            txtIdentification.Location = new Point(174, 484);
            txtIdentification.Multiline = true;
            txtIdentification.Name = "txtIdentification";
            txtIdentification.PlaceholderText = "Identification";
            txtIdentification.Size = new Size(166, 42);
            txtIdentification.TabIndex = 1;
            txtIdentification.TextAlign = HorizontalAlignment.Center;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1213, 757);
            Controls.Add(btnCreate);
            Controls.Add(btnBack);
            Controls.Add(dgvOrderDetails);
            Controls.Add(btnDisplay2);
            Controls.Add(btnUpdate2);
            Controls.Add(btnUpdate);
            Controls.Add(btnDisplay);
            Controls.Add(txtIdentification);
            Controls.Add(txtCustomer);
            Controls.Add(txtOrderNumber);
            Controls.Add(txtProductNumber);
            Controls.Add(txtProductId);
            Controls.Add(txtOrderLineId);
            Controls.Add(txtOrderId);
            Controls.Add(txtOrderDate);
            Controls.Add(dgvOrder);
            Name = "Order";
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOrder;
        private Button btnDisplay;
        private DataGridView dgvOrderDetails;
        private Button btnDisplay2;
        private TextBox txtOrderDate;
        private TextBox txtOrderNumber;
        private TextBox txtCustomer;
        private TextBox txtOrderId;
        private TextBox txtOrderLineId;
        private TextBox txtProductId;
        private TextBox txtProductNumber;
        private Button btnUpdate;
        private Button btnUpdate2;
        private Button btnBack;
        private Button btnCreate;
        private TextBox txtIdentification;
    }
}