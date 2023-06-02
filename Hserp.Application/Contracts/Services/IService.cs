using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hserp.Application.Contracts.ViewModels;
using Hserp.Application.HsUsers.ViewModels.Customer;

namespace Hserp.Application.Contracts.Services;

public interface IService<T> where T : IViewModel
{
    Task SaveAsync(T model);

    Task AddAsync(T model);

    void Update(T entity);

    void Delete(T model);

}
