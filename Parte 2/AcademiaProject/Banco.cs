using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;//*
using System.Data;//*Esses importes foram adicionados depois da criação
namespace AcademiaProject
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source:C:\\Users\\Ryan\\Documents\\C#\\CSharpClasses\\Parte 2\\AcademiaProject\\banco\\banco_academia.db");
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
                    return dt;
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }
            
        
    }
}
