using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula02.Formularios;

namespace Aula02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSoma frm = new FormSoma();
            frm.ShowDialog();
        }

        private void btSubtrair_Click(object sender, EventArgs e)
        {
            FormSubtracao frmS = new FormSubtracao();
            frmS.ShowDialog();
        }

        private void btMultiplica_Click(object sender, EventArgs e)
        {
            FormMultiplicacao FmrM = new FormMultiplicacao();
            FmrM.ShowDialog();
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            FormDivisao frmD = new FormDivisao();
            frmD.ShowDialog();
        }
    }
}
