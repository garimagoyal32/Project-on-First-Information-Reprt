using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = Request.Cookies["abc"].Values["user"]; ;
    }
    public void id()
    {
        
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Server.Transfer("Login.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Server.Transfer("updtstatus.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Server.Transfer("mpinfo.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("filer_det.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("user.aspx");
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("ad_view.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("alert.aspx");
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Response.Redirect("ad_edit.aspx");
    }
}
