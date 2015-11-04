using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label11.Text = "Request for editing FIR will be fulfilled within 24 hours of the request filed."; 
    }

    //public void check()
    //{
    //    string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
    //    SqlConnection conn = new SqlConnection(str);
    //    conn.Open();
    //    string q = "select count(*) from firinfo where fir_no=" + Convert.ToInt32(TextBox1.Text) + " and filer_name='" + TextBox2.Text + "'";
        
    //    //string query3 = "select count(*) from firinfo where fir_no=" + TextBox1.Text + " and filer_name='" + TextBox4.Text + "'";

    //    SqlCommand cmdd = new SqlCommand(q, conn);
    //    int x = (int)cmdd.ExecuteScalar();
    //    if (x > 0)
    //    {
    //        check1();
    //    }
    //    else
    //    {
    //        TextBox1.Text = " ";
    //        Label1.Visible = true;
    //    }

    //}

    protected void Button8_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "" || TextBox2.Text == "")
        {
            Response.Write("<script> alert('Please fill all entries')</script>");
        }
        else
        {
            string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query3 = "select count(*) from firinfo where fir_no=" + TextBox1.Text+" and filer_name='"+TextBox2.Text+"'";

            SqlCommand cmdd = new SqlCommand(query3, conn);
            int x = (int)cmdd.ExecuteScalar();
            if (x > 0)
            {
                int id = 5;
                Label12.Visible = false;
                Server.Transfer("viewfir.aspx?a=" + id );
            }
            else
            {
                TextBox1.Text = " ";
                Label12.Visible = true;
            }

        }
    }
}