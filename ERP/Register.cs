using Hserp.Application.Contracts.Services;
using Hserp.Application.HsUsers.Mappers;
using Hserp.Application.HsUsers.Services;
using Hserp.Application.HsUsers.Validators;
using Hserp.Application.HsUsers.ViewModels.User;
using Hserp.Entity;
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
    public partial class Register : Form
    {

        private readonly IUserService userService;

        public Register()
        {
            userService = new UserService(new UserRepository(), new UserValidator(), new UserMapper());
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            Login login = new Login();

            this.Close();

            login.Visible = true;



        }

        private async void btnSignUp_Click(object sender, EventArgs e)
        {

            try
            {


                var registerModel = new UserRegisterVM(txtUserName.Text, txtPassword.Text, txtEmail.Text, txtConfirmPassword.Text,txtConfirmEmail.Text);             
                await userService.RegisterAsync(registerModel);
                await userService.SaveAsync(registerModel);
                MessageBox.Show("Kayıt Başarılı...");


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

    }
}
