using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAlunos.Formularios;

namespace ProjetoAlunos
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
            FormCadastrar form = new FormCadastrar();
            form.ShowDialog();
        }

        private void btListarSimples_Click(object sender, EventArgs e)
        {
            FormListarSimples form = new FormListarSimples();
            form.ShowDialog();
        }

        private void btListarCompleto_Click(object sender, EventArgs e)
        {
            FormListarCompleto form = new FormListarCompleto();
            form.ShowDialog();
        }

        private void btConsultar_Click(object sender, EventArgs e)
        {
            FormConsultar form = new FormConsultar();
            form.ShowDialog();
        }

        private void btAprovados_Click(object sender, EventArgs e)
        {
            FormListarAprovados form = new FormListarAprovados();
            form.ShowDialog();
        }

        private void btReprovados_Click(object sender, EventArgs e)
        {
            FormListarReprovados form = new FormListarReprovados();
            form.ShowDialog();
        }

        private void btAcimaDe_Click(object sender, EventArgs e)
        {
            FormAcimaDe form = new FormAcimaDe();
            form.ShowDialog();
        }
    }
}
