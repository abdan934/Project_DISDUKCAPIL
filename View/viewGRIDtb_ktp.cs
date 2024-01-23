using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using Form_Projek_Akhir.report;
using Form_Projek_Akhir.model;

namespace Form_Projek_Akhir.View
{
    public partial class viewGRIDtb_ktp : Form
    {

        KTP KTP = new KTP();

        public viewGRIDtb_ktp()
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
            if (txb_VIEW_cariKTP.Text.Length == 0)
            {
                grid_VIEW_ktp.DataSource = KTP.tampilSemua();
                belangbelang(grid_VIEW_ktp);
            }
            else
            {
                grid_VIEW_ktp.DataSource = KTP.cariNik(txb_VIEW_cariKTP.Text);
                belangbelang(grid_VIEW_ktp);
            }
        }

        private void viewGRIDtb_ktp_Load(object sender, EventArgs e)
        {
            tampil();
        }
    }
}
