namespace Alura.Loja.Testes.ConsoleApp
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public string Nome { get;  internal set; }
        public int Id { get; internal set; }
        public Endereco EnderecoDeEntrega {get;set;}
    }
}