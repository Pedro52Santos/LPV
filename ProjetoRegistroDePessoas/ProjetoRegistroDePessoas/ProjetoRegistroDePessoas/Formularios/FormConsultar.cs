using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoRegistroDePessoas.RegrasDeNegocio;
using ProjetoRegistroDePessoas.Context;


namespace ProjetoRegistroDePessoas.Formularios
{
    public partial class FormConsultar : Form
    {
        ContextBDPessoa ctx = new ContextBDPessoa();
        public FormConsultar()
        {
            ContextBDPessoa ctx = new ContextBDPessoa();
            InitializeComponent();
            bindingSource1.DataSource = ctx.ListaDePessoas.ToList();
            cbPesquisa.DataSource = bindingSource1;
            cbPesquisa.DisplayMember = "Nome";
            cbPesquisa.SelectedIndex = -1;

        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p = ctx.ListaDePessoas.ToList().ElementAt(bindingSource1.Position);
            edNasc.Text = p.DataNasc.ToLongDateString();
            edNome.Text = p.Nome;
            edTel.Text = p.Tel;
            edCpf.Text = p.Cpf;
            edIdade.Text = Convert.ToString(p.DataNasc - DateTime.Now);
        }

        private void FormConsultar_Load(object sender, EventArgs e)
        {

        }
    }
}
