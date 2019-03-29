using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente conta1 = new ContaCorrente(444,234);
            Console.WriteLine(conta1.Agencia);
            Console.WriteLine(conta1.Numero);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
            ContaCorrente conta2 = new ContaCorrente(441, 233);
            Console.WriteLine(conta2.Agencia);
            Console.WriteLine(conta2.Numero);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
