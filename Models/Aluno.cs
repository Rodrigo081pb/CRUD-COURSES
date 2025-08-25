namespace CRUD_ENDPOINT_CURSOS.Models
{
    public class Aluno
    {
        // criando as propriedades da classe Aluno

        public int Id { get; set; }

        public int CursoId { get; set; }

        public string? Nome { get; set; }
        public string? Sobrenome { get; set; }
        public int Idade { get; set; }

    }
}
