using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionários;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            UsarSistema();
            Console.ReadLine();
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer carlos = new Designer("456.654.543-20");
            carlos.Nome = "Carlos";
            
            Diretor roberta = new Diretor("444.444.444-20");
            roberta.Nome = "Roberta";

            Auxiliar joao = new Auxiliar("333.333.333-20");
            joao.Nome = "João";

            GerenteDeConta camila = new GerenteDeConta("555.555.555-50");
            camila.Nome = "Camila";

            gerenciadorBonificacao.Registrar(camila);
            gerenciadorBonificacao.Registrar(joao);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(carlos);

            Console.WriteLine("Total de bonificações do mes: " + gerenciadorBonificacao.GetTotalBonificacao());
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("444.444.444-20");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";
            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(roberta, "abc");
            ParceiroComercial parceiroComercial = new ParceiroComercial();
            parceiroComercial.Senha = "123";
            sistemaInterno.Logar(parceiroComercial, "123");
        }
    }
}
