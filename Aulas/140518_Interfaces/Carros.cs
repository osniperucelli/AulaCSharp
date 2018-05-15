using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140518_Interfaces
{
    class Carros : IMeioTransporte
    {
        public int Velocidade { get; set; }


        //aqui é usado lazy load. 
        //*****chave para a classe marca, trabalha a chave extrangeira senao (recebe um carro e carrega marca, repetidamente)
        public int MarcaID { get; set; }   //ela gerara coluna e chave extrangeira no BD

        //*****instancia para ao objeto relacionado
        public virtual Marca _Marca { get; set; }





        public void Acelerar()
        {
            Velocidade += 10; // throw new NotImplementedException();
        }

        public void Desacelerar()
        {
            Velocidade -= 6; //throw new NotImplementedException();
        }




    }
}
