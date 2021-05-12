using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aula02.Formularios
{
    public partial class FormMultiplicacao : Form
    {
        public FormMultiplicacao()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double Valor1;
            double Valor2;
            double Resultado;

            Valor1 = Convert.ToDouble(ValorA.Text);
            Valor2 = Convert.ToDouble(ValorB.Text);
            Resultado = Valor1 * Valor2;
            EdResultado.Text = Convert.ToString(Resultado);
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
