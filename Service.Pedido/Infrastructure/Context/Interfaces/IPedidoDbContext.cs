using Service.Pedido.Entities;
using Microsoft.EntityFrameworkCore;

namespace Service.Pedido.Infrastructure.Context.Interfaces
{
    public interface IPedidoDbContext
    {
        DbSet<Cliente> Cliente { get; set; }
        DbSet<Entities.Pedido> Pedido { get; set; }
        DbSet<PedidoItem> PedidoItem { get; set; }
        DbSet<Produto> Produto { get; set; }
        DbSet<StatusPedido> StatusPedido { get; set; }
    }
}