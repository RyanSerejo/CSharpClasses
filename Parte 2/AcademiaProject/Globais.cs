using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaProject
{
    class Globais
    {
        public static string versao = "1.0";
        public static Boolean logado = false;
        public static int nivel = 0;
        //public static string caminho = System.Environment.CurrentDirectory;
        public static string caminho = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
        public static string nomeBanco = "banco_academia.db";
        public static string caminhoBanco = caminho + @"\banco\";
        public static string caminhoFotos = caminho + @"\fotos\";


        /*
        N_ID
        T_NAME
        T_USERNAME
        T_PASSWORD
        T_STATUS
        N_USERLEVEL
         */

        /*
         SELECT 
            tbt.n_idturma AS 'ID Turma', 
            tbt.t_dscturma AS 'Desc. Turma', 
            tbt.n_maxalunos AS 'Máx. Alunos', 
            tbh.t_dschorario AS 'Horário', 
            tbp.t_nomeprofessor AS 'Professor', 
            CASE 
                WHEN tbt.T_STATUS = 'A' THEN 'Ativa'
                WHEN tbt.T_STATUS = 'P' THEN 'Paralisada'
                WHEN tbt.T_STATUS = 'C' THEN 'Cancelada'
            END as 'Status'
        FROM 
            tb_turmas AS tbt
        INNER JOIN 
            tb_horarios AS tbh ON tbh.n_idhorario = tbt.n_idhorario
        INNER JOIN 
            tb_professores AS tbp ON tbp.n_idprofessor = tbt.n_idprofessor
         */
    }
}
