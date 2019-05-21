using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaLigada
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> dias = new LinkedList<string>();
            var d7 = dias.AddFirst("Sábado");
            var d2 = dias.AddBefore(d7, "Segunda");
            var d5 = dias.AddAfter(d2, "Quinta");
            var d1 = dias.AddBefore(d2, "Domingo");
            var d3 = dias.AddAfter(d2,"Terça");
            var d4 = dias.AddBefore(d5, "Quarta");
            var d6 = dias.AddBefore(d7, "Sexta");

            foreach (var dia in dias)
            {
                Console.WriteLine(dia);
            }
        }
    }
}
