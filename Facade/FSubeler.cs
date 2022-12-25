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
   public class FSubeler
    {
        public static int Ekleme(ESubeler veri)
        {
            int islem = 0;
            try
            {
                SqlCommand komut = new SqlCommand("SEkle", DBaglanti.con);
                komut.CommandType = CommandType.StoredProcedure;
                if (komut.Connection.State != ConnectionState.Open)
                {
                    komut.Connection.Open();
                }
                komut.Parameters.AddWithValue("SubeAdi", veri.SubeAdi);
                komut.Parameters.AddWithValue("Subeil", veri.Subeil);
                komut.Parameters.AddWithValue("Subeilce", veri.Subeilce);
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
            SqlDataAdapter adp = new SqlDataAdapter("SListele", DBaglanti.con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        public static bool Guncelle(ESubeler islem)
        {
            SqlCommand komut = new SqlCommand("SYenile", DBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("SubeNo", islem.SubeNo);
            komut.Parameters.AddWithValue("SubeAdi", islem.SubeAdi);
            komut.Parameters.AddWithValue("Subeil", islem.Subeil);
            komut.Parameters.AddWithValue("Subeilce", islem.Subeilce);
            return DBaglanti.ExecuteNonQuery(komut);
        }
        public static bool Sil(ESubeler islem)
        {
            SqlCommand komut = new SqlCommand("SSil", DBaglanti.con);
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("SubeNo", islem.SubeNo);
            return DBaglanti.ExecuteNonQuery(komut);
        }
    }
}
