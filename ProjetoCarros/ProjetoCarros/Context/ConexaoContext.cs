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
        public List<ConsultaVeiculo> ListaPessonalizadaVeiculo()
        {
            string sql = "SELECT" +
                " id," +
                " modelo," +
                " placa," +
                " TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER AS idade," +
                " (valorzero*(1 - 0.5 * TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER)::NUMERIC(10,2) AS valoratual," +
                "CASE WHEN (TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER) < 3 THEN 'SEMINOVO' " +
                "ELSE 'USADO' " +
                "END :: VARCHAR(15) AS situacao FROM CARRO";

            return Database.SqlQuery<ConsultaVeiculo>(sql).ToList();
        }

        public List<ConsultaVeiculo> ListaSeminovos()
        {
            string sql = ""; /* "SELECT" +
                " id," +
                " modelo," +
                " placa," +
                " TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER AS idade," +
                " (valorzero*(1 - 0.5 * TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER)::NUMERIC(10,2) AS valoratual," +
                "CASE WHEN (TO_CHAR(AGE(CURRENT_DATE,datafabr),'YY')::INTEGER) < 3 THEN 'SEMINOVO' " +
                "ELSE 'USADO' " +
                "END :: VARCHAR(15) AS situacao FROM CARRO"; */

            // para listar os seminovos bastar dar select de veiculos que foram fabricados a menos de 3 anos
            return Database.SqlQuery<ConsultaVeiculo>(sql).ToList();
        }

        public List<ConsultaVeiculo> ListaUsados()
        {
            string sql = "";

            return Database.SqlQuery<ConsultaVeiculo>(sql).ToList();
        }
        public List<ConsultaVeiculo> ListaMaisDeCincoAnos()
        {
            string sql = "";

            return Database.SqlQuery<ConsultaVeiculo>(sql).ToList();
        }

    }
}
