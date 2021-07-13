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
        //son test yapıldı
        //BURADA ÖĞRENCİ KAYIT EKRANINDA GİRİLEN BİLGİLER ALNIYOR
        string ad = Request.QueryString["adtxt"];
        string soyad = Request.QueryString["soyadtxt"];
        string email = Request.QueryString["emailtxt"];
        string tc = Request.QueryString["tctxt"];
        string sfr = Request.QueryString["sfr"];
        string bolum = Request.QueryString["bolum"];
        string sinif = Request.QueryString["sinif"];
             

        
        DbCrud dbcrud = new DbCrud();
        Ogrenci ogrenci = new Ogrenci();
        OgrenciCrud ogrencicrud = new OgrenciCrud();
        //BURADA ÖĞRENCİ BİLGİLERİ Ogrenci SINIFINDAN TÜRETİLEN ogrenci NESNESİNE AKTARILIYOR
        ogrenci.ad = ad;
        ogrenci.soyad = soyad;
        ogrenci.email = email;
        ogrenci.tc = tc;
        ogrenci.sfr = sfr;
        ogrenci.bolum = bolum;
        ogrenci.sinif = sinif;
        
        //OgrenciCRUD SINIFI İÇERİSİNDE TANIMLANAN OgrenciKayit METODUYLA BİLGİLER VERİTABANINA KAYDEDİLİYOR.
        if (ogrencicrud.OgrenciKayit(ogrenci)==1)
        sonuc.InnerHtml = "Uzaktan Eğitim Sistemine Kaydınız Yapılmıştır.</br>Üye Girişi Yapmak İçin Lütfen <a href='uyegiris.aspx'>Tıklayınız</a>";

        else
         sonuc.InnerHtml = "Uzaktan Eğitim Sistemine Kaydınız Yapılamıştır!!!"; 
       
        

    
		 
	}
}

