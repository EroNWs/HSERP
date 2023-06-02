using Hserp.Application.Contracts.Mappers;
using Hserp.Application.HsUsers.ViewModels.OrderDetail;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Mappers
{
    public class OrderDetailMapper : IOrderDetailMapper
    {
        public OrderDetail ToEntity(OrderDetailVM orderDetailVM)
            => new OrderDetail
            {
                Id = Guid.NewGuid(),
                OrderId = orderDetailVM.orderId,
                StockId = orderDetailVM.stockId,
                Unit = orderDetailVM.unit,               
                CreateDate = DateTime.Now
            };

        public OrderDetailVM ToViewModel(OrderDetail orderDetail)
        => new OrderDetailVM(orderDetail.OrderId, orderDetail.StockId, orderDetail.Unit, orderDetail.LineTotal);

    }
}
