using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ogreci_dersleri : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["uye"]==null)
        {
            Response.Redirect("uyegiris.aspx");
        }
        DersCrud derscrud = new DersCrud();
        
        DataTable derstablo = derscrud.dersler(Session["uye"].ToString());
        GridView1.DataSource = derstablo;
             GridView1.DataBind();
    }
}