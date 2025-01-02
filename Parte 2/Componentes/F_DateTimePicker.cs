using System;
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
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        private void btn_getData_Click(object sender, EventArgs e)
        {
            tb_data.Text = dtp_data.Text;

            tb_day.Text = dtp_data.Value.Day.ToString();
            tb_month.Text = dtp_data.Value.Month.ToString();
            tb_year.Text = dtp_data.Value.Year.ToString();

        }

        private void btn_setData_Click(object sender, EventArgs e)
        {
            int d, m, y;
            d = Int32.Parse(tb_day.Text);
            m = Int32.Parse(tb_month.Text);
            y = Int32.Parse(tb_year.Text);

            DateTime dt = new DateTime(y, m, d);//o construtor exige que seja passado na odem yymmaa;
            dtp_data.Value = dt;
        }

        private void btn_getToday_Click(object sender, EventArgs e)
        {
            dtp_data.Value = DateTime.Today;
        }
    }
}
