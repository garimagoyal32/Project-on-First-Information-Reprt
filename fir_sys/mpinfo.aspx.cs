using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class Default3 : System.Web.UI.Page
{
    string imagedata,city, zone1;
    protected void Page_Load(object sender, EventArgs e)
    {
        int x=mno()+1;
       Label6.Text = x.ToString();
       
    }

    public void station()
    {
        DropDownList3.Items.Clear();

        DropDownList3.Items.Add("Select");
        //string s = Request.Cookies["fdet"].Values["city"];

        string cnstr = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";;
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = cnstr;
        cmd.Connection = con;
        string query = "select police from stations where zone='" + zone1 + "'";
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
    }

    public void zone()
    {
        DropDownList2.Items.Clear();

        DropDownList2.Items.Add("Select");
        //string s = Request.Cookies["fdet"].Values["city"];

        string cnstr = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = cnstr;
        cmd.Connection = con;
        string query = "select zone from stations where city='" + city + "'";
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
        DropDownList3.Focus();
    }

    public void fill_data()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);

        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select * from firinfo where fir_no="+Convert.ToInt32(TextBox8.Text) ;
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
       TextBox1.Text = dt.Rows[0]["vic"].ToString();
        
       TextBox2.Text = dt.Rows[0]["age"].ToString();
       string gen = dt.Rows[0]["gender"].ToString();
       if (gen == RadioButton1.Text)
       {
           RadioButton1.Checked = true;
       }
       else if (gen == RadioButton2.Text)
       {
           RadioButton2.Checked = true;
       }
       TextBox3.Text = dt.Rows[0]["m_place"].ToString();
       TextBox4.Text = dt.Rows[0]["m_date"].ToString();
       TextBox5.Text = dt.Rows[0]["descp"].ToString();
       TextBox9.Text = dt.Rows[0]["filer_name"].ToString();

      city = dt.Rows[0]["city"].ToString();
       DropDownList1.SelectedItem.Selected = false;
       DropDownList1.Items.FindByText(city).Selected = true;

       zone();
       zone1 = dt.Rows[0]["zone"].ToString();
       DropDownList2.SelectedItem.Selected = false;
       DropDownList2.Items.FindByText(zone1).Selected = true;

       station();
       string st = dt.Rows[0]["station"].ToString();
       DropDownList3.SelectedItem.Selected = false;
       DropDownList3.Items.FindByText(st).Selected = true;

         TextBox10.Text = dt.Rows[0]["fh_name"].ToString();
        string imge=dt.Rows[0]["url"].ToString();
        Image1.ImageUrl = imge;
        Label2.Visible = true;
        Label2.Text = imge; 
        
    }

    public void fill_list()
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


    }

   

    public string def="~/upload/missing person/";
    protected void Button12_Click(object sender, EventArgs e)
    {
         imagedata = string.Empty;
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath((def)+ FileUpload1.FileName));
            imagedata = def + FileUpload1.FileName;
        }
        FileUpload1.Visible = false;
        Label2.Visible = true;
        Label2.Text = imagedata;
        Image1.ImageUrl = imagedata;
    }

    public int mno()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);

        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select max(mid) m from minfo";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        string st = dt.Rows[0]["m"].ToString();
        int x = Convert.ToInt32(st);
        return x;
    }
    public void submit()
    {
        string gen="";
        if (RadioButton1.Checked)
        {
            gen = RadioButton1.Text;
        }
        else if (RadioButton2.Checked)
        {
            gen = RadioButton2.Text;
        }
        string cnstr = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(cnstr);
        SqlCommand cmd = new SqlCommand();
        
        cmd.Connection = con;
       
        con.Open();
      
        //cmd.Parameters.AddWithValue("@ur", imagedata);
        cmd.CommandText = "insert into minfo(mid,url,vic,m_place,m_date,descp,gender,age,fir_no,city,zone,station,fh_name,filer_name) values ('" + TextBox6.Text + "', '" + Label2.Text + "','" + TextBox1.Text + "', '"  + TextBox3.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + gen + "', " + Convert.ToInt32(TextBox2.Text) + ", " + Convert.ToInt32(TextBox8.Text) + ",'" + DropDownList1.SelectedItem.ToString() + "', '" + DropDownList2.SelectedItem.ToString() + "', '" + DropDownList3.SelectedItem.ToString() + "', '" + TextBox10.Text + "', '" + TextBox9.Text + "')";
     
        //Label2.Visible = true;
        //if (string.IsNullOrEmpty(imagedata))
        //{
        //    Label2.Text = "choose right image";
        //}
        //else
        //{
        //    int a = cmd.ExecuteNonQuery();
        //    if (a > 0)
        //        Label2.Text = imagedata;
        //    else
        //        Label2.Text = "failed";
        //}
        int p = cmd.ExecuteNonQuery();
        con.Close();
    }

    public void mid(string gen)
    {
        string cnstr = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(cnstr);
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = con;

        con.Open();


        cmd.CommandText = "update minfo set vic='" + TextBox1.Text + "', url='" + Label2.Text + "', m_place='" + TextBox3.Text + "', m_date='" + TextBox4.Text + "', descp= '" + TextBox5.Text + "', gender='" + gen + "', age=" + Convert.ToInt32(TextBox2.Text) + ", fh_name='"+TextBox10.Text+"' where mid='" + TextBox6.Text + "'";
        int p = cmd.ExecuteNonQuery();
        con.Close();
        //Response.Write("<script> alert('mid updated')</script>");
    }

    public void fno(string gen)
    {
        string cnstr = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(cnstr);
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = con;

        con.Open();


        cmd.CommandText = "update firinfo set vic='" + TextBox1.Text + "',url='" + Label2.Text + "',m_place='" + TextBox3.Text + "',m_date='" + TextBox4.Text + "',descp= '" + TextBox5.Text + "',gender='" + gen + "',age=" + Convert.ToInt32(TextBox2.Text) + ", fh_name='" + TextBox10.Text + "' where fir_no='" + TextBox8.Text + "'";
        int p = cmd.ExecuteNonQuery();
        con.Close();
    }

    public void updt()
    {
        string gen = "";
        if (RadioButton1.Checked)
        {
            gen = RadioButton1.Text;
        }
        else if (RadioButton2.Checked)
        {
            gen = RadioButton2.Text;
        }
        string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(str);
        conn.Open();
        string q = "";

        q = "select count(*) from firinfo where fir_no=" + Convert.ToInt32(TextBox8.Text);

        //string query3 = "select count(*) from firinfo where fir_no=" + TextBox1.Text + " and filer_name='" + TextBox4.Text + "'";

        SqlCommand cmdd = new SqlCommand(q, conn);
        int x = (int)cmdd.ExecuteScalar();
        if (x > 0)
        {
            fno(gen);
            //Response.Write("<script> alert('fno updated')</script>");
        }
        //else
        //{
        //    TextBox8.Text = " ";
        //    Label3.Visible = true;
        //}


        //fno(gen);
        mid(gen);
        
    }

    public void dlt()
    {
        string cnstr = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(cnstr);
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = con;

        con.Open();


        cmd.CommandText = "delete from minfo where mid='" + TextBox6.Text + "'";
        int p = cmd.ExecuteNonQuery();
        con.Close();
        TextBox6.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox1.Text = "";
        TextBox10.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        DropDownList1.SelectedIndex = 0;
        DropDownList2.SelectedIndex = 0;
        DropDownList3.SelectedIndex = 0;
        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        Label2.Visible = false;
    }

    public void view()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);

        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select * from minfo where mid='" + TextBox6.Text +"'";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        city = dt.Rows[0]["city"].ToString();
        DropDownList1.SelectedItem.Selected = false;
        DropDownList1.Items.FindByText(city).Selected = true;

        zone();
        zone1 = dt.Rows[0]["zone"].ToString();
        DropDownList2.SelectedItem.Selected = false;
        DropDownList2.Items.FindByText(zone1).Selected = true;

        station();
        string st = dt.Rows[0]["station"].ToString();
        DropDownList3.SelectedItem.Selected = false;
        DropDownList3.Items.FindByText(st).Selected = true;

       TextBox1.Text = dt.Rows[0]["vic"].ToString();
       TextBox2.Text = dt.Rows[0]["age"].ToString();
       TextBox8.Text = dt.Rows[0]["fir_no"].ToString();
       Label2.Visible = true;
       Label2.Text = dt.Rows[0]["url"].ToString();
       TextBox9.Text = dt.Rows[0]["filer_name"].ToString();
       TextBox10.Text = dt.Rows[0]["fh_name"].ToString();
       Image1.ImageUrl = Label2.Text;
       string gen = dt.Rows[0]["gender"].ToString();
       if (gen == RadioButton1.Text)
       {
           RadioButton1.Checked = true;
       }
       else if (gen == RadioButton2.Text)
       {
           RadioButton2.Checked = true;
       }
       TextBox3.Text = dt.Rows[0]["m_place"].ToString();
       TextBox4.Text = dt.Rows[0]["m_date"].ToString();
       TextBox5.Text = dt.Rows[0]["descp"].ToString();

    }


  

    protected void Button9_Click(object sender, EventArgs e)
    {
        bool chk=RadioButton1.Checked|| RadioButton2.Checked;
        if (TextBox6.Text == "" || TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || Label2.Text == "" || chk == false)
        {
            Response.Write("<script> alert('Please fill all entries')</script>");
        }
        else
        {
            submit();
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = !Calendar1.Visible;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox4.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = !Calendar1.Visible;
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        bool chk = RadioButton1.Checked || RadioButton2.Checked;
        if (TextBox6.Text == "" || TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || Label2.Text == "" || chk == false)
        {
            Response.Write("<script> alert('Please fill all entries')</script>");
        }
        else
        {
            updt();
        }
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        if (TextBox6.Text == "")
        {
            Response.Write("<script> alert('Please enter the misssing person ID in MID field')</script>");
        }
        else
            dlt();
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        if (TextBox8.Text == "")
        {
            Response.Write("<script> alert('Please enter the FIR Number')</script>");
        }
        else
        {

            string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string q = "";

            q = "select count(*) from firinfo where fir_no=" + Convert.ToInt32(TextBox8.Text) + " and status!='Waiting for confirmation'";

            //string query3 = "select count(*) from firinfo where fir_no=" + TextBox1.Text + " and filer_name='" + TextBox4.Text + "'";

            SqlCommand cmdd = new SqlCommand(q, conn);
            int x = (int)cmdd.ExecuteScalar();
            if (x > 0)
            {
                Label3.Visible = false;
                fill_data();
            }
            else
            {
                TextBox8.Text = " ";
                Label3.Visible = true;
            }


        }
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
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        fill_list();
        DropDownList2.Focus();
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        if (TextBox6.Text == "")
        {
            Response.Write("<script> alert('Please enter the missing person ID in MID field')</script>");
        }
        else
        {
            //Response.Write("<script> alert('else part')</script>");

            string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();


            string q = "select count(*) from minfo where mid=" + Convert.ToInt32(TextBox6.Text);

            //string query3 = "select count(*) from firinfo where fir_no=" + TextBox1.Text + " and filer_name='" + TextBox4.Text + "'";

            SqlCommand cmdd = new SqlCommand(q, conn);
            int x = (int)cmdd.ExecuteScalar();
            if (x > 0)
            {
                Label4.Visible = false;
                //Response.Write("<script> alert('data found')</script>");
                view();
            }
            else
            {
                TextBox6.Text = " ";
                Label4.Visible = true;
            }

        }
    }
}