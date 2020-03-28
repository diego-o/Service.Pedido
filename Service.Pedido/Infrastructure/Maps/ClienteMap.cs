using Service.Pedido.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Service.Pedido.Infrastructure.Maps
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).HasColumnName("Id").IsRequired();
            builder.Property(t => t.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(100);
            builder.Property(t => t.Cpf).HasColumnName("Cpf").IsRequired().HasMaxLength(11);
            builder.Property(t => t.Senha).HasColumnName("Senha");
            builder.Property(t => t.Endereco.Cep).HasColumnName("Cep").IsRequired().HasMaxLength(9);
            builder.Property(t => t.Endereco.Logradouro).HasColumnName("Logradouro").IsRequired().HasMaxLength(150);
            builder.Property(t => t.Endereco.Complemento).HasColumnName("Complemento").IsRequired().HasMaxLength(100);
            builder.Property(t => t.Endereco.Numero).HasColumnName("Numero").IsRequired().HasMaxLength(20);
            builder.Property(t => t.Endereco.Bairro).HasColumnName("Bairro").IsRequired().HasMaxLength(100);
            builder.Property(t => t.Endereco.Cidade).HasColumnName("Cidade").IsRequired().HasMaxLength(60);
            builder.Property(t => t.Endereco.Uf).HasColumnName("Uf").IsRequired().HasMaxLength(2);

            builder.HasMany(t => t.Pedidos).WithOne(t => t.Cliente).HasForeignKey(t => t.IdCliente);
        }
    }
}
