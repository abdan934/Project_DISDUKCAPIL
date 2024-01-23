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
    public partial class form_ktp : Form
    {
        
        KTP KTP = new KTP();
        

        string sumber = "", target = @"D:\Abdan\Semester 3 (ME)\PBO II\Form_Projek_Akhir\foto\";
        string asalfoto = @"D:\Abdan\Semester 3 (ME)\PBO II\Form_Projek_Akhir\foto\";

        public form_ktp()
        {
            InitializeComponent();
        }

        void copyFile(string nik)
        {

                File.Copy(sumber, target + nik + ".jpg", true);

        }
        void renameFile(string npm)
        {
            File.Delete(target + npm + ".jpg");
            File.Move(npm + ".jpg", target + npm + ".jpg");
        }

        void brows()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Foto (*.jpg)|*.jpg";
            if (of.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txb_nik.Focus();
            tampil();
        }

        void bersihkan()
        {
            txb_alamat.Clear();
            txb_kewarganegaraan.Clear();
            txb_nama_lengkap.Clear();
            txb_nik.Clear();
            txb_pekerjaan.Clear();
            txb_status_perkawinan.Clear();
            txb_tempat_lahir.Clear();
            cek_laki_laki.Checked = false;
            cek_perempuan.Checked = false;
            cmb_agama.Text = "(None)";
            date_tgl_lahir.ResetText();
            box_foto.Image = null;
            box_foto.Refresh(); ;

            txb_nik.Focus();
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
            if (txb_cari.Text.Length == 0)
            {
                grid_ktp.DataSource = KTP.tampilSemua();
                belangbelang(grid_ktp);
            }
            else
            {
                grid_ktp.DataSource = KTP.cariNik(txb_cari.Text);
                belangbelang(grid_ktp);
            }
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            bersihkan();
        }

        private void txb_nik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (!KTP.cekNik(txb_nik.Text))
            {
                KTP.Nik = txb_nik.Text;
                KTP.Nama_lengkap = txb_nama_lengkap.Text;
                KTP.Tempat_lahir = txb_tempat_lahir.Text;
                if (cek_laki_laki.Checked == true)
                {
                    KTP.Jenis_kelamin = "Laki-laki";
                }
                else if (cek_perempuan.Checked == true)
                {
                    KTP.Jenis_kelamin = "Perempuan";
                }
                KTP.Tgl_lahir = date_tgl_lahir.Value.ToString("yyy/MM/dd");
                KTP.Alamat = txb_alamat.Text;
                KTP.Agama = cmb_agama.Text;
                KTP.Status_perkawinan = txb_status_perkawinan.Text;
                KTP.Pekerjaan = txb_pekerjaan.Text;
                KTP.Kewarganegaraan = txb_kewarganegaraan.Text;

                KTP.Foto = txb_nik.Text + ".jpg";
                copyFile(txb_nik.Text);


                KTP.simpanData();
                MessageBox.Show("Data berhasil disimpan.", "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                bersihkan();
                tampil();
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin menghapus data tersebut..?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (KTP.cekNik(txb_nik.Text))
                {
                    if (KTP.cekNoNik_diDetail_Kk(txb_nik.Text) == false)
                    {
                        KTP.Nik = txb_nik.Text;
                        KTP.hapusData(txb_nik.Text);
                        MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cek Data di Detail KK terlebih dahulu", "Informasi", MessageBoxButtons.OK,
                         MessageBoxIcon.Information);
                    }
                    bersihkan();
                    tampil();
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus.", "Gagal", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }

            }
        }

        private void btn_ubah_Click(object sender, EventArgs e)
        {
            if (KTP.cekNik(txb_nik.Text))
            {
                //Mahasiswa.Npm= npm_txt.Text;

                KTP.Nama_lengkap = txb_nama_lengkap.Text;
                KTP.Tempat_lahir = txb_tempat_lahir.Text;
                KTP.Tgl_lahir = date_tgl_lahir.Value.ToString("yyy/MM/dd");
                if (cek_laki_laki.Checked == true)
                {
                    KTP.Jenis_kelamin = "Laki-laki";
                }
                else if (cek_perempuan.Checked == true)
                {
                    KTP.Jenis_kelamin = "Perempuan";
                };
                KTP.Alamat = txb_alamat.Text;
                KTP.Agama = cmb_agama.Text;
                KTP.Status_perkawinan = txb_status_perkawinan.Text;
                KTP.Pekerjaan = txb_pekerjaan.Text;
                KTP.Kewarganegaraan = txb_kewarganegaraan.Text;


                KTP.Foto = txb_nik.Text + ".jpg";
                copyFile(txb_nik.Text);

                KTP.ubahData(txb_nik.Text);
                MessageBox.Show("Data berhasil diubah.", "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                bersihkan();
                tampil();
            }
            else
            {
                MessageBox.Show("Data Gagal diubah.", "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void btn_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Foto (*.jpg)|*.jpg";

            if (of.ShowDialog() == DialogResult.OK)
            {
                box_foto.Load(of.FileName);
                sumber = of.FileName;
            }
        }


        private void grid_ktp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow baris = this.grid_ktp.Rows[e.RowIndex];
                string asal = baris.Cells[0].Value.ToString() + ".jpg";
                txb_nik.Text = baris.Cells[0].Value.ToString();
                txb_nama_lengkap.Text = baris.Cells[1].Value.ToString();
                txb_tempat_lahir.Text = baris.Cells[2].Value.ToString();
                date_tgl_lahir.Text = baris.Cells[3].Value.ToString();
                string kelamin = baris.Cells[4].Value.ToString();
                if (kelamin == "Laki-laki")
                {
                    cek_laki_laki.Checked = true;
                }
                else if (kelamin == "Perempuan")
                {
                    cek_perempuan.Checked = true;
                }
                txb_alamat.Text = baris.Cells[5].Value.ToString();
                cmb_agama.Text = baris.Cells[6].Value.ToString();
                txb_status_perkawinan.Text = baris.Cells[7].Value.ToString();
                txb_pekerjaan.Text = baris.Cells[8].Value.ToString();
                txb_kewarganegaraan.Text = baris.Cells[9].Value.ToString();
               
                box_foto.Load(target + baris.Cells[10].Value.ToString());
                sumber = target + baris.Cells[10].Value.ToString();
            }
        }

        private void txb_cari_TextChanged(object sender, EventArgs e)
        {
            tampil();
        }


        private void btn_cetak_Click(object sender, EventArgs e)
        {
            if (txb_nik.Text.Trim() == "" )
            {
                MessageBox.Show("Pilih data yang akan dicetak.", "Informasi", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
               
            }
            else
            {
                
                 Form_KTPRptCrp cetakKtp = new Form_KTPRptCrp(txb_nik.Text.Trim());
                 cetakKtp.ShowDialog();
            }
        }
  

 






    }
}
