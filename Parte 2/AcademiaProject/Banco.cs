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
    }
}
