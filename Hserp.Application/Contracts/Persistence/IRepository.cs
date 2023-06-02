using Hserp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Application.Contracts.Persistence;

public interface IRepository<T> where T : BaseEntity
{
    Task SaveAsync(T entity);

    void Update(T entity);

    void Delete(T entity);

    Task AddAsync(T entity);

}
