using Escola.Enums;

namespace Escola.Models
{
    public class Matricula
    {
        public int Id { get; set; }
        public int? AlunoId { get; set; }

        public virtual Aluno Aluno { get; set; }

        public int CursoId { get; set; }

        public virtual Curso Curso { get; set; }

        public PeriodoMatricula Periodo { get; set; }

    }
}
