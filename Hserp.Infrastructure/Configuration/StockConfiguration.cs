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
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.HasMany(x=>x.OrderDetails).WithOne(x=>x.Stock).HasForeignKey(x=>x.StockId);

            builder.Property(x => x.Code).HasColumnType("nvarchar(32)").IsRequired();

            builder.Property(x => x.Name).HasColumnType("nvarchar(128)").IsRequired();

            builder.Property(x => x.Price).HasColumnType("money").IsRequired();

        }
    }
}
