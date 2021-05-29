using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for VideoCrud
/// </summary>
public class VideoCrud
{
    DbCrud dbcrud = new DbCrud();
    
    public DataTable videolar(string ders)
    {
        dbcrud.baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM TblDers_Video inner join TblVideolar on TblDers_Video.D_VideoKod=TblVideolar.VideoKod WHERE D_Kodu=@p1", dbcrud.baglanti);
        komut.Parameters.AddWithValue("@p1", ders);

        DataTable dt = new DataTable();
        dt.Load(komut.ExecuteReader());
        dbcrud.baglanti.Close();
        return dt;
    }
    public DataTable video(string vkod)
    {
        dbcrud.baglanti.Open();
        //SqlCommand komut = new SqlCommand("SELECT * FROM TblDers_Video inner join TblVideolar on TblDers_Video.D_VideoKod=TblVideolar.VideoKod WHERE D_VideoKod=@p1", dbcrud.baglanti);
        SqlCommand komut = new SqlCommand("SELECT * FROM TblVideolar WHERE VideoKod=@p1", dbcrud.baglanti);
        komut.Parameters.AddWithValue("@p1", vkod);
        DataTable dt = new DataTable();
        dt.Load(komut.ExecuteReader());
        dbcrud.baglanti.Close();
        return dt;
    }
}