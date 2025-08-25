namespace CRUD_ENDPOINT_CURSOS.Models
{
    public class Curso
    {
        // criando as propriedades da classe Curso
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public int Duracao { get; set; } // duração em horas
    }
}
