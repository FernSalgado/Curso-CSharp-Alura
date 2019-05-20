using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_Alura___Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";
            string[] aulas = new string[]
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };

            Console.WriteLine(aulas);
            Imprimir(aulas);

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }

            Array.Reverse(aulas);
            Imprimir(aulas);

            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            Array.Resize(ref aulas, 3);
            Imprimir(aulas);

            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);

            Array.Sort(aulas);
            Imprimir(aulas);

            string[] copia = new string[2];
            Array.Copy(aulas, 1, copia, 0, 2);
            Imprimir(copia);

            string[] clone = aulas.Clone() as string[];
            Imprimir(clone);

            Array.Clear(clone, 1, 2);
            Imprimir(clone);


        }

        private static void Imprimir(string[] aulas)
        {
            foreach (var item in aulas)
            {
                Console.WriteLine(item);
            }
        }
    }
}
