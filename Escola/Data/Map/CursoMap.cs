using Escola.Models;
using Microsoft.EntityFrameworkCore;

namespace Escola.Data.Map
{
    public class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Curso> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(256);
            builder.Property(x => x.Descricao).HasMaxLength(1000);
            builder.Property(x => x.Nivel).IsRequired();

        }
    }
}
