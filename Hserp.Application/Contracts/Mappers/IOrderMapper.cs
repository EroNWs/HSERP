using Hserp.Application.Contracts.Mapper;
using Hserp.Application.HsUsers.ViewModels.Order;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Mappers
{
    public interface IOrderMapper : IMapper
    {
        Order ToEntity(OrderVM orderVM);
        OrderVM ToViewModel(Order order);

    }
}
