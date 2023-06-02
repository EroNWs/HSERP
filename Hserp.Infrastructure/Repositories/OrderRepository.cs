using Hserp.Application.Contracts.Persistence;
using Hserp.Entity;
using Hserp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Infrastructure.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {

        //customer name göre sıralı olarak getir 
        public async Task<ICollection<Order>> GetOrderByCustomerNameAsync(string customerName)
        {
            await using HserpContext hserpContext = new HserpContext();

            var query = await (from cu in hserpContext.Customers
                               join or in hserpContext.Orders on cu.Id equals or.CustomerId
                               where cu.Name == customerName
                               select new
                               {
                                   Name = cu.Name,
                                   Code = cu.Code,
                                   Country = cu.Country,
                                   OrderDate = or.OrderDate,
                                   Identification = or.Identification

                               }).ToListAsync();

            return (ICollection<Order>)query;

        }

        //OrderDAte göre sıralı olarak getir. 
        public async Task<ICollection<Order>> GetOrderByDateAsync(DateTime orderDate)
        {
            await using HserpContext hserpContext = new();

            var query = await hserpContext.Orders.Where(x => x.OrderDate == orderDate).Select(y => new Order
            {
                OrderDate = y.OrderDate,
                Identification = y.Identification

            }).ToListAsync();

            return query;

        }



    }
}
