using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Alura.Filmes.App.Dados
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("customer");
            builder.Property(c => c.PrimeiroNome)
                .HasColumnName("first_update")
                .HasColumnType("varchar(45)")
                .IsRequired();

            builder.Property(c => c.UltimoNome)
                .HasColumnName("last_name")
                .HasColumnType("varchar(45)")
                .IsRequired();

            builder.Property(c => c.Email)
                .HasColumnName("email")
                .HasColumnType("varchar(50)");

            builder.Property(c => c.Ativa)
                .HasColumnName("active");

            builder.Property<DateTime>("create_date")
                .HasColumnType("datetime")
                .HasDefaultValueSql("getdate()")
                .IsRequired();
        }
    }
}
