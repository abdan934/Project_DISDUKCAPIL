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
    public partial class form_Kk : Form
    {

        Kk Kk = new Kk();

        public form_Kk()
        {
            InitializeComponent();
        }

        void bersihkan()
        {
            txb_no_kk.Clear();
            txb_alamat.Clear();
            txb_no_kk.Focus();
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
                grid_kk.DataSource = Kk.tampilSemua();
                belangbelang(grid_kk);
            }
            else
            {
                grid_kk.DataSource = Kk.cariNo_kk(txb_cari.Text);
                belangbelang(grid_kk);
            }
        }

        private void form_Kk_Load(object sender, EventArgs e)
        {
            bersihkan();
            tampil();
        }

        private void txb_no_kk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void button_simpan_Click(object sender, EventArgs e)
        {
            if (!Kk.cekNo_kk(txb_no_kk.Text))
            {
                Kk.No_kk = txb_no_kk.Text;
                Kk.Alamat = txb_alamat.Text;



                Kk.simpanData();
                MessageBox.Show("Data berhasil disimpan.", "Informasi", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                bersihkan();
                tampil();
            }
            else 
            {
                MessageBox.Show("Data sudah terdaftar..!!","Informasi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        private void button_ubah_Click(object sender, EventArgs e)
        {
            if (Kk.cekNo_kk(txb_no_kk.Text))
            {
 

                Kk.Alamat = txb_alamat.Text;
                

                Kk.ubahData(txb_no_kk.Text);
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

        private void grid_kk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow baris = this.grid_kk.Rows[e.RowIndex];
                txb_no_kk.Text = baris.Cells[0].Value.ToString();
                txb_alamat.Text = baris.Cells[1].Value.ToString();
                txb_nama_suami.Text = Kk.tampilnamaSuami(baris.Cells[0].Value.ToString());
                
            }
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin menghapus data tersebut..?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (Kk.cekNo_kk(txb_no_kk.Text))
                {
                    if (Kk.cekNoKk_diDetail_Kk(txb_no_kk.Text) == false)
                    {
                        Kk.No_kk = txb_no_kk.Text;
                        Kk.hapusData(txb_no_kk.Text);
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

            }
        }

        private void txb_cari_TextChanged(object sender, EventArgs e)
        {
            tampil();
        }



    }
}
