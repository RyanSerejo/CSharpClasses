using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_MaskedTextBox : Form
    {
        public F_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {

            if (cb_somenteTexto.Checked)
            {
                mtb_cep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            }
            else {
                mtb_cep.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            string msg = mtb_cep.Text;
            MessageBox.Show(msg);
        }

        private void cb_mostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            string vazio = "";
            if (cb_mostrarSenha.Checked)
            {
                mtb_senha.PasswordChar = vazio;
            }
        }
    }
}
