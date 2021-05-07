using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uyekontrol : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string tc = Request.QueryString["tctxt"];
        string sfr = Request.QueryString["sfr"];
        DbCrud dbcrud = new DbCrud();
        
        OgrenciCrud ogrencicrud = new OgrenciCrud();
        if(ogrencicrud.uyemi(tc,sfr))
        {
            Response.Redirect("ogrenci_dersleri.aspx");
        }
        else
        {
            Response.Redirect("uyegiris.aspx?hata=1");
           
        }
    }
}