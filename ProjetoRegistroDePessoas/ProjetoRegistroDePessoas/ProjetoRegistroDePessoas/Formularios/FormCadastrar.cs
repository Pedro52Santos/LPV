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
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            edNome.Clear();
            edNasc.Clear();
            edTel.Clear();
            edCpf.Clear();
            edNome.Select();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
           
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = edNome.Text;
            pessoa.Cpf = edCpf.Text;
            pessoa.DataNasc = Convert.ToDateTime(edNasc.Text);
            pessoa.Tel = edTel.Text;

            ContextBDPessoa ctx = new ContextBDPessoa();
            ctx.ListaDePessoas.Add(pessoa);
            ctx.SaveChanges();
            MessageBox.Show("Salvo com sucesso!!!");
            btCancelar_Click(sender, e);
        }
    }
}
