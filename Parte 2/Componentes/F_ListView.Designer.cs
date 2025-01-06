namespace Componentes
{
    partial class F_ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "10",
            "19,50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "10",
            "45,50"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "20",
            "450,50"}, -1);
            this.lv_produtos = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_produtos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_produtos
            // 
            this.lv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_produtos,
            this.col_qtde,
            this.col_preco});
            this.lv_produtos.HideSelection = false;
            this.lv_produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lv_produtos.Location = new System.Drawing.Point(26, 12);
            this.lv_produtos.Name = "lv_produtos";
            this.lv_produtos.Size = new System.Drawing.Size(344, 299);
            this.lv_produtos.TabIndex = 0;
            this.lv_produtos.UseCompatibleStateImageBehavior = false;
            this.lv_produtos.View = System.Windows.Forms.View.Details;
            // 
            // col_id
            // 
            this.col_id.Text = "ID";
            this.col_id.Width = 40;
            // 
            // col_produtos
            // 
            this.col_produtos.Text = "Produtos";
            this.col_produtos.Width = 130;
            // 
            // col_qtde
            // 
            this.col_qtde.Text = "Quantidade";
            this.col_qtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.col_qtde.Width = 90;
            // 
            // col_preco
            // 
            this.col_preco.Text = "Preço";
            this.col_preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.col_preco.Width = 80;
            // 
            // F_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 323);
            this.Controls.Add(this.lv_produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "F_ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_produtos;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_produtos;
        private System.Windows.Forms.ColumnHeader col_qtde;
        private System.Windows.Forms.ColumnHeader col_preco;
    }
}