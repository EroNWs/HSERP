using Hserp.Entity;
using Hserp.Infrastructure.Configuration;
using Hserp.Infrastructure.Initializer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Infrastructure.Persistence;

public class HserpContext : DbContext
{
    public DbSet<HsUser> HsUsers { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<Stock> Stocks { get; set; }

    public DbSet<OrderDetail> OrderDetails { get; set; }

    public DbSet<HsUserAuth> HsUserAuths { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(/*DbContextInitializer.Configuration.GetConnectionString*/("Server= ERON_520; DataBase = ERPSystem; Integrated Security = True; Connect Timeout = 30; Encrypt=False;Trust Server Certificate=True;Application Intent = ReadWrite; Multi Subnet Failover=False"))
                .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

            base.OnConfiguring(optionsBuilder);
        }

    }

 

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfiguration(new CustomerConfiguration()).ApplyConfiguration(new HsUserConfiguration()).ApplyConfiguration(new HsUserAuthConfiguration()).ApplyConfiguration(new OrderConfiguration()).ApplyConfiguration(new OrderDetailConfiguration()).ApplyConfiguration(new StockConfiguration());
        
    }



    public HserpContext()
    {
        //default ctor ihtiyacımız olabilir diye tanımladık
    }


    public HserpContext(DbContextOptions<HserpContext> options) : base(options)  //ctor'umuz
                                                                                 //bunun yapıcı metodunda DbContextOptions alıyoruz. 
                                                                                 //Generic olarak neree işlem yapmak istiyorsak eğer onu belirtiyoruz 
                                                                                 //biz buradaki sınıf üzerinde işlem yapacağımız için onu yazıyoruz. 
                                                                                 //options ise bunun ismi 
    {

    }


}
