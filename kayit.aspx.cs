using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class bireysel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //test yapıldı
        OgrenciCrud uyekontrol = new OgrenciCrud();
        //BURADA  VERİTABANINDA AYNI T.C KİMLİK NOLU ÖĞRENCİ VARSA, UYARI MESAJI VERİLİYOR.
        if (uyekontrol.uyevarmi(tctxt.Text))
        {
            Response.Write("<script>alert('Bu T.C. Kimlik No ile sistem kayıtlı öğrenci bulunmaktadır. Lütfen Sistem yöntecisi ile iletişime geçiniz.')</script>");
        }
        else
        {
            //BURADA BÖLÜM VE SINIF BİLGİLERİNİN SEÇİLMESİ SAĞLANIYOR.
            if (DropDownList2.SelectedIndex >= 0)
            {
                if (DropDownList3.SelectedIndex >= 0)
                {

                    //BU KOD BLOĞUNDA GİRİLEN BİLGİLER onay.aspx sayfasına aktarılıyor.
                    Response.Redirect("onay.aspx?adtxt=" + adtxt.Text + "&soyadtxt=" + soyadtxt.Text + "&emailtxt=" + emailtxt.Text + "&tctxt=" + tctxt.Text + "&bolum=" + DropDownList2.SelectedValue + "&sinif=" + DropDownList3.SelectedItem.Text + "&sfr=" + sfrtxt.Text);
                                          


                }
                else
                {
                    Response.Write("<script>alert('Sınıf Seçimi yapmalısınız')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Bölüm Seçmelisiniz')</script>");
            }
        }
    }
}