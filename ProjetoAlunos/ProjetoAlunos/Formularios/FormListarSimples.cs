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


namespace ProjetoAlunos.Formularios
{
    public partial class FormListarSimples : Form
    {
        public FormListarSimples()
        {
            InitializeComponent();
            ConexaoContext ctx = new ConexaoContext();
            bindingSource1.DataSource = ctx.ListaSimples.ToList();
            GridAlunos.DataSource = bindingSource1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GridAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
