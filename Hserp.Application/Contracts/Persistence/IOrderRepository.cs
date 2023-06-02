using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Persistence
{
   public interface IOrderRepository : IRepository<Order>
    {
        Task<ICollection<Order>> GetOrderByDateAsync(DateTime orderDate);

        Task<ICollection<Order>> GetOrderByCustomerNameAsync(string customerName);      

    }
}
