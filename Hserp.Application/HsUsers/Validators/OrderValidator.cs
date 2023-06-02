using Hserp.Application.Contracts.Validator;
using Hserp.Application.Contracts.Validators;
using Hserp.Application.Contracts.ViewModels;
using Hserp.Application.HsUsers.ViewModels.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Validators
{
    public class OrderValidator :IOrderValidator
    {
       
        public void Validate(OrderVM viewModel)
        {
            
            if (string.IsNullOrEmpty(viewModel.identification))
                throw new ArgumentException("Tanımlama Boş Olamaz");
        }

        //Max uzunlukları kontrol edilecek 
        //Min uzunlukları kontrol edilecek 

        //OrderDate Seçmeli yapılacak

        

    }
}
