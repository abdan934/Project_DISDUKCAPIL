using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using Form_Projek_Akhir.config;

namespace Form_Projek_Akhir.model
{
    class Kk
    {
        private servisDb serverDb;
        private DataTable temp;
        private string Query = "";

        private string _no_kk;
        private string _alamat;

        public Kk()
        {
            serverDb = new servisDb();
            temp = new DataTable();

            _no_kk = "";
            _alamat = "";
        }

        public string No_kk
        {
            set { _no_kk = value; }
        }

        public string Alamat
        {
            set { _alamat= value; }
        }

        public bool cekNo_kk(string no_kk)
        {
            bool cek = false;
            Query = "SELECT * FROM tb_kk WHERE no_kk='" + no_kk + "'";
            temp = serverDb.eksekusiQuery(Query);

            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public bool cekNoKk_diDetail_Kk(string no_kk)
        {
            bool cek = false;
            Query = "SELECT * FROM tb_detail_kk WHERE no_kk='" + no_kk + "'";
            temp = serverDb.eksekusiQuery(Query);

            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public string tampilnamaSuami(string no_kk)
        {
            string suami = "";
            Query = "SELECT distinct tb_detail_kk.nama_lengkap FROM tb_kk,tb_detail_kk WHERE tb_detail_kk.status_hubungan = 'Kepala Keluarga' AND tb_kk.no_kk='"+no_kk+"' AND tb_detail_kk.no_kk=tb_kk.no_kk";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    suami = data[0].ToString();
                }

            }
            return suami;
        }

        public string tampiltotalAnak()
        {
            string Anak = "";
            Query = "SELECT DISTINCT COUNT(nik) FROM tb_detail_kk WHERE status_hubungan LIKE  'Anak %'";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    Anak = data[0].ToString();
                }

            }
            return Anak;
        }

        public string tampiltotalRW01()
        {
            string Rw = "";
            Query = "SELECT DISTINCT COUNT(nik) FROM tb_detail_kk WHERE alamat LIKE  '%RW01%'";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    Rw = data[0].ToString();
                }

            }
            return Rw;
        }

        public string tampiltotalRW02()
        {
            string Rw = "";
            Query = "SELECT DISTINCT COUNT(nik) FROM tb_detail_kk WHERE alamat LIKE  '%RW02%'";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    Rw = data[0].ToString();
                }

            }
            return Rw;
        }

        public DataTable tampilSemua()
        {
            Query = "SELECT DISTINCT * FROM tb_kk";
            return serverDb.eksekusiQuery(Query);
        }

        public DataTable cariNo_kk(string cari)
        {
            Query = "SELECT DISTINCT * FROM tb_kk WHERE no_kk like '%" + cari + "%'";
            return serverDb.eksekusiQuery(Query);
        }

        public void simpanData()
        {
            Query = "INSERT INTO tb_kk VALUES ('" + _no_kk + "','" + _alamat +  "')";
            if (!(serverDb.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal disimpan");
            }
        }

        public void hapusData(string no_kk)
        {
            Query = "DELETE FROM tb_kk WHERE no_kk = '" + no_kk + "'";
            if (!(serverDb.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal dihapus");
            }
        }

        public string tampilAlamatByNo_kk(string no_kk)
        {
            string alamat = "";
            Query = " SELECT alamat FROM tb_kk WHERE no_kk='" + no_kk + "'";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    alamat = data[0].ToString();
                }

            }
            return alamat;
        }

        public void ubahData(string no_kk)
        {
            Query = "UPDATE tb_kk SET alamat= '" + _alamat + "' WHERE" + " no_kk = '" + no_kk + "'";
            if (!(serverDb.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal diubah");
            }
        }

    }
}
