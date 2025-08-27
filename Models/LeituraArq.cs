namespace CRUD_ENDPOINT_CURSOS.Models
{
    public class LeituraArq
    {
        public (bool Sucesso, string[] Linhas, int QuantLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            }
            catch(Exception ex){ 
                return (false, new string[0], 0);
            }


        }
    }
}
