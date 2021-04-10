using System;
using System.Collections.Generic;
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
        string sfr = Request.QueryString["sfrtxt"];
        string bolum = Request.QueryString["bolum"];
        string sinif = Request.QueryString["sinif"];
        
        

        string tarih = System.DateTime.Now.ToShortTimeString();
        //OnkayitDsTableAdapters.Ekim2019KurumsalTableAdapter ekleme = new OnkayitDsTableAdapters.Ekim2019KurumsalTableAdapter();
        //UzmanlikDataSetTableAdapters.UzmanlikBireysel2019TableAdapter ekleme = new UzmanlikDataSetTableAdapters.UzmanlikBireysel2019TableAdapter();
        //*MeslekEdindirmexsdTableAdapters.me2020TableAdapter ekleme = new MeslekEdindirmexsdTableAdapters.me2020TableAdapter();

        string yedek1; 
        yedek1="me"+ad.Substring(0, 2);
      //*  yedek1+=(ekleme.sayi() + 1).ToString();
       
        //if (Convert.ToInt16(ekleme.Varmi(tel)) == 0)
        //{
            //ekleme.KursiyerEkle1()
            //ekleme.KursiyerEkle(ad, email, tel, kurs, onay, ozel, System.DateTime.Now);
           //* ekleme.KursiyerEkle(ad, soyad, email, tel, cinsiyet, kurs, onay, ozel, isdurumu, sehir, sektor, katilim, yedek1, mezun, System.DateTime.Now);

            //ekleme.KursiyerEkle(ad, email, tel,cinsiyet, kurs, onay, ozel, isdurumu, sehir, System.DateTime.Now);
            sonuc.InnerHtml = "Ön başvurunuz alınmıştır.</br>Kayıt takip kodunuz: " + yedek1 + "</br>Yakında başlayacak olan eğitimlerimize kaydınızı tamamlamak için belirtilen kayıt no ve kimliğiniz ile Butgem e gelerek şahsen başvurunuzu tamamlayınız.";

        //}
        //else
        //{
        //    sonuc.InnerHtml = "Daha önce kurs ön başvurunuz yapılmıştır.";

        //}
		 
	}
}