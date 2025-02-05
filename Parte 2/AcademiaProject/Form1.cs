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
    }
}
