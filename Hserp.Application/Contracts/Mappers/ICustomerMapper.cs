using Hserp.Application.Contracts.Mapper;
using Hserp.Application.HsUsers.ViewModels.Customer;
using Hserp.Application.HsUsers.ViewModels.User;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Mappers
{
    public interface ICustomerMapper:IMapper
    {
        Customer ToEntity(CustomerVM customerVM);
        CustomerVM ToViewModel(Customer customer);

    }
}
