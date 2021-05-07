using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kayit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string ad = Request.QueryString["adtxt"];
        string soyad = Request.QueryString["soyadtxt"];
        string email = Request.QueryString["emailtxt"];
        string tc = Request.QueryString["tctxt"];
        string sfr = Request.QueryString["sfr"];
        string bolum = Request.QueryString["bolum"];
        string sinif = Request.QueryString["sinif"];
             

        string tarih = System.DateTime.Now.ToShortTimeString();
        DbCrud dbcrud = new DbCrud();
        Ogrenci ogrenci = new Ogrenci();
        OgrenciCrud ogrencicrud = new OgrenciCrud();

        ogrenci.Ad = ad;
        ogrenci.Soyad = soyad;
        ogrenci.Email = email;
        ogrenci.Tc = tc;
        ogrenci.Sfr = sfr;
        ogrenci.Bolum = bolum;
        ogrenci.Sinif = sinif;
        if(ogrencicrud.OgrenciKayit(ogrenci))
        { sonuc.InnerHtml = "Uzaktan Eğitim Sistemine Kaydınız Yapılmıştır.";}
       
        

    
		 
	}
}

public class DbCRUD
{
}