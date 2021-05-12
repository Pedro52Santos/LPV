using System;
using System.Collections.Generic;
using System.Text;

namespace MinhasValidacoes.CalcularDatas
{
    public static class CalculosDeData
    {
        public static int DifEntreDatasEmDias(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);
            TimeSpan diferenca = dataFinal - dataInicial;
            int dias = diferenca.Days;
            return dias;
        }
        public static int DifEntreDatasEmDias(string dataIn, string dataF)
        {
            int anoI, anoF, mesI, mesF, diaI, diaF;
            diaI = Convert.ToInt32(dataIn.Substring(0, 2));
            mesI = Convert.ToInt32(dataIn.Substring(3, 2));
            anoI = Convert.ToInt32(dataIn.Substring(6, 4));
            diaF = Convert.ToInt32(dataF.Substring(0, 2));
            mesF = Convert.ToInt32(dataF.Substring(3, 2));
            anoF = Convert.ToInt32(dataF.Substring(6, 4));

            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);
            TimeSpan diferenca = dataFinal - dataInicial;
            int dias = diferenca.Days;
            return dias;
        }
    }
}
