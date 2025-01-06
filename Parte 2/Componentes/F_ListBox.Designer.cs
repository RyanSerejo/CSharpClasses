namespace Componentes
{
    partial class F_ListBox
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
            this.lb_carros = new System.Windows.Forms.ListBox();
            this.lb_carro = new System.Windows.Forms.Label();
            this.tb_typedcar = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_get = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_carros
            // 
            this.lb_carros.FormattingEnabled = true;
            this.lb_carros.Location = new System.Drawing.Point(18, 14);
            this.lb_carros.Name = "lb_carros";
            this.lb_carros.Size = new System.Drawing.Size(183, 212);
            this.lb_carros.TabIndex = 0;
            // 
            // lb_carro
            // 
            this.lb_carro.AutoSize = true;
            this.lb_carro.Location = new System.Drawing.Point(218, 14);
            this.lb_carro.Name = "lb_carro";
            this.lb_carro.Size = new System.Drawing.Size(78, 13);
            this.lb_carro.TabIndex = 1;
            this.lb_carro.Text = "Digite um carro";
            // 
            // tb_typedcar
            // 
            this.tb_typedcar.Location = new System.Drawing.Point(221, 30);
            this.tb_typedcar.Name = "tb_typedcar";
            this.tb_typedcar.Size = new System.Drawing.Size(169, 20);
            this.tb_typedcar.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(221, 56);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(169, 20);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Adicionar";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(221, 82);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(169, 20);
            this.btn_remove.TabIndex = 4;
            this.btn_remove.Text = "Remover";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_get
            // 
            this.btn_get.Location = new System.Drawing.Point(221, 108);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(169, 20);
            this.btn_get.TabIndex = 5;
            this.btn_get.Text = "Obter";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(221, 134);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(169, 20);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Limpar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // F_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tb_typedcar);
            this.Controls.Add(this.lb_carro);
            this.Controls.Add(this.lb_carros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_carros;
        private System.Windows.Forms.Label lb_carro;
        private System.Windows.Forms.TextBox tb_typedcar;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Button btn_clear;
    }
}