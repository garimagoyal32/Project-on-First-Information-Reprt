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
        //Label3.Text = DateTime.Now.ToShortDateString();
        //string t = "4/24/2014";

        //string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" +t + "'";
        string query2 = "select fir_no, type, filer_id, filer_name, vic, gender, i_date, station, city, date_short, status from firinfo ";
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
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        DropDownList3.Items.Clear();
        DropDownList2.Items.Add("Select");
        DropDownList3.Items.Add("Select");
        //string s = Request.Cookies["fdet"].Values["city"];
        string s = DropDownList1.SelectedItem.ToString();
        //Response.Write(s);

        string cnstr = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = cnstr;
        cmd.Connection = con;
        string query = "select distinct zone from stations where city='" + s + "'";
        con.Open();


        cmd.CommandText = query;
        SqlDataReader r = cmd.ExecuteReader();
        while (r.Read())
        {
            ListItem z = new ListItem();

            z.Text = r[0].ToString();

            DropDownList2.Items.Add(z);

        }
        con.Close();
        DropDownList2.Focus();
        city();

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList3.Items.Clear();

        DropDownList3.Items.Add("Select");
        //string s = Request.Cookies["fdet"].Values["city"];

        string cnstr = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = cnstr;
        cmd.Connection = con;
        string query = "select police from stations where zone='" + DropDownList2.SelectedItem + "'";
        con.Open();


        cmd.CommandText = query;
        SqlDataReader r = cmd.ExecuteReader();
        while (r.Read())
        {
            ListItem z = new ListItem();

            z.Text = r[0].ToString();

            DropDownList3.Items.Add(z);

        }
        con.Close();
        DropDownList3.Focus();
        zone();
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        station();
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox2.Text = Calendar1.SelectedDate.ToShortDateString();
        
        Calendar1.Visible = !Calendar1.Visible;
        TextBox2.Focus();
        cal();

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = !Calendar1.Visible;
        TextBox2.Focus();
    }

   

    public void city()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        //Label3.Text = DateTime.Now.ToShortDateString();
        //string t = "4/24/2014";

        //string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" +t + "'";
        string query2 = "select fir_no, type, filer_id, filer_name, vic, gender, i_date, station, city, date_short, status from firinfo where city='"+DropDownList1.SelectedItem.ToString()+"'";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        GridView1.DataSource = dt;
        GridView1.DataBind();
        con2.Close();

        //TextBox2.Text = dt.Rows[0]["status"].ToString();    
    }

    public void zone()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        //Label3.Text = DateTime.Now.ToShortDateString();
        //string t = "4/24/2014";

        //string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" +t + "'";
        string query2 = "select fir_no, type, filer_id, filer_name, vic, gender, i_date, station, city, date_short, status from firinfo where zone='" + DropDownList2.SelectedItem.ToString() + "'";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        GridView1.DataSource = dt;
        GridView1.DataBind();
        con2.Close();

        //TextBox2.Text = dt.Rows[0]["status"].ToString();    
    }

    public void station()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        //Label3.Text = DateTime.Now.ToShortDateString();
        //string t = "4/24/2014";

        //string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" +t + "'";
        string query2 = "select fir_no, type, filer_id, filer_name, vic, gender, i_date, station, city, date_short, status from firinfo where station='" + DropDownList3.SelectedItem.ToString() + "'";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        GridView1.DataSource = dt;
        GridView1.DataBind();
        con2.Close();

        //TextBox2.Text = dt.Rows[0]["status"].ToString();    
    }

    public void cal()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        //Label3.Text = DateTime.Now.ToShortDateString();
        //string t = "4/24/2014";

        //string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" +t + "'";
        string query2 = "select fir_no, type, filer_id, filer_name, vic, gender, i_date, station, city, date_short, status from firinfo where date_short='" + TextBox2.Text + "'";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        GridView1.DataSource = dt;
        GridView1.DataBind();
        con2.Close();

        //TextBox2.Text = dt.Rows[0]["status"].ToString();    
    }

    public void fno()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        //Label3.Text = DateTime.Now.ToShortDateString();
        //string t = "4/24/2014";

        //string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" +t + "'";
        string query2 = "select type_id from firinfo where fir_no="+ Convert.ToInt32(TextBox1.Text);
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);
        
        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        int t = Convert.ToInt32(dt.Rows[0]["type_id"]);
        
        con2.Close();
        //int t = Convert.ToInt32(s);
        if (t == 1)
        {
            cat1();
            
        }
        else if (t == 2)
            {
                cat2();
            }
        else if (t == 3)
        {
            cat3();
        }
        else if (t == 4)
        {
            cat4();
        }
        else if (t == 5)
        {
            cat5();
        }
        else if (t ==6)
        {
            cat3();
        }
        else if (t == 7)
        {
            cat7();
        }
        else if (t == 8)
        {
            cat8();
        }
      
    }

    public void cat1()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        //Label3.Text = DateTime.Now.ToShortDateString();
        //string t = "4/24/2014";

        //string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" +t + "'";
        string query2 = "select fir_no, type, subtype, filer_id, filer_name, vic, gender, age, i_date, station, city, date_short, descp, a_name, status from firinfo where fir_no='"+TextBox1.Text+"'";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        GridView1.DataSource = dt;
        GridView1.DataBind();
        con2.Close();
    }

    public void cat2()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        //Label3.Text = DateTime.Now.ToShortDateString();
        //string t = "4/24/2014";

        //string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" +t + "'";
        string query2 = "select fir_no, type, subtype, filer_id, filer_name, vic, age, i_date, station, city, date_short, descp, a_name, status from firinfo  where fir_no='" + TextBox1.Text + "'";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        GridView1.DataSource = dt;
        GridView1.DataBind();
        con2.Close();
    }

    public void cat3()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        //Label3.Text = DateTime.Now.ToShortDateString();
        //string t = "4/24/2014";

        //string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" +t + "'";
        string query2 = "select fir_no, type, filer_id, filer_name, vic, i_date, station, city, date_short, descp, a_name, status from firinfo  where fir_no='" + TextBox1.Text + "'";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        GridView1.DataSource = dt;
        GridView1.DataBind();
        con2.Close();
    }

    public void cat4()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        //Label3.Text = DateTime.Now.ToShortDateString();
        //string t = "4/24/2014";

        //string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" +t + "'";
        string query2 = "select fir_no, type, filer_id, filer_name, vic, gender, age, i_date, station, city, date_short, descp, a_name, status from firinfo where fir_no='" + TextBox1.Text + "'";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        GridView1.DataSource = dt;
        GridView1.DataBind();
        con2.Close();
    }

    public void cat5()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        //Label3.Text = DateTime.Now.ToShortDateString();
        //string t = "4/24/2014";

        //string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" +t + "'";
        string query2 = "select fir_no, type, filer_id, filer_name, vic, gender, age, m_date, m_place, station, city, date_short, descp, a_name, status from firinfo where fir_no='" + TextBox1.Text + "'";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        GridView1.DataSource = dt;
        GridView1.DataBind();
        con2.Close();
    }

    public void cat7()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        //Label3.Text = DateTime.Now.ToShortDateString();
        //string t = "4/24/2014";

        //string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" +t + "'";
        string query2 = "select fir_no, type, filer_id, filer_name, vic, i_date, i_place, station, city, date_short, brand, model, color status from firinfo  where fir_no='" + TextBox1.Text + "'";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        GridView1.DataSource = dt;
        GridView1.DataBind();
        con2.Close();
    }
    public void cat8()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        //Label3.Text = DateTime.Now.ToShortDateString();
        //string t = "4/24/2014";

        //string query2 = "select fir_no, type, city, station, date from firinfo where date_short='" +t + "'";
        string query2 = "select fir_no, type, filer_id, filer_name, vic, i_date, i_place, station, city, date_short, brand, model, color, plate status from firinfo where fir_no='" + TextBox1.Text + "'";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        GridView1.DataSource = dt;
        GridView1.DataBind();
        con2.Close();
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "")
        {
            Response.Write("<script>alert('Please enter FIR No.')</script>");
        }
        else
        {
            string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query3 = "select count(*) from firinfo where fir_no=" + TextBox1.Text;

            SqlCommand cmdd = new SqlCommand(query3, conn);
            int x = (int)cmdd.ExecuteScalar();
            if (x > 0)
            {
                Label6.Visible = false;
                //Response.Write("<script>alert('hello')</script>");
                fno();
            }
            else
            {
                TextBox1.Text = " ";
                TextBox1.Focus();
                Label6.Visible = true;
            }
        }
    }
    
}