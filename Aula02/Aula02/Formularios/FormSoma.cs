using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aula02.Formularios
{
    public partial class FormSoma : Form
    {
        public FormSoma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public double Rresultado;

        private void btCalcular_Click(object sender, EventArgs e)
        {
            double Valor1;
            double Valor2;
            double Resultado;

            Valor1 = Convert.ToDouble(ValorA.Text);
            Valor2 = Convert.ToDouble(ValorB.Text);
            Resultado = Valor1 + Valor2;
        }
    }
}
