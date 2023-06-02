using Hserp.Application.Contracts.Services;
using Hserp.Application.HsUsers.Mappers;
using Hserp.Application.HsUsers.Services;
using Hserp.Application.HsUsers.Validators;
using Hserp.Application.HsUsers.ViewModels.Stock;
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
    public partial class StockList : Form
    {

        private readonly IStockService stockService;
        public StockList()
        {
            stockService = new StockService(new StockRepository(), new StockValidator(), new StockMapper());

            InitializeComponent();
        }

    


        private void btnBack_Click(object sender, EventArgs e)
        {
            Main main = new Main();

            this.Close();
            main.Show();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private async void btnDisplay_Click(object sender, EventArgs e)
        {

            if (!txtStockCode.Text.IsNullOrEmpty())
            {
                var stock = new StockCodeVM(txtStockCode.Text);
               dgvStockAndDetails.DataSource = (await stockService.GetStockByCode(stock.ToString())).ToList();

            }
            else if (!txtStockName.Text.IsNullOrEmpty())
            {
                var stock = new StockNameVM(txtStockName.Text);
                await stockService.GetStockByNameAsync(stock.ToString());
            }
            else if (!txtUnitPrice.Text.IsNullOrEmpty())
            { 
                var stock = new StockPriceVM(Decimal.Parse(txtUnitPrice.Text));
                await stockService.GetStockByPriceAsync(Decimal.Parse(stock.ToString()));
            
            
            }


        }

        private async void btnNewRecord_Click(object sender, EventArgs e)
        {
            try
            {
                var stock = new StockVM(txtStockCode.Text, txtStockName.Text, Decimal.Parse(txtUnitPrice.Text));
                await stockService.AddAsync(stock);
                await stockService.SaveAsync(stock);
                MessageBox.Show("Kayıt Başarılı...");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
