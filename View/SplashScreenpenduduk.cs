using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Form_Projek_Akhir.View
{
    public partial class SplashScreenpenduduk : Form
    {

        public SplashScreenpenduduk()
        {
            InitializeComponent();
        }


        private void SplashScreenpenduduk_Load(object sender, EventArgs e)
        {
            pnl_jalan.Width = 0;
            timer.Start();
            
        }

        private void timer_Tick_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 99; i++)
            {
                pnl_jalan.Width = pnl_jalan.Width + 10;
                
            }
            timer.Enabled = false;
            Form_Projek_Akhir.View.Form1 login = new Form_Projek_Akhir.View.Form1();
            login.Show();
            this.Hide();
        }





    }
}
