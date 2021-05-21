using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarros.RegrasDeNegocio
{
    [Table("carro", Schema = "public")]
    class Carro
    {
        [Column("id")]
        public int Id { get; set; }
        [Column("modelo")]
        public string Modelo { get; set; }
        [Column("placa")]
        public string Placa { get; set; }
        [Column("datafabr")]
        public DateTime DataFabr { get; set; }
        [Column("valorzero")]
        public double ValorZero { get; set; }
    }
}
