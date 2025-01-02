namespace Componentes
{
    partial class F_ComboBox
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
            this.cb_veiculos = new System.Windows.Forms.ComboBox();
            this.btn_showSelected = new System.Windows.Forms.Button();
            this.btn_clearElements = new System.Windows.Forms.Button();
            this.btn_resetElements = new System.Windows.Forms.Button();
            this.btn_addVeiculo = new System.Windows.Forms.Button();
            this.tb_typedVeiculo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cb_veiculos
            // 
            this.cb_veiculos.FormattingEnabled = true;
            this.cb_veiculos.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cb_veiculos.Location = new System.Drawing.Point(12, 12);
            this.cb_veiculos.Name = "cb_veiculos";
            this.cb_veiculos.Size = new System.Drawing.Size(240, 21);
            this.cb_veiculos.TabIndex = 0;
            // 
            // btn_showSelected
            // 
            this.btn_showSelected.Location = new System.Drawing.Point(258, 12);
            this.btn_showSelected.Name = "btn_showSelected";
            this.btn_showSelected.Size = new System.Drawing.Size(278, 21);
            this.btn_showSelected.TabIndex = 1;
            this.btn_showSelected.Text = "Mostrar selecionado";
            this.btn_showSelected.UseVisualStyleBackColor = true;
            this.btn_showSelected.Click += new System.EventHandler(this.btn_showSelected_Click);
            // 
            // btn_clearElements
            // 
            this.btn_clearElements.Location = new System.Drawing.Point(258, 41);
            this.btn_clearElements.Name = "btn_clearElements";
            this.btn_clearElements.Size = new System.Drawing.Size(278, 21);
            this.btn_clearElements.TabIndex = 2;
            this.btn_clearElements.Text = "Limpar elementos";
            this.btn_clearElements.UseVisualStyleBackColor = true;
            this.btn_clearElements.Click += new System.EventHandler(this.btn_clearElements_Click);
            // 
            // btn_resetElements
            // 
            this.btn_resetElements.Location = new System.Drawing.Point(258, 68);
            this.btn_resetElements.Name = "btn_resetElements";
            this.btn_resetElements.Size = new System.Drawing.Size(278, 21);
            this.btn_resetElements.TabIndex = 3;
            this.btn_resetElements.Text = "Resetar elementos";
            this.btn_resetElements.UseVisualStyleBackColor = true;
            this.btn_resetElements.Click += new System.EventHandler(this.btn_resetElements_Click);
            // 
            // btn_addVeiculo
            // 
            this.btn_addVeiculo.Location = new System.Drawing.Point(258, 168);
            this.btn_addVeiculo.Name = "btn_addVeiculo";
            this.btn_addVeiculo.Size = new System.Drawing.Size(278, 21);
            this.btn_addVeiculo.TabIndex = 4;
            this.btn_addVeiculo.Text = "Adicionar veículo";
            this.btn_addVeiculo.UseVisualStyleBackColor = true;
            this.btn_addVeiculo.Click += new System.EventHandler(this.btn_addVeiculo_Click);
            // 
            // tb_typedVeiculo
            // 
            this.tb_typedVeiculo.Location = new System.Drawing.Point(260, 142);
            this.tb_typedVeiculo.Name = "tb_typedVeiculo";
            this.tb_typedVeiculo.Size = new System.Drawing.Size(276, 20);
            this.tb_typedVeiculo.TabIndex = 5;
            // 
            // F_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_typedVeiculo);
            this.Controls.Add(this.btn_addVeiculo);
            this.Controls.Add(this.btn_resetElements);
            this.Controls.Add(this.btn_clearElements);
            this.Controls.Add(this.btn_showSelected);
            this.Controls.Add(this.cb_veiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_veiculos;
        private System.Windows.Forms.Button btn_showSelected;
        private System.Windows.Forms.Button btn_clearElements;
        private System.Windows.Forms.Button btn_resetElements;
        private System.Windows.Forms.Button btn_addVeiculo;
        private System.Windows.Forms.TextBox tb_typedVeiculo;
    }
}