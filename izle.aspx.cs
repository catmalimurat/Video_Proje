using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.ComponentModel;

public partial class izle : System.Web.UI.Page
{
    string vkod;
    protected void Page_Load(object sender, EventArgs e)
    {
        //string vid = Request.QueryString["vid"];
        //vkod = Request.QueryString["vkod"];
        //string ders= Request.QueryString["ders"];
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("videosoru.aspx?vkod="+ Session["videokod"]);
    }
}