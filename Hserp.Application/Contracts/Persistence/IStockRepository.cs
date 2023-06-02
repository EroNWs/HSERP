using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Persistence
{
    public interface IStockRepository : IRepository<Stock>
    {
        Task<ICollection<Stock>> GetStockByCode(string code);

        Task<ICollection<Stock>> GetStockByNameAsync(string name);

        Task<ICollection<Stock>> GetStockByPriceAsync(decimal price);

    }
}
