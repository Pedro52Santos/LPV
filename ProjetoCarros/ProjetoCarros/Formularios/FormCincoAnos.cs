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
    public partial class FormCincoAnos : Form
    {
        public FormCincoAnos()
        {
            InitializeComponent();
            ConexaoContext ctx = new ConexaoContext();
            bindingSource1.DataSource = ctx.ListaMaisDeCincoAnos();
            gridVeiculos.DataSource = bindingSource1.DataSource;
        }
    }
}
