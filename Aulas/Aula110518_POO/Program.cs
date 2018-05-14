using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula110518_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            a.Nome = "Godofredo"; //estou usando o set
            //a.Cpf = "123456789"
            Console.WriteLine("Aluno: " + a.Nome);   //esse cara é o get
             
            Aluno b = new Aluno("Juliana", "123");
            Console.WriteLine("Aluno:  " + b.Nome + " , Cpf" + b.Cpf);

            Aluno c = new Aluno("Jandira", "456");
            //Pessoa p = new Pessoa();
            Console.WriteLine("Aluno: " + c.Nome + " , Cpf" + c.Cpf);


            Console.ReadKey();

        }

        
    }
}
