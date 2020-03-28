using Service.Pedido.Entities;
using Microsoft.EntityFrameworkCore;
using Service.Pedido.Infrastructure.Configurations;

namespace Service.Pedido.Infrastructure.Context
{
    public class PedidoDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(MyAppConfig.ConnectionString);
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Entities.Pedido> Pedido { get; set; }
        public DbSet<PedidoItem> PedidoItem { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<StatusPedido> StatusPedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
