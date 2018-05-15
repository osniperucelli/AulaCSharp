using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula110518_POO
{
    abstract class Pessoa 
    {
       
        //atributos
        private string nome;
        
        // propriedade
        public string Nome
        {
            get => nome; //get {return nome;}
            set => nome = value; //set {nome = value; }

        }

        //public string CPf { get; set; }

        public string Cpf { get; private set; }

        //Construtor
        public Pessoa()
        {
        }

        public Pessoa(string nome)
        {
            Nome = nome;
        }


        public Pessoa(string nome, string cfp)
        {
            Nome = nome;
            Cpf = cpf;
        }


        public abstract string ShowInfoPessoa();
        
        


     }
}
