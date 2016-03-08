using Microsoft.AspNet.Hosting;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogSearch.ConfigHelper
{
    public class AppSettings : IConfiguration
    {
        private Configuration _config;

        public AppSettings()
        {
            _config = new Configuration();
        }

        public Configuration GetConfiguration()
        {
            return _getConfiguration();
        }

        private Configuration _getConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");

            IConfigurationRoot c = builder.Build();

            return c.Get<Configuration>("Configuration");
        }
    }
}
