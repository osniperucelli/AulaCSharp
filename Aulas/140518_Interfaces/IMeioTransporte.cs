﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _140518_Interfaces
{
    interface IMeioTransporte
    {

       int Velocidade { get; set; }

        void Acelerar();

        void desacelerar();


    }
}
