using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoRegistroDePessoas.RegrasDeNegocio
{
    [Table("pessoa", Schema = "public")]
    class Pessoa
    {

        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("cpf")]
        public string Cpf { get; set; }
        [Column("datanasc")]
        public DateTime DataNasc { get; set; }
        [Column("tel")]
        public string Tel { get; set; }
    }
}
