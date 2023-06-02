using Hserp.Application.HsUsers.ViewModels.User;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Services
{
    public interface IUserService 
    {
        Task<UserVM> LoginAsync(UserLoginVM loginVM);

        Task SaveAsync(UserRegisterVM model);

        Task RegisterAsync(UserRegisterVM model);

    }

}
