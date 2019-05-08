using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    /// <summary>
    /// Define uma nova conta no ByteBank.
    /// </summary>
    public class ContaCorrente
    {
        private static int TaxaOperacao;

        /// <summary>
        /// Mostra quantas contas foram criadas no ByteBank.
        /// </summary>
        public static int TotalDeContasCriadas { get; private set; }

        /// <summary>
        /// Objeto do tipo Cliente
        /// </summary>
        public Cliente Titular { get; set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public int Numero { get; }
        public int Agencia { get; }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }
        /// <summary>
        /// Metodo construtor da conta corrente no ByteBank.
        /// </summary>
        /// <param name="agencia">Referente ao parametro <see cref="Agencia"/>, deve ser maior que 0.</param>
        /// <param name="numero">Referente ao parametro <see cref="Numero"/>, deve ser maior que 0.</param>
        public ContaCorrente(int agencia, int numero)
        {
            if (numero <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        /// <summary>
        /// Realiza um saque na conta e atualiza o campo <see cref="Saldo"/>
        /// </summary>
        /// <exception cref="ArgumentException">Exceção Lançada quando um valor negativo é lançado no argumento <paramref name="valor"/>.</exception>
        /// <exception cref="SaldoInsuficienteException">Exceção lançada quando o argumento <paramref name="valor"/> é maior que o <see cref="Saldo"/>.</exception>
        /// <param name="valor">Valor do saque. Deve ser maior que 0 e menor que o <see cref="Saldo"/>.</param>

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            _saldo -= valor;
        }

        /// <summary>
        /// Deposita uma quantia apartir do parametro <paramref name="valor"/> e adiciona ao <see cref="Saldo"/> da ContaCorrente.
        /// </summary>
        /// <exception cref="ArgumentException">Lança uma excesão caso o valor do parametro <paramref name="valor"/> seja menor que 0.</exception>
        /// <param name="valor"></param>
        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }
            _saldo += valor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="contaDestino"></param>

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            contaDestino.Depositar(valor);
        }
    }

}
