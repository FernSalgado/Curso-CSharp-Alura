using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharpSets
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso csharp = new Curso("C# Collections", "Marcelo");
            csharp.Adiciona(new Aula("Aula 1", 20));
            csharp.Adiciona(new Aula("Aula 2", 20));
            csharp.Adiciona(new Aula("Aula 3", 20));

            Aluno a1 = new Aluno("Vanessa", 34672);
            Aluno a2 = new Aluno("Ana", 5617);
            Aluno a3 = new Aluno("Rafael", 17645);
            Aluno a4 = new Aluno("Rafael", 17645);
            csharp.Matricula(a1);
            csharp.Matricula(a2);
            csharp.Matricula(a3);
            Console.WriteLine("Aluno com matricula 5617:");
            Aluno busca = csharp.buscaMatriculado(5617);
            Console.WriteLine(busca);

            Console.WriteLine("Aluno com matricula 5618:");
            Console.WriteLine(csharp.buscaMatriculado(5618));
        }

        public static void TestaSets()
        {
            Curso csharp = new Curso("C# Collections", "Marcelo");
            csharp.Adiciona(new Aula("Aula 1", 20));
            csharp.Adiciona(new Aula("Aula 2", 20));
            csharp.Adiciona(new Aula("Aula 3", 20));

            Aluno a1 = new Aluno("Vanessa", 34672);
            Aluno a2 = new Aluno("Ana", 5617);
            Aluno a3 = new Aluno("Rafael", 17645);
            Aluno a4 = new Aluno("Rafael", 17645);
            csharp.Matricula(a1);
            csharp.Matricula(a2);
            csharp.Matricula(a3);

            foreach (var aluno in csharp.Alunos)
            {
                Console.WriteLine(aluno);
            }
            Console.WriteLine(csharp.EstaMatriculado(a4));
            Console.WriteLine($"A3 equals a4? {a3.Equals(a4)}");
        }
    }
}
