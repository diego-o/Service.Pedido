using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Pedido.Infrastructure.Maps
{
    public class PedidoMap : IEntityTypeConfiguration<Entities.Pedido>
    {
        public void Configure(EntityTypeBuilder<Entities.Pedido> builder)
        {
            builder.ToTable("Pedido");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.IdCliente).HasColumnName("IdCliente").IsRequired();
            builder.Property(t => t.IdStatusPedido).HasColumnName("IdStatusPedido").IsRequired();
            builder.Property(t => t.Total).HasColumnName("Total");

            builder.HasOne(t => t.Cliente).WithMany(t => t.Pedidos).HasForeignKey(t => t.IdCliente);
            builder.HasOne(t => t.StatusPedido).WithMany(t => t.Pedidos).HasForeignKey(t => t.IdStatusPedido);
            builder.HasMany(t => t.Itens).WithOne(t => t.Pedido).HasForeignKey(t => t.IdPedido);
        }
    }
}
