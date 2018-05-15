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

        public void Acelerar()
        {
            Velocidade += 10; // throw new NotImplementedException();
        }

        public void desacelerar()
        {
            Velocidade -= 6; //throw new NotImplementedException();
        }




    }
}
