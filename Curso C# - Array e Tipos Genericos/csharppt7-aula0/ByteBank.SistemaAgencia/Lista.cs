using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Lista<T>
    {
        private T[] _items;
        private int _proximaPosicao;
        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }
        public Lista(int numeroIndice = 5)
        {
            _items = new T[numeroIndice];
            _proximaPosicao = 0;
        }
        public void Adicionar(T conta)
        {
            VerificarCapacidade(_proximaPosicao + 1);
            //Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            _items[_proximaPosicao] = conta;
            _proximaPosicao++;
        }

        public void AdicionarVarios(params T[] contas)
        {
            foreach (T conta in contas)
            {
                Adicionar(conta);
            }
        }

        public void Remover(T item)
        {
            int indiceItem = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                object itemAtual = _items[i];

                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }
            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _items[i] = _items[i + 1];
            }
            _proximaPosicao--;
            //_items[_proximaPosicao] = null;
        }
        public void EscreverListaNaTela()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                T item = _items[i];
                //Console.WriteLine($"Conta: {conta.Agencia}{conta.Numero}");
            }
        }
        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_items.Length >= tamanhoNecessario)
            {
                return;
            }
            int novoTamanho = _items.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }
            //Console.WriteLine("Aumentando lista.");
            T[] novoArray = new T[novoTamanho];

            for (int i = 0; i < _items.Length; i++)
            {
                novoArray[i] = _items[i];
            }

            _items = novoArray;
        }

        public T GetItemNoIndice(int i)
        {
            if (i < 0 || i >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(i));
            }
            return _items[i];
        }

        public T this[int i]
        {
            get
            {
                return GetItemNoIndice(i);
            }
        }
    }
}
