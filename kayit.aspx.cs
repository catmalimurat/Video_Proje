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
     
        if (DropDownList2.SelectedIndex>=0)
        {
            if (DropDownList3.SelectedIndex >= 0)
            {


                Response.Redirect("onay.aspx?adtxt=" + adtxt.Text + "&soyadtxt=" + soyadtxt.Text + "&emailtxt=" + emailtxt.Text + "&tctxt=" + tctxt.Text + "&bolum=" + DropDownList2.SelectedValue + "&sinif=" + DropDownList3.SelectedItem.Text + "&sfr="+sfrtxt.Text);
                        //Response.Redirect("kayit.aspx?adtxt="+ adtxt.Text+"&emailtxt="+emailtxt.Text+"&teltxt="+teltxt.Text+"&cinsiyet="+cinsiyet+"&kurs="+DropDownList3.SelectedValue + "&onay="+onayli+"&isdurumu="+isdurumu+"&sehir="+ DropDownList1.SelectedValue+"&ozeltxt="+ozeltxt.Text);                          


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