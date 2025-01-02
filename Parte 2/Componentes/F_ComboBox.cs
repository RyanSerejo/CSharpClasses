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
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_showSelected_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_veiculos.Text);
        }

        private void btn_clearElements_Click(object sender, EventArgs e)
        {
            cb_veiculos.Items.Clear();
            cb_veiculos.Text = string.Empty;
        }

        private void btn_resetElements_Click(object sender, EventArgs e)
        {
            cb_veiculos.Items.Clear();
            cb_veiculos.Items.Add("Carro");
            cb_veiculos.Items.Add("Avião");
            cb_veiculos.Items.Add("Navio");
            cb_veiculos.Items.Add("Ônibus");
            cb_veiculos.Items.Add("Trem");

        }

        private void btn_addVeiculo_Click(object sender, EventArgs e)
        {
            if (tb_typedVeiculo.Text != "")
            {
               if(cb_veiculos.FindString(tb_typedVeiculo.Text) < 0)
                {
                    cb_veiculos.Items.Add(tb_typedVeiculo.Text.ToString());
                    MessageBox.Show("Veículo adicionado");
                } else
                {
                    MessageBox.Show("Veículo já está na lista");
                }
                tb_typedVeiculo.Text = string.Empty;
                tb_typedVeiculo.Focus();
            }
        }
    }
}
