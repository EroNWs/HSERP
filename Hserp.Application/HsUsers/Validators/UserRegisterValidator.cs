using Hserp.Application.Contracts;
using Hserp.Application.Contracts.Validators;
using Hserp.Application.HsUsers.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Validators;

public class UserValidator : IUserValidator
{
    public void Validate(UserRegisterVM viewModel)
    {
        if (string.IsNullOrEmpty(viewModel.username))
            throw new ArgumentException("Kullanıcı Adı Boş Olamaz");

        if (string.IsNullOrEmpty(viewModel.password))
            throw new ArgumentException("Kullanıcı Şifre Boş Olamaz");

        if (!viewModel.password.Equals(viewModel.confirmedPassword))
            throw new ArgumentException("Kullanıcı Şifre Bilgileri Eşleşmiyor");

        if (!viewModel.email.Equals(viewModel.confirmedEmail))
            throw new ArgumentException("Kullanıcı Email Bilgileri Eşleşmiyor");
    }
    
    public void Validate(UserLoginVM loginVM)
    {

        if (string.IsNullOrEmpty(loginVM.userName))
            throw new ArgumentException("Kullanıcı Adı Boş Olamaz");

        if (string.IsNullOrEmpty(loginVM.password))
            throw new ArgumentException("Kullanıcı Şifre Boş Olamaz");
    }

    //Emailde .com ve @ olmalı

    //Kullanıcı adı eşşiz olmalı

    //İsimde sayı olmamalı

    //Max uzunlukları kontrol edilecek 
    //Min uzunlukları kontrol edilecek 


}
