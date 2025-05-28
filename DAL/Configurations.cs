using Microsoft.Extensions.Configuration;
using System;

namespace CHTL.DAL {
    public static class Configurations {
        private readonly static IConfigurationRoot _configuration;

        static Configurations() {
            _configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.local.json", false, true)
                .Build();
        }

        public static string GetValue(string key) => _configuration[key];
    }
}