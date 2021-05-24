using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunos.Consultas
{
    class ConsultaAluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Nota1Bim { get; set; }
        public double Nota2Bim { get; set; }
        public double Media { get; set; }
        public string Situacao { get; set; }
    }
}
