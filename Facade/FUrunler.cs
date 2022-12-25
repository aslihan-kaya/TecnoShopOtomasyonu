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
   public class FUrunler
    {
        public static int Ekleme(EUrunler veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("UEkle", DBaglanti.con);
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("UrunTipi", veri.UrunTipi);
                komut.Parameters.AddWithValue("UrunAdi", veri.UrunAdi);
                komut.Parameters.AddWithValue("UrunFiyat", veri.UrunFiyat);
                komut.Parameters.AddWithValue("MusteriNo", veri.MusteriNo);
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
            SqlDataAdapter adp = new SqlDataAdapter("UListele", DBaglanti.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Guncelle(EUrunler islem)
        {
            SqlCommand komut = new SqlCommand("UYenile", DBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("UrunNo", islem.UrunNo);
            komut.Parameters.AddWithValue("UrunTipi", islem.UrunTipi);
            komut.Parameters.AddWithValue("UrunAdi", islem.UrunAdi);
            komut.Parameters.AddWithValue("UrunFiyat", islem.UrunFiyat);
            komut.Parameters.AddWithValue("MusteriNo", islem.MusteriNo);

            return DBaglanti.ExecuteNonQuery(komut);
        }
        public static bool Sil(EUrunler islem)
        {
            SqlCommand komut = new SqlCommand("USil", DBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("UrunNo", islem.UrunNo);
            return DBaglanti.ExecuteNonQuery(komut);
        }
    }
}
