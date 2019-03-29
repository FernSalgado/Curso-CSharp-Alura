using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();
            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora";
            //gabriela.cpf = "434.434.434-43";

            ContaCorrente conta = new ContaCorrente();
            //conta.titular = gabriela;
            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela";
            conta.titular.profissao = "Dev";
            conta.titular.cpf = "434.434.434-43";
            conta.saldo = 600;
            conta.agencia = 563;
            conta.numero = 563427;
            conta.titular.nome = "Gabriela Costa";
            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.ReadLine();
        }
    }
}
