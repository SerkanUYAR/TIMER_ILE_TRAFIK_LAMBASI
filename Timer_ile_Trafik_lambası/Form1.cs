using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_ile_Trafik_lambası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            label1.Text = sayac.ToString();
            if (sayac == 1)
            {
                btnkırmızı.BackColor = Color.Red;
            }
            if (sayac ==5)
            {
                btnkırmızı.BackColor = Color.Red;
                btnsarı.BackColor = Color.Yellow;

            }
            if (sayac ==8)
            {
                btnyesıl.BackColor = Color.Green;
                btnkırmızı.BackColor = Color.WhiteSmoke;
                btnsarı.BackColor = Color.WhiteSmoke;

            }
            if (sayac == 12)
            {
                sayac = 0;
                btnyesıl.BackColor = Color.WhiteSmoke;
                btnkırmızı.BackColor = Color.Red;

            }





        }
    }
}
