using Hserp.Application.Contracts.Mappers;
using Hserp.Application.HsUsers.ViewModels.Customer;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Mappers
{
    public class CustomerMapper : ICustomerMapper
    {
        public Customer ToEntity(CustomerVM customerVM)
            => new Customer
            {
                Id = Guid.NewGuid(),
                Code = customerVM.code,
                Name = customerVM.name,
                TaxOffice = customerVM.taxOffice,
                TaxNumber = customerVM.taxNumber,
                Phone = customerVM.phone,
                Address = customerVM.address,
                City = customerVM.city,
                Country = customerVM.country,
                CreateDate = DateTime.Now
            };

        public CustomerVM ToViewModel(Customer customer)
          => new CustomerVM(
            customer.Code,
            customer.Name,
            customer.TaxOffice,
            customer.TaxNumber,
            customer.Phone,
            customer.Address,
            customer.City,
            customer.Country);


    }
}
