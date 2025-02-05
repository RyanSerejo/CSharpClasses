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
    public partial class F_Login : Form
    {
        Form1 form1;
        DataTable dt = new DataTable();
        public F_Login(Form1 f)
        {
            InitializeComponent();
            form1 = f;

        }

        private void btn_logar_Click(object sender, EventArgs e)
        {
            string username = tb_username.Text;
            string password = tb_password.Text; 

            if (username == "" || password == "")
            {
                MessageBox.Show("Usuário ou senha inválidos");
                tb_username.Focus();
                return;
            }
            string sql = "SELECT * FROM tb_users WHERE T_USERNAME='"+username+"' AND T_PASSWORD='"+password+"'";
            dt = Banco.Consulta(sql);
            if (dt.Rows.Count == 1)
            {
                form1.lb_acesso.Text = dt.Rows[0].ItemArray[5].ToString();
                form1.lb_nomeUsuario.Text = dt.Rows[0].Field<string>("T_USERNAME");
                form1.pb_ledLogado.Image = Properties.Resources.greenLed;
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("N_USERLEVEL").ToString());//transformou primeiro em string, e então para int;
                Globais.logado = true;
                this.Close();
            }
            else {
                MessageBox.Show("Usuário não encontrado.");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
