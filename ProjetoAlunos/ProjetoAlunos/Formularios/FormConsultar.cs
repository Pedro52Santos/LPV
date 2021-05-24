using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAlunos.Context;
using ProjetoAlunos.Consultas;

namespace ProjetoAlunos.Formularios
{
    public partial class FormConsultar : Form
    {
        ConexaoContext ctx = new ConexaoContext();
        public FormConsultar()
        {
            InitializeComponent();
            bindingSource1.DataSource = ctx.ListaCompleta();
            cbNome.DataSource = bindingSource1;
            cbNome.DisplayMember = "nome";
            cbNome.SelectedIndex = -1;
            cbNome.Select();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            ConsultaAluno consultaAluno = new ConsultaAluno();
            consultaAluno = ctx.ListaCompleta().ElementAt(bindingSource1.Position);
            edNota1.Text = consultaAluno.Nota1b.ToString();
            EdNota2.Text = consultaAluno.Nota2b.ToString();
            edMedia.Text = consultaAluno.Media.ToString();
            edIdade.Text = consultaAluno.Idade.ToString();
            edSituacao.Text = consultaAluno.Situacao;

        }

        private void edNota1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            cbNome.SelectedIndex = -1;
            edNota1.Clear();
            EdNota2.Clear();
            edMedia.Clear();
            edIdade.Clear();
            edSituacao.Clear();
        }
    }
}
