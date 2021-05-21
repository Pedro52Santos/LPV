using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCarros.Context;
using ProjetoCarros.RegrasDeNegocio;
using Utilitarias;

namespace ProjetoCarros.Formularios
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            edModelo.Clear();
            edPlaca.Clear();
            edValorN.Clear();
            edModelo.Select();
        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Carro veiculo = new Carro();
            veiculo.Modelo = edModelo.Text;
            veiculo.Placa = edPlaca.Text;
            veiculo.ValorZero = Convert.ToDouble(edValorN.Text);
            veiculo.DataFabr = dtDataFab.Value;

            ConexaoContext ctx = new ConexaoContext();
            ctx.ListaSimplesVeiculo.Add(veiculo);
            ctx.SaveChanges();
            Mensagens msg = new Mensagens("Aviso");
            msg.MsgInfirmacao("Salvo com sucesso!!");
            btCancelar_Click(sender, e);
        }
    }
}
