using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarias;
using Aula13.Contexto;
using Aula13.RegrasDeNegocio;

namespace Aula13.Formularios
{
    public partial class FormCadastrar : Form
    {
        public FormCadastrar()
        {
            InitializeComponent();
            EdNumInscricao.Text = Convert.ToString((Context.Id + 1)+122);
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            EdNome.Clear();
            EdNota.Clear();
            EdNumInscricao.Clear();
            EdNome.Select();
            EdNumInscricao.Text = Convert.ToString((Context.Id + 1) + 122);
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            Mensagens msg = new Mensagens("ADS");
            Candidato objCandidato = new Candidato();
            objCandidato.Nome = EdNome.Text;
            objCandidato.Nota = Convert.ToDouble(EdNota.Text);
            objCandidato.NumInsc = Convert.ToInt32(EdNumInscricao.Text);
            Context.Id++;
            objCandidato.Id = Context.Id;
            Context.ListaCandidatos.Add(objCandidato);
            msg.MsgInfirmacao("ARMAZENADO COM SUCESSO");
            BtCancelar_Click(sender, e);
        }
    }
}
