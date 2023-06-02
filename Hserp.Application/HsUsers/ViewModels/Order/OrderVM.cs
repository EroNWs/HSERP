using Hserp.Application.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.ViewModels.Order
{
   public record OrderVM (string identification, DateTime orderDate): IViewModel;

    public record OrderCustomerVM(string customerName);

    public record OrderDateVM(DateTime orderDate);
}
