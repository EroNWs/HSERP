using Hserp.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hserp.Infrastructure.Initializer
{
    public class DbContextInitializer
    {

        public static IConfigurationRoot Configuration;
        public static DbContextOptionsBuilder<HserpContext> OptionsBuilder;
        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            //bir nesne ürettik 

            Configuration = builder.Build();

            OptionsBuilder = new DbContextOptionsBuilder<HserpContext>();
            OptionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlCon"));


            //var ApiKey = Configuration["API Key"];

        }


    }
}
