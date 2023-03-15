namespace Escola.Models
{
    public class Aluno
    {   
        public int Id { get; set; }
        public int Nome { get; set; }

        public string Rg { get; set; }

        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
