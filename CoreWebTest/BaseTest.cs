using System.IO;
using CoreDal;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CoreWebTest
{
    public class BaseTest
    {      
        private DbContextOptionsBuilder<CoreDataContext> builder {get; set;}

        public CoreDataContext Context => GetContext();
        public BaseTest()
        {
            Initialize();
        }

        private void Initialize()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory().Replace("bin\\Debug\\netcoreapp2.0",""))
                .AddJsonFile("appsettings.json")
                .Build();
            builder = new DbContextOptionsBuilder<CoreDataContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            
            builder.UseSqlServer(connectionString, providerOptions=>providerOptions.CommandTimeout(60))
                        .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        private CoreDataContext GetContext()
        {
            return new CoreDataContext(builder.Options);
        }
    }

}