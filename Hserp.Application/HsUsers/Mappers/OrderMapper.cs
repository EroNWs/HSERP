using Hserp.Application.Contracts.Mappers;
using Hserp.Application.HsUsers.ViewModels.Order;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Mappers
{
    public class OrderMapper : IOrderMapper
    {
        public Order ToEntity(OrderVM orderVM)
            => new Order
            {
                Id = Guid.NewGuid(),
                Identification = orderVM.identification,
                OrderDate = orderVM.orderDate,               
                CreateDate = DateTime.Now

            };

        public OrderVM ToViewModel(Order order)     
        => new OrderVM(order.Identification, order.OrderDate);

    }
}
