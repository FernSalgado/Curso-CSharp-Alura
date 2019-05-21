using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            var nav = new Navegador();
            nav.NavegarPara("google.com");
            nav.NavegarPara("alura.com");
            nav.NavegarPara("caellum.com");
            nav.Anterior();
            nav.Anterior();
            nav.Anterior();
            nav.Proximo();
            nav.Anterior();
            nav.Anterior();
            nav.Proximo();
            nav.Proximo();
            nav.Proximo();
            nav.Proximo();
        }
    }
    internal class Navegador
    {
        private readonly Stack<string> historicoAnterior = new Stack<string>();
        private readonly Stack<string> historicoProximo = new Stack<string>();
        private string Atual = "Vazia";
        public Navegador()
        {
            exibePaginaAtual();
        }

        internal void NavegarPara(string url)
        {
            historicoAnterior.Push(Atual);
            Atual = url;
            exibePaginaAtual();
        }

        internal void exibePaginaAtual()
        {
            Console.WriteLine("Pagina atual: " + Atual);
        }

        internal void Anterior()
        {
            if (historicoAnterior.Any())
            {
                historicoProximo.Push(Atual);
                Atual = historicoAnterior.Pop();
                exibePaginaAtual();
            }
            else
            {
                Console.WriteLine("Pilha de anterior vazio.");
            }
        }
        internal void Proximo()
        {
            if (historicoProximo.Any())
            {
                historicoAnterior.Push(Atual);
                Atual = historicoProximo.Pop();
                exibePaginaAtual();
            }
            else
            {
                Console.WriteLine("Pilha de proximo vazio.");
            }
        }
    }
}
