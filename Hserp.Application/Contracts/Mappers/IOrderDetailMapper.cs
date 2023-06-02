using Hserp.Application.Contracts.Mapper;
using Hserp.Application.HsUsers.ViewModels.OrderDetail;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Mappers
{
    public interface IOrderDetailMapper : IMapper
    {
        OrderDetail ToEntity(OrderDetailVM orderDetailVM);
        OrderDetailVM ToViewModel(OrderDetail orderDetail);

    }
}
