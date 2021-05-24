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
            //https://www.freepik.com/vectors/school School vector created by pch.vector - www.freepik.com
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            Aluno A = new Aluno();
            A.Nome = edNome.Text;
            A.Nota1Bim = Convert.ToDouble(edNota1.Text);
            A.Nota2Bim = Convert.ToDouble(edNota2.Text);
            A.DataNasc = dateTimePicker1.Value;

            ConexaoContext ctx = new ConexaoContext();
            ctx.ListaSimples.Add(A);
            ctx.SaveChanges();
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
