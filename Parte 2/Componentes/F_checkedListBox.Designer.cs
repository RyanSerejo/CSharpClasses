namespace Componentes
{
    partial class F_CheckedListBox
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
            this.clb_tranportes = new System.Windows.Forms.CheckedListBox();
            this.btn_showSelected = new System.Windows.Forms.Button();
            this.btn_clearList = new System.Windows.Forms.Button();
            this.btn_resetList = new System.Windows.Forms.Button();
            this.btn_addNewTransp = new System.Windows.Forms.Button();
            this.tb_novoTransp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clb_tranportes
            // 
            this.clb_tranportes.FormattingEnabled = true;
            this.clb_tranportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.clb_tranportes.Location = new System.Drawing.Point(12, 15);
            this.clb_tranportes.Name = "clb_tranportes";
            this.clb_tranportes.Size = new System.Drawing.Size(188, 199);
            this.clb_tranportes.TabIndex = 0;
            // 
            // btn_showSelected
            // 
            this.btn_showSelected.Location = new System.Drawing.Point(206, 12);
            this.btn_showSelected.Name = "btn_showSelected";
            this.btn_showSelected.Size = new System.Drawing.Size(219, 24);
            this.btn_showSelected.TabIndex = 1;
            this.btn_showSelected.Text = "Mostrar Selecionados";
            this.btn_showSelected.UseVisualStyleBackColor = true;
            this.btn_showSelected.Click += new System.EventHandler(this.btn_showSelected_Click);
            // 
            // btn_clearList
            // 
            this.btn_clearList.Location = new System.Drawing.Point(206, 42);
            this.btn_clearList.Name = "btn_clearList";
            this.btn_clearList.Size = new System.Drawing.Size(219, 24);
            this.btn_clearList.TabIndex = 2;
            this.btn_clearList.Text = "Limpar Lista";
            this.btn_clearList.UseVisualStyleBackColor = true;
            this.btn_clearList.Click += new System.EventHandler(this.btn_clearList_Click);
            // 
            // btn_resetList
            // 
            this.btn_resetList.Location = new System.Drawing.Point(206, 72);
            this.btn_resetList.Name = "btn_resetList";
            this.btn_resetList.Size = new System.Drawing.Size(219, 24);
            this.btn_resetList.TabIndex = 3;
            this.btn_resetList.Text = "Resetar lista";
            this.btn_resetList.UseVisualStyleBackColor = true;
            this.btn_resetList.Click += new System.EventHandler(this.btn_resetList_Click);
            // 
            // btn_addNewTransp
            // 
            this.btn_addNewTransp.Location = new System.Drawing.Point(206, 190);
            this.btn_addNewTransp.Name = "btn_addNewTransp";
            this.btn_addNewTransp.Size = new System.Drawing.Size(219, 24);
            this.btn_addNewTransp.TabIndex = 4;
            this.btn_addNewTransp.Text = "Adicionar transporte";
            this.btn_addNewTransp.UseVisualStyleBackColor = true;
            this.btn_addNewTransp.Click += new System.EventHandler(this.btn_addNewTransp_Click);
            // 
            // tb_novoTransp
            // 
            this.tb_novoTransp.Location = new System.Drawing.Point(206, 164);
            this.tb_novoTransp.Name = "tb_novoTransp";
            this.tb_novoTransp.Size = new System.Drawing.Size(219, 20);
            this.tb_novoTransp.TabIndex = 5;
            // 
            // F_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.tb_novoTransp);
            this.Controls.Add(this.btn_addNewTransp);
            this.Controls.Add(this.btn_resetList);
            this.Controls.Add(this.btn_clearList);
            this.Controls.Add(this.btn_showSelected);
            this.Controls.Add(this.clb_tranportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_tranportes;
        private System.Windows.Forms.Button btn_showSelected;
        private System.Windows.Forms.Button btn_clearList;
        private System.Windows.Forms.Button btn_resetList;
        private System.Windows.Forms.Button btn_addNewTransp;
        private System.Windows.Forms.TextBox tb_novoTransp;
    }
}