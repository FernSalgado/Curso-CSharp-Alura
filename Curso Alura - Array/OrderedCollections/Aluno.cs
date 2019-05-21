using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderedCollections
{
    class Aluno
    {
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private int nroMatricula;

        public int NroMatricula
        {
            get { return nroMatricula; }
            set { nroMatricula = value; }
        }


        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.nroMatricula = matricula;
        }


        public override string ToString()
        {
            return $"[Nome: {nome} Matricula: {nroMatricula}]";
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
