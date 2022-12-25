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
  public  class FPersoneller
    {
        public static int Ekleme(EPersoneller veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("PEkle", DBaglanti.con);
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("PersonelAdi", veri.PersonelAdi);
                komut.Parameters.AddWithValue("Telefon", veri.Telefon);
                komut.Parameters.AddWithValue("Adres", veri.Adres);
                komut.Parameters.AddWithValue("Maas", veri.Maas);
                komut.Parameters.AddWithValue("Prim", veri.Prim);
                komut.Parameters.AddWithValue("SubeNo", veri.SubeNo);
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
            SqlDataAdapter adp = new SqlDataAdapter("PListele", DBaglanti.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Guncelle(EPersoneller islem)
        {
            SqlCommand komut = new SqlCommand("PYenile", DBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("PersonelNo", islem.PersonelNo);
            komut.Parameters.AddWithValue("PersonelAdi", islem.PersonelAdi);
            komut.Parameters.AddWithValue("Telefon", islem.Telefon);
            komut.Parameters.AddWithValue("Adres", islem.Adres);
            komut.Parameters.AddWithValue("Maas", islem.Maas);
            komut.Parameters.AddWithValue("Prim", islem.Prim);
            komut.Parameters.AddWithValue("SubeNo", islem.SubeNo);
 
            return DBaglanti.ExecuteNonQuery(komut);
        }
        public static bool Sil(EPersoneller islem)
        {
            SqlCommand komut = new SqlCommand("PSil", DBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("PersonelNo", islem.PersonelNo);
            return DBaglanti.ExecuteNonQuery(komut);
        }
    }
}
