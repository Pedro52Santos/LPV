using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13.RegrasDeNegocio
{
    public class Candidato
    {
        public int Id { get; set; }
        public int NumInsc { get; set; }
        public string Nome { get; set; }
        public double Nota { get; set; }
        public string Situacao
        {
            get
            {
                string resultado = "Desclassificado";
                if (Nota > 60)
                {
                    resultado = "Classificado";
                }
                return resultado;
            }
        }
    }
}
