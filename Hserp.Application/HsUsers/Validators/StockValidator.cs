using Hserp.Application.Contracts.Validator;
using Hserp.Application.Contracts.Validators;
using Hserp.Application.Contracts.ViewModels;
using Hserp.Application.HsUsers.ViewModels.Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Validators
{
    public class StockValidator :IStockValidator
    {           
        public void Validate(StockVM viewModel)
        {
            if (string.IsNullOrEmpty(viewModel.code))
                throw new ArgumentException("Kod Boş Olamaz");

            if (string.IsNullOrEmpty((viewModel.price).ToString()))
                throw new ArgumentException("Fiyat Boş Olamaz");


            if (string.IsNullOrEmpty(viewModel.name))
                throw new ArgumentException("İsim Boş Olamaz");
        }

        //Max uzunlukları kontrol edilecek 
        //Min uzunlukları kontrol edilecek 


        //en az 2 sayısal 3 büyük harf

        //Fiyat sayısal olmalıdır. 
               


    }
}
