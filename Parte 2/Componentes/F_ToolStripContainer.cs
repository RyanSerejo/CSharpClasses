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
    public partial class F_ToolStripContainer : Form
    {
        public F_ToolStripContainer()
        {
            InitializeComponent();
        }

        private void F_ToolStripContainer_Load(object sender, EventArgs e)
        {
            List<ToolStrip> list = new List<ToolStrip>();
            int num = toolStripContainer1.TopToolStripPanel.Controls.Count;

            for (int i = 0; i < num; i++) {
                checkedListBox1.Items.Add(toolStripContainer1.TopToolStripPanel.Controls[i].Name);
                checkedListBox1.SetItemChecked(i, true);

            }
            //Tstrip_1.Visible = list[1].Visible;
           //Tstrip_2.Visible = list[2].Visible;
        }
        private void barrasDeFerramentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.Visible == true )
            {
                checkedListBox1.Visible = false;
            }
            else {
                checkedListBox1.Visible = true;
            }
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }
    }
}
