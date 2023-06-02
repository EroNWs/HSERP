using Hserp.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Infrastructure.Configuration
{
    public class HsUserAuthConfiguration : IEntityTypeConfiguration<HsUserAuth>
    {
        public void Configure(EntityTypeBuilder<HsUserAuth> builder)
        {
            //Ne farkı var, <HsUser>(x=>x.User verecek miyiz burada) ile (x=>x.User)
           builder.HasOne<HsUser>(x=>x.User).WithMany(x=>x.UserAuths).HasForeignKey(x=>x.UserId);        

        }
    }
}
