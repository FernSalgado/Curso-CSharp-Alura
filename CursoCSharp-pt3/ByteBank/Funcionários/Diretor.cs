using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionários
{
    public class Diretor : FuncionarioAutenticavel
    {
        //diz que o metodo construtor de Diretor deve usar o parametro Cpf e usar o método construtor da classe
        public Diretor(string cpf) : base(5000,cpf)
        {

        }
        //override permite que o metodo filho sobrescreva o metodo herdado (requer comando virtual no metedodo herdado)
        public override double GetBonificacao()
        {
            //base faz referencia a classe herdada. (Nesse caso, funciona´rio)
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
