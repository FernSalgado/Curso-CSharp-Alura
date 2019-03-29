using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente fernando = new Cliente();
            fernando.Nome = "Fernando";
            fernando.Cpf = "419.239.918-09";
            fernando.Profissao = "Dev";
            conta.Titular = fernando;
            conta.Agencia = 463;
            conta.Numero = 463433;
            conta.Saldo = 3400;
            Console.WriteLine(conta.Titular.Nome + 
                " " + conta.Saldo +
                " " + conta.Numero );
            Console.ReadLine();
        }
    }
}
