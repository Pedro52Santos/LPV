using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCarros.RegrasDeNegocio;

namespace ProjetoCarros.Context
{
    class ConexaoContext:DbContext
    {
        public ConexaoContext() : base("PgVeiculo")
        {

        }
        public DbSet<Carro> ListaSimplesVeiculo { get; set; }
    }
}
