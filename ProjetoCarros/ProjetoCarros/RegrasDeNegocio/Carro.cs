using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarros.RegrasDeNegocio
{
    class Carro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public DateTime DataFabr { get; set; }
        public double ValorZero { get; set; }
    }
}
