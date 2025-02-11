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

        private void btn_novo_Click(object sender, EventArgs e)
        {
            F_NovoUsuario f_NovoUsuario = new F_NovoUsuario();
            f_NovoUsuario.ShowDialog();
            dgv_usuarios.DataSource = Banco.GetUserIdName();

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            int line = dgv_usuarios.SelectedRows[0].Index;

            Usuario u = new Usuario();
            u.id = Convert.ToInt32(tb_id.Text);
            u.nome = tb_nome.Text;
            u.username = tb_username.Text;
            u.senha = tb_senha.Text;
            u.status = cb_status.Text;
            u.nivel = Convert.ToInt32(Math.Round(n_nivel.Value,0));
            Banco.AttUser(u);
            //dgv_usuarios.DataSource = Banco.GetUserIdName();
            //dgv_usuarios.CurrentCell = dgv_usuarios[0, line];
            dgv_usuarios[1, line].Value = tb_nome.Text;
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo excluir Usuário?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) { 
                Banco.DeleteUser(tb_id.Text);
                dgv_usuarios.Rows.Remove(dgv_usuarios.CurrentRow);
            }
        }
    }
}
