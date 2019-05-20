using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharpSets
{
    class Aluno
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int matricula;

        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
        }

        public int Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public override string ToString()
        {
            return $"[Nome: {nome} Matricula: {matricula}]";
        }
        public override bool Equals(object obj)
        {
            Aluno outro = obj as Aluno;
            return this.nome.Equals(outro.nome); 
        }
        public override int GetHashCode()
        {
            return this.nome.GetHashCode(); 
        }
    }
}
