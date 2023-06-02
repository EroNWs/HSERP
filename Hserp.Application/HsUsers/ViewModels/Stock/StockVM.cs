using Hserp.Application.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.ViewModels.Stock
{
    public record StockVM (string code,string name, decimal price) : IViewModel;

    public record StockCodeVM(string code);

    public record StockNameVM (string name);

    public record StockPriceVM (decimal price);

}
