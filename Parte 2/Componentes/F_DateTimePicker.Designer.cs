namespace Componentes
{
    partial class F_DateTimePicker
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
            this.dtp_data = new System.Windows.Forms.DateTimePicker();
            this.btn_getData = new System.Windows.Forms.Button();
            this.btn_setData = new System.Windows.Forms.Button();
            this.btn_getToday = new System.Windows.Forms.Button();
            this.tb_data = new System.Windows.Forms.TextBox();
            this.tb_day = new System.Windows.Forms.TextBox();
            this.tb_month = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtp_data
            // 
            this.dtp_data.Location = new System.Drawing.Point(12, 18);
            this.dtp_data.Name = "dtp_data";
            this.dtp_data.Size = new System.Drawing.Size(312, 20);
            this.dtp_data.TabIndex = 0;
            // 
            // btn_getData
            // 
            this.btn_getData.Location = new System.Drawing.Point(330, 18);
            this.btn_getData.Name = "btn_getData";
            this.btn_getData.Size = new System.Drawing.Size(267, 20);
            this.btn_getData.TabIndex = 1;
            this.btn_getData.Text = "Obter data";
            this.btn_getData.UseVisualStyleBackColor = true;
            this.btn_getData.Click += new System.EventHandler(this.btn_getData_Click);
            // 
            // btn_setData
            // 
            this.btn_setData.Location = new System.Drawing.Point(330, 47);
            this.btn_setData.Name = "btn_setData";
            this.btn_setData.Size = new System.Drawing.Size(267, 20);
            this.btn_setData.TabIndex = 2;
            this.btn_setData.Text = "Definir data";
            this.btn_setData.UseVisualStyleBackColor = true;
            this.btn_setData.Click += new System.EventHandler(this.btn_setData_Click);
            // 
            // btn_getToday
            // 
            this.btn_getToday.Location = new System.Drawing.Point(330, 74);
            this.btn_getToday.Name = "btn_getToday";
            this.btn_getToday.Size = new System.Drawing.Size(267, 20);
            this.btn_getToday.TabIndex = 3;
            this.btn_getToday.Text = "Hoje";
            this.btn_getToday.UseVisualStyleBackColor = true;
            this.btn_getToday.Click += new System.EventHandler(this.btn_getToday_Click);
            // 
            // tb_data
            // 
            this.tb_data.Location = new System.Drawing.Point(12, 48);
            this.tb_data.Name = "tb_data";
            this.tb_data.Size = new System.Drawing.Size(312, 20);
            this.tb_data.TabIndex = 4;
            // 
            // tb_day
            // 
            this.tb_day.Location = new System.Drawing.Point(12, 74);
            this.tb_day.Name = "tb_day";
            this.tb_day.Size = new System.Drawing.Size(100, 20);
            this.tb_day.TabIndex = 5;
            // 
            // tb_month
            // 
            this.tb_month.Location = new System.Drawing.Point(118, 74);
            this.tb_month.Name = "tb_month";
            this.tb_month.Size = new System.Drawing.Size(100, 20);
            this.tb_month.TabIndex = 6;
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(224, 74);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(100, 20);
            this.tb_year.TabIndex = 7;
            // 
            // F_DateTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_year);
            this.Controls.Add(this.tb_month);
            this.Controls.Add(this.tb_day);
            this.Controls.Add(this.tb_data);
            this.Controls.Add(this.btn_getToday);
            this.Controls.Add(this.btn_setData);
            this.Controls.Add(this.btn_getData);
            this.Controls.Add(this.dtp_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_DateTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_data;
        private System.Windows.Forms.Button btn_getData;
        private System.Windows.Forms.Button btn_setData;
        private System.Windows.Forms.Button btn_getToday;
        private System.Windows.Forms.TextBox tb_data;
        private System.Windows.Forms.TextBox tb_day;
        private System.Windows.Forms.TextBox tb_month;
        private System.Windows.Forms.TextBox tb_year;
    }
}