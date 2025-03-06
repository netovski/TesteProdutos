namespace ProdutoApp.Models
{
    public class Produto
    {
        public int Id { get; set; }  // Identificador único
        public string Nome { get; set; }  // Nome do produto
        public string Descricao { get; set; }  // Descrição do produto
        public decimal Preco { get; set; }  // Preço do produto
    }
}
