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
    public partial class FormListarSimples : Form
    {
        public FormListarSimples()
        {
            InitializeComponent();
            ConexaoContext ctx = new ConexaoContext();
            bindSListaVeiculo.DataSource = ctx.ListaSimplesVeiculo.ToList();
            gridVeiculos.DataSource = bindSListaVeiculo;
        }
    }
}
