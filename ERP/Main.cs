using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCustomerList_Click(object sender, EventArgs e)
        {
            CustomerList customerList = new CustomerList();

            this.Hide();
            customerList.Visible = true;

        }

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            CustomerDetail customerDetail = new CustomerDetail();
            this.Hide();
            customerDetail.Visible = true;

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            this.Hide();
            order.Visible = true;
        }

        private void btnStockList_Click(object sender, EventArgs e)
        {
            StockList stockList = new StockList();
            this.Hide();
            stockList.Visible = true;
        }
    }
}
