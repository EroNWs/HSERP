using Hserp.Application.Contracts.Validator;
using Hserp.Application.HsUsers.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Validators;

public interface IUserValidator : IValidator<UserRegisterVM>
{
    void Validate(UserLoginVM loginVM);

}
