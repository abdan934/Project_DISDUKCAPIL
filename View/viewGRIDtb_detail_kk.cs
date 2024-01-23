using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Form_Projek_Akhir.report;
using Form_Projek_Akhir.model;


namespace Form_Projek_Akhir.View
{
    public partial class viewGRIDtb_detail_kk : Form
    {
        KTP KTP = new KTP();
        Detail_KK KK = new Detail_KK();
        Kk Kk = new Kk();

        public viewGRIDtb_detail_kk()
        {
            InitializeComponent();
        }

        void belangbelang(DataGridView dgv)
        {
            foreach (DataGridViewRow baris in dgv.Rows)
            {
                foreach (DataGridViewCell kolom in baris.Cells)
                {
                    if (baris.Index % 2 == 0)
                    {
                        kolom.Style.BackColor = Color.LightGray;
                    }
                    else
                    {
                        kolom.Style.BackColor = Color.WhiteSmoke;

                    }
                }
            }
        }

        void tampil()
        {

            //grid_mhs.DataSource = Mahasiswa.tampilSemua();
            if (txb_VIEW_cariDETKK.Text.Length == 0 && Txb_cari_alamat.Text.Length == 0)
            {
                grid_VIEW_kk.DataSource = KK.tampilSemuaKK();
                belangbelang(grid_VIEW_kk);
            }
            else if (txb_VIEW_cariDETKK.Text.Length > 0)
            {
                grid_VIEW_kk.DataSource = KK.cariData(txb_VIEW_cariDETKK.Text);
                // grid_kk.DataSource = KK.cariDataRtRw(txb_cari_alamat.Text);
                //grid_kk.DataSource = KK.cariNik(txb_cari.Text);
                //grid_kk.DataSource = KK.cariNo_kk(txb_VIEW_cariDETKK.Text);
                //grid_kk.DataSource = KK.cariHubungan(txb_cari.Text);
                belangbelang(grid_VIEW_kk);
            }
            else if (Txb_cari_alamat.Text.Length > 0)
            {
               // grid_kk.DataSource = KK.cariData(txb_cari.Text);
                grid_VIEW_kk.DataSource = KK.cariDataRtRw(Txb_cari_alamat.Text);
                //grid_kk.DataSource = KK.cariNik(txb_cari.Text);
                //grid_kk.DataSource = KK.cariNo_kk(txb_cari.Text);
                //grid_kk.DataSource = KK.cariHubungan(txb_cari.Text);
                belangbelang(grid_VIEW_kk);
            }

        }


        private void viewGRIDtb_detail_kk_Load(object sender, EventArgs e)
        {
            tampil();
        }
    }
}
