using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProjetoRegistroDePessoas.RegrasDeNegocio;

namespace ProjetoRegistroDePessoas.Context
{
    class ContextBDPessoa: DbContext
    {
        public ContextBDPessoa(): base("PgPessoas")
        {

        }
        public DbSet<Pessoa>ListaDePessoas { get; set; }
    }
}
