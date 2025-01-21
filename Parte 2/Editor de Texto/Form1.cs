using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Editor_de_Texto
{
    public partial class Form1 : Form
    {
        StringReader leitura = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Novo()
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Novo();
        }
        private void Salvar()
        {
            try
            {
                if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    FileStream arquivo = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter streamWriter = new StreamWriter(arquivo);
                    streamWriter.Flush();
                    streamWriter.BaseStream.Seek(0, SeekOrigin.Begin);
                    streamWriter.Write(this.richTextBox1.Text);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na gravação: " + ex.Message, "Erro ao gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void salvcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Abrir()
        {
            this.openFileDialog1.Title = "Abrir Arquivo";
            openFileDialog1.InitialDirectory = @"C:\\Users\\Ryan\\Documents\\C#\\CSharpClasses\\Parte 2\\Editor de Texto";
            openFileDialog1.Filter = "(*.CFB)|*.CFB";

            DialogResult dr = this.openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK) {
                try
                {
                    FileStream arquivo = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                    StreamReader streamReader = new StreamReader(arquivo);
                    streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                    this.richTextBox1.Text = "";
                    string line = streamReader.ReadLine();
                    while (line != null) {
                        this.richTextBox1.Text += line + "\n";
                        line = streamReader.ReadLine();
                    }
                    streamReader.Close();
                }
                catch (Exception ex) {
                    MessageBox.Show("Erro na leitura: " + ex.Message, "Erro ao ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_abrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void abrirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void Copiar()
        {
            if (richTextBox1.SelectionLength > 0) {
                richTextBox1.Copy();
            }
        }

        private void Colar()
        {
            try
            {
                richTextBox1.Paste();
            } catch
            {

            }
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Copiar();
        }

        private void btn_colar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void Negrito(){
            string fontName = richTextBox1.Font.Name;
            float fontSize = richTextBox1.Font.Size;
            bool n, i, s;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular);
            if (n == false)
            {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Italic);

                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Underline);

                }
                else if (i == false & s == false) { 
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold);
                }
            }
            else {
                if (i == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic);

                }
                else if (i == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Underline);

                }
               
            }
        }

        private void Italico()
        {
            string fontName = richTextBox1.Font.Name;
            float fontSize = richTextBox1.Font.Size;
            bool n, i, s;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular);
            if (i == false)
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Italic);

                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic | FontStyle.Underline);

                } else if (n == false & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic);

                }
            }
            else
            {
                if (n == true & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == true & s == false)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold);

                }
                else if (n == false & s == true)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Underline);

                }

            }
        }

        private void Sublinhado()
        {
            string fontName = richTextBox1.Font.Name;
            float fontSize = richTextBox1.Font.Size;
            bool n, i, s;
            n = richTextBox1.SelectionFont.Bold;
            i = richTextBox1.SelectionFont.Italic;
            s = richTextBox1.SelectionFont.Underline;

            richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Regular);
            if (s == false)
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Underline);

                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic | FontStyle.Underline);

                } else if (n == false & i == false)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Underline);
                }
            }
            else
            {
                if (n == true & i == true)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == true & i == false)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Bold);

                }
                else if (n == false & i == true)
                {
                    richTextBox1.SelectionFont = new Font(fontName, fontSize, FontStyle.Italic);
                }

            }
        }
        private void Imprimir()
        {
            printDialog1.Document = printDocument1;
            string texto = this.richTextBox1.Text;
            leitura = new StringReader(texto);
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                this.printDocument1.Print();
            }
        }

        private void AlignLeft()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void AlignRight()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;

        }
        private void AlignCenter()
        {
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

        }
        private void btn_negrito_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Negrito();
        }

        private void btn_italico_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void italidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Italico();
        }

        private void btn_sublinhado_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sublinhado();
        }

        private void btn_centralizar_Click(object sender, EventArgs e)
        {
            AlignCenter();
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlignCenter();
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlignLeft();
        }

        private void btn_esquerda_Click(object sender, EventArgs e)
        {
            AlignLeft();
        }

        private void btn_direita_Click(object sender, EventArgs e)
        {
            AlignRight();
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlignRight();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            float linhasPagina = 0;
            float PosY = 0;
            int cont = 0;
            float leftMargin = e.MarginBounds.Left - 50;
            float topMargin = e.MarginBounds.Top - 50;
            if (leftMargin < 5) {
                leftMargin = 20;
            }
            if (topMargin < 5) { 
                topMargin = 20;
            }
            string linha = null;
            Font fonte = this.richTextBox1.Font;
            SolidBrush pincel = new SolidBrush (Color.Black);
            linhasPagina = e.MarginBounds.Height / fonte.GetHeight(e.Graphics);
            linha = leitura.ReadLine();
            while (cont < linhasPagina)
            {
                PosY = (topMargin + (cont * fonte.GetHeight(e.Graphics)));
                e.Graphics.DrawString(linha, fonte, pincel, leftMargin, PosY, new StringFormat());
                cont += 1;
                linha = leitura.ReadLine();
            }
            if (linha != null)
            {
                e.HasMorePages = true;
            }
            else { 
                e.HasMorePages = false;
            }
            pincel.Dispose();
        }
    }
}
