using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DersCrud
/// </summary>
public class DersCrud
{
    DbCrud dbcrud = new DbCrud();
    public DersCrud()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public DataTable dersler(string tc)
    {
        dbcrud.baglanti.Open();
        
        SqlCommand komut = new SqlCommand("SELECT * FROM TblOgrenci_Dersleri  inner join TblDersler on TblDersler.D_Kodu=TblOgrenci_Dersleri.D_Kodu WHERE O_Tc_Kimlik=@p1", dbcrud.baglanti);
        komut.Parameters.AddWithValue("@p1", tc);
        
        DataTable dt = new DataTable();
        dt.Load(komut.ExecuteReader());
        dbcrud.baglanti.Close();
        return dt;
    }
}