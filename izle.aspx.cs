using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;
using System.Data;

public partial class izle : System.Web.UI.Page
{
    string vid,vkod;
    SoruCRUD durum = new SoruCRUD();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uye"]==null)
        {
            Response.Redirect("uyegiris.aspx");
        }
        vid = Request.QueryString["vid"];
        vkod= Request.QueryString["videokod"];
        //string vid = Request.QueryString["vid"];
        //vkod = Request.QueryString["vkod"];
        //string ders= Request.QueryString["ders"];

        //video bilgileri göster
        VideoCrud bilgi = new VideoCrud();
        DataTable bilgitablo = bilgi.video(vkod);
        TextBox1.Text = bilgitablo.Rows[0][2].ToString();
        TextBox2.Text = bilgitablo.Rows[0][3].ToString();
        //GridView1.DataSource = bilgitablo;
        //GridView1.DataBind();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {int bayrak;
        vkod = Request.QueryString["videokod"];
        vid = Request.QueryString["vid"];
       

        //soru kısmı
        
        bayrak =durum.cevaplanmis(Session["uye"].ToString(), vkod);
        if(bayrak==0)
        Response.Redirect("videosoru.aspx?vkod="+ vkod+"&vid="+vid);
        else
            Response.Redirect("ogrenci_dersleri.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ogrenci_dersleri.aspx");
    }
}