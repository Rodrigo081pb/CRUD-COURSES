using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_ENDPOINT_CURSOS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        // criar crud simples para a entidade aluno - criar aluno, remover aluno, atualizar aluno, 
        // buscar aluno por id, listar todo os alunos, alterar curso do aluno por id.
        private static List<Models.Aluno> alunos = new List<Models.Aluno>();
        private static int nextId = 1;

        [HttpPost("criar-aluno")]
        public ActionResult<Models.Aluno> CriarAluno([FromBody] Models.Aluno aluno)
        {
            aluno.Id = nextId++;
            alunos.Add(aluno);
            return CreatedAtAction(nameof(BuscarAlunoPorId), new { id = aluno.Id }, aluno);
        }

        [HttpPost("alterar-curso-aluno")]
        public ActionResult<Models.Aluno> AlterarCursoDoAluno(int id, int novoCursoId)
        {
            var aluno = alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }
            aluno.CursoId = novoCursoId;
            return NoContent();
        }

        [HttpGet("listar-aluno")]
        public ActionResult<List<Models.Aluno>> ListarAlunos()
        {
            return Ok(alunos);
        }

        [HttpGet("buscar-aluno-id")]
        public ActionResult<Models.Aluno> BuscarAlunoPorId(int id)
        {
            var aluno = alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }
            return Ok(aluno);
        }

        [HttpPut("atualizar-aluno")]
        public ActionResult AtualizarAluno(int id, [FromBody] Models.Aluno alunoAtualizado)
        {
            var aluno = alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }
            aluno.Nome = alunoAtualizado.Nome;
            aluno.Sobrenome = alunoAtualizado.Sobrenome;
            aluno.Idade = alunoAtualizado.Idade;
            aluno.CursoId = alunoAtualizado.CursoId;
            return NoContent();
        }

        [HttpGet("remover-aluno")]
        public ActionResult RemoverAluno(int id)
        {
            var aluno = alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null)
            {
                return NotFound();
            }
            alunos.Remove(aluno);
            return NoContent();
        }

        [HttpGet("listar-alunos-id")]
        public ActionResult<List<Models.Aluno>> ListarAlunosPorCursoId(int cursoId)
        {
            var alunosDoCurso = alunos.Where(a => a.CursoId == cursoId).ToList();
            return Ok(alunosDoCurso);
        }


        [HttpPost("remove-aluno-curso-id")]
        public ActionResult RemoverAlunoDoCursoPorId(int alunoId)
        {
            var aluno = alunos.FirstOrDefault(a => a.Id == alunoId);
            if (aluno == null)
            {
                return NotFound();
            }
            aluno.CursoId = 0; // assumindo que 0 significa que o aluno não está mais associado a nenhum curso
            return NoContent();
        }

        [HttpGet("listar-alunos-curso")]
        public ActionResult<List<Models.Aluno>> ListarAlunosDoCurso(int cursoId)
        {
            var alunosDoCurso = alunos.Where(a => a.CursoId == cursoId).ToList();
            return Ok(alunosDoCurso);
        }

    }
}
