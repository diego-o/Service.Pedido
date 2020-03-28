using System.IO;
using Microsoft.Extensions.Configuration;

namespace Service.Pedido.Infrastructure.Configurations
{
    public static class MyAppConfig
    {
        private static IConfigurationRoot _conifguration = new ConfigurationBuilder().
                             SetBasePath(Directory.GetCurrentDirectory()).
                             AddJsonFile("appsettings.json").Build();

        public static string ConnectionString =>
            _conifguration["DataBase:ConnectionString"];
    }
}
