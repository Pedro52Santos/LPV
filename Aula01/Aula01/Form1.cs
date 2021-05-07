using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarias;

namespace Aula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCakcular_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(textBox1.Text);
            num = Math.Pow(num, 0.5);
            Mensagens msg = new Mensagens("Resultado");
            msg.MsgInfirmacao("Raiz quadrada " + num);
        }
    }
}
