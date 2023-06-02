namespace ERP
{
    partial class StockList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockList));
            dgvStockAndDetails = new DataGridView();
            btnNewRecord = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtStockName = new TextBox();
            txtStockCode = new TextBox();
            txtUnitPrice = new TextBox();
            btnDisplay = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStockAndDetails).BeginInit();
            SuspendLayout();
            // 
            // dgvStockAndDetails
            // 
            dgvStockAndDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockAndDetails.Location = new Point(46, 25);
            dgvStockAndDetails.Name = "dgvStockAndDetails";
            dgvStockAndDetails.RowHeadersWidth = 51;
            dgvStockAndDetails.RowTemplate.Height = 29;
            dgvStockAndDetails.Size = new Size(1142, 301);
            dgvStockAndDetails.TabIndex = 0;
            // 
            // btnNewRecord
            // 
            btnNewRecord.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNewRecord.Location = new Point(407, 513);
            btnNewRecord.Name = "btnNewRecord";
            btnNewRecord.Size = new Size(166, 49);
            btnNewRecord.TabIndex = 6;
            btnNewRecord.Text = "New Record";
            btnNewRecord.UseVisualStyleBackColor = true;
            btnNewRecord.Click += btnNewRecord_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(616, 436);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(166, 49);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(616, 513);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(166, 49);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtStockName
            // 
            txtStockName.Location = new Point(514, 578);
            txtStockName.Multiline = true;
            txtStockName.Name = "txtStockName";
            txtStockName.PlaceholderText = "Stock Name";
            txtStockName.Size = new Size(166, 42);
            txtStockName.TabIndex = 1;
            txtStockName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStockCode
            // 
            txtStockCode.Location = new Point(514, 635);
            txtStockCode.Multiline = true;
            txtStockCode.Name = "txtStockCode";
            txtStockCode.PlaceholderText = "Stock Code";
            txtStockCode.Size = new Size(166, 45);
            txtStockCode.TabIndex = 2;
            txtStockCode.TextAlign = HorizontalAlignment.Center;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(514, 700);
            txtUnitPrice.Multiline = true;
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.PlaceholderText = "Unit Price";
            txtUnitPrice.Size = new Size(166, 45);
            txtUnitPrice.TabIndex = 3;
            txtUnitPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // btnDisplay
            // 
            btnDisplay.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDisplay.Location = new Point(407, 436);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(166, 49);
            btnDisplay.TabIndex = 4;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(1048, 701);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(153, 44);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // StockList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1213, 757);
            Controls.Add(btnBack);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtStockCode);
            Controls.Add(txtStockName);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnDisplay);
            Controls.Add(btnNewRecord);
            Controls.Add(dgvStockAndDetails);
            Name = "StockList";
            Text = "Stock List and Details";
            ((System.ComponentModel.ISupportInitialize)dgvStockAndDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStockAndDetails;
        private Button btnNewRecord;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtStockName;
        private TextBox txtStockCode;
        private TextBox txtUnitPrice;
        private Button btnDisplay;
        private Button btnBack;
    }
}