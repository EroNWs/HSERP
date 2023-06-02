using Hserp.Application.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.ViewModels.User;

public record UserRegisterVM(string username, string password, string email, string confirmedPassword, string confirmedEmail) : IViewModel;
