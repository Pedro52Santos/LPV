using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilitarias;

namespace Aula02.Formularios
{
    public partial class FormDivisao : Form
    {
        public FormDivisao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double Valor1;
            double Valor2;
            double Resultado;

            Valor1 = Convert.ToDouble(ValorA.Text);
            Valor2 = Convert.ToDouble(ValorB.Text);
            if(Valor2 <= 0)
            {
                Mensagens msg = new Mensagens("ERRO!!");
                msg.MsgErro("Não é possível dividir por zero");
            }else
            {
                Resultado = Valor1 / Valor2;
                EdResultado.Text = Convert.ToString(Resultado);
            }
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            ValorA.Clear();
            ValorB.Clear();
            EdResultado.Clear();
            ValorA.Select();
        }
    }
}
