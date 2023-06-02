using Hserp.Application.Contracts.Mappers;
using Hserp.Application.HsUsers.ViewModels.Stock;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Mappers
{
    public class StockMapper : IStockMapper
    {
        public Stock ToEntity(StockVM stockVM)
 => new Stock
 {
     Id = Guid.NewGuid(),
     Code = stockVM.code,
     Name = stockVM.name,
     Price = stockVM.price,
     CreateDate = DateTime.Now
 };

        public StockVM ToViewModel(Stock stock)
       => new StockVM(stock.Code, stock.Name, stock.Price);


    }
}
