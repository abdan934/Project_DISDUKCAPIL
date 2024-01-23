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
    public partial class form_KK : Form
    {
        KTP KTP = new KTP();
        Detail_KK KK = new Detail_KK();
        Kk Kk = new Kk();


        public form_KK()
        {
            InitializeComponent();
        }

        void besihkan()
        {
            textBox_no_kk.Clear();
            textBox_nama_lengkap.Clear();
            textBox_nik.Clear();
            radioButton_laki_laki.Checked = false;
            radioButton_perempuan.Checked = false;
            textBox_tempat_lahir.Clear();
            textBox_tgl_lahir.ResetText();
            cmb_agama.Text = "(None)";
            textBox_pendidikan.Clear();
            textBox_jenis_pekerjaan.Clear();
            textBox_status_pernikahan.Clear();
            textBox_status_hubungan_dalam_keluarga.Clear();
            textBox_kewarganegaraan.Clear();
            textBox_no_kk.Focus();
            txb_alamat.Clear();
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
            if (txb_cari.Text.Length == 0 && txb_cari_alamat.Text.Length == 0)
            {
                grid_kk.DataSource = KK.tampilSemuaKK();
                belangbelang(grid_kk);
            }
            else if (txb_cari.Text.Length > 0)
            {
                //grid_kk.DataSource = KK.cariData(txb_cari.Text);
               // grid_kk.DataSource = KK.cariDataRtRw(txb_cari_alamat.Text);
                //grid_kk.DataSource = KK.cariNik(txb_cari.Text);
                grid_kk.DataSource = KK.cariNo_kk(txb_cari.Text);
                //grid_kk.DataSource = KK.cariHubungan(txb_cari.Text);
                belangbelang(grid_kk);
            }
            else if (txb_cari_alamat.Text.Length > 0)
            {
               grid_kk.DataSource = KK.cariData(txb_cari.Text);
                grid_kk.DataSource = KK.cariDataRtRw(txb_cari_alamat.Text);
                //grid_kk.DataSource = KK.cariNik(txb_cari.Text);
                grid_kk.DataSource = KK.cariNo_kk(txb_cari.Text);
                //grid_kk.DataSource = KK.cariHubungan(txb_cari.Text);
                belangbelang(grid_kk);
            }

        }

        private void textBox_no_kk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void textBox_nik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void btn_cek_no_kk_Click_1(object sender, EventArgs e)
        {
            if (Kk.cekNo_kk(textBox_no_kk.Text))
            {
                txb_alamat.Text = Kk.tampilAlamatByNo_kk(textBox_no_kk.Text);
                MessageBox.Show("Data ditemukan");
            }
            else
            {
                MessageBox.Show("Data tidak ada");
            }
        }

        private void btn_cek_Click_1(object sender, EventArgs e)
        {
            if (KTP.cekNik(textBox_nik.Text))
            {

                //KTP.tampilNamaByNik(textBox_nik.Text);
                textBox_nama_lengkap.Text = KTP.tampilNamaByNik(textBox_nik.Text);
                textBox_tempat_lahir.Text = KTP.tampilTempat_lahirByNik(textBox_nik.Text);
                textBox_tgl_lahir.Text = KTP.tampilTgl_lahirByNik(textBox_nik.Text);
                string kelamin = KTP.tampilJenis_kelaminByNik(textBox_nik.Text);
                if (kelamin == "Laki-laki")
                {
                    radioButton_laki_laki.Checked = true;
                }
                else if (kelamin == "Perempuan")
                {
                    radioButton_perempuan.Checked = true;
                }
                cmb_agama.Text = KTP.tampilAgamaByNik(textBox_nik.Text);
                textBox_status_pernikahan.Text = KTP.tampilStatus_kawinByNik(textBox_nik.Text);
                textBox_jenis_pekerjaan.Text = KTP.tampilPekerjaanByNik(textBox_nik.Text);
                textBox_kewarganegaraan.Text = KTP.tampilKewarganegaraanByNik(textBox_nik.Text);
            }
            else
            {
                MessageBox.Show("Data tidak ada");
            }
        }

        private void button_simpan_Click_1(object sender, EventArgs e)
        {
            if (KK.cekNik(textBox_nik.Text))
            {
                KK.No_kk = textBox_no_kk.Text;
                KK.Nama_lengkap = textBox_nama_lengkap.Text;
                KK.Nik = textBox_nik.Text;
                if (radioButton_laki_laki.Checked == true)
                {
                    KK.Jenis_kelamin = "Laki-laki";
                }
                else if (radioButton_perempuan.Checked == true)
                {
                    KK.Jenis_kelamin = "Perempuan";
                }
                KK.Tempat_lahir = textBox_tempat_lahir.Text;
                KK.Tgl_lahir = textBox_tgl_lahir.Value.ToString("yyy/MM/dd");
                KK.Agama = cmb_agama.Text;
                KK.Pendidikan = textBox_pendidikan.Text;
                KK.Pekerjaan = textBox_jenis_pekerjaan.Text;
                KK.Status_perkawinan = textBox_status_pernikahan.Text;
                KK.Status_hubungan = textBox_status_hubungan_dalam_keluarga.Text;
                KK.Kewarganegaraan = textBox_kewarganegaraan.Text;
                KK.Alamat = txb_alamat.Text;

                KK.simpanDataKk();
                MessageBox.Show("Data berhasil disimpan.", "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                besihkan();
                tampil();
            }

        }

        private void button_batal_Click_1(object sender, EventArgs e)
        {
            besihkan();
        }


        private void form_KK_Load(object sender, EventArgs e)
        {
            textBox_no_kk.Focus();
            tampil();
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin menghapus data tersebut..?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (KK.cekNik(textBox_nik.Text))
                {
                    KK.Nik = textBox_nik.Text;
                    KK.hapusDataKk(textBox_nik.Text);
                    MessageBox.Show("Data berhasil dihapus.", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    besihkan();
                    tampil();
                }

            }
        }

        private void grid_kk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow baris = this.grid_kk.Rows[e.RowIndex];

                textBox_no_kk.Text = baris.Cells[0].Value.ToString();
                textBox_nik.Text = baris.Cells[2].Value.ToString();
                textBox_nama_lengkap.Text = baris.Cells[1].Value.ToString();
                string kelamin = baris.Cells[3].Value.ToString();
                if (kelamin == "Laki-laki")
                {
                    radioButton_laki_laki.Checked = true;
                }
                else if (kelamin == "Perempuan")
                {
                    radioButton_perempuan.Checked = true;
                }
                textBox_tempat_lahir.Text = baris.Cells[4].Value.ToString();
                textBox_tgl_lahir.Text = baris.Cells[5].Value.ToString();
                cmb_agama.Text = baris.Cells[6].Value.ToString();
                textBox_pendidikan.Text = baris.Cells[7].Value.ToString();
                textBox_jenis_pekerjaan.Text = baris.Cells[8].Value.ToString();
                textBox_status_pernikahan.Text = baris.Cells[9].Value.ToString();
                textBox_status_hubungan_dalam_keluarga.Text = baris.Cells[10].Value.ToString();
                textBox_kewarganegaraan.Text = baris.Cells[11].Value.ToString();
                txb_alamat.Text = baris.Cells[12].Value.ToString();
            }
        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            if (KK.cekNik(textBox_nik.Text))
            {
                //Mahasiswa.Npm= npm_txt.Text;

                KK.No_kk = textBox_no_kk.Text;
                KK.Nik = textBox_nik.Text;
                KK.Nama_lengkap = textBox_nama_lengkap.Text;
                if (radioButton_laki_laki.Checked == true)
                {
                    KK.Jenis_kelamin = "Laki-laki";
                }
                else if (radioButton_perempuan.Checked == true)
                {
                    KK.Jenis_kelamin = "Perempuan";
                }
                KK.Tempat_lahir = textBox_tempat_lahir.Text;
                KK.Tgl_lahir = textBox_tgl_lahir.Value.ToString("yyy/MM/dd");
                KK.Agama = cmb_agama.Text;
                KK.Pendidikan = textBox_pendidikan.Text;
                KK.Pekerjaan = textBox_jenis_pekerjaan.Text;
                KK.Status_perkawinan = textBox_status_pernikahan.Text;
                KK.Status_hubungan = textBox_status_hubungan_dalam_keluarga.Text;
                KK.Kewarganegaraan = textBox_kewarganegaraan.Text;
                KK.Alamat = txb_alamat.Text;


                KK.ubahDataKk(textBox_nik.Text);
                MessageBox.Show("Data berhasil diubah.", "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                besihkan();
                tampil();
            }
            else
            {
                MessageBox.Show("Data Gagal diubah.", "Gagal", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            }
        }

        private void txb_cari_TextChanged(object sender, EventArgs e)
        {
            tampil();
        }

        private void btn_cetak_Click(object sender, EventArgs e)
        {
            if (textBox_no_kk.Text.Trim() == "")
            {
                MessageBox.Show("Pilih data yang akan dicetak.", "Informasi", MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
            else
            {
                Form_KKrptCr cetakKk = new Form_KKrptCr(textBox_no_kk.Text.Trim());
                cetakKk.ShowDialog();
            }
        }

        private void txb_cari_alamat_TextChanged(object sender, EventArgs e)
        {
            tampil();
        }

    }
}