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
    public partial class F_CheckBox : Form
    {
        List<CheckBox> checkedBoxes = new List<CheckBox>();
        public F_CheckBox()
        {
            InitializeComponent();
            checkedBoxes.Add(cb_carro);
            checkedBoxes.Add(cb_aviao);
            checkedBoxes.Add(cb_navio);
            checkedBoxes.Add(cb_onibus);
        }

        private void btn_checkedTransp_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (CheckBox t in checkedBoxes) { 
                if (t.Checked)
                {
                    txt += t.Text + ", ";
                }
            }
            MessageBox.Show(txt);
        }

        private void cb_patinete_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_patinete.Checked){
            
                MessageBox.Show("Patinete marcado");
            
            }

        }
    }
}
