﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Main : Form
    {
        public int num;
        public F_Main()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(tb_veiculo.Text == "")
            {
                MessageBox.Show("Digite um valor");
                tb_veiculo.Focus();
                return;
            }

            tb_listaVeiculo.Text += tb_veiculo.Text + ", ";
            // tb.listaVeiculo.Text = tb.listaVeiculo + tb_veiculo.Text;
            tb_veiculo.Clear();
            tb_listaVeiculo.Focus();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tb_listaVeiculo.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void button_Click(object sender, EventArgs e)
        {
            F_Veiculos f_Veiculos = new F_Veiculos(tb_listaVeiculo.Text, this);
            f_Veiculos.ShowDialog();
        }

        private void btn_valueNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show(num.ToString());
        }

        private void checkboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new F_CheckBox();
            f_CheckBox.ShowDialog();
        }


        private void checkedListBoxToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new F_CheckedListBox();
            f_CheckedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new F_ComboBox();
            f_ComboBox.ShowDialog(); 
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new F_DateTimePicker();
            f_DateTimePicker.ShowDialog();
        }

        private void labelLinkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new F_LinkLabel();
            f_LinkLabel.ShowDialog();   
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListBox f_ListBox = new F_ListBox();
            f_ListBox.ShowDialog(); 
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ListView f_ListView = new F_ListView();
            f_ListView.ShowDialog();    
        }

        private void maskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_MaskedTextBox = new F_MaskedTextBox();  
            f_MaskedTextBox.ShowDialog();
        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MonthCalendar f_MonthCalendar = new F_MonthCalendar();
            f_MonthCalendar.ShowDialog();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if(e.ClickedItem.Name.ToString() == "tsmi_Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            } else if (e.ClickedItem.Name.ToString() == "tsmi_Fechar")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "tsmi_Mensagem")
            {
                MessageBox.Show("Mensagem");
            }
        }

        private void numericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpDown f_NumericUpDown = new F_NumericUpDown();
            f_NumericUpDown.ShowDialog();
        }

        private void pictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox f_PictureBox = new F_PictureBox();
            f_PictureBox.ShowDialog();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ProgressBar f_ProgressBar = new F_ProgressBar();
            f_ProgressBar.ShowDialog();
        }

        private void radioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_RadioButton f_RadioButton = new F_RadioButton();
            f_RadioButton.ShowDialog(); 
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TrackBar f_TrackBar = new F_TrackBar(); 
            f_TrackBar.ShowDialog();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TreeView f_TreeView = new F_TreeView();
            f_TreeView.ShowDialog();    
        }

        private void webBroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_WebBrowser f_WebBrowser = new F_WebBrowser();
            f_WebBrowser.ShowDialog();
        }

        private void splitContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_SplitContainer f_SplitContainer = new F_SplitContainer();
            f_SplitContainer.ShowDialog();  
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TabControl f_TabControl = new F_TabControl();
            f_TabControl.ShowDialog();
        }

        private void tabLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_TableLayoutPanel f_TableLayoutPanel = new F_TableLayoutPanel();
            f_TableLayoutPanel.ShowDialog();
        }

        private void toolStripContainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ToolStripContainer f_ToolStripContainer = new F_ToolStripContainer();
            f_ToolStripContainer.ShowDialog();
        }

        private void backgroundWorkerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_BackgroundWorker f_BackgroundWorker   = new F_BackgroundWorker();
            f_BackgroundWorker.ShowDialog();    
        }

        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer f_Timer = new Timer();
            f_Timer.ShowDialog();
        }

        private void sQLiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_SQLite f_SQLite = new F_SQLite();
            f_SQLite.ShowDialog();
        }
    }
}
