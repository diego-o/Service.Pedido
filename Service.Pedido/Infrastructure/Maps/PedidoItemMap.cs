using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Service.Pedido.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Pedido.Infrastructure.Maps
{
    public class PedidoItemMap : IEntityTypeConfiguration<PedidoItem>
    {
        public void Configure(EntityTypeBuilder<PedidoItem> builder)
        {
            builder.ToTable("PedidoItem");

            builder.HasKey(t => new { t.IdPedido, t.IdProduto });

            builder.Property(t => t.IdPedido).HasColumnName("IdPedido").IsRequired();
            builder.Property(t => t.IdProduto).HasColumnName("IdProduto").IsRequired();

            builder.HasOne(t => t.Pedido).WithMany(t => t.Itens).HasForeignKey(t => t.IdPedido);
            builder.HasOne(t => t.Produto).WithMany(t => t.Itens).HasForeignKey(t => t.IdProduto);
        }
    }
}
