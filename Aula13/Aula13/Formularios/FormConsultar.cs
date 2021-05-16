using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula13.RegrasDeNegocio;
using Aula13.Contexto;

namespace Aula13.Formularios
{
    public partial class FormConsultar : Form
    {
        List<Candidato> listaCandidato = Context.ListaCandidatos;
        public FormConsultar()
        {
            InitializeComponent();
            bindingSource1.DataSource = listaCandidato;
            CbPesquisa.DisplayMember = "Nome";
            CbPesquisa.SelectedIndex = -1;
        }

        private void FormConsultar_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Candidato objCand = new Candidato();
            objCand = listaCandidato.ToList().ElementAt(bindingSource1.Position);
            EdeNumIns.Text = Convert.ToString(objCand.NumInsc);
            EdNome.Text = objCand.Nome;
            EdNota.Text = objCand.Nota.ToString();
            EdSituacao.Text = objCand.Situacao.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EdSituacao.Clear();
            EdNota.Clear();
            EdNome.Clear();
            EdeNumIns.Clear();
            CbPesquisa.SelectedIndex = -1;
            CbPesquisa.Focus();
        }
    }
}
