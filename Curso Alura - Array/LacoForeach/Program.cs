using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayMeses = new string[]
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            foreach (var item in arrayMeses)
            {
                arrayMeses[1] = "A";
                Console.WriteLine(item);
            }
            IList<string> meses = new List<string>
            {
                "Janeiro", "Fevereiro", "Março",
                "Abril", "Maio", "Junho",
                "Julho", "Agosto", "Setembro",
                "Outubro", "Novembro", "Dezembro"
            };
            foreach (var item in meses)
            {
                //meses[0] = "A";
                Console.WriteLine(item);
            }
        }
    }
}
