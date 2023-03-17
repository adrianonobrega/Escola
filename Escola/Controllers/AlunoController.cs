using Escola.Interfaces;
using Escola.Models;
using Microsoft.AspNetCore.Mvc;

namespace Escola.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAluno _IAluno;

        public AlunoController(IAluno iAluno)
        {
            _IAluno = iAluno;
        }

        [HttpGet]
        public async Task<ActionResult<List<Aluno>>> ListarTodosAlunos()
        {
            List<Aluno> alunos = await _IAluno.ListarTodosAlunos();
            return Ok(alunos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> ListarUmAluno(int id)
        {
            Aluno aluno = await _IAluno.ListarUmAluno(id);
            return Ok(aluno);
        }


        [HttpPost]
        public async Task<ActionResult<Aluno>> CadastrarAluno([FromBody] Aluno alunoModel)
        {
            Aluno aluno = await _IAluno.AdicionarAluno(alunoModel);

            return Ok(aluno);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Aluno>> AtualizarAluno([FromBody] Aluno alunoModel, int id)
        {
            alunoModel.Id = id;
            Aluno aluno = await _IAluno.AtualizarAluno(alunoModel, id);

            return Ok(aluno);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Aluno>> ApagarAluno(int id)
        {
            bool apagar = await _IAluno.ApagarAluno(id);

            return Ok("Usuario excluido com sucesso!");
        }
    }
}
