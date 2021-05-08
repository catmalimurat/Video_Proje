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
    public VideoCrud()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public DataTable videolar(string ders)
    {
        dbcrud.baglanti.Open();

        SqlCommand komut = new SqlCommand("SELECT * FROM TblDers_Video WHERE D_kodu=@p1", dbcrud.baglanti);
        komut.Parameters.AddWithValue("@p1", ders);

        DataTable dt = new DataTable();
        dt.Load(komut.ExecuteReader());
        dbcrud.baglanti.Close();
        return dt;
    }
}