using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace CRUD_ENDPOINT_CURSOS.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CursoController : Controller
    {

        // criando uma lista estática para armazenar os cursos
        private static List<Models.Curso> cursos = new List<Models.Curso>();
        private static int nextId = 1;

        // endpoint para criar um curso
        [HttpPost("criar-curso")]
        public ActionResult<Models.Curso> CriarCurso([FromBody] Models.Curso curso)
        {
            curso.Id = nextId++; // aqui eu estou adicionando mais um id quando mais um curso for criado
            cursos.Add(curso); // aqui eu to adicionando
            return CreatedAtAction(nameof(BuscarCursoPorId), new { id = curso.Id }, curso);
        }

        // endpoint para listar todos os cursos
        [HttpGet("listar-cursos")]
        public ActionResult<List<Models.Curso>> ListarCursos()
        {
            //return Ok(cursos);
            return Ok(cursos);
        }

        // endpoint para buscar um curso por id
        [HttpGet("buscar-cursos-{id}")]
        public ActionResult<Models.Curso> BuscarCursoPorId(int id)
        {
            var curso = cursos.FirstOrDefault(c => c.Id == id);
            if (curso == null)
            {
                return NotFound();
            }
            return Ok(curso);
        }

        // endpoint para atualizar um curso
        [HttpPut("atualizar-curso-{id}")]
        public ActionResult AtualizarCurso(int id, [FromBody] Models.Curso cursoAtualizado)
        {
            var curso = cursos.FirstOrDefault(c => c.Id == id);
            if (curso == null)
            {
                return NotFound();
            }
            curso.Nome = cursoAtualizado.Nome;
            curso.Descricao = cursoAtualizado.Descricao;
            curso.Duracao = cursoAtualizado.Duracao;
            return NoContent();
        }

        // endpoint para apagar um curso
        [HttpDelete("deletar-curso-{id}")]
        public ActionResult ApagarCurso(int id)
        {
            var curso = cursos.FirstOrDefault(c => c.Id == id);
            if (curso == null)
            {
                return NotFound();
            }
            cursos.Remove(curso);
            return NoContent();
        }

    }

}
