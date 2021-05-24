using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAlunos.RegrasdeNegocio
{
    [Table ("carro", Schema ="public")]
    class Aluno
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("datanasc")]
        public DateTime DataNasc { get; set; }
        [Column("nota1b")]
        public double Nota1Bim { get; set; }
        [Column("nota2b")]
        public double Nota2Bim { get; set; }
    }
}
