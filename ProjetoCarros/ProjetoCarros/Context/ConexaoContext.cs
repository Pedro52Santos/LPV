using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCarros.RegrasDeNegocio;
using ProjetoCarros.Consultas;

namespace ProjetoCarros.Context
{
    class ConexaoContext:DbContext
    {
        public ConexaoContext() : base("PgVeiculo")
        {

        }
        public DbSet<Carro> ListaSimplesVeiculo { get; set; }

        //consultas personalizadas
        public List<ConsultaVeiculo> ListaGeral()
        {
            string sql = "SELECT Id," +
                " modelo," +
                " placa," +
                " TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER AS idade," +
                " valorzero," +
                " (valorzero * (1 - 0.05 * TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER))::NUMERIC(10,2) AS valoratual," +
                " CASE WHEN (TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER)< 3 THEN 'seminovo'" +
                " ELSE 'usado'" +
                " END :: VARCHAR(15) AS situacao " +
                "FROM carro ";

            return Database.SqlQuery<ConsultaVeiculo>(sql).ToList();
        }

        public List<ConsultaVeiculo> ListaSeminovos()
        {
            string sql = "SELECT Id," +
                " modelo," +
                " placa," +
                " TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER AS idade," +
                " valorzero," +
                " (valorzero * (1 - 0.05 * TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER))::NUMERIC(10,2) AS valoratual," +
                " CASE WHEN (TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER)< 3 THEN 'seminovo'" +
                " ELSE 'usado'" +
                " END :: VARCHAR(15) AS situacao " +
                "FROM carro " +
                "WHERE (TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER)< 3 ";
            return Database.SqlQuery<ConsultaVeiculo>(sql).ToList();
        }

        public List<ConsultaVeiculo> ListaUsados()
        {
           string sql = "SELECT Id," +
               " modelo," +
               " placa," +
               " TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER AS idade," +
               " valorzero," +
               " (valorzero * (1 - 0.05 * TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER))::NUMERIC(10,2) AS valoratual," +
               " CASE WHEN (TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER)< 3 THEN 'seminovo'" +
               " ELSE 'usado'" +
               " END :: VARCHAR(15) AS situacao " +
               "FROM carro " +
               "WHERE (TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER)> 3 ";
            return Database.SqlQuery<ConsultaVeiculo>(sql).ToList();
        }
        public List<ConsultaVeiculo> ListaMaisDeCincoAnos()
        {
            string sql = "SELECT Id," +
               " modelo," +
               " placa," +
               " TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER AS idade," +
               " valorzero," +
               " (valorzero * (1 - 0.05 * TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER))::NUMERIC(10,2) AS valoratual," +
               " CASE WHEN (TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER)< 3 THEN 'seminovo'" +
               " ELSE 'usado'" +
               " END :: VARCHAR(15) AS situacao " +
               "FROM carro " +
               "WHERE (TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER)> 5 ";

            return Database.SqlQuery<ConsultaVeiculo>(sql).ToList();
        }

    }
}
