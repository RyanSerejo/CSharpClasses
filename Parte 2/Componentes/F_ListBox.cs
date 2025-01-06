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
    public partial class F_ListBox : Form
    {   

        List<string> carros = new List<string>();
        public F_ListBox()
        {
            InitializeComponent();
            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");

            lb_carros.DataSource = carros;

        }

         public void AttList(ListBox lb, List<string>l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (tb_typedcar.Text == "")
            {
                MessageBox.Show("Digite um carro");
            }
            else {
                carros.Add(tb_typedcar.Text);
                tb_typedcar.Clear();
                AttList(lb_carros, carros);
                
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                carros.RemoveAt(lb_carros.SelectedIndex);
                AttList(lb_carros, carros);
            }
            catch{
                MessageBox.Show("Não foi possível remover item");
            }

        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            try
            {
                tb_typedcar.Text = carros[lb_carros.SelectedIndex];

            } catch {
                MessageBox.Show("Carro selecionado inválido");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            carros.Clear();
            AttList(lb_carros, carros);

        }
    }
}
