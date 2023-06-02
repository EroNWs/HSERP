using Hserp.Application.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.ViewModels.OrderDetail
{
    public record OrderDetailVM (Guid orderId, Guid stockId, int unit, decimal lineTotal) : IViewModel;
}
