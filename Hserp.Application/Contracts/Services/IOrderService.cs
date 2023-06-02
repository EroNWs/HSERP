using Hserp.Application.Contracts.Validators;
using Hserp.Application.HsUsers.ViewModels.Order;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Services
{
    public interface IOrderService :IService<OrderVM>
    {
        IOrderValidator orderValidator { get; }

        Task<ICollection<OrderVM>> GetOrderByDateAsync(DateTime orderDate);

        Task<ICollection<OrderVM>> GetOrderByCustomerNameAsync(string customerName);


    }
}
