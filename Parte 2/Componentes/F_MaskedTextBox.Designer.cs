namespace Componentes
{
    partial class F_MaskedTextBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_cep = new System.Windows.Forms.MaskedTextBox();
            this.cb_somenteTexto = new System.Windows.Forms.CheckBox();
            this.btn_show = new System.Windows.Forms.Button();
            this.cb_mostrarSenha = new System.Windows.Forms.CheckBox();
            this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha";
            // 
            // mtb_cep
            // 
            this.mtb_cep.Location = new System.Drawing.Point(12, 144);
            this.mtb_cep.Mask = "00000-000";
            this.mtb_cep.Name = "mtb_cep";
            this.mtb_cep.Size = new System.Drawing.Size(310, 20);
            this.mtb_cep.TabIndex = 2;
            // 
            // cb_somenteTexto
            // 
            this.cb_somenteTexto.AutoSize = true;
            this.cb_somenteTexto.Location = new System.Drawing.Point(340, 145);
            this.cb_somenteTexto.Name = "cb_somenteTexto";
            this.cb_somenteTexto.Size = new System.Drawing.Size(98, 17);
            this.cb_somenteTexto.TabIndex = 3;
            this.cb_somenteTexto.Text = "Somente Texto";
            this.cb_somenteTexto.UseVisualStyleBackColor = true;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(460, 144);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(90, 24);
            this.btn_show.TabIndex = 4;
            this.btn_show.Text = "Exibir";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // cb_mostrarSenha
            // 
            this.cb_mostrarSenha.AutoSize = true;
            this.cb_mostrarSenha.Location = new System.Drawing.Point(340, 35);
            this.cb_mostrarSenha.Name = "cb_mostrarSenha";
            this.cb_mostrarSenha.Size = new System.Drawing.Size(93, 17);
            this.cb_mostrarSenha.TabIndex = 5;
            this.cb_mostrarSenha.Text = "Mostrar senha";
            this.cb_mostrarSenha.UseVisualStyleBackColor = true;
            this.cb_mostrarSenha.CheckedChanged += new System.EventHandler(this.cb_mostrarSenha_CheckedChanged);
            // 
            // mtb_senha
            // 
            this.mtb_senha.Location = new System.Drawing.Point(12, 33);
            this.mtb_senha.Name = "mtb_senha";
            this.mtb_senha.PasswordChar = '*';
            this.mtb_senha.Size = new System.Drawing.Size(308, 20);
            this.mtb_senha.TabIndex = 6;
            // 
            // F_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtb_senha);
            this.Controls.Add(this.cb_mostrarSenha);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.cb_somenteTexto);
            this.Controls.Add(this.mtb_cep);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_MaskedTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_cep;
        private System.Windows.Forms.CheckBox cb_somenteTexto;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.CheckBox cb_mostrarSenha;
        private System.Windows.Forms.MaskedTextBox mtb_senha;
    }
}