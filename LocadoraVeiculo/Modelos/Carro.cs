namespace Modelos
{
    using System;
    using System.Collections.Generic;

    public class Carro
    {
               
        public Carro()
        {
            this.Aluguel = new HashSet<Aluguel>();
        }
        public int Id { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
        public string cor { get; set; }
        public string marca { get; set; }

        public ICollection<Aluguel> Aluguel(get; set;)    
    }
}
