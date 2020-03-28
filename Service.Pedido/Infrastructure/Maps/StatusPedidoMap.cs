using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Service.Pedido.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Pedido.Infrastructure.Maps
{
    public class StatusPedidoMap : IEntityTypeConfiguration<StatusPedido>
    {
        public void Configure(EntityTypeBuilder<StatusPedido> builder)
        {
            builder.ToTable("StatusPedido");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.Descricao).HasColumnName("Descricao").IsRequired().HasMaxLength(50);

            builder.HasMany(t => t.Pedidos).WithOne(t => t.StatusPedido).HasForeignKey(t => t.IdStatusPedido);
        }
    }
}
