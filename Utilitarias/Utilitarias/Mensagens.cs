using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilitarias
{
    public class Mensagens
    {
        private string titulo;
        public Mensagens(string titulo)
        {
            this.titulo = titulo;
        }

        public void MsgAlerta(string mensagem)
        {
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void MsgInfirmacao(string mensagem)
        {
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MsgErro(string mensagem)
        {
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public string MsgPergunta(string pergunta)
        {
            DialogResult resposta = MessageBox.Show(pergunta, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resposta.ToString();
        }
    }
}
