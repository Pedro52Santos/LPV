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
        public ConexaoContext() : base("PGAlunos")
        {

        }
        public DbSet<Aluno> ListaSimples { get; set; }
    

        public List<ConsultaAluno> ListaCompleta()
        {
            string sql = "SELECT " +
                " Id," +
                " nome," +
                " TO_CHAR(AGE(CURRENT_DATE, datanasc), 'YY')::INTEGER AS idade," +
                " nota1b," +
                " nota2b," +
                " ((nota1b + nota2b) / 2) ::NUMERIC(4, 1) AS media," +
                    " CASE WHEN((nota1b + nota2b) / 2) >= 60" +
                        " THEN 'APROVADO'" +
                        "ELSE 'REPROVADO'" +
                " END::VARCHAR(9) AS situacao " +
                "FROM aluno";
            return Database.SqlQuery<ConsultaAluno>(sql).ToList();
        }
        public List<ConsultaAluno> ListaAprovados()
        {
            string sql = "SELECT " +
                " Id," +
                " nome," +
                " TO_CHAR(AGE(CURRENT_DATE, datanasc), 'YY')::INTEGER AS idade," +
                " nota1b," +
                " nota2b," +
                " ((nota1b + nota2b) / 2) ::NUMERIC(4, 1) AS media," +
                    " CASE WHEN((nota1b + nota2b) / 2) >= 60" +
                        " THEN 'APROVADO'" +
                        "ELSE 'REPROVADO'" +
                " END::VARCHAR(9) AS situacao " +
                "FROM aluno" +
                " WHERE ((nota1b + nota2b)/2) >=60";

            return Database.SqlQuery<ConsultaAluno>(sql).ToList();
        }
        public List<ConsultaAluno> ListaReprovados()
        {
            string sql = "SELECT " +
                " Id," +
                " nome," +
                " TO_CHAR(AGE(CURRENT_DATE, datanasc), 'YY')::INTEGER AS idade," +
                " nota1b," +
                " nota2b," +
                " ((nota1b + nota2b) / 2) ::NUMERIC(4, 1) AS media," +
                    " CASE WHEN((nota1b + nota2b) / 2) >= 60" +
                        " THEN 'APROVADO'" +
                        "ELSE 'REPROVADO'" +
                " END::VARCHAR(9) AS situacao " +
                "FROM aluno" +
                " WHERE ((nota1b + nota2b)/2) < 60";
            return Database.SqlQuery<ConsultaAluno>(sql).ToList();
        }
        public List<ConsultaAluno> ListaAcimade()
        {
            string sql = "SELECT " +
                 " Id," +
                 " nome," +
                 " TO_CHAR(AGE(CURRENT_DATE, datanasc), 'YY')::INTEGER AS idade," +
                 " nota1b," +
                 " nota2b," +
                 " ((nota1b + nota2b) / 2) ::NUMERIC(4, 1) AS media," +
                     " CASE WHEN((nota1b + nota2b) / 2) >= 60" +
                         " THEN 'APROVADO'" +
                         "ELSE 'REPROVADO'" +
                 " END::VARCHAR(9) AS situacao " +
                 "FROM aluno" +
                 " WHERE ((nota1b + nota2b)/2) >=80";
            return Database.SqlQuery<ConsultaAluno>(sql).ToList();
        }
    }
}
