using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nothing.Model.Data
{
    public class DBFactory : IDesignTimeDbContextFactory<NothingDBContext>
    {
        public NothingDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            var connectionStrings = configuration.GetConnectionString("BookTicketDB");

            var optionsBuilder = new DbContextOptionsBuilder<NothingDBContext>();
            optionsBuilder.UseSqlServer(connectionStrings);

            return new NothingDBContext(optionsBuilder.Options);
        }
    }
}
