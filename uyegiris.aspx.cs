﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class uyegiris : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string hata = Request.QueryString["hata"];
        if (hata=="1")
        {
            Label1.Text = "Hatalı veri girişi";
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("uyekontrol.aspx?tctxt="+ tctxt.Text+  "&sfr=" + sfrtxt.Text);
    }
}