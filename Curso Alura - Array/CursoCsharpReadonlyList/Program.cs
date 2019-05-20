using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharpReadonlyList
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharpColecoes = new Curso("C# Collections","Marcelo Oliveira");
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            Imprimir(csharpColecoes.Aulas);
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 10));

            Imprimir(csharpColecoes.Aulas);

            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);
            aulasCopiadas.Sort();
            Imprimir(aulasCopiadas);
            Console.WriteLine(csharpColecoes.TempoTotal);
            Console.WriteLine(csharpColecoes);
        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
