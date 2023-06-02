using Hserp.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Infrastructure.Configuration
{
    public class HsUserConfiguration : IEntityTypeConfiguration<HsUser>
    {
        public void Configure(EntityTypeBuilder<HsUser> builder)
        {
            builder.HasMany(x => x.UserAuths).WithOne(x => x.User).HasForeignKey(x => x.UserId);

            builder.Property(x => x.Username).HasColumnType("nvarchar(128)").IsRequired();

            builder.Property(x => x.Password).HasColumnType("nvarchar(32)").IsRequired();

            builder.Property(x => x.Email).HasColumnType("nvarchar(256)");

        }
    }
}
