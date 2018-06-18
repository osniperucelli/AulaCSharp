namespace Modelos
{ 
    using System;
    using System.Collections.Generic;

    public class Cliente
    {
        public Cliente()
        {
            this.Aluguel = new HashSet<Aluguel>();
        }

        public int Id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string idade { get; set; }
        public string cpf { get; set; }
        public string sexo { get; set; }
        public string estado { get; set; }
        public string cidade { get; set; }
        public string pais { get; set; }
        public string habilitacao { get; set; }
    }
}
