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
        Panel1.Visible = true;
    }
    public void status()
    {
        string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";;
        SqlConnection conn = new SqlConnection(str);
        string q = "select status from firinfo where fir_no=" + Convert.ToInt32(TextBox1.Text);

        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(q, conn);
        System.Data.DataTable dt = new System.Data.DataTable();
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da);
        System.Data.DataSet ds = new System.Data.DataSet();
        da.Fill(dt);
        TextBox2.Text = dt.Rows[0]["status"].ToString();
        conn.Close();

    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "" || TextBox2.Text == "" || DropDownList1.SelectedIndex == 0 || DropDownList2.SelectedIndex == 0)
        {
            Response.Write("<script>alert('Please fill all entries')</script>");
        }
        else
        {
            string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query3 = "update firinfo set status='" + DropDownList1.SelectedItem.ToString() + "', reason='" + DropDownList2.SelectedItem.ToString() + "' where fir_no=" + Convert.ToInt32(TextBox1.Text);

            SqlCommand cmdd = new SqlCommand(query3, conn);
            int x = cmdd.ExecuteNonQuery();
           
            conn.Close();
          
            Panel2.Visible = false;
            Response.Write("<script>alert('FIR status updated ')</script>");
        }
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Label2.Visible = true;
           
        }
        else
        {
            Label2.Visible = false;
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
            string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query3 = "select count(*) from firinfo where fir_no=" +Convert.ToInt32(TextBox1.Text) ;

            SqlCommand cmdd = new SqlCommand(query3, conn);
            int x = Convert.ToInt32(cmdd.ExecuteScalar());
            if (x > 0)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
                status();
                //Response.Redirect("Default2.aspx");
            }
            else
            {
                TextBox1.Text = "";
                Label2.Visible = true;
            }
            conn.Close();
        }
    }
}