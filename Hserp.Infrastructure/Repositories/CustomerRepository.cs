using Hserp.Application.Contracts.Persistence;
using Hserp.Entity;
using Hserp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Infrastructure.Repositories
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public async Task<ICollection<Customer>> GetCustomersbyCountry(string country)
        {

          await using HserpContext hserpContext = new HserpContext();

            //group by ile şehre göre sıralayarak getir.
            var query = hserpContext.Customers.Where(x => x.Country.Contains(country)).Select(x => new Customer
            {
                Name = x.Name,
                Code = x.Code,
                TaxOffice = x.TaxOffice,
                TaxNumber = x.TaxNumber,
                Phone = x.Phone,
                Address = x.Address,
                City = x.City

            });

            return await query.ToListAsync();




        }

        //OrderDAte göre sıralı olarak getir. 
        public async Task<ICollection<Customer>> GetCustomersbyOrderDate(DateTime orderDate)
        {
           await using HserpContext hserpContext = new HserpContext();

            var query =await (from cu in hserpContext.Customers
                               join or in hserpContext.Orders on cu.Id equals or.CustomerId
                               where or.OrderDate == orderDate
                               select new
                               {
                                   Name = cu.Name,
                                   Code = cu.Code,
                                   TaxOffice = cu.TaxOffice,
                                   TaxNumber = cu.TaxNumber,
                                   Phone = cu.Phone,
                                   Address = cu.Address,
                                   City = cu.City,
                                   Country = cu.Country,
                                   OrderDate = or.OrderDate

                               }).ToListAsync();

            return (ICollection<Customer>)query;


        }

        //TaxNumber sıralı olarak getir
        public async Task<ICollection<Customer>> GetCustomersbyTaxNumber(string taxNumber)
        {
           await using HserpContext hserpContext = new HserpContext();

            var query = hserpContext.Customers.Where(x => x.TaxNumber == taxNumber).Select(x => new Customer
            {

                Name = x.Name,
                Code = x.Code,
                TaxOffice = x.TaxOffice,
                TaxNumber = x.TaxNumber,
                Phone = x.Phone,
                Address = x.Address,
                City = x.City,
                Country = x.Country
               

            });

            return await query.ToListAsync();

            //En fazla sirapiş veren müşteri, 
            //En son sipariş veren müşteri,
            //Customer name ve sipariş tarihi ... olanlar

        }
    }
}
