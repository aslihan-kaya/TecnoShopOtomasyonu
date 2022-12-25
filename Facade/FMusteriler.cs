using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entity;

namespace Facade
{
   public class FMusteriler
    {
        public static int Ekleme(EMusteriler veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("MEkle", DBaglanti.con);
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("MusteriAdi", veri.MusteriAdi);
                komut.Parameters.AddWithValue("MTelefon", veri.MTelefon);
                komut.Parameters.AddWithValue("MAdres", veri.MAdres);
                komut.Parameters.AddWithValue("PersonelNo", veri.PersonelNo);
                islem = komut.ExecuteNonQuery();

            }
            catch
            {

                islem = -1;
            }
            return islem;
        }
        public static DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("MListele", DBaglanti.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Guncelle(EMusteriler islem)
        {
            SqlCommand komut = new SqlCommand("MYenile", DBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("MusteriNo", islem.MusteriNo);
            komut.Parameters.AddWithValue("MusteriAdi", islem.MusteriAdi);
            komut.Parameters.AddWithValue("MTelefon", islem.MTelefon);
            komut.Parameters.AddWithValue("MAdres", islem.MAdres);
            komut.Parameters.AddWithValue("PersonelNo", islem.PersonelNo);

            return DBaglanti.ExecuteNonQuery(komut);
        }
        public static bool Sil(EMusteriler islem)
        {
            SqlCommand komut = new SqlCommand("MSil", DBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("MusteriNo", islem.MusteriNo);
            return DBaglanti.ExecuteNonQuery(komut);
        }
    }
}
