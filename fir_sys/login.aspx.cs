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
        
    }

    public void user_det()
    {
        string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";;
        SqlConnection conn = new SqlConnection(str);
        string q = "select * from login where userid='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";

        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(q, conn);
        System.Data.DataTable dt = new System.Data.DataTable();
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da);
        System.Data.DataSet ds = new System.Data.DataSet();
        da.Fill(dt);
        string user = dt.Rows[0]["name"].ToString();
        conn.Close();

        HttpCookie k = new HttpCookie("abc");
        k.Values["unm"] = TextBox1.Text;
        k.Values["pwd"] = TextBox2.Text;
        k.Values["user"] = user;

        Response.Cookies.Add(k);
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        
        if (TextBox1.Text == " " || TextBox2.Text == " ")
        {
            Response.Write("<script>alert('Please fill all entries'</script>");
        }
       else
        {
           
            string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query3 = "select count(*) from login where userid='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";

            SqlCommand cmdd = new SqlCommand(query3, conn);
            int x = Convert.ToInt32(cmdd.ExecuteScalar());
            if (x > 0)
            {
                user_det();
                Response.Redirect("Default2.aspx");
            }
            else
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                Response.Write("<script>alert('Incorrect user id or password')</script>");
            }
            conn.Close();
           
              
        }
    }
}