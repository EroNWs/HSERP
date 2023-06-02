using Hserp.Application.Contracts.Persistence;
using Hserp.Entity;
using Hserp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Infrastructure.Repositories
{
    public class OrderDetailRepository : BaseRepository<OrderDetail>, IOrderDetailRepository
    {

        public async Task<ICollection<OrderDetail>> GetOderDetailbyCustomerName(string customerName)
        {
            await using HserpContext hserpContext = new();

            var query = await (from cu in hserpContext.Customers
                               join or in hserpContext.Orders on cu.Id equals or.CustomerId
                               join od in hserpContext.OrderDetails on or.Id equals od.OrderId
                               where cu.Name == customerName
                               select new
                               {
                                   Name = cu.Name,
                                   Code = cu.Code,
                                   Address = cu.Address,
                                   Country = cu.Country,
                                   City = cu.City,
                                   Unit = od.Unit,
                                   LineTotal = od.LineTotal,
                                   Identification = or.Identification

                               }).ToListAsync();

            return (ICollection<OrderDetail>)query;

        }

        public async Task<ICollection<OrderDetail>> GetOderDetailbyPrice(decimal price)
        {
            await using HserpContext hserpContext = new();

            var query = await (from st in hserpContext.Stocks
                               join od in hserpContext.OrderDetails
                               on st.Id equals od.StockId
                               where st.Price == price
                               select new
                               {

                                   Price = st.Price,
                                   Name = st.Name,
                                   Code = st.Code,
                                   LineTotal = od.LineTotal,
                                   Unit = od.Unit

                               }).ToListAsync();

            return (ICollection<OrderDetail>)query;

        }


        public async Task<ICollection<OrderDetail>> GetOrderDetailbyOrderDate(DateTime orderDate)
        {
            await using HserpContext hserpContext = new HserpContext();

            var query = await (from or in hserpContext.Orders
                               join od in hserpContext.OrderDetails on or.Id equals od.OrderId
                               where or.OrderDate == orderDate
                               select new
                               {

                                   or.OrderDate,
                                   or.Customer.Name,
                                   od.Unit,
                                   od.LineTotal

                               }).ToListAsync();
            return (ICollection<OrderDetail>)query;

        }


    }
}
