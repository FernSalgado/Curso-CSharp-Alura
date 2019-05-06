using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }

        public static void CarregarContas()
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();

            }
            //LeitorDeArquivo leitor = null
            //try
            //{
            //    leitor = new LeitorDeArquivo("contas.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.Fechar();
            //}
            //catch (IOException)
            //{
            //    Console.WriteLine("Exceção do tipo IOException");
            //}


        }
        public static void TestarExceptions()
        {
            try
            {
                //codigos
                Console.WriteLine("Conta 1:");
                ContaCorrente conta1 = new ContaCorrente(0, 500);
                Console.WriteLine("Conta 2:");
                ContaCorrente conta2 = new ContaCorrente(455, 0);
                Console.WriteLine("Conta 3:");
                ContaCorrente conta3 = new ContaCorrente(455, 500);
                conta3.Sacar(500);
                Console.WriteLine("Conta 4:");
                ContaCorrente conta4 = new ContaCorrente(455, 501);
                Console.WriteLine("Transferencia da conta 3 para 4");
                conta3.Transferir(500, conta4);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Argumento com problema: ", e.ParamName);
                Console.WriteLine(e.Message);
            }
            catch (OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
