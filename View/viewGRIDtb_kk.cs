using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Form_Projek_Akhir.model;


namespace Form_Projek_Akhir.View
{
    public partial class viewGRIDtb_kk : Form
    {
        Kk Kk = new Kk();

        public viewGRIDtb_kk()
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
            if (txb_VIEW_cariKK.Text.Length == 0)
            {
                grid_VIEW_kk.DataSource = Kk.tampilSemua();
                belangbelang(grid_VIEW_kk);
            }
            else
            {
                grid_VIEW_kk.DataSource = Kk.cariNo_kk(txb_VIEW_cariKK.Text);
                belangbelang(grid_VIEW_kk);
            }
        }


        private void viewGRIDtb_kk_Load(object sender, EventArgs e)
        {
            tampil();
        }

    }
}
