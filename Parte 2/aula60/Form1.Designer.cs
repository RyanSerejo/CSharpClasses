namespace aula60
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_texto = new System.Windows.Forms.Button();
            this.TextBox_Texto = new System.Windows.Forms.TextBox();
            this.lb_link = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_texto
            // 
            this.btn_texto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_texto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_texto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_texto.Location = new System.Drawing.Point(12, 44);
            this.btn_texto.Name = "btn_texto";
            this.btn_texto.Size = new System.Drawing.Size(301, 76);
            this.btn_texto.TabIndex = 0;
            this.btn_texto.Text = "Imprimir";
            this.btn_texto.UseVisualStyleBackColor = false;
            this.btn_texto.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox_Texto
            // 
            this.TextBox_Texto.Location = new System.Drawing.Point(12, 18);
            this.TextBox_Texto.Name = "TextBox_Texto";
            this.TextBox_Texto.Size = new System.Drawing.Size(301, 20);
            this.TextBox_Texto.TabIndex = 2;
            this.TextBox_Texto.TextChanged += new System.EventHandler(this.TextBox_Texto_TextChanged);
            // 
            // lb_link
            // 
            this.lb_link.AutoSize = true;
            this.lb_link.Location = new System.Drawing.Point(12, 153);
            this.lb_link.Name = "lb_link";
            this.lb_link.Size = new System.Drawing.Size(101, 13);
            this.lb_link.TabIndex = 3;
            this.lb_link.Text = "www.blondgirls.com";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 685);
            this.Controls.Add(this.lb_link);
            this.Controls.Add(this.TextBox_Texto);
            this.Controls.Add(this.btn_texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_texto;
        private System.Windows.Forms.TextBox TextBox_Texto;
        private System.Windows.Forms.Label lb_link;
    }
}

