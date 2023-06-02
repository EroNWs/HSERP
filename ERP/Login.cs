using Hserp.Application.Contracts.Services;
using Hserp.Application.HsUsers;
using Hserp.Application.HsUsers.Mappers;
using Hserp.Application.HsUsers.Services;
using Hserp.Application.HsUsers.Validators;
using Hserp.Application.HsUsers.ViewModels;
using Hserp.Application.HsUsers.ViewModels.User;
using Hserp.Infrastructure.Repositories;

namespace ERP
{
    public partial class Login : Form
    {
        private readonly IUserService userService;
        public Login()
        {
            userService = new UserService(new UserRepository(), new UserValidator(), new UserMapper());
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var loginModel = new UserLoginVM(txtUserName.Text, txtPassword.Text);
                await userService.LoginAsync(loginModel);
                MessageBox.Show("Giriþ Baþarýlý...");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            Main main = new Main();
            this.Hide();
            main.Visible = true;




        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Register register = new Register();

            register.Visible = true;

            this.Hide();



        }
    }
}