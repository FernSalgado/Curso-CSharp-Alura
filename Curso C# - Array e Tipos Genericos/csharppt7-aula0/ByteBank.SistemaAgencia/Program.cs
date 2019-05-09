using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;
namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            var contas = new List<ContaCorrente>
            {
                new ContaCorrente(007,333),
                new ContaCorrente(003,111),
                new ContaCorrente(002,777),
                new ContaCorrente(001,222),
                new ContaCorrente(000,555),
            };
            //contas.Sort();
            contas.Sort(new ComparadorContaCorrentePorAgencia());
            foreach (var item in contas)
            {
                Console.WriteLine($"Conta numero {item.Numero}, ag. {item.Agencia}");
            }
            Console.ReadLine();
        }

        static void TestaLista()
        {
            //ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ListaDeObjects lista = new ListaDeObjects();
            ContaCorrente conta = new ContaCorrente(111, 1111);
            ContaCorrente[] contas = new ContaCorrente[]
            {
                conta,
                new ContaCorrente(874,800),
                new ContaCorrente(874,801),
                new ContaCorrente(874,802),
                new ContaCorrente(874,803),
                new ContaCorrente(874,804),
                new ContaCorrente(874,805),
                new ContaCorrente(874,806)
            };
            lista.AdicionarVarios(contas);
            lista.AdicionarVarios(new ContaCorrente(874, 807), new ContaCorrente(874, 808), new ContaCorrente(874, 809));

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i] as ContaCorrente;
                Console.WriteLine($"Item na posição {i}: Conta {itemAtual.Numero}/{itemAtual.Agencia}.");
            }
        }
        static void TestaArrayInt()
        {
            int[] idade = new int[5];
            idade[0] = 15;
            idade[1] = 22;
            idade[2] = 33;
            idade[3] = 44;
            idade[4] = 55;

            int acumulador = 0;
            for (int i = 0; i < idade.Length; i++)
            {
                Console.WriteLine($"Acessando o array Idade no índice: {i}.");
                Console.WriteLine($"Valor de idade[{i}]={idade[i]}");
                acumulador += idade[i];
            }
            int media = acumulador / idade.Length;
            Console.WriteLine($"A media de idades dividido por {idade.Length} é: {media}");

        }
    }
}
