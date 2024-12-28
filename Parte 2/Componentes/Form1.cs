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
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um valor");
                tb_veiculo.Focus();
                return;
            }

            tb_listaVeiculo.Text += tb_veiculo.Text + ", ";
            // tb.listaVeiculo.Text = tb.listaVeiculo + tb_veiculo.Text;
            tb_veiculo.Clear();
            tb_listaVeiculo.Focus();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_listaVeiculo.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }
    }
}
