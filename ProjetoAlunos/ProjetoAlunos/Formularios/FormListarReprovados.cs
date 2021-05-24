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
    public partial class FormListarReprovados : Form
    {
        public FormListarReprovados()
        {
            InitializeComponent();
            ConexaoContext ctx = new ConexaoContext();
            bindingSource1.DataSource = ctx.ListaReprovados();
            GridAlunos.DataSource = bindingSource1.DataSource;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //'https://www.freepik.com/vectors/people' People vector created by pch.vector
        }
    }
}
