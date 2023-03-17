using Escola.Data;
using Escola.Interfaces;
using Escola.Models;
using Microsoft.EntityFrameworkCore;

namespace Escola.Services
{
    public class AlunoServices : IAluno
    {
        private readonly EscolaDBContext _dbContext;

        public AlunoServices(EscolaDBContext EscolaDBContext)
        {
            _dbContext = EscolaDBContext;
        }

        public async Task<Aluno> ListarUmAluno(int id) 
        {
            return await _dbContext.Alunos.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Aluno>> ListarTodosAlunos() 
        {
            return await _dbContext.Alunos.ToListAsync();
        }

        public async Task<Aluno> AdicionarAluno(Aluno aluno)
        {
            await _dbContext.Alunos.AddAsync(aluno);
            _dbContext.SaveChanges();

            return aluno;
        }

        public async Task<Aluno> AtualizarAluno(Aluno aluno, int id)
        {
            Aluno alunoId = await ListarUmAluno(id);
            if (alunoId == null)
            {
                throw new Exception($"Aluno do ID {id} não foi encontrado.");
            }

            alunoId.Nome = aluno.Nome;
            alunoId.Cpf = aluno.Cpf;
            alunoId.Rg = aluno.Rg;
            aluno.DataNascimento = aluno.DataNascimento;

            _dbContext.Alunos.Update(alunoId);
            await _dbContext.SaveChangesAsync();

            return alunoId;
        }

        public async Task<bool> ApagarAluno(int id)
        {
            Aluno alunoId = await ListarUmAluno(id);

            if (alunoId == null)
            {
                throw new Exception($"Aluno do ID {id} não foi encontrado.");
            }

            _dbContext.Alunos.Remove(alunoId);
            await _dbContext.SaveChangesAsync();
            return true;

        }
    }

}
