using Hserp.Application.Contracts.Mappers;
using Hserp.Application.Contracts.Persistence;
using Hserp.Application.Contracts.Services;
using Hserp.Application.Contracts.Validators;
using Hserp.Application.HsUsers.Mappers;
using Hserp.Application.HsUsers.ViewModels.OrderDetail;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Services
{
    public class OrderDetailService : IOrderDetailService
    {

        private readonly IOrderDetailRepository repository;

        private readonly IOrderDetailValidator validator;
        public IOrderDetailValidator orderDetailValidator => validator;

        private readonly IOrderDetailMapper orderDetailMapper;

        public OrderDetailService(IOrderDetailRepository repository, IOrderDetailValidator validator, IOrderDetailMapper orderDetailMapper)
        {
            this.repository = repository;
            this.validator = validator;
            this.orderDetailMapper = orderDetailMapper;
        }


                

        public async Task AddAsync(OrderDetailVM model)
        {
            validator.Validate(model);

            var entity = repository.AddAsync(new OrderDetail
            {
                Unit = model.unit,

            });
        }


        public async Task<ICollection<OrderDetailVM>> GetOderDetailbyCustomerName(string customerName)
        {
            var entities = await repository.GetOderDetailbyCustomerName(customerName);
            var viewModels = new List<OrderDetailVM>();
            foreach (var entity in entities)
            {
                var viewModel = orderDetailMapper.ToViewModel(entity);
                viewModels.Add(viewModel);
            }

            return viewModels;

        }


        public async Task<ICollection<OrderDetailVM>> GetOderDetailbyPrice(decimal price)
        {
            var entities = await repository.GetOderDetailbyPrice(price);
            var viewModels = new List<OrderDetailVM>();
            foreach (var entity in entities)
            {
                var viewModel = orderDetailMapper.ToViewModel(entity);
                viewModels.Add(viewModel);
            }

            return viewModels;
        }


        public async Task<ICollection<OrderDetailVM>> GetOrderDetailbyOrderDate(DateTime orderDate)
        {
            var entities = await repository.GetOrderDetailbyOrderDate(orderDate);
            var viewModels = new List<OrderDetailVM>();
            foreach (var entity in entities)
            {
                var viewModel = orderDetailMapper.ToViewModel(entity);
                viewModels.Add(viewModel);
            }

            return viewModels;
        }


        public void Delete(OrderDetailVM model)
        {
            throw new NotImplementedException();
        }


        public async Task SaveAsync(OrderDetailVM model)
        {
            validator.Validate(model);
            await repository.SaveAsync(orderDetailMapper.ToEntity(model));
        }

        public void Update(OrderDetailVM model)
        {
            validator.Validate(model);
            repository.Update(orderDetailMapper.ToEntity(model));
        }

    }
}
