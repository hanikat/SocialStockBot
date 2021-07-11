using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ElasticsearchDataAccess
{
    public static class Settings
    {
        private static IConfiguration _configuration;

        static Settings()
        {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public static string ElasticsearchURL => _configuration["Elasticsearch:URL"];

        public static string ElasticsearchUsername => _configuration["Elasticsearch:Username"];

        public static string ElasticsearchPassword => _configuration["Elasticsearch:Password"];

    }
}
