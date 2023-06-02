using Hserp.Application.Contracts.Persistence;
using Hserp.Entity;
using Hserp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Infrastructure.Repositories;

public class UserRepository : BaseRepository<HsUser>, IUserRepository
{
    private readonly HserpContext context = new();


    public async Task<HsUser> GetUserAsync(string username, string passsword)
        => await context.HsUsers
                .FirstOrDefaultAsync(f => f.Username == username && f.Password == passsword)
        ?? throw new Exception("Kullanıcı Bulunamadı!");




    //public async Task SaveAsync(HsUser entity)
    //{
    //    //context.Set<HsUser>().Entry(entity).State = EntityState.Added;
    //    //await context.HsUsers.AddAsync(entity);
    //    //await context.SaveChangesAsync();
    //}


  
}
