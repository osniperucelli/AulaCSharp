using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140518_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // abaixo temos exemplo de polimorfismo

            Carros c = new Carros();

            Console.WriteLine("Carro criado, velodicadae incial: " + c.Velocidade);
            c.Acelerar();
            c.Acelerar();

            AcelerarBastante(c);


            Onibus b = new Onibus();

            Console.WriteLine("O onibus criado, velocidade inicial: " + b.Velocidade);
            b.Acelerar();
            b.Acelerar();

          
            AcelerarBastante(b);

            Console.WriteLine("Carro, velocidade atual: " + c.Velocidade);
            Console.WriteLine("O onibus, velocidade atual: " + b.Velocidade);
            

            
            Console.ReadKey();

         }

        //metodo com injecao de dependencia. Recebe interface.

        static void AcelerarBastante(IMeioTransporte meioTransporte)
        {

            for (int i = 0; i < 10; i++)
            {
                meioTransporte.Acelerar();
                
            }

        }
        
    }
}
