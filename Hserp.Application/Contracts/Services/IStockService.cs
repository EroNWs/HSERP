using Hserp.Application.Contracts.Validators;
using Hserp.Application.HsUsers.ViewModels.Stock;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Services
{
    public interface IStockService : IService<StockVM>
    {
        IStockValidator stockValidator { get; }

        Task<ICollection<StockVM>> GetStockByCode(string code);

        Task<ICollection<StockVM>> GetStockByNameAsync(string name);

        Task<ICollection<StockVM>> GetStockByPriceAsync(decimal price);


    }

}
