namespace AcademiaProject
{
    partial class F_NovoAluno
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
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.tb_turma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_plano = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_nome
            // 
            this.tb_nome.Enabled = false;
            this.tb_nome.Location = new System.Drawing.Point(15, 25);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(337, 20);
            this.tb_nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // mtb_telefone
            // 
            this.mtb_telefone.Enabled = false;
            this.mtb_telefone.Location = new System.Drawing.Point(358, 25);
            this.mtb_telefone.Mask = "(99)9999-9999";
            this.mtb_telefone.Name = "mtb_telefone";
            this.mtb_telefone.Size = new System.Drawing.Size(130, 20);
            this.mtb_telefone.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Telefone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Status";
            // 
            // cb_status
            // 
            this.cb_status.Enabled = false;
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Location = new System.Drawing.Point(12, 76);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(145, 21);
            this.cb_status.TabIndex = 21;
            // 
            // tb_turma
            // 
            this.tb_turma.Enabled = false;
            this.tb_turma.Location = new System.Drawing.Point(201, 77);
            this.tb_turma.Name = "tb_turma";
            this.tb_turma.ReadOnly = true;
            this.tb_turma.Size = new System.Drawing.Size(263, 20);
            this.tb_turma.TabIndex = 22;
            this.tb_turma.Tag = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Turma";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 21);
            this.button1.TabIndex = 24;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(201, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 21);
            this.button2.TabIndex = 27;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Plano";
            // 
            // tb_plano
            // 
            this.tb_plano.Location = new System.Drawing.Point(15, 139);
            this.tb_plano.Name = "tb_plano";
            this.tb_plano.Size = new System.Drawing.Size(189, 20);
            this.tb_plano.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Controls.Add(this.btn_fechar);
            this.panel1.Controls.Add(this.btn_gravar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 35);
            this.panel1.TabIndex = 28;
            // 
            // btn_novo
            // 
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.Location = new System.Drawing.Point(14, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(123, 27);
            this.btn_novo.TabIndex = 3;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_fechar
            // 
            this.btn_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fechar.Location = new System.Drawing.Point(400, 3);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(102, 27);
            this.btn_fechar.TabIndex = 6;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            // 
            // btn_gravar
            // 
            this.btn_gravar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gravar.Enabled = false;
            this.btn_gravar.Location = new System.Drawing.Point(143, 3);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(123, 27);
            this.btn_gravar.TabIndex = 4;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.Enabled = false;
            this.btn_cancelar.Location = new System.Drawing.Point(272, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(122, 27);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // F_NovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 240);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_plano);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_turma);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_telefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_nome);
            this.Name = "F_NovoAluno";
            this.Text = "Novo Aluno";
            this.Load += new System.EventHandler(this.F_NovoAluno_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.TextBox tb_turma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_plano;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}