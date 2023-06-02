using Hserp.Application.Contracts.Validators;
using Hserp.Application.HsUsers.ViewModels.OrderDetail;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Services
{
    public interface IOrderDetailService:IService<OrderDetailVM>
    {
        IOrderDetailValidator orderDetailValidator { get; }

        Task<ICollection<OrderDetailVM>> GetOrderDetailbyOrderDate(DateTime orderDate);

        //Stock durumuna göre order Detail Stcok miktarı olmadığı için çekmedim.


        //Task<ICollection<OrderDetail>> GetOderDetailsbySituationStock()


        //Fiyatına göre orderDetail 

        Task<ICollection<OrderDetailVM>> GetOderDetailbyPrice(decimal price);

        //Customername göre orderdetail 
        Task<ICollection<OrderDetailVM>> GetOderDetailbyCustomerName(string customerName);


    }
}
