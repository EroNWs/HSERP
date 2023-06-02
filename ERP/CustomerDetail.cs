using Hserp.Application.Contracts.Services;
using Hserp.Application.HsUsers.Mappers;
using Hserp.Application.HsUsers.Services;
using Hserp.Application.HsUsers.Validators;
using Hserp.Application.HsUsers.ViewModels.Customer;
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
    public partial class CustomerDetail : Form
    {
        private readonly ICustomerService customerService;
        public CustomerDetail()
        {

            customerService = new CustomerService(new CustomerRepository(), new CustomerValidator(), new CustomerMapper());
            InitializeComponent();
        }

        private async void btnDisplay_Click(object sender, EventArgs e)
        {
            if (!txtHeadOfficeCountry.Text.IsNullOrEmpty())
            {

                var customer = new CustomerCountryVM(txtHeadOfficeCountry.Text);

                dgvCustomerDetail.DataSource = await customerService.GetCustomersbyCountry(customer.ToString());

               

            }

            else if (!txtTaxNumber.Text.IsNullOrEmpty())
            {

                var customer = new CustomerTaxVM(txtTaxNumber.Text);

                await customerService.GetCustomersbyTaxNumber(customer.ToString());


            }

            else if (dtpOrderDate.Value <= DateTime.Now)
            {

                var customer = new CustomerOrderDateVM(dtpOrderDate.Value);

                await customerService.GetCustomersbyOrderDate(DateTime.Parse(customer.ToString()));

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();

            this.Close();
            main.Show();


        }

        private void CustomerDetail_Load(object sender, EventArgs e)
        {
            dtpOrderDate.Value = DateTime.Now;
        }
    }
}
