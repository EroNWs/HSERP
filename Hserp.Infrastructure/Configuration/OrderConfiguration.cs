﻿using Hserp.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Infrastructure.Configuration
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasMany(x=>x.OrderDetails).WithOne(x=>x.Order).HasForeignKey(x=>x.OrderId);

            builder.Property(x => x.Identification).HasColumnType("nvarchar(150)").IsRequired();           

        }
    }
}
