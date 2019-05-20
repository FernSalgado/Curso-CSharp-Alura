using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Alura___Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            var aulaIntro = new Aula("Introdução às Coleções",20);
            var aulaModelando = new Aula("Modelando a Classe Aula",15);
            var aulaSets = new Aula ("A Trabalhando com Conjuntos",19);
            //Lista(aulaIntro, aulaModelando, aulaSets);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            Imprimir(aulas);
            Console.WriteLine("Sort:");
            aulas.Sort();
            Imprimir(aulas);

            aulas.Sort((este, outro) => este.Tempo.CompareTo(outro.Tempo));
            Imprimir(aulas);
        }

        private static void Imprimir(List<Aula> aulas)
        {
            Console.Clear();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }

        private static void Lista()
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";
            List<string> aulas = new List<string>
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };
            ImprimirLista(aulas);

            Console.WriteLine("A primeira aula com 'Introdução' é: "
                + aulas.First(aula => aula.Contains("Conclusão"))
                );

            List<string> copia = new List<string>(aulas);
            ImprimirLista(copia);

            copia.RemoveRange(copia.Count - 2, 2);
            ImprimirLista(copia);
        }

        private static void ImprimirLista(List<string> aulas)
        {
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aulas);
            //}
            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}
            aulas.ForEach(aula => { Console.WriteLine(aula); });
        }
    }
}
