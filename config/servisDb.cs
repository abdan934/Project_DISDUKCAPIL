using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;


namespace Form_Projek_Akhir.config
{
    class servisDb : configDb
    {
        MySqlConnection sqlCon;
        MySqlCommand sqlCom;
        MySqlDataAdapter sqlData;

        string lokasi = "server=localhost;port=3306;database=disdukcapil;"+"uid=root;pwd=";

        public servisDb()
        {
            sqlCon = new MySqlConnection(lokasi);
            sqlCom = new MySqlCommand();
            sqlData = new MySqlDataAdapter();

        }

        void bukakoneksi()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                try
                {
                    sqlCon.Open();
                }
                catch (Exception ex) { }
            }
        }

        void tutupkoneksi()
        {
            sqlCon.Close();
        }

        public override int eksekusiNonQuery(string query)
        {
            int nilaikembali = -1;
            try
            {
                bukakoneksi();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = query;
                nilaikembali = sqlCom.ExecuteNonQuery();
            }
            catch (Exception ex) { }
            finally
            {
                tutupkoneksi();
            }
            return nilaikembali;
        }
        public override DataTable eksekusiQuery(string query)
        {
            DataTable nilaikembali = new DataTable();
            try
            {
                bukakoneksi();
                sqlCom.Connection = sqlCon;
                sqlCom.CommandText = query;
                sqlData.SelectCommand = sqlCom;
                sqlData.Fill(nilaikembali);
            }
            catch (Exception ex) { }
            finally
            {
                tutupkoneksi();
            }
            return nilaikembali;
        }
    }
}
