using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alura.Filmes.App.Dados
{
    class FilmeCategoriaConfiguration : IEntityTypeConfiguration<FilmeCategoria>
    {
        public void Configure(EntityTypeBuilder<FilmeCategoria> builder)
        {
            builder.ToTable("film_category");
            builder.Property<int>("film_id");
            builder.Property<byte>("category_id");
            builder.HasKey("film_id", "category_id");
            builder
                .HasOne(fc => fc.Categoria)
                .WithMany(c => c.Filmes)
                .HasForeignKey("category_id");
            builder
                .HasOne(fc => fc.Filme)
                .WithMany(f => f.Categorias)
                .HasForeignKey("film_id");
        }
    }
}
