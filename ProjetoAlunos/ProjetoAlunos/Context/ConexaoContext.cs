using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAlunos.Consultas;
using ProjetoAlunos.RegrasdeNegocio;

namespace ProjetoAlunos.Context
{
    class ConexaoContext:DbContext
    {
        public ConexaoContext(): base("PGAlunos")
        {

        }
        public DbSet<Aluno> ListaSimples { get; set; }

        public List<ConsultaAluno> ListaCompleta()
        {
            string sql = "";
            return Database.SqlQuery<ConsultaAluno>(sql).ToList();
        }
    }
}
