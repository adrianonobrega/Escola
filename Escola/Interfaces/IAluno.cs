using Escola.Models;

namespace Escola.Interfaces
{
    public interface IAluno
    {
        Task<List<Aluno>> ListarTodosAlunos();

        Task<Aluno> ListarUmAluno(int id);

        Task<Aluno> AdicionarAluno(Aluno aluno);

        Task<Aluno> AtualizarAluno(Aluno aluno, int id);

        Task<bool> ApagarAluno(int id);
    }
}
