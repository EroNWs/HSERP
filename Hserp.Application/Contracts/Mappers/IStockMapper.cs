using Hserp.Application.Contracts.Mapper;
using Hserp.Application.HsUsers.ViewModels.Stock;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Mappers
{
    public interface IStockMapper : IMapper
    {
        Stock ToEntity(StockVM stockVM);
        StockVM ToViewModel(Stock stock);

    }

}
