using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public void diff()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";;
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select date from firinfo where fir_no=" + Convert.ToInt32(TextBox1.Text);
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        string dat= dt.Rows[0]["date"].ToString(); 
        //DateTime d1=DateTime.Parse(dat);
        string dtt = DateTime.Now.ToString();
        DateTime d2 = DateTime.Parse(dtt);
        DateTime d3 = DateTime.Parse(dat);
        //HiddenField1.Value = d1.ToString();
        TimeSpan ds = d2.Subtract(d3);
        int h = ds.Hours;
        int d = ds.Days;
        int s = ds.Seconds;
        int m = ds.Minutes;
        int y = Convert.ToInt32(TextBox1.Text);
        if (d > 36)
        {
            int x = 3;
           
            Server.Transfer("fir_msg.aspx?a=" + x + "&fn=" + y );
        }
        else
        {
            int x = 4;

            Server.Transfer("fir_msg.aspx?a=" + x + "&hr=" + h + "&dy=" + d + "&min=" + m + "&sec=" + s);
        }
    }

    public void check()
    {
        string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(str);
        conn.Open();

        string query3 = "select count(*) from firinfo where fir_no=" + TextBox1.Text;

        SqlCommand cmdd = new SqlCommand(query3, conn);
        int x = (int)cmdd.ExecuteScalar();
        if (x > 0)
        {
            diff();
        }
        else
        {
            TextBox1.Text = " ";
            Label2.Visible = true;
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Label2.Visible = true;
        }
        else
        {
            check();
        }
    }
}