using Escola.Models;

namespace Escola.Interfaces
{
    public interface IMatricula
    {
        Task<List<Aluno>> ListarTodasMatriculas();

        Task<Aluno> ListarUmaMatricula(int id);

        Task<Aluno> AdicionarMatricula(Aluno aluno);

        Task<Aluno> AtualizarMatricula(Aluno aluno, int id);

        Task<bool> ApagarMatricula(int id);
    }
}
