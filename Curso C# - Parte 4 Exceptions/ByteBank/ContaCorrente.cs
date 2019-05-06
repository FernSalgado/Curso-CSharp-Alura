// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public static double TaxaOperacao { get; private set; }
        public static int ContadorSaquesNaoPermitidos { get; private set; }
        public static int ContadorTransferenciasNaoPermitidas { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }
        public int Agencia{get;}
        public int Numero {get;}
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
        public ContaCorrente(int numeroAgencia, int numeroConta)
        {
            if(numeroAgencia <= 0)
            {
                throw new ArgumentException("O número da agencia deve ser maior que 0.",nameof(numeroAgencia));
            }
            if(numeroConta <= 0)
            {
                throw new ArgumentException("O número da conta deve ser maior que 0",nameof(numeroConta));
            }
            Agencia = numeroAgencia;
            Numero = numeroConta;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                ContadorSaquesNaoPermitidos++;
                throw new ArgumentException("O valor de saque deve ser maior que 0!",nameof(valor));
            }
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException("Operação não realizada, o saldo é insuficiente.");
            }

            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ArgumentException("O valor do deposito deve ser maior que 0!",nameof(valor));
            }
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException("Não foi possivel transferir, saldo insuficiente!");
            }
            _saldo -= valor;
            contaDestino.Depositar(valor);
        }
    }
}
