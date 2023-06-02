using Hserp.Application.Contracts.Validators;
using Hserp.Application.HsUsers.ViewModels.Customer;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Services
{
    public interface ICustomerService:IService<CustomerVM>
    {
        ICustomerValidator customerValidator { get; }       

        Task<ICollection<CustomerVM>> GetCustomersbyCountry(string country);

        Task<ICollection<CustomerVM>> GetCustomersbyTaxNumber(string taxNumber);

        Task<ICollection<CustomerVM>> GetCustomersbyOrderDate(DateTime orderDate);


    }
}
