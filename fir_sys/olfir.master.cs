using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class olfir : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = DateTime.Now.ToLongDateString();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {

    }
    //protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    //{
    //    Response.Redirect("missing.aspx");
    //}
    protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("missing.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("under_cons.aspx");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("under_cons.aspx");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("under_cons.aspx");
    }
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("login.aspx");
    }
    protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("http://www.ksp.gov.in/home/wanted.php");
    }
    protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("http://www.ksp.gov.in/home/vehicle.php");
    }
    protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("find.aspx");
    }
    //protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
    //{
    //    Response.Redirect("chkstatus.aspx");
    //}
    //protected void Menu3_MenuItemClick(object sender, MenuEventArgs e)
    //{
    //    //if (Menu3.
    //    //{
    //    //    Response.Redirect("search1.aspx");
    //    //}
    //    Response.Redirect("search.aspx");
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("grievance.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("refile.aspx");
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("chkstatus.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("search.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("fir_edit.aspx");
    }
    protected void Button7_Click1(object sender, EventArgs e)
    {
        Response.Redirect("faq.aspx");
    }
}
