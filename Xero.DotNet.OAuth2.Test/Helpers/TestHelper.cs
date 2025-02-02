
using Microsoft.Extensions.Configuration;
using System;
using Xero.DotNet.OAuth2.Client;
using Xero.DotNet.OAuth2.Test.Model.Accounting;

namespace Xero.DotNet.OAuth2.Test
{
    public static class TestHelper
    {
        public static IConfigurationRoot GetIConfigurationRoot(string outputPath)
        {
            return new ConfigurationBuilder().SetBasePath(outputPath).AddJsonFile("appsettings.json", optional: true).AddEnvironmentVariables().Build();
        }

        public static XeroConfiguration GetApplicationConfiguration(string outputPath)
        {
            var configuration = new XeroConfiguration();
            var iConfig = GetIConfigurationRoot(outputPath);
            iConfig.GetSection("XeroConfiguration").Bind(configuration);
            return configuration;
        }

    }
}