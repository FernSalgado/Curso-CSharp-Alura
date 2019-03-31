using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionários
{
    //abstract diz que a classe não pode ser instanciada e que só deve ser usada como base para outras
    public abstract class Funcionario
    {
        //private define que somente a classe Funcionario pode acessar o metodo
        //protected define que a classe Funcionario e todas as classes derivadas dela podem acessar o metodo
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(double salario,string cpf)
        {
            Cpf = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
        }
        //virtual permite que o metodo seja sobreposto nas classes filhas (com comando override na declaração do metodo filho)
        //definir um metodo como abstract define que ele só será acessado nas classes derivadas
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
    }
}
