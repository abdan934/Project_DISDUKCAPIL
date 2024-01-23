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
    using model;
    public partial class CRUDUser : Form
    {
        USER user = new USER();

        public CRUDUser()
        {
            InitializeComponent();
        }

        private void cek_btn_Click(object sender, EventArgs e)
        {
            if (user.cekUsername(user_txt.Text))
            {
                MessageBox.Show("Data Sudah Ada");
            }
            else
            {
                MessageBox.Show("Data Tidak Ada"); 
            }
        }

        private void simpan_btn_Click(object sender, EventArgs e)
        {
            if (!user.cekUsername(user_txt.Text))
            {
                user.Username = user_txt.Text;
                user.Password = pw_txt.Text;
                user.simpanData();
                MessageBox.Show("Data Berhasil Disimpan",
                "INFORMASI",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

                bersihkan();
                user_txt.Focus();
                tampilGrid();
            }
        }
        void bersihkan()
        {
            user_txt.Clear();
            pw_txt.Clear();
        }
        
        private void ubah_btn_Click(object sender, EventArgs e)
        {
            if (user.cekUsername(user_txt.Text))
            {
                user.Username = user_txt.Text;
                user.Password = pw_txt.Text;
                user.ubahData(id_user_txt.Text);
                MessageBox.Show("Data Berhasil diubah",
                    "INFORMASI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                bersihkan();
                user_txt.Focus();
                tampilGrid();
            }

        }

        private void hapus_btn_Click(object sender, EventArgs e)
        {
            if (user.cekUsername(user_txt.Text))
            {
                user.hapusData(id_user_txt.Text);
                MessageBox.Show("Data berhasil dihapus",
                    "INFORMASI",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                bersihkan();
                user_txt.Focus();
                tampilGrid();
            }
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

        void tampilGrid()
        {
            if (cari_txt.Text.Length == 0)
            {
                user_dgv.DataSource = user.tampilSemua();
                belangbelang(user_dgv);
            }
            else 
            {
                user_dgv.DataSource = user.cariData(cari_txt.Text);
            }
        }

        private void CRUDUser_Load(object sender, EventArgs e)
        {
            tampilGrid();
        }

     

        private void user_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow baris = this.user_dgv.Rows[e.RowIndex];
                user_txt.Text = baris.Cells[1].Value.ToString();
                pw_txt.Text = baris.Cells[2].Value.ToString();
                id_user_txt.Text = baris.Cells[0].Value.ToString();
                tampilGrid();
            }
        }

        private void cari_txt_TextChanged(object sender, EventArgs e)
        {
            tampilGrid();
        }

        private void cetak_btn_Click(object sender, EventArgs e)
        {
            if (user_txt.Text == "")
            {
               
            }
        }



     







    }


}
