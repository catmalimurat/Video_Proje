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
        int bayrak,vistatistik;
        dbcrud.baglanti.Open();
        //videoya ait istatistik
        //eğer daha önce bu videoya ait cevap varsa
        
        SqlCommand ara = new SqlCommand("select count(*) from TblDers_Video_Istatistik where D_VideoKod=@a1", dbcrud.baglanti);
        ara.Parameters.AddWithValue("@a1", dkod);
        vistatistik = Convert.ToInt16(ara.ExecuteScalar());

        if (vistatistik != 0)
        {
            //BURDA YANLIŞ DOĞRUYU AYIRT
            if (dsay==1)
            {
                SqlCommand guncelle = new SqlCommand("update TblDers_Video_Istatistik set DogruSay=DogruSay+1 where D_VideoKod=@a1", dbcrud.baglanti);
            guncelle.Parameters.AddWithValue("@a1", dkod);guncelle.ExecuteNonQuery();}
            if (ysay==1)
            {
SqlCommand guncelle = new SqlCommand("update TblDers_Video_Istatistik set YanlisSay=YanlisSay+1 where D_VideoKod=@a1", dbcrud.baglanti);
                guncelle.Parameters.AddWithValue("@a1", dkod); guncelle.ExecuteNonQuery();
            }
            
            
            
            dbcrud.baglanti.Close();
        }
        else
        {
            //
            dbcrud.baglanti.Close();
            dbcrud.baglanti.Open();

            SqlCommand komut2 = new SqlCommand("INSERT INTO TblDers_Video_Istatistik (D_VideoKod,DogruSay,YanlisSay) values (@pr1,@pr2,@pr3)", dbcrud.baglanti);
        komut2.Parameters.AddWithValue("@pr1", dkod);
        komut2.Parameters.AddWithValue("@pr2", dsay);
        komut2.Parameters.AddWithValue("@pr3", ysay);
        komut2.ExecuteNonQuery();
            dbcrud.baglanti.Close();
        }
      
        dbcrud.baglanti.Open();
        //öğrenciye ait istatistik
        SqlCommand komut = new SqlCommand("INSERT INTO TblOgrenci_Video_Istatistik (O_Tc_Kimlik,D_Kodu,D_VideoKod,DogruSay,YanlisSay) values (@p1,@p2,@p3,@p4,@p5)", dbcrud.baglanti);
        komut.Parameters.AddWithValue("@p1", tc);
        komut.Parameters.AddWithValue("@p2", vkod);
        komut.Parameters.AddWithValue("@p3", dkod);
        komut.Parameters.AddWithValue("@p4", dsay);
        komut.Parameters.AddWithValue("@p5", ysay);       
        bayrak = komut.ExecuteNonQuery();       
        dbcrud.baglanti.Close();
        return bayrak;
    }

    public int cevaplanmis(string tc,string vkod)
    {
        int bayrak;
        dbcrud.baglanti.Open();
        SqlCommand komut = new SqlCommand("select count(*) from TblOgrenci_Video_Istatistik where O_Tc_Kimlik=@p1 and D_VideoKod=@p2", dbcrud.baglanti);
        komut.Parameters.AddWithValue("@p1", tc);
        komut.Parameters.AddWithValue("@p2", vkod);
        bayrak =Convert.ToInt16(komut.ExecuteScalar());
        dbcrud.baglanti.Close();
        return bayrak;
    }

}