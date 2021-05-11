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

        ogrenci.ad = ad;
        ogrenci.soyad = soyad;
        ogrenci.email = email;
        ogrenci.tc = tc;
        ogrenci.sfr = sfr;
        ogrenci.bolum = bolum;
        ogrenci.sinif = sinif;
        /*
        if (ogrencicrud.OgrenciKayit(ogrenci)==1)
        sonuc.InnerHtml = "Uzaktan Eğitim Sistemine Kaydınız Yapılmıştır.";
        else
         sonuc.InnerHtml = "Uzaktan Eğitim Sistemine Kaydınız Yapılamıştır!!!"; */
       
        

    
		 
	}
}

public class DbCRUD
{
}