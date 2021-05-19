using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoRegistroDePessoas.Formularios;

namespace ProjetoRegistroDePessoas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}
