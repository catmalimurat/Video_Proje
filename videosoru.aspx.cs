using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class soru : System.Web.UI.Page
{
    string dkod,vid;
    SoruCRUD q = new SoruCRUD();
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        dkod = Request.QueryString["vkod"];
        
        SoruCRUD goster = new SoruCRUD();
        DataTable sorular=goster.sorular(dkod);
        if (sorular.Rows.Count > 0)
        {
            Label1.Text = sorular.Rows[0][2].ToString();
            S1.Text = sorular.Rows[0][3].ToString();
            S2.Text = sorular.Rows[0][4].ToString();
            S3.Text = sorular.Rows[0][5].ToString();
            S4.Text = sorular.Rows[0][6].ToString();
            S5.Text = sorular.Rows[0][7].ToString();
            Label2.Text= sorular.Rows[0][8].ToString();
        }
        else { Label1.Text = "Derse ait soru yok...";
            Panel1.Visible = false;
            Response.Write("Dersler sayfasına gitmek için<a href='ogrenci_dersleri.aspx'> tıklayınız</a>");
        }
            
      

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        bool dogru = false;
        dkod = Request.QueryString["vkod"];
        vid = Request.QueryString["vid"];
        if ((S1.Checked) && (S1.ID == Label2.Text))
        {
            dogru = true;
        }
        if ((S2.Checked) && (S2.ID == Label2.Text))
        {
            dogru = true;
        }
        if ((S3.Checked) && (S3.ID == Label2.Text))
        {
            dogru = true;
        }
        if ((S4.Checked) && (S4.ID == Label2.Text))
        {
            dogru = true;
        }
        if ((S5.Checked) && (S5.ID == Label2.Text))
        {
            dogru = true;
        }
        int ysayisi = 0;
        int  dsayisi = 0;
        if (dogru)
        {
            dsayisi = 1;
        }
        else
            ysayisi = 1;

        int sonuc = q.OgrenciVideoIstatistikKaydet(Session["uye"].ToString(), dkod, dkod.Substring(0, 4), dsayisi, ysayisi);
        
        if ((sonuc==1)&&(dogru))
        {
            Response.Write("<script language='javascript'>alert('Cevabınız doğru.Sisteme kaydedildi...')</script>'");
        }
        else if ((sonuc == 1) && (!dogru))
        {
            Response.Write("<script language='javascript'>alert('Cevabınız yanlış.Sisteme kaydedildi...')</script>'");
        }
        else
        { Response.Write("<script language='javascript'>alert('Beklenmeyen bir hata oluştu. Tekrar Deneyiniz...')</script>'"); }

       Response.Redirect("ogrenci_dersleri.aspx");
    }
}