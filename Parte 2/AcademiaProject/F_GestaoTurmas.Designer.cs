﻿namespace AcademiaProject
{
    partial class F_GestaoTurmas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_turmas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_imprimirTurma = new System.Windows.Forms.Button();
            this.btn_novaTurma = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_salvarEdicoes = new System.Windows.Forms.Button();
            this.btn_excluirTurma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_professor = new System.Windows.Forms.ComboBox();
            this.cb_horario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.n_maxAlunos = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_dscTurma = new System.Windows.Forms.TextBox();
            this.tb_vagas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_maxAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_turmas
            // 
            this.dgv_turmas.AllowUserToAddRows = false;
            this.dgv_turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turmas.EnableHeadersVisualStyles = false;
            this.dgv_turmas.Location = new System.Drawing.Point(12, 12);
            this.dgv_turmas.MultiSelect = false;
            this.dgv_turmas.Name = "dgv_turmas";
            this.dgv_turmas.ReadOnly = true;
            this.dgv_turmas.RowHeadersVisible = false;
            this.dgv_turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_turmas.Size = new System.Drawing.Size(339, 427);
            this.dgv_turmas.TabIndex = 15;
            this.dgv_turmas.SelectionChanged += new System.EventHandler(this.dgv_turmas_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_imprimirTurma);
            this.panel1.Controls.Add(this.btn_novaTurma);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_salvarEdicoes);
            this.panel1.Controls.Add(this.btn_excluirTurma);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 444);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 35);
            this.panel1.TabIndex = 16;
            // 
            // btn_imprimirTurma
            // 
            this.btn_imprimirTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimirTurma.Location = new System.Drawing.Point(398, 5);
            this.btn_imprimirTurma.Name = "btn_imprimirTurma";
            this.btn_imprimirTurma.Size = new System.Drawing.Size(122, 27);
            this.btn_imprimirTurma.TabIndex = 9;
            this.btn_imprimirTurma.Text = "Imprimir Turma";
            this.btn_imprimirTurma.UseVisualStyleBackColor = true;
            this.btn_imprimirTurma.Click += new System.EventHandler(this.btn_imprimirTurma_Click);
            // 
            // btn_novaTurma
            // 
            this.btn_novaTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novaTurma.Location = new System.Drawing.Point(12, 5);
            this.btn_novaTurma.Name = "btn_novaTurma";
            this.btn_novaTurma.Size = new System.Drawing.Size(123, 27);
            this.btn_novaTurma.TabIndex = 6;
            this.btn_novaTurma.Text = "Nova Turma";
            this.btn_novaTurma.UseVisualStyleBackColor = true;
            this.btn_novaTurma.Click += new System.EventHandler(this.btn_novaTurma_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(526, 5);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(122, 27);
            this.btn_fechar.TabIndex = 10;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_salvarEdicoes
            // 
            this.btn_salvarEdicoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvarEdicoes.Location = new System.Drawing.Point(141, 5);
            this.btn_salvarEdicoes.Name = "btn_salvarEdicoes";
            this.btn_salvarEdicoes.Size = new System.Drawing.Size(123, 27);
            this.btn_salvarEdicoes.TabIndex = 7;
            this.btn_salvarEdicoes.Text = "Salvar edições";
            this.btn_salvarEdicoes.UseVisualStyleBackColor = true;
            this.btn_salvarEdicoes.Click += new System.EventHandler(this.btn_salvarEdicoes_Click);
            // 
            // btn_excluirTurma
            // 
            this.btn_excluirTurma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluirTurma.Location = new System.Drawing.Point(270, 5);
            this.btn_excluirTurma.Name = "btn_excluirTurma";
            this.btn_excluirTurma.Size = new System.Drawing.Size(122, 27);
            this.btn_excluirTurma.TabIndex = 8;
            this.btn_excluirTurma.Text = "Excluir Turma";
            this.btn_excluirTurma.UseVisualStyleBackColor = true;
            this.btn_excluirTurma.Click += new System.EventHandler(this.btn_excluirTurma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Professor";
            // 
            // cb_professor
            // 
            this.cb_professor.FormattingEnabled = true;
            this.cb_professor.Location = new System.Drawing.Point(360, 68);
            this.cb_professor.Name = "cb_professor";
            this.cb_professor.Size = new System.Drawing.Size(288, 21);
            this.cb_professor.TabIndex = 2;
            // 
            // cb_horario
            // 
            this.cb_horario.FormattingEnabled = true;
            this.cb_horario.Location = new System.Drawing.Point(360, 189);
            this.cb_horario.Name = "cb_horario";
            this.cb_horario.Size = new System.Drawing.Size(288, 21);
            this.cb_horario.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Horário";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(505, 131);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(143, 21);
            this.cb_status.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Status";
            // 
            // n_maxAlunos
            // 
            this.n_maxAlunos.Location = new System.Drawing.Point(360, 131);
            this.n_maxAlunos.Name = "n_maxAlunos";
            this.n_maxAlunos.Size = new System.Drawing.Size(119, 20);
            this.n_maxAlunos.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Máximo de alunos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nome Turma";
            // 
            // tb_dscTurma
            // 
            this.tb_dscTurma.Location = new System.Drawing.Point(359, 25);
            this.tb_dscTurma.Name = "tb_dscTurma";
            this.tb_dscTurma.Size = new System.Drawing.Size(289, 20);
            this.tb_dscTurma.TabIndex = 27;
            // 
            // tb_vagas
            // 
            this.tb_vagas.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_vagas.Location = new System.Drawing.Point(359, 244);
            this.tb_vagas.Name = "tb_vagas";
            this.tb_vagas.ReadOnly = true;
            this.tb_vagas.Size = new System.Drawing.Size(120, 20);
            this.tb_vagas.TabIndex = 29;
            this.tb_vagas.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(357, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Vagas";
            // 
            // F_GestaoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 479);
            this.Controls.Add(this.tb_vagas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_dscTurma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.n_maxAlunos);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_horario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_professor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_turmas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Turmas";
            this.Load += new System.EventHandler(this.F_GestaoTurmas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turmas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.n_maxAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_turmas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_novaTurma;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_salvarEdicoes;
        private System.Windows.Forms.Button btn_excluirTurma;
        private System.Windows.Forms.Button btn_imprimirTurma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_professor;
        private System.Windows.Forms.ComboBox cb_horario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown n_maxAlunos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_dscTurma;
        private System.Windows.Forms.TextBox tb_vagas;
        private System.Windows.Forms.Label label6;
    }
}