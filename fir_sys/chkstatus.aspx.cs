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
        
        Label1.Visible = false;
        Panel1.Visible = false;
    }

    

    public void status()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select status from firinfo where fir_no=" + Convert.ToInt32(TextBox1.Text);
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        TextBox2.Text = dt.Rows[0]["status"].ToString();        
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
            Panel1.Visible = true;
            status();
        }
        else
        {
            TextBox1.Text = " ";
            Label1.Visible = true;
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Label1.Visible = true;
        }
        else
        {
            check();
        }

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Panel1.Visible = false;
    }
}