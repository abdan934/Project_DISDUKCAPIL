using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Form_Projek_Akhir.config;

namespace Form_Projek_Akhir.model
{
    //using Konfigurasi; bisa taruh diatas ato dibuat disini

    internal class USER
    {
        private servisDb serverDB;
        private DataTable temp;

        private string Query = "";

        private string _username;
        private string _pw;
        private string _id_user;

        public USER()
        {
            serverDB = new servisDb();
            temp = new DataTable();

            _username = "";
            _pw = "";
            _id_user = "";
        }

        //karna sifatnya private maka harus pake properti yg public, bisa berisi mutator(set) atau aksesor(get), tergantung tipe atributnya

        //property


        public string Username
        {
            set { _username = value; } 
        }

        public string Password
        {
            set { _pw = value; }
        }

        public string Id_user
        {
            set { _id_user = value; }
        }

        public bool login(string user,string pw)
        {
            bool cek = false;
            Query = "select DISTINCT * from tb_user where username='" + user + "' and pw='" + pw + "'";
            temp = serverDB.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        public bool cekUsername(string user)
        {
            bool cek = false;
            Query = "select * from tb_user where username='" + user + "'";
            temp = serverDB.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }

        
        public bool cekPw(string pw)
        {
            bool cek = false;
            Query = "select * from tb_user where pw='" + pw + "'";
            temp = serverDB.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                cek = true;
            }
            return cek;
        }
        public void simpanData()
        {
            Query = "insert into tb_user (username,pw) values ('" + _username + "','" + _pw + "')";
            if (!(serverDB.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal disimpan");
            }
        }

        public void ubahData(string id_user)
        {
            Query = "update tb_user set username='" + _username + "', pw = '" + _pw + "' where id_user = '" + id_user + "'";
            if (!(serverDB.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal diubah");
            }
        }

        public void hapusData(string id_user)
        {
            Query = "delete from tb_user where id_user = '" + id_user + "'";
            if (!(serverDB.eksekusiNonQuery(Query) > 0))
            {
                throw new Exception("Data gagal dihapus");
            }
        }
        public DataTable tampilSemua()
        {
            Query = "select * from tb_user";
            return serverDB.eksekusiQuery(Query);
        }

        public string tampilPassbyUser(string user)
        {
            string pw = "";
            Query = "select password from tb_user where username = '" + user + "' ";
            temp = serverDB.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    pw = data[0].ToString();
                }
            }
            return pw;
        }

        public string tampilusernamebyUser(string username)
        {
            string user = "";
            Query = "select username from tb_user where username = '" + username + "' ";
            temp = serverDB.eksekusiQuery(Query);
            if (temp.Rows.Count > 0)
            {
                foreach (DataRow data in temp.Rows)
                {
                    user = data[0].ToString();
                }
            }
            return user;
        }

        public System.Data.DataTable cariData(string cari)
        {
            Query = "select * from tb_user where username like '%" + cari + "%'";
            return serverDB.eksekusiQuery(Query);
        }




    }
}
