using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCarros.Consultas;
using ProjetoCarros.Context;

namespace ProjetoCarros.Formularios
{
    public partial class FormConsultar : Form
    {
        ConexaoContext ctx = new ConexaoContext();
        public FormConsultar()
        {
            InitializeComponent();
            bindingSource1.DataSource = ctx.ListaPessonalizadaVeiculo();
            cbPesquisa.DataSource = bindingSource1;
            cbPesquisa.DisplayMember = "placa";
            cbPesquisa.SelectedIndex = -1;
            cbPesquisa.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaVeiculo veiculo = new ConsultaVeiculo();
            veiculo = ctx.ListaPessonalizadaVeiculo().ElementAt(bindingSource1.Position);
            edPlaca.Text = veiculo.Placa;
            edModelo.Text = veiculo.Modelo;
            edSituacao.Text = veiculo.Situacao;
            edIdade.Text = Convert.ToString(veiculo.Idade);
            edValor.Text = Convert.ToString(veiculo.ValorAtual);
            btLimpar_Click(sender, e);
         }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            edValor.Clear();
            edPlaca.Clear();
            edSituacao.Clear();
            edModelo.Clear();
            edIdade.Clear();
            cbPesquisa.Select();
        }
    }
}
