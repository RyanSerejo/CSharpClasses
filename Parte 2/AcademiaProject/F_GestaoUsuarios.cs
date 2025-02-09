using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaProject
{
    public partial class F_GestaoUsuarios : Form
    {
        public F_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void F_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            dgv_usuarios.DataSource = Banco.GetUserIdName();
            dgv_usuarios.Columns[0].Width = 90;
            dgv_usuarios.Columns[1].Width = 190;

        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgv_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int countLines  = dgv.SelectedRows.Count;
            if (countLines > 0) {
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = Banco.GetUserData(vid);
                tb_id.Text = dt.Rows[0].Field<Int64>("N_ID").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("T_NAME").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("T_USERNAME").ToString();
                tb_senha.Text = dt.Rows[0].Field<string>("T_PASSWORD").ToString();
                cb_status.Text = dt.Rows[0].Field<string>("T_STATUS").ToString();
                n_nivel.Value = dt.Rows[0].Field<Int64>("N_USERLEVEL");
            }

        }
    }
}
