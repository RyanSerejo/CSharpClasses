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
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_showSelected_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (string t in clb_tranportes.CheckedItems) { 
                txt += t + ", ";
            }
          
            MessageBox.Show(txt);

        }

        private void btn_clearList_Click(object sender, EventArgs e)
        {
            clb_tranportes.Items.Clear();
        }

        private void btn_resetList_Click(object sender, EventArgs e)
        {
            clb_tranportes.Items.Clear();
            //da pra adicionar itens com:
            //clb_transportes.Items.Add("Nome", (true or false, para checked ou não))
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");
            clb_tranportes.Items.AddRange(tr.ToArray());
        }

        private void btn_addNewTransp_Click(object sender, EventArgs e)
        {
            clb_tranportes.Items.Add(tb_novoTransp.Text);
            tb_novoTransp.Clear();
            tb_novoTransp.Focus();
        }
    }
}
