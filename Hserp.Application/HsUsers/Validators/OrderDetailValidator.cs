using Hserp.Application.Contracts.Validator;
using Hserp.Application.Contracts.Validators;
using Hserp.Application.Contracts.ViewModels;
using Hserp.Application.HsUsers.ViewModels.OrderDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Validators
{
    public class OrderDetailValidator :IOrderDetailValidator
    {       

        public void Validate(OrderDetailVM viewModel)
        {
            if (string.IsNullOrEmpty((viewModel.orderId).ToString()))
                throw new ArgumentException("Sipariş Id'si Boş Olamaz");

            if (string.IsNullOrEmpty((viewModel.stockId).ToString()))
                throw new ArgumentException("Stok Id'si Boş Olamaz");

            if (string.IsNullOrEmpty((viewModel.unit).ToString()))
                throw new ArgumentException("Sipariş Birimi Boş Olamaz");
        }


        //Max uzunlukları kontrol edilecek 
        //Min uzunlukları kontrol edilecek 

        //SAyısal mı kontrol edilecek Unit



    }
}
