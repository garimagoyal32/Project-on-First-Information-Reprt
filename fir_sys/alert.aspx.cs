using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    public void disp()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        Label3.Text= DateTime.Now.ToShortDateString();
        string t = "4/24/2014";

        //string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" +t + "'";
        string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" + Label3.Text + "'";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        GridView1.DataSource = dt;
        GridView1.DataBind();
        con2.Close();

        //TextBox2.Text = dt.Rows[0]["status"].ToString();    
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        disp();
    }
}