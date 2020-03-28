using System;
using Service.Pedido.Entities;
using Microsoft.EntityFrameworkCore;
using Service.Pedido.Infrastructure.Configurations;
using Service.Pedido.Infrastructure.Maps;
using Service.Pedido.Infrastructure.Context.Interfaces;

namespace Service.Pedido.Infrastructure.Context
{
    public class PedidoDbContext : DbContext, IPedidoDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(MyAppConfig.ConnectionString);
        }

        protected void SaveAll()
        {
            try
            {
                this.SaveChanges();
            }
            catch (Exception error)
            {
                throw error;
            }
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Entities.Pedido> Pedido { get; set; }
        public DbSet<PedidoItem> PedidoItem { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<StatusPedido> StatusPedido { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new PedidoItemMap());
            modelBuilder.ApplyConfiguration(new PedidoMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new StatusPedidoMap());
        }
    }
}
