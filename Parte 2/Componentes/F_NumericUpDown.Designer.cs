namespace Componentes
{
    partial class F_NumericUpDown
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
            this.nupdown1 = new System.Windows.Forms.NumericUpDown();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_set = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupdown1)).BeginInit();
            this.SuspendLayout();
            // 
            // nupdown1
            // 
            this.nupdown1.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupdown1.Location = new System.Drawing.Point(12, 12);
            this.nupdown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nupdown1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nupdown1.Name = "nupdown1";
            this.nupdown1.Size = new System.Drawing.Size(133, 20);
            this.nupdown1.TabIndex = 0;
            this.nupdown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(156, 12);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(142, 20);
            this.tb_valor.TabIndex = 1;
            // 
            // btn_set
            // 
            this.btn_set.Location = new System.Drawing.Point(304, 13);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(120, 19);
            this.btn_set.TabIndex = 2;
            this.btn_set.Text = "Definir";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // F_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 404);
            this.Controls.Add(this.btn_set);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.nupdown1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "F_NumericUpDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.nupdown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nupdown1;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button btn_set;
    }
}