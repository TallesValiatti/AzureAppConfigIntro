using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;

namespace AppConfigurationConsole
{
    class Program
    {
        private static readonly string _connectionString = "<ConnectionString>";
         static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                            .AddAzureAppConfiguration(_connectionString)
                            .Build();

            Console.WriteLine(config["my-key"]);
        }
    }
}
