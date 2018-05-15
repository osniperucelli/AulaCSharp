using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula110518_POO
{
    //class Aluno
    class Aluno : Pessoa

    {


        /*atributos

        private string nome;

        //Propriedade

        public string Nome
        {
            get => nome; //get {return nome; }
            set => nome = value;  //set {nome = value; }
        }

        public string Cpf { get; set; }
        */


        //Construtores
        public Aluno()
        {
        }

        //propriedade

        //public Aluno(string nome)
        
        public Aluno(string nome) : base(nome)
        {
            //Nome = nome;
        }

        //public Aluno(String nome, string cpf)
        public Aluno(string nome, string cpf) : base(nome, cpf)
        {
            //this.Nome = nome;
            //Cpf = cpf;
           
        }


        public override string ShowInfoPessoa()
        {
            {
                return 'Aluno: ' + Nome + ", Cpf:  " + Cpf + ", Matricula: " + Matricula;
            }
            //throw new System.NotImplementedException(); //a partir do momento que nao tenho conexao com banco tenho excessao//gera o famoso try catch
        }


    }
}



