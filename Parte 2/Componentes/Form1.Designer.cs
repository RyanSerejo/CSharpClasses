namespace Componentes
{
    partial class F_Main
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
            this.btn_add = new System.Windows.Forms.Button();
            this.lb_veiculo = new System.Windows.Forms.Label();
            this.tb_veiculo = new System.Windows.Forms.TextBox();
            this.tb_listaVeiculo = new System.Windows.Forms.TextBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.btn_valueNum = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkboxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLinkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(267, 53);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(209, 20);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_veiculo
            // 
            this.lb_veiculo.AutoSize = true;
            this.lb_veiculo.Location = new System.Drawing.Point(13, 37);
            this.lb_veiculo.Name = "lb_veiculo";
            this.lb_veiculo.Size = new System.Drawing.Size(90, 13);
            this.lb_veiculo.TabIndex = 1;
            this.lb_veiculo.Text = "Digite um veículo";
            // 
            // tb_veiculo
            // 
            this.tb_veiculo.Location = new System.Drawing.Point(16, 53);
            this.tb_veiculo.Name = "tb_veiculo";
            this.tb_veiculo.Size = new System.Drawing.Size(250, 20);
            this.tb_veiculo.TabIndex = 2;
            // 
            // tb_listaVeiculo
            // 
            this.tb_listaVeiculo.Location = new System.Drawing.Point(16, 79);
            this.tb_listaVeiculo.Multiline = true;
            this.tb_listaVeiculo.Name = "tb_listaVeiculo";
            this.tb_listaVeiculo.ReadOnly = true;
            this.tb_listaVeiculo.Size = new System.Drawing.Size(460, 215);
            this.tb_listaVeiculo.TabIndex = 3;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(16, 300);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(461, 27);
            this.btn_Clear.TabIndex = 4;
            this.btn_Clear.Text = "Limpar";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(16, 334);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(461, 23);
            this.button.TabIndex = 5;
            this.button.Text = "Mostrar";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // btn_valueNum
            // 
            this.btn_valueNum.Location = new System.Drawing.Point(20, 365);
            this.btn_valueNum.Name = "btn_valueNum";
            this.btn_valueNum.Size = new System.Drawing.Size(455, 22);
            this.btn_valueNum.TabIndex = 6;
            this.btn_valueNum.Text = "Valor da Variável num";
            this.btn_valueNum.UseVisualStyleBackColor = true;
            this.btn_valueNum.Click += new System.EventHandler(this.btn_valueNum_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(497, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkboxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem1,
            this.comboBoxToolStripMenuItem,
            this.dateTimePickerToolStripMenuItem,
            this.labelLinkLabelToolStripMenuItem});
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.cToolStripMenuItem.Text = "Componentes";
            // 
            // checkboxToolStripMenuItem
            // 
            this.checkboxToolStripMenuItem.Name = "checkboxToolStripMenuItem";
            this.checkboxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkboxToolStripMenuItem.Text = "Checkbox";
            this.checkboxToolStripMenuItem.Click += new System.EventHandler(this.checkboxToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem1
            // 
            this.checkedListBoxToolStripMenuItem1.Name = "checkedListBoxToolStripMenuItem1";
            this.checkedListBoxToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.checkedListBoxToolStripMenuItem1.Text = "CheckedListBox";
            this.checkedListBoxToolStripMenuItem1.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem1_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // dateTimePickerToolStripMenuItem
            // 
            this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateTimePickerToolStripMenuItem.Text = "DateTimePicker";
            this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
            // 
            // labelLinkLabelToolStripMenuItem
            // 
            this.labelLinkLabelToolStripMenuItem.Name = "labelLinkLabelToolStripMenuItem";
            this.labelLinkLabelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.labelLinkLabelToolStripMenuItem.Text = "Label// LinkLabel";
            this.labelLinkLabelToolStripMenuItem.Click += new System.EventHandler(this.labelLinkLabelToolStripMenuItem_Click);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 455);
            this.Controls.Add(this.btn_valueNum);
            this.Controls.Add(this.button);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.tb_listaVeiculo);
            this.Controls.Add(this.tb_veiculo);
            this.Controls.Add(this.lb_veiculo);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Componentes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label lb_veiculo;
        private System.Windows.Forms.TextBox tb_veiculo;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button button;
        public System.Windows.Forms.TextBox tb_listaVeiculo;
        private System.Windows.Forms.Button btn_valueNum;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkboxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedListBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelLinkLabelToolStripMenuItem;
    }
}

