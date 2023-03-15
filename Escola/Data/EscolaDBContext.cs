using Escola.Data.Map;
using Escola.Models;
using Microsoft.EntityFrameworkCore;

namespace Escola.Data
{
    public class EscolaDBContext : DbContext
    {
        public EscolaDBContext(DbContextOptions<EscolaDBContext> options): base(options) { }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMap());
            modelBuilder.ApplyConfiguration(new CursoMap());
            modelBuilder.ApplyConfiguration(new MatriculaMap());

            base.OnModelCreating(modelBuilder);
        }


    }
}
