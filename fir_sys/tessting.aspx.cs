using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class tessting : System.Web.UI.Page
{
    int f = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //Random randomNumber = new Random();
        ////Provide the min and max limit for the no
        //int generatedNo = randomNumber.Next(100000, 999999);
        //TextBox1.Text = generatedNo.ToString();  

        //Calendar1.Visible = true;

        string dt = DateTime.Now.ToString();
        DateTime d1 = DateTime.Parse(dt);
        HiddenField1.Value = d1.ToString();

       
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //int n=0;
        //string s = "Data Source=.;Initial Catalog=fir_sys;Integrated Security=True;Pooling=False";
        //SqlConnection con = new SqlConnection(s);
        //string q="select firno from test";
        //SqlCommand cmd = new SqlCommand(q, con);
        ////SqlDataReader r = new SqlCommand(q,con).ExecuteReader();
       
        //con.Open();
        //SqlDataReader r = cmd.ExecuteReader();
        ////SqlDataReader r = new SqlCommand(q, con).ExecuteReader();
       
        //bool b = r.Read();
        //while (b)
        //{
           
        //        n = Convert.ToInt32(r[0]);
              
        //}
        //TextBox1.Text = n.ToString();
        //con.Close();


        //Calendar2.Visible = true;

        string dtt = DateTime.Now.ToString();
        DateTime d2 = DateTime.Parse(dtt);
        DateTime d3 = DateTime.Parse(HiddenField1.Value);
        //HiddenField1.Value = d1.ToString();
        TimeSpan ds = d2.Subtract(d3);
        int d = ds.Seconds;
        //ds.Hours = 9;
        //Label1.Text = (d2.Subtract(d3)).ToString();
        Label1.Text = d.ToString();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //string s = DateTime.Now.ToString();
        //string s = DateTime.Parse("04 / 20 / 2014").ToString();
        //string s1 = "4/21/2014 12:00:00 AM";
       
        ////int p = Convert.ToInt32(s1 - s);
        //TextBox1.Text = s;

        DateTime dt1 = DateTime.Parse(TextBox1.Text);
        DateTime dt2 = DateTime.Parse(TextBox6.Text);
        TextBox7.Text = (dt1.Subtract(dt2)).ToString();
          
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        TextBox6.Text = Calendar2.SelectedDate.ToString();
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        //Response.Clear();
        //Response.AppendHeader("content-disposition", "attachment; filename=eyes.txt");
        //Response.ContentType = "text/plain";
        //Response.WriteFile(Server.MapPath("/eyes.pdf"));
        //Response.Flush();
        //Response.End();
        Label1.Text = Calendar1.SelectedDate.ToLongDateString();

    }
}