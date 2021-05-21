using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCarros.Formularios;

namespace ProjetoCarros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCadastrar fmc = new FormCadastrar();
            fmc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormListarSimples fml = new FormListarSimples();
            fml.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormListarGeral fml = new FormListarGeral();
            fml.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormConsultar fmc = new FormConsultar();
            fmc.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormSeminovos form = new FormSeminovos();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormUsados form = new FormUsados();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormCincoAnos form = new FormCincoAnos();
            form.ShowDialog();
        }
    }
}
