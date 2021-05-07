using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OgrenciCrud
/// </summary>
public class OgrenciCrud
{
    public OgrenciCrud()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    DbCrud dbcrud = new DbCrud();
    public int OgrenciKayit(Ogrenci ogr)
    {
        int bayrak;
        dbcrud.baglanti.Open();
        SqlCommand komut = new SqlCommand("INSERT INTO TblOgrenciler (O_Tc_Kimlik,O_Ad,O_Soyad,O_Sifre,[O_E-mail],O_Bolum,O_Sinif) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", dbcrud.baglanti);
        komut.Parameters.AddWithValue("@p1", ogr.Tc);
        komut.Parameters.AddWithValue("@p2", ogr.Ad);
        komut.Parameters.AddWithValue("@p3", ogr.Soyad);
        komut.Parameters.AddWithValue("@p4", ogr.Sfr);
        komut.Parameters.AddWithValue("@p5", ogr.Email);
        komut.Parameters.AddWithValue("@p6", ogr.Bolum);
        komut.Parameters.AddWithValue("@p7", ogr.Sinif);
        bayrak=komut.ExecuteNonQuery();
        dbcrud.baglanti.Close();
        return bayrak;
    }
    public bool uyemi(string gtc,string sfr)
    {
        dbcrud.baglanti.Open();
        SqlCommand komut = new SqlCommand("Select Count( O_Tc_Kimlik) from TblOgrenciler Where O_Tc_Kimlik=@p1 and O_Sifre=@p2", dbcrud.baglanti);
        komut.Parameters.AddWithValue("@p1", gtc);
        komut.Parameters.AddWithValue("@p2", sfr);
        int ks = Convert.ToInt16(komut.ExecuteScalar());
        if (ks > 0)
        {
            return true;
        }
        dbcrud.baglanti.Close();
        return false;

    }
}