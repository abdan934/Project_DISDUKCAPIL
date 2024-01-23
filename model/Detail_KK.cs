using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using Form_Projek_Akhir.config;

namespace Form_Projek_Akhir.model
{
    class Detail_KK
    {
        private servisDb serverDb;
        private DataTable temp;
        private string Query = "";
        string sumber = "", target = @"D:\Abdan\Semester 3 (ME)\PBO II\Form_Projek_Akhir\foto\";

        private string _no_kk;
        private string _nik;
        private string _nama_lengkap;
        private string _tempat_lahir;
        private string _tgl_lahir;
        private string _jenis_kelamin;
        private string _pendidikan;
        private string _alamat;
        private string _agama;
        private string _status_perkawinan;
        private string _pekerjaan;
        private string _kewarganegaraan;
        private string _status_hubungan;

        public Detail_KK()
        {
            serverDb = new servisDb();
            temp = new DataTable();

            _no_kk = "";
            _nik = "";
            _nama_lengkap = "";
            _tempat_lahir = "";
            _tgl_lahir = "";
            _jenis_kelamin = "";
            _pendidikan = "";
            _alamat = "";
            _agama = "";
            _status_perkawinan = "";
            _pekerjaan = "";
            _kewarganegaraan = "";
            _status_hubungan = "";
        }

        public string No_kk
        {
            set { _no_kk = value; }
        }

        public string Nik
        {
            set { _nik = value; }
        }

        public string Nama_lengkap
        {
            set { _nama_lengkap = value; }
        }

        public string Tempat_lahir
        {
            set { _tempat_lahir = value; }
        }

        public string Tgl_lahir
        {
            set { _tgl_lahir = value; }
        }

        public string Jenis_kelamin
        {
            set { _jenis_kelamin = value; }
        }

        public string Pendidikan
        {
            set { _pendidikan = value; }
        }

        public string Alamat
        {
            set { _alamat = value; }
        }

        public string Agama
        {
            set { _agama = value; }
        }

        public string Status_perkawinan
        {
            set { _status_perkawinan = value; }
        }

        public string Pekerjaan
        {
            set { _pekerjaan = value; }
        }


        public string Kewarganegaraan
        {
            set { _kewarganegaraan = value; }
        }

        public string Status_hubungan
        {
            set { _status_hubungan = value; }
        }

        public bool cekNo_kk(string no_kk)
        {
            bool cek = false;
            Query = "SELECT DISTINCT * FROM tb_detail_kk WHERE no_kk='" + no_kk + "'";
            temp = serverDb.eksekusiQuery(Query);

            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public bool cekNik(string nik)
        {
            bool cek = false;
            Query = "SELECT DISTINCT * FROM tb_ktp WHERE nik='" + nik + "'";
            temp = serverDb.eksekusiQuery(Query);

            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

      

        public DataTable tampilSemuaKK()
        {
            Query = "SELECT DISTINCT * FROM tb_detail_kk";
            return serverDb.eksekusiQuery(Query);
        }

        public DataTable cariData(string cari)
        {
            Query = "SELECT DISTINCT * FROM tb_detail_kk WHERE nama_lengkap like '%" + cari + "%'";
            return serverDb.eksekusiQuery(Query);
        }

        public DataTable cariDataRtRw(string cari)
        {
            Query = "SELECT DISTINCT * FROM tb_detail_kk, tb_ktp WHERE alamat like '%" + cari + "%' and tb_detail_kk.nik=tb_ktp.nik ";
            return serverDb.eksekusiQuery(Query);
        }

        public DataTable cariNo_kk(string cari)
        {
            Query = "SELECT DISTINCT * FROM tb_detail_kk WHERE no_kk like '%" + cari + "%'";
            return serverDb.eksekusiQuery(Query);
        }

        public DataTable cariNik(string cari)
        {
            Query = "SELECT DISTINCT * FROM tb_detail_kk WHERE nik like '%" + cari + "%'";
            return serverDb.eksekusiQuery(Query);
        }

        public DataTable cariHubungan(string cari)
        {
            Query = "SELECT DISTINCT * FROM tb_detail_kk WHERE status_hubungan like '%" + cari + "%'";
            return serverDb.eksekusiQuery(Query);
        }

        public void simpanDataKk()
        {
            Query = "INSERT INTO tb_detail_kk VALUES ('" + _no_kk + "','"  + _nama_lengkap + "','" + _nik + "','" + _jenis_kelamin + "','"
               + _tempat_lahir + "','" + _tgl_lahir + "','" + _agama + "','" + _pendidikan + "','" + _pekerjaan + "','" +_status_perkawinan +"','" 
               + _status_hubungan +"','" +  _kewarganegaraan + "','"+_alamat+"')";
            if (!(serverDb.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal disimpan");
            }
        }

        public void hapusDataKk(string nik)
        {
            Query = "DELETE FROM tb_detail_kk WHERE nik = '" + nik + "'";
            if (!(serverDb.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal dihapus");
            }
        }

        public void ubahDataKk(string nik)
        {
            Query = "UPDATE tb_detail_kk SET no_kk = '" + _no_kk +"',nama_lengkap= '" + _nama_lengkap + "',nik ='" +
                _nik + "',jenis_kelamin = '" + _jenis_kelamin + "',tempat_lahir = '" + _tempat_lahir + "',tgl_lahir = '" + _tgl_lahir +
                "',agama = '" + _agama+ "',pendidikan = '" + _pendidikan+ "',jenis_pekerjaan = '" + _pekerjaan +
                "',status_pernikahan = '" + _status_perkawinan + "',status_hubungan = '" + _status_hubungan + "',kewarganegaraan = '"
                + _kewarganegaraan +"',alamat = '"+_alamat + "' WHERE" + " nik = '" + nik + "'";
            if (!(serverDb.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal diubah");
            }
        }

    }
}
