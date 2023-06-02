using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Persistence
{
    public interface IOrderDetailRepository : IRepository<OrderDetail>
    {
        Task<ICollection<OrderDetail>> GetOrderDetailbyOrderDate(DateTime orderDate);

        //Stock durumuna göre order Detail Stcok miktarı olmadığı için çekmedim.


        //Task<ICollection<OrderDetail>> GetOderDetailsbySituationStock()


        //Fiyatına göre orderDetail 

        Task<ICollection<OrderDetail>> GetOderDetailbyPrice(decimal price);

        //Customername göre orderdetail 
        Task<ICollection<OrderDetail>> GetOderDetailbyCustomerName(string customerName);




    }
}
