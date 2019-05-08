namespace Alura.Loja.Testes.ConsoleApp
{
    public class Compra
    {
        public Compra()
        {
        }

        public int Id { get; internal set; }
        public int Quantidade { get; internal set; }
        public int ProdutoId { get; internal set; }
        public Produto Produto { get; internal set; }
        public double Preco { get; internal set; }

        public override string ToString()
        {
            return $"Id: {this.Id} Quantidade: {this.Quantidade} ProdutoId: {this.ProdutoId} Produto: {this.Produto.Nome} Preço: {this.Preco}";
        }
    }
}