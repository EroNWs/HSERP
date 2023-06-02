using Hserp.Application.Contracts.Persistence;
using Hserp.Entity;
using Hserp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Infrastructure.Repositories
{
    public class StockRepository :BaseRepository<Stock>, IStockRepository
    {
      
        public async Task<ICollection<Stock>> GetStockByCode(string code)
        {
           await using HserpContext hserpContext=new HserpContext();

            return await hserpContext.Stocks.Where(x => x.Code == code).Select(y => new Stock
            {
                Code = y.Code,
                Name = y.Name,
                Price = y.Price

            }).ToListAsync();

        }

        public async Task<ICollection<Stock>> GetStockByNameAsync(string name)
        {
            await using HserpContext hserpContext = new();

            var query = await (from st in hserpContext.Stocks where st.Name == name select st).ToListAsync();

            return query;
        }


        public async Task<ICollection<Stock>> GetStockByPriceAsync(decimal price)
        {

            await using HserpContext hserpContext = new HserpContext();

            return await hserpContext.Stocks.Where(x => x.Price == price).Select(y => new Stock
            {
                Code = y.Code,
                Name = y.Name,
                Price = y.Price

            }).ToListAsync();


        }

       
        //Toplam stock durumu sıralı olarak
        //Hangi üründen ne kadar stok var durumu sıralı olarak 



    }
}
