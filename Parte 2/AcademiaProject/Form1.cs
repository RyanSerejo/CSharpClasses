using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
        }

        private void lOGONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
        }

        private void lOGOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lb_acesso.Text = "0";
            lb_nomeUsuario.Text = "---";
            pb_ledLogado.Image = Properties.Resources.redLed;
            Globais.nivel = 0;
            Globais.logado = false;
            
        }

        private void bancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if(Globais.nivel >= 2)
                {

                }
                else
                { 
                MessageBox.Show("Acesso não permitido.");

                }
            }
            else {
                MessageBox.Show("É necessário ter um usuário logado.");
            }

        }

        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {
                    F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
                    f_NovoUsuario.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Acesso não permitido.");

                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado.");
            }
        }

        private void gestãoDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                if (Globais.nivel >= 1)
                {

                }
                else
                {
                    MessageBox.Show("Acesso não permitido.");

                }
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado.");
            }
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Globais.logado)
            {
                
            }
            else
            {
                MessageBox.Show("É necessário ter um usuário logado.");
            }
        }
    }
}
