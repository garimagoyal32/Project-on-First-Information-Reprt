using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    //int s=1;
    int s;
    public void pan()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        pan();
        s = Convert.ToInt32(Request.QueryString["a"]);
        if (s == 1)
        {
            Panel1.Visible = true;
           
            string fn = Request.QueryString["fn"].ToString();
            Label3.Text = fn;

        }
        else if(s==2)
        {
            Panel2.Visible = true;
            
        }
        else if (s == 3)
        {
            Panel3.Visible = true;
            string fn = Request.QueryString["fn"].ToString();
            Label5.Text = fn;
            
        }
        else if (s == 4)
        {
            Panel4.Visible = true;
            Label7.Text = Request.QueryString["dy"].ToString();
            Label9.Text = Request.QueryString["hr"].ToString();
            Label11.Text = Request.QueryString["min"].ToString();
            Label13.Text = Request.QueryString["sec"].ToString();
        }
        else if (s == 5)
        {
            Panel5.Visible = true;

        }

    }
}