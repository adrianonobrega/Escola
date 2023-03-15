using Escola.Enums;

namespace Escola.Models
{
    public class Curso
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public NivelCurso Nivel { get; set; }

    }
}
