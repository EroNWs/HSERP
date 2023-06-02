using Hserp.Application.Contracts.Services;
using Hserp.Application.HsUsers.Mappers;
using Hserp.Application.HsUsers.Services;
using Hserp.Application.HsUsers.Validators;
using Hserp.Application.HsUsers.ViewModels.Order;
using Hserp.Infrastructure.Repositories;
using Microsoft.IdentityModel.Tokens;
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
    public partial class Order : Form
    {
        private readonly IOrderService orderService;
        public Order()
        {
            orderService = new OrderService(new OrderRepository(), new OrderValidator(), new OrderMapper());
            InitializeComponent();
        }

        private async void btnDisplay_Click(object sender, EventArgs e)
        {
            if (!txtCustomer.Text.IsNullOrEmpty())
            {
                var order = new OrderCustomerVM(txtCustomer.Text);
                await orderService.GetOrderByCustomerNameAsync(order.ToString());
            }

            else if (!txtOrderDate.Text.IsNullOrEmpty())
            {
                var order = new OrderDateVM(DateTime.Parse(txtOrderDate.Text));
                await orderService.GetOrderByDateAsync(DateTime.Parse(order.ToString()));

            }

        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var orderModel = new OrderVM(txtIdentification.Text, DateTime.Parse(txtOrderDate.Text));

                await orderService.AddAsync(orderModel);
                await orderService.SaveAsync(orderModel);
                MessageBox.Show("Kayıt işlemi başarılı...");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

          



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();

            this.Close();
            main.Show();

        }
    }
}
