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
    public partial class F_ListView : Form
    {
        public F_ListView()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            tb_id.Clear();
            tb_produto.Clear();
            tb_qtde.Clear();
            tb_preco.Clear();
        }

        private void Obter()
        {
            tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
            tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
            tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
            tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                MessageBox.Show("ID não pode estar vazio");
                tb_id.Focus();
                return;
            }

            string[] pr = new string[4];
            pr[0] = tb_id.Text;
            pr[1] = tb_produto.Text;
            pr[2] = tb_qtde.Text;
            pr[3] = tb_preco.Text;

            ListViewItem l = new ListViewItem(pr);
            lv_produtos.Items.Add(l);
            Limpar();
            
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);

            }
            catch {
                MessageBox.Show("Impossível remover");
            }
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            Obter();
        }

        private void lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_produtos.SelectedIndices.Count > 0) {
                Obter();
            }
            
        }
    }
}
