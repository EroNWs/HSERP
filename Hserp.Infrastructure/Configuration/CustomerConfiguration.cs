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
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            
            builder.HasMany(x=>x.Orders).WithOne(x=>x.Customer).HasForeignKey(x=>x.CustomerId);

            builder.Property(x => x.Code).HasColumnType("nvarchar(32)").IsRequired();

            builder.Property(x => x.Name).HasColumnType("nvarchar(128)").IsRequired();

            builder.Property(x => x.TaxOffice).HasColumnType("nvarchar(128)").IsRequired();

            builder.Property(x => x.TaxNumber).HasColumnType("varchar(11)").IsRequired();

            builder.Property(x => x.Phone).HasColumnType("varchar(32)").IsRequired();

            builder.Property(x => x.Address).HasColumnType("nvarchar(512)").IsRequired();

            builder.Property(x => x.City).HasColumnType("nvarchar(128)").IsRequired();

            builder.Property(x => x.Country).HasColumnType("nvarchar(128)").IsRequired();


        }
    }
}
