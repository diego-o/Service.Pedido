using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Service.Pedido.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Pedido.Infrastructure.Maps
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(200);
            builder.Property(t => t.Valor).HasColumnName("Valor");

            builder.HasMany(t => t.Itens).WithOne(t => t.Produto).HasForeignKey(t => t.IdProduto);
        }
    }
}
