using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula13.Formularios;
using Aula13.Contexto;
using Aula13.RegrasDeNegocio;

namespace Aula13.Formularios
{
    public partial class FormListar : Form
    {
        List<Candidato> ListaCandidatos = Context.ListaCandidatos;
        public FormListar()
        {
            InitializeComponent();
            bindingSource1.DataSource = ListaCandidatos;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = bindingSource1;
            
        }

    }
}
