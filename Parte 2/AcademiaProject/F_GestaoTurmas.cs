﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace AcademiaProject
{
    public partial class F_GestaoTurmas: Form
    {
        string idSelecionado;
        int modo = 1;// 1 = Edição 2 = inserção
        string vqueryDGV;
        public F_GestaoTurmas()
        {
            InitializeComponent();
        }

        private void F_GestaoTurmas_Load(object sender, EventArgs e)
        {
             vqueryDGV = @"
                SELECT 
                    tbt.N_IDTURMA as 'ID',
                    tbt.T_DSCTURMA as 'Turma',
                    tbh.T_DSCHORARIO as 'Horário'
                FROM
                    tb_turmas as tbt
                INNER JOIN
                    tb_horarios as tbh on tbh.N_IDHORARIO = tbt.N_IDHORARIO 
                ";
            dgv_turmas.DataSource = Banco.dql(vqueryDGV);
            dgv_turmas.Columns[0].Width = 40;
            dgv_turmas.Columns[1].Width = 120;
            dgv_turmas.Columns[2].Width = 85;

            //Popular comboBox Professores
            string vqueryProfessores = @"
                SELECT 
                    N_IDPROFESSOR,
                    T_NOMEPROFESSOR
                FROM
                    tb_professores
                ORDER BY
                    N_IDPROFESSOR
            ";
            cb_professor.Items.Clear();
            cb_professor.DataSource = Banco.dql(vqueryProfessores);
            cb_professor.DisplayMember = "T_NOMEPROFESSOR";
            cb_professor.ValueMember = "N_IDPROFESSOR";

            //Popular comboBox Status
            Dictionary<string, string> st = new Dictionary<string, string>();
            st.Add("A", "Ativa");
            st.Add("P", "Paralisada");
            st.Add("C", "Cancelada");
            cb_status.Items.Clear();
            cb_status.DataSource = new BindingSource(st, null);
            cb_status.DisplayMember = "Value";
            cb_status.ValueMember = "Key";

            //Popular comboBox Horarios
            string vqueryHorarios = @"
                SELECT 
                    *
                FROM
                    tb_horarios
                ORDER BY
                    T_DSCHORARIO
            ";
            cb_horario.Items.Clear();
            cb_horario.DataSource = Banco.dql(vqueryHorarios);
            cb_horario.DisplayMember = "T_DSCHORARIO";
            cb_horario.ValueMember = "N_IDHORARIO";


        }

        private void dgv_turmas_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int countLine = dgv.SelectedRows.Count;
            if(countLine > 0){
                idSelecionado = dgv_turmas.Rows[dgv_turmas.SelectedRows[0].Index].Cells[0].Value.ToString();
                string vqueryCampos = @"
                SELECT 
                    T_DSCTURMA,
                    N_IDPROFESSOR,
                    N_IDHORARIO,
                    N_MAXALUNOS,
                    T_STATUS
                FROM
                    tb_turmas
                WHERE
                    N_IDTURMA="+ idSelecionado;
                DataTable dt = Banco.dql(vqueryCampos);
                tb_dscTurma.Text = dt.Rows[0].Field<string>("T_DSCTURMA");
                cb_professor.SelectedValue = dt.Rows[0].Field<Int64>("N_IDPROFESSOR").ToString();
                n_maxAlunos.Value = dt.Rows[0].Field<Int64>("N_MAXALUNOS");
                cb_status.SelectedValue = dt.Rows[0].Field<string>("T_STATUS");
                cb_horario.SelectedValue = dt.Rows[0].Field<Int64>("N_IDHORARIO");
                tb_vagas.Text = CalcVagas();

            }
        }

        private void btn_novaTurma_Click(object sender, EventArgs e)
        {
            tb_dscTurma.Clear();
            cb_professor.SelectedIndex = -1;
            n_maxAlunos.Value = 0;
            cb_status.SelectedIndex = -1;
            cb_horario.SelectedIndex = -1;
            modo = 2;
            
        }

        private void btn_salvarEdicoes_Click(object sender, EventArgs e)
        {
            int linha = dgv_turmas.SelectedRows[0].Index;
            string queryTurma = "";
            string msg = "";
            if (modo == 1)
            {
                queryTurma = String.Format(@"
            UPDATE
                tb_turmas
            SET
                T_DSCTURMA='{0}',
                N_IDPROFESSOR={1},
                N_IDHORARIO={2},
                N_MAXALUNOS={3},
                T_STATUS='{4}'
            WHERE
                N_IDTURMA={5}", tb_dscTurma.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString()), cb_status.SelectedValue, idSelecionado);
                msg = "Dados atualizados";
            }
            else
            {
                queryTurma = String.Format(@"
            INSERT INTO
                tb_turmas
                (T_DSCTURMA, N_IDPROFESSOR, N_IDHORARIO, N_MAXALUNOS, T_STATUS) VALUES ('{0}',{1},{2},{3},'{4}')", tb_dscTurma.Text, cb_professor.SelectedValue, cb_horario.SelectedValue, Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString()), cb_status.SelectedValue);
                msg = "Dados inseridos";
            }
            Banco.dml(queryTurma);
            if(modo == 1)
            {
                dgv_turmas[1, linha].Value = tb_dscTurma.Text;
                dgv_turmas[2, linha].Value = cb_horario.Text;
                tb_vagas.Text = CalcVagas();
            }else
            {
                dgv_turmas.DataSource = Banco.dql(vqueryDGV);
            }
            
            MessageBox.Show(msg);
        }

        private string CalcVagas()
        {
            //Calculo de vagas
            string queryVagas = String.Format(@"
            SELECT
                count(N_IDALUNO) as 'countVagas'
            FROM
                tb_alunos
            WHERE
                T_STATUS='A' and N_IDTURMA={0}", idSelecionado);

            DataTable dt = Banco.dql(queryVagas);
            int vagas = Int32.Parse(Math.Round(n_maxAlunos.Value, 0).ToString());
            vagas -= Int32.Parse(dt.Rows[0].Field<Int64>("countVagas").ToString());
            return vagas.ToString();
        }

        private void btn_excluirTurma_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseja mesmo excluir Turma?", "Excluir?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string queryExcluirTurma = String.Format(@"
                DELETE
                FROM
                    tb_turmas
                WHERE
                    N_IDTURMA={0}", idSelecionado);
                Banco.dml(queryExcluirTurma);
                dgv_turmas.Rows.Remove(dgv_turmas.CurrentRow);
            }
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_imprimirTurma_Click(object sender, EventArgs e)
        {
            string nomeArquivo = Globais.caminho + @"\turmas.pdf";
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);


            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Globais.caminho + @"\logo.jpeg");
            logo.ScaleToFit(140f, 120f);
            logo.Alignment = Element.ALIGN_LEFT;
            
            string dados = "";
            Paragraph paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo1.Alignment = Element.ALIGN_CENTER;
            paragrafo1.Add("Gym Project\n");
           

            Paragraph paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 20, (int)System.Drawing.FontStyle.Bold));
            paragrafo2.Alignment = Element.ALIGN_LEFT;
            paragrafo2.Add("Relatório de Turmas\n\n");

            //adiconando a tabela
            PdfPTable tabela = new PdfPTable(3);// 3 colunas
            tabela.DefaultCell.FixedHeight = 20;

            /*PdfPCell celula1 = new PdfPCell();
            celula1.Colspan = 3;//Linha 1 mesclada
            //celula.Rotation = 90;
            celula1.AddElement(logo);
            tabela.AddCell(celula1);
            */

            tabela.AddCell("ID Turma");
            tabela.AddCell("Turma");
            tabela.AddCell("Horário");

            DataTable dtTurmas = Banco.dql(vqueryDGV);
            for (int i = 0; i < dtTurmas.Rows.Count; i++)
            {
                tabela.AddCell(dtTurmas.Rows[i].Field<Int64>("ID").ToString());
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Turma"));
                tabela.AddCell(dtTurmas.Rows[i].Field<string>("Horário"));

            }

            doc.Open();
            doc.Add(logo);
            doc.Add(paragrafo1);
            doc.Add(paragrafo2);
            doc.Add(tabela);
            doc.Close();

        }
    }
}
