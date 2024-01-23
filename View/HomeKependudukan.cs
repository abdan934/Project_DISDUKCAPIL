using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Form_Projek_Akhir.model;

namespace Form_Projek_Akhir.View
{
    public partial class MenuUtama : Form
    {
        public MenuUtama(string nama)
        {
            InitializeComponent();
            lbl_nama.Text = nama;

            panelAktif(true, false, false, false, false, false, false, false, true);
            View.ChartJenisKelamin chart = new View.ChartJenisKelamin();
            chart.TopLevel = false;
            pnl_load1.Controls.Add(chart);
            chart.Show();
        }

        void panelAktif(bool p1,bool p2,bool p3,bool p4,bool l1,bool l2,bool l3,bool l4,bool l5)
        {

            lblSelected1.Visible = l1;
            lblSelected2.Visible = l2;
            lblSelected3.Visible = l3;
            lblSelected4.Visible = l4;
            lblSelected5.Visible =l5;

            pnl_load1.Visible = p1;
            pnl_datamaster.Visible = p2;
            pnl_dataKTP.Visible = p3;
            pnl_kelolaKK.Visible = p4;

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah akan keluar dari sistem..?",
            "KONFIRMASI",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }  
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            
                 this.WindowState = FormWindowState.Maximized;     
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void btn_datamaster_Click(object sender, EventArgs e)
        {
            panelAktif(false,true,false,false,true,false,false,false,false);

        }

        private void btn_ktp_Click(object sender, EventArgs e)
        {
            panelAktif(false,false,true,false,false,true,false,false,false);
        }

        private void btn_datakk_Click(object sender, EventArgs e)
        {
            panelAktif(false,false,false,true,false,false,true,false,false);
            
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            lblSelected1.Visible = false;
            lblSelected2.Visible = false;
            lblSelected3.Visible = false;
            lblSelected4.Visible = true;

            if (MessageBox.Show("Apakah ingin logout dari sistem..?",
             "KONFIRMASI",
             MessageBoxButtons.YesNo,
             MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }


        }

        private void MenuUtama_Load(object sender, EventArgs e)
        {
            panelAktif(true, false, false, false, false, false, false, false,false);
           // lbl_nama.Text = 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbl_nama.Text == "Kepala Desa")
            {
                panelAktif(true, false, false, false, false, false, false, false, false);
                View.viewGRIDtb_ktp v_ktp = new View.viewGRIDtb_ktp();
                v_ktp.TopLevel = false;
                pnl_load1.Controls.Add(v_ktp);
                v_ktp.Show();
            }
            else
            {
                panelAktif(true, false, false, false, false, false, false, false, false);
                View.form_ktp ktp = new View.form_ktp();
                ktp.TopLevel = false;
                pnl_load1.Controls.Add(ktp);
                ktp.Show();
            }
        }

        private void btn_menuktp_Click(object sender, EventArgs e)
        {
            if (lbl_nama.Text == "Kepala Desa")
            {
                panelAktif(true, false, false, false, false, false, false, false, false);
                View.viewGRIDtb_ktp v_ktp = new View.viewGRIDtb_ktp();
                v_ktp.TopLevel = false;
                pnl_load1.Controls.Add(v_ktp);
                v_ktp.StartPosition = FormStartPosition.CenterScreen;
                v_ktp.Show();
            }
            else
            {
                panelAktif(true, false, false, false, false, false, false, false, false);
                View.form_ktp ktp = new View.form_ktp();
                ktp.TopLevel = false;
                pnl_load1.Controls.Add(ktp);
                ktp.StartPosition = FormStartPosition.CenterScreen;
                ktp.Show();
            }
        }

        private void btn_menuDetailKK_Click(object sender, EventArgs e)
        {
            if (lbl_nama.Text == "Kepala Desa")
            {
                panelAktif(true, false, false, false, false, false, false, false, false);
                View.viewGRIDtb_detail_kk v_FormKk = new View.viewGRIDtb_detail_kk();
                v_FormKk.TopLevel = false;
                pnl_load1.Controls.Add(v_FormKk);
                v_FormKk.StartPosition = FormStartPosition.CenterScreen;
                v_FormKk.Show();
            }
            else
            {
                panelAktif(true, false, false, false, false, false, false, false, false);
                View.form_KK FormKk = new View.form_KK();
                FormKk.TopLevel = false;
                pnl_load1.Controls.Add(FormKk);
                FormKk.StartPosition = FormStartPosition.CenterScreen;
                FormKk.Show();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbl_nama.Text == "Kepala Desa")
            {
                panelAktif(true, false, false, false, false, false, false, false, false);
                View.viewGRIDtb_detail_kk v_FormKk = new View.viewGRIDtb_detail_kk();
                v_FormKk.TopLevel = false;
                pnl_load1.Controls.Add(v_FormKk);
                v_FormKk.StartPosition = FormStartPosition.CenterScreen;
                v_FormKk.Show();
            }
            else
            {
                panelAktif(true, false, false, false, false, false, false, false, false);
                View.form_KK FormKk = new View.form_KK();
                FormKk.TopLevel = false;
                pnl_load1.Controls.Add(FormKk);
                FormKk.StartPosition = FormStartPosition.CenterScreen;
                FormKk.Show();
            }
            
        }

        private void btn_menuKK_Click(object sender, EventArgs e)
        {
            if (lbl_nama.Text == "Kepala Desa")
            {
                panelAktif(true, false, false, false, false, false, false, false, false);
                View.viewGRIDtb_kk FormKK = new View.viewGRIDtb_kk();
                FormKK.TopLevel = false;
                pnl_load1.Controls.Add(FormKK);
                FormKK.StartPosition = FormStartPosition.CenterScreen;
                FormKK.Show();
            }
            else
            {
                panelAktif(true, false, false, false, false, false, false, false, false);
                View.form_Kk FormKK = new View.form_Kk();
                FormKK.TopLevel = false;
                pnl_load1.Controls.Add(FormKK);
                FormKK.StartPosition = FormStartPosition.CenterScreen;
                FormKK.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbl_nama.Text == "Kepala Desa")
            {
                panelAktif(true, false, false, false, false, false, false, false, false);
                View.viewGRIDtb_kk FormKK = new View.viewGRIDtb_kk();
                FormKK.TopLevel = false;
                pnl_load1.Controls.Add(FormKK);
                FormKK.StartPosition = FormStartPosition.CenterScreen;
                FormKK.Show();
            }
            else
            {
                panelAktif(true, false, false, false, false, false, false, false, false);
                View.form_Kk FormKK = new View.form_Kk();
                FormKK.TopLevel = false;
                pnl_load1.Controls.Add(FormKK);
                FormKK.StartPosition = FormStartPosition.CenterScreen;
                FormKK.Show();
            }
        }

        private void btn_menuadmin_Click(object sender, EventArgs e)
        {
            if (lbl_nama.Text != "admin")
            {
                MessageBox.Show("Anda bukanlah Admin", "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }else
            {
                panelAktif(true, false, false, false, false, false, false, false, false);
                View.CRUDUser Admin = new View.CRUDUser();
                Admin.TopLevel = false;
                pnl_load1.Controls.Add(Admin);
                Admin.Show();
            }
        }

        private void btn_chart_Click(object sender, EventArgs e)
        {
            panelAktif(true, false, false, false, false, false, false, false, true);
            View.ChartJenisKelamin chart = new View.ChartJenisKelamin();
            chart.TopLevel =false;
            pnl_load1.Controls.Add(chart);
            chart.Show();
        }

    }
}
