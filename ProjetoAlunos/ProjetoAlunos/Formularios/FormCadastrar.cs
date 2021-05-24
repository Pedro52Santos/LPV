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
using ProjetoAlunos.RegrasdeNegocio;
using Utilitarias;


namespace ProjetoAlunos.Formularios
{
    public partial class FormCadastrar : Form
    {
       
        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Aluno objAluno = new Aluno();
            objAluno.Nome = edNome.Text;
            objAluno.Nota1Bim = Convert.ToDouble(edNota1.Text);
            objAluno.Nota2Bim = Convert.ToDouble(edNota2.Text);
            objAluno.DataNasc = dateTimePicker1.Value;


            ConexaoContext conexao = new ConexaoContext();
            conexao.ListaSimples.Add(objAluno);
            conexao.SaveChanges();
            Mensagens mensagens = new Mensagens("Aviso");
            mensagens.MsgInfirmacao("Salvo com sucesso!!");
            btLimpar_Click(sender, e);

        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            edNome.Clear();
            edNota1.Clear();
            edNota2.Clear();
        }
    }
}
