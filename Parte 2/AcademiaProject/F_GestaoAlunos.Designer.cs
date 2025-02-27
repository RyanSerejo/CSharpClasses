namespace AcademiaProject
{
    partial class F_GestaoAlunos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_alunos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_financeiro = new System.Windows.Forms.Button();
            this.btn_salvarEdicoes = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_excluirAluno = new System.Windows.Forms.Button();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_turmas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_alunos
            // 
            this.dgv_alunos.AllowUserToAddRows = false;
            this.dgv_alunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_alunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_alunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_alunos.EnableHeadersVisualStyles = false;
            this.dgv_alunos.Location = new System.Drawing.Point(12, 11);
            this.dgv_alunos.MultiSelect = false;
            this.dgv_alunos.Name = "dgv_alunos";
            this.dgv_alunos.ReadOnly = true;
            this.dgv_alunos.RowHeadersVisible = false;
            this.dgv_alunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_alunos.Size = new System.Drawing.Size(339, 427);
            this.dgv_alunos.TabIndex = 16;
            this.dgv_alunos.SelectionChanged += new System.EventHandler(this.dgv_alunos_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_financeiro);
            this.panel1.Controls.Add(this.btn_salvarEdicoes);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_excluirAluno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 31);
            this.panel1.TabIndex = 17;
            // 
            // btn_financeiro
            // 
            this.btn_financeiro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_financeiro.Location = new System.Drawing.Point(330, 3);
            this.btn_financeiro.Name = "btn_financeiro";
            this.btn_financeiro.Size = new System.Drawing.Size(157, 27);
            this.btn_financeiro.TabIndex = 8;
            this.btn_financeiro.Text = "Financeiro";
            this.btn_financeiro.UseVisualStyleBackColor = true;
            // 
            // btn_salvarEdicoes
            // 
            this.btn_salvarEdicoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvarEdicoes.Location = new System.Drawing.Point(4, 2);
            this.btn_salvarEdicoes.Name = "btn_salvarEdicoes";
            this.btn_salvarEdicoes.Size = new System.Drawing.Size(157, 27);
            this.btn_salvarEdicoes.TabIndex = 6;
            this.btn_salvarEdicoes.Text = "Salvar Edições";
            this.btn_salvarEdicoes.UseVisualStyleBackColor = true;
            this.btn_salvarEdicoes.Click += new System.EventHandler(this.btn_salvarEdicoes_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(493, 2);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(157, 27);
            this.btn_fechar.TabIndex = 9;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_excluirAluno
            // 
            this.btn_excluirAluno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_excluirAluno.Location = new System.Drawing.Point(167, 1);
            this.btn_excluirAluno.Name = "btn_excluirAluno";
            this.btn_excluirAluno.Size = new System.Drawing.Size(157, 27);
            this.btn_excluirAluno.TabIndex = 7;
            this.btn_excluirAluno.Text = "Excluir Aluno";
            this.btn_excluirAluno.UseVisualStyleBackColor = true;
            this.btn_excluirAluno.Click += new System.EventHandler(this.btn_excluirAluno_Click);
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(359, 27);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(291, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nome Turma";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Location = new System.Drawing.Point(360, 66);
            this.mtb_telefone.Mask = "(99)9999-9999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(127, 20);
            this.mtb_telefone.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Telefone";
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(507, 66);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(143, 21);
            this.cb_status.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Status";
            // 
            // cb_turmas
            // 
            this.cb_turmas.FormattingEnabled = true;
            this.cb_turmas.Location = new System.Drawing.Point(360, 130);
            this.cb_turmas.Name = "cb_turmas";
            this.cb_turmas.Size = new System.Drawing.Size(268, 21);
            this.cb_turmas.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Turmas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Imprimir Carteirinha";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(360, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 145);
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Clique duplo para alterar a foto";
            // 
            // F_GestaoAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 476);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_turmas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_alunos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_GestaoAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Alunos";
            this.Load += new System.EventHandler(this.F_GestaoAlunos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_alunos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_alunos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_financeiro;
        private System.Windows.Forms.Button btn_salvarEdicoes;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_excluirAluno;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_turmas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}