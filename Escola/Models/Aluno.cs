﻿namespace Escola.Models
{
    public class Aluno
    {   
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Rg { get; set; }

        public string Cpf { get; set; }

        public DateTime DataNascimento { get; set; }
    }
}
