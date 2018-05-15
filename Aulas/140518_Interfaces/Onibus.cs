using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140518_Interfaces
{
    class Onibus : IMeioTransporte
    {
        public int Velocidade { get;  /*=> throw new NotImplementedException()*/ set; /* => throw new NotImplementedException()*/ }

        public void Acelerar()
        {
            Velocidade += 7; //throw new NotImplementedException();
        }

        public void Desacelerar()   //cuidado que a primeira letra eh maiuscula
        {
            Velocidade -= 4; //throw new NotImplementedException();
        }
    }
}
