using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCarros.Consultas
{
    class ConsultaVeiculo
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int Idade { get; set; }
        public double ValorAtual { get; set; }
        public string Situacao { get; set; }
    }
}
