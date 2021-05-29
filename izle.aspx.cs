using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;

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
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        int bayrak;
        vkod = Request.QueryString["videokod"];
        vid = Request.QueryString["vid"];
        bayrak =durum.cevaplanmis(Session["uye"].ToString(), vkod);
        if(bayrak==0)
        Response.Redirect("videosoru.aspx?vkod="+ vkod+"&vid="+vid);
        else
            Response.Redirect("ogrenci_dersleri.aspx");
    }
}