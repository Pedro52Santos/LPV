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
        //***********************************************************************************************************************
        public static int DifEntreDatasEmMeses(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);
            TimeSpan diferenca = dataFinal - dataInicial;
            int meses = (int)(diferenca.Days / 30.436875);
            return meses;
        }

        public static int DifEntreDatasEmMeses(string dataIn, string dataF)
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
            int meses = (int)(diferenca.Days / 30.436875);
            return meses;
        }
        //*******************************************************************************************************************

        public static int DifEntreDatasEmAnos(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = new DateTime(anoF, mesF, diaF);
            TimeSpan diferenca = dataFinal - dataInicial;
            int anos = (int)(diferenca.Days / 365);
            return anos;
        }

        public static int DifEntreDatasEmAnos(string dataIn, string dataF)
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
            int anos = (int)(diferenca.Days / 365);
            return anos;
        }

        //*************************************************************************************************

        public static int DifEntreDataParaHojeEmDias(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = DateTime.Now;
            TimeSpan diferenca = dataFinal - dataInicial;
            int dias = diferenca.Days;
            return dias;
        }
        public static int DifEntreDataParaHojeEmDias(string dataIn, string dataF)
        {
            int anoI, anoF, mesI, mesF, diaI, diaF;
            diaI = Convert.ToInt32(dataIn.Substring(0, 2));
            mesI = Convert.ToInt32(dataIn.Substring(3, 2));
            anoI = Convert.ToInt32(dataIn.Substring(6, 4));
            diaF = Convert.ToInt32(dataF.Substring(0, 2));
            mesF = Convert.ToInt32(dataF.Substring(3, 2));
            anoF = Convert.ToInt32(dataF.Substring(6, 4));

            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = DateTime.Now;
            TimeSpan diferenca = dataFinal - dataInicial;
            int dias = diferenca.Days;
            return dias;
        }

        //******************************************************************************************************

        public static int DifEntreDataParaHojeEmMeses(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = DateTime.Now;
            TimeSpan diferenca = dataFinal - dataInicial;
            int meses = (int)(diferenca.Days / 30.436875);
            return meses;
        }

        public static int DifEntreDataParaHojeEmMeses(string dataIn, string dataF)
        {
            int anoI, anoF, mesI, mesF, diaI, diaF;
            diaI = Convert.ToInt32(dataIn.Substring(0, 2));
            mesI = Convert.ToInt32(dataIn.Substring(3, 2));
            anoI = Convert.ToInt32(dataIn.Substring(6, 4));
            diaF = Convert.ToInt32(dataF.Substring(0, 2));
            mesF = Convert.ToInt32(dataF.Substring(3, 2));
            anoF = Convert.ToInt32(dataF.Substring(6, 4));

            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = DateTime.Now;
            TimeSpan diferenca = dataFinal - dataInicial;
            int meses = (int)(diferenca.Days / 30.436875);
            return meses;
        }


        //*******************************************************************************************************************

        public static int DifEntreDataParaHojeEmAnos(int diaI, int mesI, int anoI, int diaF, int mesF, int anoF)
        {
            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = DateTime.Now;
            TimeSpan diferenca = dataFinal - dataInicial;
            int anos = (int)(diferenca.Days / 365);
            return anos;
        }

        public static int DifEntreDataParaHojeEmAnos(string dataIn, string dataF)
        {
            int anoI, anoF, mesI, mesF, diaI, diaF;
            diaI = Convert.ToInt32(dataIn.Substring(0, 2));
            mesI = Convert.ToInt32(dataIn.Substring(3, 2));
            anoI = Convert.ToInt32(dataIn.Substring(6, 4));
            diaF = Convert.ToInt32(dataF.Substring(0, 2));
            mesF = Convert.ToInt32(dataF.Substring(3, 2));
            anoF = Convert.ToInt32(dataF.Substring(6, 4));

            DateTime dataInicial = new DateTime(anoI, mesI, diaI);
            DateTime dataFinal = DateTime.Now;
            TimeSpan diferenca = dataFinal - dataInicial;
            int anos = (int)(diferenca.Days / 365);
            return anos;
        }

        //******************************************************************************************************************************

        public static DateTime SomarDiasParaUmaData(int qtDias, int dia, int mes, int ano)
        {
            DateTime dataFutura = new DateTime(ano, mes, dia);
            return dataFutura.AddDays(qtDias);
        }
        public static DateTime SomarDiasParaUmaData(int qtDias, string dataIn)
        {
            int dia = Convert.ToInt32(dataIn.Substring(0, 2));
            int mes = Convert.ToInt32(dataIn.Substring(3, 2));
            int ano = Convert.ToInt32(dataIn.Substring(6, 4));

            DateTime dataFutura = new DateTime(ano, mes, dia);
            return dataFutura.AddDays(qtDias);

        }

        //******************************************************************************************************************************

        public static DateTime SomarDiasApartirdeHoje(int qtdDias)
        {
            DateTime dataFutura = DateTime.Now;
            return dataFutura.AddDays(qtdDias);
        }
    }

}
