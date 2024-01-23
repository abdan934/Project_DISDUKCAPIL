using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Form_Projek_Akhir.View
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        void aktifPanel(bool p1,bool p2)
        {
            pnl_datamaster.Visible = p1;
            pnl_dataKTP.Visible = p2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aktifPanel(true, false);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            aktifPanel(false, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aktifPanel(false, true);
        }

        private void btn_menuktp_Click(object sender, EventArgs e)
        {
            aktifPanel(false, false);
           // model.form_ktp ktp = new model.form_ktp();
           // ktp.TopLevel = false;
          //  panel3.Controls.Add(ktp);
          //  ktp.Show();
            
        }
    }
}
