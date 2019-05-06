using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dootrix.Planets.Common
{
    public static class CommonConfiguration
    {
        public static IConfiguration Config { get; }

        static CommonConfiguration()
        {
            Config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }
    }
}
