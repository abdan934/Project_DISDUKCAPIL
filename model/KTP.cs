using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Form_Projek_Akhir.config;
using System.IO;
using System.Data;

namespace Form_Projek_Akhir.model
{
    class KTP
    {
        private servisDb serverDb;
        private DataTable temp;
        private string Query = "";
        string sumber = "", target = @"D:\Abdan\Semester 3 (ME)\PBO II\Form_Projek_Akhir\foto\";

        private string _nik;
        private string _nama_lengkap;
        private string _tempat_lahir;
        private string _tgl_lahir;
        private string _jenis_kelamin;
        private string _alamat;
        private string _agama;
        private string _status_perkawinan;
        private string _pekerjaan;
        private string _kewarganegaraan;
        private string _foto;


        void copyFile(string npm)
        {
            File.Copy(sumber, target + npm + ".jpg", true);
        }

        public KTP()
        {
            serverDb = new servisDb();
            temp = new DataTable();

            _nik = "";
            _nama_lengkap = "";
            _tempat_lahir = "";
            _tgl_lahir = "";
            _jenis_kelamin = "";
            _alamat = "";
            _agama = "";
            _status_perkawinan = "";
            _pekerjaan = "";
            _kewarganegaraan = "";
            _foto = "";
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

        public string Foto
        {
            set { _foto = value; }
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

        public bool cekNoNik_diDetail_Kk(string nik)
        {
            bool cek = false;
            Query = "SELECT DISTINCT * FROM tb_detail_kk WHERE nik='" + nik + "'";
            temp = serverDb.eksekusiQuery(Query);

            if (temp.Rows.Count > 0)
            {
                cek = true;
            }

            return cek;
        }

        public DataTable tampilSemua()
        {
            Query = "SELECT DISTINCT * FROM tb_ktp";
            return serverDb.eksekusiQuery(Query);
        }

        public DataTable cariNik(string cari)
        {
            Query = "SELECT DISTINCT * FROM tb_ktp WHERE nama_lengkap like '%" + cari + "%'";
            return serverDb.eksekusiQuery(Query);
        }

        public void simpanData()
        {
            Query = "INSERT INTO tb_ktp VALUES ('" + _nik + "','" + _nama_lengkap + "','" + _tempat_lahir + "','"
                + _tgl_lahir + "','" + _jenis_kelamin + "','" + _alamat + "','" + _agama + "','" + _status_perkawinan +
                "','" + _pekerjaan + "','" + _kewarganegaraan + "','" + _foto + "')";
            if (!(serverDb.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal disimpan");
            }
        }

        public void hapusData(string nik)
        {
            Query = "DELETE FROM tb_ktp WHERE nik = '" + nik + "'";
            if (!(serverDb.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal dihapus, Harap cek kembali apakah data sudah ada di detail KK..?");
            }
        }

        public string tampilNamaByNik(string nik)
        {
            string nama_lengkap = "";
            Query = " SELECT nama_lengkap FROM tb_ktp WHERE nik='" + nik + "'";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    nama_lengkap = data[0].ToString();
                }

            }
            return nama_lengkap;
        }

        public string tampilTempat_lahirByNik(string nik)
        {
            string tempat_lahir = "";
            Query = " SELECT tempat_lahir FROM tb_ktp WHERE nik='" + nik + "'";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    tempat_lahir = data[0].ToString();
                }

            }
            return tempat_lahir;
        }

        public string tampilJenis_kelaminByNik(string nik)
        {
            string jenis_kelamin = "";
            Query = " SELECT jenis_kelamin FROM tb_ktp WHERE nik='" + nik + "'";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    jenis_kelamin = data[0].ToString();
                }

            }
            return jenis_kelamin;
        }

        public string tampilTgl_lahirByNik(string nik)
        {
            string tgl_lahir = "";
            Query = " SELECT tgl_lahir FROM tb_ktp WHERE nik='" + nik + "'";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    tgl_lahir = data[0].ToString();
                }

            }
            return tgl_lahir;
        }

        public string tampilAgamaByNik(string nik)
        {
            string agama = "";
            Query = " SELECT agama FROM tb_ktp WHERE nik='" + nik + "'";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    agama = data[0].ToString();
                }

            }
            return agama;
        }

        public string tampilStatus_kawinByNik(string nik)
        {
            string status_hub = "";
            Query = " SELECT status_perkawinan FROM tb_ktp WHERE nik='" + nik + "'";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    status_hub = data[0].ToString();
                }

            }
            return status_hub;
        }

        public string tampilPekerjaanByNik(string nik)
        {
            string pekerjaan = "";
            Query = " SELECT pekerjaan FROM tb_ktp WHERE nik='" + nik + "'";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    pekerjaan = data[0].ToString();
                }

            }
            return pekerjaan;
        }

        public string tampilKewarganegaraanByNik(string nik)
        {
            string kewarganegaraan = "";
            Query = " SELECT kewarganegaraan FROM tb_ktp WHERE nik='" + nik + "'";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    kewarganegaraan = data[0].ToString();
                }

            }
            return kewarganegaraan;
        }

        public void ubahData(string nik)
        {
            Query = "UPDATE tb_ktp SET nama_lengkap= '" + _nama_lengkap + "',tempat_lahir ='" +
                _tempat_lahir + "',tgl_lahir = '" + _tgl_lahir + "',jenis_kelamin = '" + _jenis_kelamin +
                "',alamat = '" + _alamat + "',agama = '" + _agama + "',status_perkawinan = '" + _status_perkawinan +
                "',pekerjaan = '" + _pekerjaan + "',kewarganegaraan = '" + _kewarganegaraan + "',foto = '" + _foto + "' WHERE" + " nik = '" + nik + "'";
            if (!(serverDb.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal diubah");
            }
        }


        public string tampiltotalJKL()
        {
            string jenislaki = "";
            Query = "SELECT COUNT(jenis_kelamin) FROM tb_ktp WHERE jenis_kelamin = 'Laki-laki'";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    jenislaki = data[0].ToString();
                }

            }
            return jenislaki;
        }

        public string tampiltotalJKP()
        {
            string jenisperempuan = "";
            Query = "SELECT COUNT(jenis_kelamin) FROM tb_ktp WHERE jenis_kelamin = 'Perempuan'";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    jenisperempuan = data[0].ToString();
                }

            }
            return jenisperempuan;
        }


        public string tampiltotalJK()
        {
            string jenis = "";
            Query = "SELECT COUNT(jenis_kelamin) FROM tb_ktp";
            temp = serverDb.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    jenis = data[0].ToString();
                }

            }
            return jenis;
        }

    }
}
