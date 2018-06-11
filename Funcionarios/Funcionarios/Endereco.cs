using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    public class Endereco
    {
        private string logradouro;
        private string cep;
        private string bairro;
        private string cidade;
        private string estado;
        private string complemento;
        private string numero;

        public Endereco()
        {

        }

        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Numero { get => numero; set => numero = value; }
    }
}
