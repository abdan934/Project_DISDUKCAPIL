using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Form_Projek_Akhir.report;
using Form_Projek_Akhir.model;
using System.Data.SqlClient;

namespace Form_Projek_Akhir.View
{
    public partial class ChartJenisKelamin : Form
    {

        KTP KTP = new KTP();
        Kk KK = new Kk();
        
        public ChartJenisKelamin()
        {
            InitializeComponent();
        }

        private void ChartJenisKelamin_Load(object sender, EventArgs e)
        {
            
            jml_laki.Text = KTP.tampiltotalJKL();
            jml_perem.Text = KTP.tampiltotalJKP();
            tot_pend.Text = KTP.tampiltotalJK(); ;
            chart_Jk.Series["total_ktp"].Points.AddXY("Laki-Laki", KTP.tampiltotalJKL());
            chart_Jk.Series["total_ktp"].Points.AddXY("Perempuan", KTP.tampiltotalJKP());

            chart_anak.Series["total_anak"].Points.AddXY("Anak", KK.tampiltotalAnak());

            chart_total_penduduk.Series["total_penduduk"].Points.AddXY("RW01", KK.tampiltotalRW01());
            chart_total_penduduk.Series["total_penduduk"].Points.AddXY("RW02", KK.tampiltotalRW02());

            penduduk.Text = KK.tampiltotalRW01();
            lbl_rw02.Text = KK.tampiltotalRW02();
            lbl_anak.Text = KK.tampiltotalAnak();  
        }
    }
}
