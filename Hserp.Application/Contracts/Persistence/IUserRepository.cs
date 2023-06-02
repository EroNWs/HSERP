using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Persistence;

public interface IUserRepository : IRepository<HsUser>
{
    Task<HsUser> GetUserAsync(string username, string passsword);

}
