using Hserp.Application.Contracts.Services;
using Hserp.Application.HsUsers.Mappers;
using Hserp.Application.HsUsers.Services;
using Hserp.Application.HsUsers.Validators;
using Hserp.Application.HsUsers.ViewModels.Customer;
using Hserp.Infrastructure.Repositories;
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
    public partial class CustomerList : Form
    {
        private readonly ICustomerService customerService;

        public CustomerList()
        {
            customerService = new CustomerService(new CustomerRepository(), new CustomerValidator(), new CustomerMapper());

            InitializeComponent();
        }

        //New Record için kullanılacak Button
        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var registerCustomer = new CustomerVM(txtCustomerCode.Text, txtCustomerName.Text, txtTaxOffice.Text, txtTaxNumber.Text, txtPhoneNumber.Text, txtHeadOfficeAddress.Text, txtHeadOfficeCity.Text, txtHeadOfficeCountry.Text);
                await customerService.AddAsync(registerCustomer);
                await customerService.SaveAsync(registerCustomer);
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

        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            CustomerDetail customerDetail = new CustomerDetail();
            this.Hide();
            customerDetail.Visible = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
