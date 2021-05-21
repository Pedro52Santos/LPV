using ProjetoCarros.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCarros.Formularios
{
    public partial class FormUsados : Form
    {
        public FormUsados()
        {
            InitializeComponent();
            ConexaoContext ctx = new ConexaoContext();
            bindingSource1.DataSource = ctx.ListaUsados();
            gridGeral.DataSource = bindingSource1.DataSource;
        }
    }
}
