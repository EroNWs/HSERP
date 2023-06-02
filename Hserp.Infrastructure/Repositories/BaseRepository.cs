using Hserp.Application.Contracts.Persistence;
using Hserp.Entity;
using Hserp.Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        public async Task AddAsync(T entity)
        {
            try
            {
                await using HserpContext context = new HserpContext();
                await context.AddAsync<T>(entity);
                await context.SaveChangesAsync();
                //Console.WriteLine($"state:{context.Entry(context).State}");
                //await Console.Out.WriteLineAsync($"Last State: {context.Entry(entity).State}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async void Update(T entity)
        {
            await using HserpContext context = new HserpContext();
            context.Update<T>(entity);
            await context.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(T entity)
        {
            throw new NotImplementedException();
        }


    }
}
