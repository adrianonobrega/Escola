using Escola.Models;

namespace Escola.Interfaces
{
    public interface ICurso
    {
        Task<List<Curso>> ListarTodosCursos();

        Task<Curso> ListarUmCurso(int id);

        Task<Curso> AdicionarCurso(Aluno aluno);

        Task<Curso> AtualizarCurso(Aluno aluno, int id);

        Task<bool> ApagarCurso(int id);
    }
}
