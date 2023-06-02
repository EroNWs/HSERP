using Hserp.Application.Contracts.Mappers;
using Hserp.Application.Contracts.Persistence;
using Hserp.Application.Contracts.Services;
using Hserp.Application.Contracts.Validators;
using Hserp.Application.HsUsers.Mappers;
using Hserp.Application.HsUsers.ViewModels.Customer;
using Hserp.Application.HsUsers.ViewModels.Order;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository repository;

        private readonly IOrderValidator validator;
        public IOrderValidator orderValidator => validator;

        private readonly IOrderMapper orderMapper;

        public OrderService(IOrderRepository repository, IOrderValidator validator, IOrderMapper orderMapper)
        {
            this.repository = repository;
            this.validator = validator;
            this.orderMapper = orderMapper;
        }


                       

        public async Task AddAsync(OrderVM model)
        {
           validator.Validate(model);

            var entity = repository.AddAsync(new Order
            {
               Identification= model.identification,
                OrderDate = model.orderDate

            });

        }

       

        public async Task<ICollection<OrderVM>> GetOrderByCustomerNameAsync(string customerName)
        {
            var entities = await repository.GetOrderByCustomerNameAsync(customerName);
            var viewModels = new List<OrderVM>();

            foreach (var entity in entities)
            {
                var viewModel = orderMapper.ToViewModel(entity);
                viewModels.Add(viewModel);
            }

            return viewModels;
        }

        public async Task<ICollection<OrderVM>> GetOrderByDateAsync(DateTime orderDate)
        {
           var entities = await repository.GetOrderByDateAsync(orderDate);
            var viewModels = new List<OrderVM>();

            foreach (var entity in entities)
            {
                var viewModel = orderMapper.ToViewModel(entity);
                viewModels.Add(viewModel);
            
            }
            return viewModels;
        }

        public void Delete(OrderVM model)
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync(OrderVM model)
        {
            validator.Validate(model);
            await repository.SaveAsync(orderMapper.ToEntity(model));
        }

        public void Update(OrderVM model)
        {
            validator.Validate(model);
            repository.Update(orderMapper.ToEntity(model));
        }

    }
}
