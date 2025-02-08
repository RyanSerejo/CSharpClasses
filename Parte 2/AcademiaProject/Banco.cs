using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;//*
using System.Data;
using System.Windows.Forms;//*Esses importes foram adicionados depois da criação
namespace AcademiaProject
{
    class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=C:\\Users\\Ryan\\Documents\\C#\\CSharpClasses\\Parte 2\\AcademiaProject\\banco\\banco_academia.db");
            conexao.Open();
            return conexao;
        }

        public static DataTable GetAllUsers() {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_users";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da .Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex) {
                ConexaoBanco().Close();
                throw ex;
            }
        }

        public static DataTable Consulta(string sql) {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }
        
        ////Funções do Form F_NovoUsuario
        public static void NovoUsuario(Usuario u)
        {
            
            if (existeUsername(u)) {
                MessageBox.Show("Username já existe.");
                return;
            }

            try
            {
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_users (T_NAME, T_USERNAME, T_PASSWORD, T_STATUS, N_USERLEVEL) VALUES (@nome, @username, @senha, @status, @nivel)";
                cmd.Parameters.AddWithValue("@nome", u.nome);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@senha", u.senha);
                cmd.Parameters.AddWithValue("@status", u.status);
                cmd.Parameters.AddWithValue("@nivel", u.nivel);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Novo usuário inserido");
                ConexaoBanco().Close();
            }
            catch (Exception ex) {
                MessageBox.Show("Erro ao gravar novo usuário");
                ConexaoBanco().Close();
            }
        }


        ////Fim FUnções do form F_NovoUsuario
        
        
        ////Rotinas Gerais
        public static bool existeUsername(Usuario u)
        {
            bool res;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT T_USERNAME FROM tb_users WHERE T_USERNAME='"+u.username+"'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill (dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }else
            {
                res = false;
            }
            
            return res;
        }


    }
}
