using Hserp.Application.Contracts.Validator;
using Hserp.Application.Contracts.Validators;
using Hserp.Application.Contracts.ViewModels;
using Hserp.Application.HsUsers.ViewModels.Customer;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Validators
{
    public class CustomerValidator :ICustomerValidator
    {
          

        public void Validate(CustomerVM viewModel)
        {
            if (string.IsNullOrEmpty(viewModel.code))
                throw new ArgumentException("Müşteri Kodu Boş Olamaz");

            if (string.IsNullOrEmpty(viewModel.taxNumber))
                throw new ArgumentException("Müşteri Vergi Numarası Boş Olamaz");

            if (string.IsNullOrEmpty(viewModel.phone))
                throw new ArgumentException("Müşteri Telefonu Boş Olamaz");

            if (string.IsNullOrEmpty(viewModel.country))
                throw new ArgumentException("Müşteri Ülkesi Boş Olamaz");

            if (string.IsNullOrEmpty(viewModel.name))
                throw new ArgumentException("Müşteri İsmi Boş Olamaz");

            if (string.IsNullOrEmpty(viewModel.taxOffice))
                throw new ArgumentException("Müşteri Vergi Dairesi Boş Olamaz");

            if (string.IsNullOrEmpty(viewModel.address))
                throw new ArgumentException("Müşteri Adresi Boş Olamaz");

            if (string.IsNullOrEmpty(viewModel.city))
                throw new ArgumentException("Müşteri Adresi Şehir Boş Olamaz");
        }



        //Max uzunlukları kontrol edilecek 
        //Min uzunlukları kontrol edilecek 
        
        //Taxnumber sayısal olmalı

        //Phone sayısal olmalı

        //City ve Country sayısal olmamalı 



    }
}
