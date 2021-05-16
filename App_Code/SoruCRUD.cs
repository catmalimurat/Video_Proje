using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SoruCRUD
/// </summary>
public class SoruCRUD
{
    DbCrud dbcrud = new DbCrud();

    public SoruCRUD()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DataTable sorular(string gvkod)
    {
        dbcrud.baglanti.Open();

        SqlCommand komut = new SqlCommand("SELECT * FROM TblVideo_Soruları WHERE D_VideoKod=@p1", dbcrud.baglanti);
        komut.Parameters.AddWithValue("@p1", gvkod);
        DataTable dt = new DataTable();
        dt.Load(komut.ExecuteReader());
        dbcrud.baglanti.Close();
        return dt;
    }

    public int OgrenciVideoIstatistikKaydet(string tc, string dkod, string vkod, int dsay, int ysay)
    {
        int bayrak;
        dbcrud.baglanti.Open();
        //SqlCommand ara = new SqlCommand("select * from TblOgrenci_Video_Istatistik where O_Tc_Kimlik=tc");

        SqlCommand komut = new SqlCommand("INSERT INTO TblOgrenci_Video_Istatistik (O_Tc_Kimlik,D_Kodu,D_VideoKod,DogruSay,YanlisSay) values (@p1,@p2,@p3,@p4,@p5)", dbcrud.baglanti);
        komut.Parameters.AddWithValue("@p1", tc);
        komut.Parameters.AddWithValue("@p2", dkod);
        komut.Parameters.AddWithValue("@p3", vkod);
        komut.Parameters.AddWithValue("@p4", dsay);
        komut.Parameters.AddWithValue("@p5", ysay);       
        bayrak = komut.ExecuteNonQuery();
        dbcrud.baglanti.Close();
        return bayrak;
    }

}