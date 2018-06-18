using Modelos;
using System.Data.Entity;

namespace Controllers.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {

        }

        public DbSet<Carro> Usuarios { get; set; }

        public DbSet<Cliente> Categorias { get; set; }

        public DbSet<Aluguel> Atividades { get; set; }
    }
}
