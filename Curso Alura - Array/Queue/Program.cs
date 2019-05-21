using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            Enfileirar("van");
            Enfileirar("kombi");
            Enfileirar("guincho");
            Enfileirar("pickup");
            exibePilha();
            Desenfileirar();
            exibePilha();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
        }

        private static void exibePilha()
        {
            foreach (var carro in pedagio)
            {
                Console.WriteLine(carro);
            }
        }

        private static void Enfileirar(string veiculo)
        {
            
            Console.WriteLine($"Entrou no pedagio: {veiculo}");
            pedagio.Enqueue(veiculo);
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                Console.WriteLine($"Saiu do pedagio: {pedagio.Dequeue()}");
                
                    exibeProximo();
            }
            else
            {
                Console.WriteLine("Pedagio vazio.");
            }
        }

        private static void exibeProximo()
        {
            if (pedagio.Count >= 1)
            {
                Console.WriteLine($"O próximo carro é: {pedagio.Peek()}");
            }
            
        }
    }
}
