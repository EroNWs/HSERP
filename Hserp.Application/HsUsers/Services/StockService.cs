using Hserp.Application.Contracts.Mappers;
using Hserp.Application.Contracts.Persistence;
using Hserp.Application.Contracts.Services;
using Hserp.Application.Contracts.Validators;
using Hserp.Application.HsUsers.Mappers;
using Hserp.Application.HsUsers.ViewModels.Stock;
using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.HsUsers.Services
{
    public class StockService : IStockService
    {
        private readonly IStockRepository repository;

        private readonly IStockValidator validator;
        public IStockValidator stockValidator => validator;

        private readonly IStockMapper stockMapper;

        public StockService(IStockRepository repository, IStockValidator validator, IStockMapper stockMapper)
        {
            this.repository = repository;
            this.validator = validator;
            this.stockMapper = stockMapper;
        }


       

        public async Task AddAsync(StockVM model)
        {
            validator.Validate(model);

            var entity = repository.AddAsync(new Stock
            {
                Code= model.code,
                Name = model.name,
                Price =model.price

            });

        }

       

        public async Task<ICollection<StockVM>> GetStockByCode(string code)
        {
            var query = await repository.GetStockByCode(code);

            return (ICollection<StockVM>)query.Where(x => x.Code == code).Select(y => new Stock
            {
                Code = y.Code,
                Name = y.Name,
                Price = y.Price

            });
        }


        public async Task<ICollection<StockVM>> GetStockByNameAsync(string name)
        {
            var query = await repository.GetStockByNameAsync(name);

            return (ICollection<StockVM>)query.Where(x => x.Name == name).Select(y => new Stock
            {
                Code = y.Code,
                Name = y.Name,
                Price = y.Price

            });
        }

        public async Task<ICollection<StockVM>> GetStockByPriceAsync(decimal price)
        {
            var query = await repository.GetStockByPriceAsync(price);

            return (ICollection<StockVM>)query.Where(x => x.Price==price).Select(y => new Stock
            {
                Code = y.Code,
                Name = y.Name,
                Price = y.Price


            });

        }



        public void Delete(StockVM model)
        {
            throw new NotImplementedException();
        }

        public async Task SaveAsync(StockVM model)
        {
            validator.Validate(model);
            await repository.SaveAsync(stockMapper.ToEntity(model));
        }

        public void Update(StockVM model)
        {
            validator.Validate(model);
            repository.Update(stockMapper.ToEntity(model));
        }

    }
}
