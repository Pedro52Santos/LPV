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

namespace ProjetoCarros.Formularios
{
    public partial class FormListarGeral : Form
    {
        public FormListarGeral()
        {
            InitializeComponent();
            ConexaoContext ctx = new ConexaoContext();
            bindingSource1.DataSource = ctx.ListaPessonalizadaVeiculo();
            gridGeral.DataSource = bindingSource1.DataSource;   
        }
    }
}
