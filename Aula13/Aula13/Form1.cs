using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula13.Formularios;

namespace Aula13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar fmc = new FormCadastrar();
            fmc.ShowDialog();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FormConsultar fmc = new FormConsultar();
            fmc.ShowDialog();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            FormListar fml = new FormListar();
            fml.ShowDialog();
        }
    }
}
