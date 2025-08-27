namespace CRUD_ENDPOINT_CURSOS.Models
{
    public class Venda
    {
        public Venda(int id, string produto, int quantidade, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Quantidade = quantidade;
            Preco = preco;
            DataVenda = dataVenda; // formato 
        }

        public int Id { get; set; }
        public string? Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
