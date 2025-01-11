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
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            if(Decimal.Parse(tb_valor.Text) >= nupdown1.Minimum & Decimal.Parse(tb_valor.Text) <= nupdown1.Maximum)
            {
                nupdown1.Value = Decimal.Parse(tb_valor.Text);
            } else
            {
                MessageBox.Show("Número fora do alcance exigido.");
            }
        }
    }
}
