using Microsoft.Extensions.DependencyInjection;
using Service.Pedido.Infrastructure.Context;
using Service.Pedido.Infrastructure.Context.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Pedido.Injection
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigInjection(this IServiceCollection services)
        {
            return services.AddTransient<IPedidoDbContext, PedidoDbContext>();
        }
    }
}
