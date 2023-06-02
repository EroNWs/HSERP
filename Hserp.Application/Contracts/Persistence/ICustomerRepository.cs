using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Persistence
{
    public interface ICustomerRepository:IRepository<Customer>
    {
        Task<ICollection<Customer>> GetCustomersbyCountry(string country);

        Task<ICollection<Customer>> GetCustomersbyTaxNumber(string taxNumber);

        Task<ICollection<Customer>> GetCustomersbyOrderDate (DateTime orderDate);


    }
}
