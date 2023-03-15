using Escola.Models;
using Microsoft.EntityFrameworkCore;

namespace Escola.Data.Map
{
    public class MatriculaMap : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Matricula> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AlunoId).IsRequired();
            builder.HasOne(x => x.Aluno);
            builder.Property(x => x.CursoId).IsRequired();
            builder.HasOne(x => x.Curso);
            builder.Property(x => x.Periodo).IsRequired();
           
        }
    }
}
