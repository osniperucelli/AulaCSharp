namespace Modelos
{
    using System;
    using System.Collections.Generic;

    public class Aluguel
    {
        public int Id { get; set; }

        public string dataInicial { get; set; }
        public string dataFinal { get; set; }
        public string valor { get; set; }
        public int id_cliente { get; set; }
        public int id_carro { get; set; }

        public Carro Carro { get; set; }
        public Cliente Cliente { get; set; }

        
    }
}
