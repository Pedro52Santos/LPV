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
    public partial class FormListarCompleto : Form
    {
        public FormListarCompleto()
        {
            InitializeComponent();
            ConexaoContext ctx = new ConexaoContext();
            bindingSource1.DataSource = ctx.ListaCompleta();
            GridAlunos.DataSource = bindingSource1.DataSource;
        }
    }
}
