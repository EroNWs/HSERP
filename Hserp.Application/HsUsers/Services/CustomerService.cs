using Hserp.Application.Contracts.Mappers;
using Hserp.Application.Contracts.Persistence;
using Hserp.Application.Contracts.Services;
using Hserp.Application.Contracts.Validators;
using Hserp.Application.HsUsers.Validators;
using Hserp.Application.HsUsers.ViewModels.Customer;
using Hserp.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Services
{
    public class CustomerService : ICustomerService
    {

        private readonly ICustomerRepository repository;

        private readonly ICustomerValidator validator;
        public ICustomerValidator customerValidator => validator;

        private readonly ICustomerMapper customerMapper;

        public CustomerService(ICustomerRepository repository, ICustomerValidator validator, ICustomerMapper customerMapper)
        {
            this.repository = repository;
            this.validator = validator;
            this.customerMapper = customerMapper;
        }


        public async Task AddAsync(CustomerVM model)
        {
            validator.Validate(model);

            var entity = repository.AddAsync(new Customer
            {
                Code = model.code,
                Name = model.name,
                TaxOffice = model.taxOffice,
                TaxNumber = model.taxNumber,
                Phone = model.phone,
                Address = model.address,
                City = model.city,
                Country = model.country

            });

        }




        public async Task<ICollection<CustomerVM>> GetCustomersbyCountry(string country)
        {
            var query = await repository.GetCustomersbyCountry(country);


            var viewModels = new List<CustomerVM>();

            var entities = await repository.GetCustomersbyCountry(country);

            foreach (var entity in entities)
            {
                var viewModel = customerMapper.ToViewModel(entity);
                viewModels.Add(viewModel);
            }

            return viewModels;



            //return (ICollection<CustomerVM>)query.Where(x => x.Country == country).Select(x => new CustomerVM
            //{
            //    Code = x.Code,
            //    Name = x.Name,
            //    TaxOffice = x.TaxOffice,
            //    TaxNumber = x.TaxNumber,
            //    Phone = x.Phone,
            //    Address = x.Address,
            //    City = x.City,
            //    Country = x.Country

            //}).ToList();



        }


        public async Task<ICollection<CustomerVM>> GetCustomersbyOrderDate(DateTime orderDate)
        {

            var entities = await repository.GetCustomersbyOrderDate(orderDate);
            var viewModels = new List<CustomerVM>();

            foreach (var entity in entities)
            {
                var viewModel = customerMapper.ToViewModel(entity);
                viewModels.Add(viewModel);
            }

            return viewModels;

        }


        public async Task<ICollection<CustomerVM>> GetCustomersbyTaxNumber(string taxNumber)
        {

            var entities = await repository.GetCustomersbyTaxNumber(taxNumber);

                var viewModels = new List<CustomerVM>();

            foreach (var item in entities)
            {
                var viewModel = customerMapper.ToViewModel(item);
                viewModels.Add(viewModel);

            }

            return viewModels;

        }



        public void Delete(CustomerVM model)
        {
            throw new NotImplementedException();
        }


        public async Task SaveAsync(CustomerVM model)
        {
            validator.Validate(model);
            await repository.SaveAsync(customerMapper.ToEntity(model));
        }

        public void Update(CustomerVM model)
        {
            validator.Validate(model);
            repository.Update(customerMapper.ToEntity(model));
        }

      
    }
}
