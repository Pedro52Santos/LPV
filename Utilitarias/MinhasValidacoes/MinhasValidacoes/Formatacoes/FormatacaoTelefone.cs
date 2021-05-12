using System;
using System.Collections.Generic;
using System.Text;

namespace MinhasValidacoes.Formatacoes
{
    public static class FormatacaoTelefone
    {
           public static string ColocaMascara(string numTelefone)
        {
            string comMascara;
            string ddd = numTelefone.Substring(0, 2);
            string num1 = numTelefone.Substring(2, 5);
            string num2 = numTelefone.Substring(7, 4);
            comMascara = "(" + ddd + ")" + " " + num1 + "-" + num2;
            return comMascara;
        }
        public static string ColocaMascara(int numTelefone)
        {
            string numTelefoneConvertido = Convert.ToString(numTelefone);
            string comMascara;
            string ddd = numTelefoneConvertido.Substring(0, 2);
            string num1 = numTelefoneConvertido.Substring(2, 5);
            string num2 = numTelefoneConvertido.Substring(7, 4);
            comMascara = "(" + ddd + ")" + " " + num1 + "-" + num2;
            return comMascara;
        }

        public static string RetiraMascara(string numTelefone)
        {
            string semMascara;
            string ddd = numTelefone.Substring(1, 2);
            string num1 = numTelefone.Substring(5, 5);
            string num2 = numTelefone.Substring(11, 4);
            semMascara = ddd + num1 + num2;
            return semMascara;  
        }
        public static string RetiraMascara(long numTelefone)
        {
            string numTelefonecv = Convert.ToString(numTelefone);
            string semMascara;
            string ddd = numTelefonecv.Substring(1, 2);
            string num1 = numTelefonecv.Substring(5, 5);
            string num2 = numTelefonecv.Substring(11, 4);
            semMascara = ddd + num1 + num2;
            return semMascara;
        }

        public static int QtdCaracter(string numTelefone)
        {
            return numTelefone.Length;
        }
        public static int QtdCaracter(long numTelefone)
        {
            string numTelefoneCV = Convert.ToString(numTelefone);
            return numTelefoneCV.Length;
        }

    }
}
