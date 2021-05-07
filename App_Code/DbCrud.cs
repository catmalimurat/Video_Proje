using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DbCrud
/// </summary>
public class DbCrud
{
    public SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4SN9S8I;Initial Catalog=UzaktanEgitimDb;Integrated Security=True");
    public DbCrud()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}