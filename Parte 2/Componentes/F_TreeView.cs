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
    public partial class F_TreeView : Form
    {
        public F_TreeView()
        {
            InitializeComponent();
        }

        private void Adicionar(string nomedoNo, string textdoNo)
        {
         
            TreeNode no1 = treeView1.Nodes.Add(nomedoNo.ToString());
            no1.Name = textdoNo.ToString();

        }


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox2.Clear();

            textBox1.Text = treeView1.SelectedNode.Text;

            if (treeView1.SelectedNode.Tag != null) { 
            textBox2.Text = treeView1.SelectedNode.Tag.ToString();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            TreeNode raizEstados = treeView1.Nodes.Add("Estados");
            raizEstados.Name = "RaizEstados";

            TreeNode raizCores = treeView1.Nodes.Add("Cores");
            raizCores.Name = "raizCores";

            TreeNode estado1 = raizEstados.Nodes.Add("Pará");
            estado1.Name = "estado1";

            TreeNode estado2 = raizEstados.Nodes.Add("São Paulo");
            estado1.Name = "estado2";

            TreeNode cor1 = raizCores.Nodes.Add("Azul");
            cor1.Name = "cor1";
            TreeNode cor2 = raizCores.Nodes.Add("Vermelho");
            cor1.Name = "cor2";

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_removeSelected_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);

            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao remover Nó.");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                treeView1.Nodes.Remove(treeView1.Nodes["raizEstados"]);
                treeView1.Nodes.Remove(treeView1.Nodes["raizCores"]);
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao remover.");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomedoNo = textBox1.Text;
            string textdoNO = textBox2.Text;
            Adicionar(nomedoNo, textdoNO);
        }
    }
}
