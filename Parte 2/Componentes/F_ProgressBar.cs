using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Componentes
{
    public partial class F_ProgressBar : Form
    {
        public F_ProgressBar()
        {
            InitializeComponent();
        }

        private void btn_definir_Click(object sender, EventArgs e)
        {
            int text1 = int.Parse(textbox1.Text);
            if (text1 >= progressBar1.Minimum & text1 <= progressBar1.Maximum)
            {
                progressBar1.Value = text1;
            }
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            int text2 = int.Parse(textBox2.Text);
            progressBar1.Value = 0;
            progressBar1.Maximum = text2;
            for (int i = 0; i <= text2; i++) {
                label1.Text = i.ToString();
                label1.Refresh();// Atualiza o valor em tempo de execução   
                progressBar1.Value = i;
               
                //Thread.Sleep(200);
            }
        }
    }
}
