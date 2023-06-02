namespace ERP
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            btnCustomerList = new Button();
            btnOrder = new Button();
            btnStockList = new Button();
            btnCustomerDetails = new Button();
            SuspendLayout();
            // 
            // btnCustomerList
            // 
            btnCustomerList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomerList.Location = new Point(421, 259);
            btnCustomerList.Name = "btnCustomerList";
            btnCustomerList.Size = new Size(207, 65);
            btnCustomerList.TabIndex = 1;
            btnCustomerList.Text = "Customer List";
            btnCustomerList.UseVisualStyleBackColor = true;
            btnCustomerList.Click += btnCustomerList_Click;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrder.Location = new Point(421, 378);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(207, 65);
            btnOrder.TabIndex = 3;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnStockList
            // 
            btnStockList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnStockList.Location = new Point(699, 378);
            btnStockList.Name = "btnStockList";
            btnStockList.Size = new Size(207, 65);
            btnStockList.TabIndex = 4;
            btnStockList.Text = "Stock List";
            btnStockList.UseVisualStyleBackColor = true;
            btnStockList.Click += btnStockList_Click;
            // 
            // btnCustomerDetails
            // 
            btnCustomerDetails.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCustomerDetails.Location = new Point(699, 259);
            btnCustomerDetails.Name = "btnCustomerDetails";
            btnCustomerDetails.Size = new Size(207, 65);
            btnCustomerDetails.TabIndex = 2;
            btnCustomerDetails.Text = "Customer Details";
            btnCustomerDetails.UseVisualStyleBackColor = true;
            btnCustomerDetails.Click += btnCustomerDetails_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1213, 757);
            Controls.Add(btnCustomerDetails);
            Controls.Add(btnStockList);
            Controls.Add(btnOrder);
            Controls.Add(btnCustomerList);
            Name = "Main";
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCustomerList;
        private Button btnOrder;
        private Button btnStockList;
        private Button btnCustomerDetails;
    }
}