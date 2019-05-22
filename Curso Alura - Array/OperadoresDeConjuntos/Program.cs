using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresDeConjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] seq1 = { "Janeiro","Fevereiro","Março"};
            string[] seq2 = { "Fevereiro","MARÇO","Abril"};
            var consulta = seq1.Concat(seq2);
            Console.WriteLine("Concat:");
            ExibeConsulta(consulta);
            consulta = seq1.Union(seq2,StringComparer.CurrentCultureIgnoreCase);
            Console.WriteLine("Union:");
            ExibeConsulta(consulta);
            consulta = seq1.Intersect(seq2);
            Console.WriteLine("Intersect:");
            ExibeConsulta(consulta);
            consulta = seq1.Except(seq2);
            Console.WriteLine("Except:");
            ExibeConsulta(consulta);
        }

        static void ExibeConsulta(dynamic consulta)
        {
            foreach (var item in consulta)
            {
                Console.WriteLine(item);
            }
        }
    }
}
