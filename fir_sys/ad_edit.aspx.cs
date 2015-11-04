using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    string imagedata, imagedata1, city, zone1;
    public void pan_close()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel4.Visible = false;
        Panel10.Visible = false;
        Panel11.Visible = false;
        Panel12.Visible = false;
        Panel13.Visible = false;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            pan_close();
           
        }

    }

    public void station()
    {
        DropDownList3.Items.Clear();

        DropDownList3.Items.Add("Select");
        //string s = Request.Cookies["fdet"].Values["city"];


        string cnstr = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
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

    public void reset()
    {
        Label34.Text = "";
        Label35.Text = "";

        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox18.Text = "";
        TextBox6.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";
        TextBox12.Text = "";
        TextBox16.Text = "";
        TextBox9.Text = "";
        TextBox13.Text = "";
        TextBox17.Text = "";
        TextBox14.Text = "";
        TextBox15.Text = "";
        

        DropDownList1.SelectedIndex = 0;
        DropDownList4.SelectedIndex = 0;
        

        RadioButton1.Checked = false;
        RadioButton2.Checked = false;
        RadioButton4.Checked = false;
        RadioButton5.Checked = false;
        RadioButton6.Checked = false;
        RadioButton7.Checked = false;
        RadioButton8.Checked = false;
        RadioButton9.Checked = false;
        RadioButton10.Checked = false;
        RadioButton11.Checked = false;
        RadioButton12.Checked = false;
        RadioButton13.Checked = false;
        RadioButton14.Checked = false;
        RadioButton15.Checked = false;
        RadioButton16.Checked = false;
    }

    public void fill_data()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);

        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select * from firinfo where fir_no=" + Convert.ToInt32(TextBox19.Text);
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        Label34.Text = dt.Rows[0]["url"].ToString();
        Label35.Text = dt.Rows[0]["u_file"].ToString();

        TextBox2.Text = dt.Rows[0]["vic"].ToString();

        TextBox3.Text = dt.Rows[0]["fh_name"].ToString();
        TextBox18.Text = dt.Rows[0]["filer_name"].ToString();

        TextBox6.Text = dt.Rows[0]["age"].ToString();
        string gen = dt.Rows[0]["gender"].ToString();
        if (gen == RadioButton8.Text)
        {
            RadioButton8.Checked = true;
        }
        else if (gen == RadioButton9.Text)
        {
            RadioButton9.Checked = true;
        }

        string sub = dt.Rows[0]["subtype"].ToString();
        if (sub == RadioButton1.Text)
        {
            RadioButton1.Checked = true;
        }
        else if (sub == RadioButton2.Text)
        {
            RadioButton2.Checked = true;
        }
        else if (sub == RadioButton4.Text)
        {
            RadioButton4.Checked = true;
        }
        else if (sub == RadioButton5.Text)
        {
            RadioButton5.Checked = true;
        }
        else if (sub == RadioButton6.Text)
        {
            RadioButton6.Checked = true;
        }
        else if (sub == RadioButton7.Text)
        {
            RadioButton7.Checked = true;
        }
        else if (sub == RadioButton14.Text)
        {
            RadioButton14.Checked = true;
        }
        else if (sub == RadioButton15.Text)
        {
            RadioButton15.Checked = true;
        }
        else if (sub == RadioButton16.Text)
        {
            RadioButton16.Checked = true;
        }

        string tr = dt.Rows[0]["track"].ToString();
        if (tr == RadioButton10.Text)
        {
            RadioButton10.Checked = true;
        }
        else if (tr == RadioButton11.Text)
        {
            RadioButton11.Checked = true;
        }

        string ak = dt.Rows[0]["a_known"].ToString();
        if (ak == RadioButton12.Text)
        {
            RadioButton12.Checked = true;
        }
        else if (ak == RadioButton13.Text)
        {
            RadioButton13.Checked = true;
        }

        TextBox4.Text = dt.Rows[0]["i_place"].ToString();
        TextBox5.Text = dt.Rows[0]["i_date"].ToString();
        TextBox7.Text = dt.Rows[0]["m_place"].ToString();
        TextBox8.Text = dt.Rows[0]["m_date"].ToString();
        TextBox10.Text = dt.Rows[0]["brand"].ToString();
        TextBox11.Text = dt.Rows[0]["model"].ToString();

        TextBox12.Text = dt.Rows[0]["color"].ToString();
        TextBox16.Text = dt.Rows[0]["plate"].ToString();
        TextBox9.Text = dt.Rows[0]["descp"].ToString();
        TextBox13.Text = dt.Rows[0]["a_name"].ToString();
        TextBox17.Text = dt.Rows[0]["rel"].ToString();
        TextBox14.Text = dt.Rows[0]["address"].ToString();

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

       string type = dt.Rows[0]["type"].ToString();
        DropDownList4.SelectedItem.Selected = false;
        DropDownList4.Items.FindByText(type).Selected = true;

        TextBox15.Text = dt.Rows[0]["a_det"].ToString();
        string imge = dt.Rows[0]["url"].ToString();
        //Image1.ImageUrl = imge;
        //Label2.Visible = true;
        //Label2.Text = imge;

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


    }

    //public void fno(string gen)
    //{
    //    string cnstr = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
    //    SqlConnection con = new SqlConnection(cnstr);
    //    SqlCommand cmd = new SqlCommand();

    //    cmd.Connection = con;

    //    con.Open();


    //    cmd.CommandText = "update firinfo set vic='" + TextBox1.Text + "',url='" + Label2.Text + "',m_place='" + TextBox3.Text + "',m_date='" + TextBox4.Text + "',descp= '" + TextBox5.Text + "',gender='" + gen + "',age=" + Convert.ToInt32(TextBox2.Text) + ", fh_name='" + TextBox10.Text + "' where fir_no='" + TextBox8.Text + "'";
    //    int p = cmd.ExecuteNonQuery();
    //    con.Close();
    //}

    //public void updt()
    //{
    //    string gen = "";
    //    if (RadioButton1.Checked)
    //    {
    //        gen = RadioButton1.Text;
    //    }
    //    else if (RadioButton2.Checked)
    //    {
    //        gen = RadioButton2.Text;
    //    }
    //    string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
    //    SqlConnection conn = new SqlConnection(str);
    //    conn.Open();
    //    string q = "";

    //    q = "select count(*) from firinfo where fir_no=" + Convert.ToInt32(TextBox8.Text);

    //    //string query3 = "select count(*) from firinfo where fir_no=" + TextBox1.Text + " and filer_name='" + TextBox4.Text + "'";

    //    SqlCommand cmdd = new SqlCommand(q, conn);
    //    int x = (int)cmdd.ExecuteScalar();
    //    if (x > 0)
    //    {
    //        fno(gen);
    //        //Response.Write("<script> alert('fno updated')</script>");
    //    }
    //    //else
    //    //{
    //    //    TextBox8.Text = " ";
    //    //    Label3.Visible = true;
    //    //}


    //    //fno(gen);


    //}
    protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = !Calendar1.Visible;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox4.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = !Calendar1.Visible;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (TextBox19.Text == "")
        {
            Response.Write("<script> alert('Please enter the FIR Number')</script>");
        }
        else
        {

            string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            string q = "";

            q = "select count(*) from firinfo where fir_no=" + Convert.ToInt32(TextBox19.Text);

            //string query3 = "select count(*) from firinfo where fir_no=" + TextBox1.Text + " and filer_name='" + TextBox4.Text + "'";

            SqlCommand cmdd = new SqlCommand(q, conn);
            int x = (int)cmdd.ExecuteScalar();
            if (x > 0)
            {
                Label36.Visible = false;
                //fill_data();
                cat_view();
            }
            else
            {
                TextBox19.Text = " ";
                Label36.Visible = true;
            }
        }
    }

    public void cat_view()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);

        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select type_id from firinfo where fir_no=" + Convert.ToInt32(TextBox19.Text);
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

        int t =Convert.ToInt32(dt.Rows[0]["type_id"]);
        if (t == 1)
        {
            pan_close();
            reset();
            Panel1.Visible = true;
            Panel2.Visible = true;
            Panel4.Visible = true;
            Panel5.Visible = true;
            Panel10.Visible = true;
            Panel11.Visible = true;
            Panel12.Visible = true;
            Panel13.Visible = true;
            fill_data();
        }
        else if (t == 2)
        {
           pan_close();
            reset();
           Panel1.Visible = true;
            Panel3.Visible = true;
            Panel4.Visible = true;
            Panel5.Visible = true;
            Panel10.Visible = true;
            Panel11.Visible = true;
            Panel12.Visible = true;
            Panel13.Visible = true;
           fill_data();
        }
        else if (t == 3)
        {
           pan_close();
            reset();
            //Panel1.Visible = true;
            //Panel2.Visible = true;
            //Panel4.Visible = true;
            Panel5.Visible = true;
            Panel10.Visible = true;
            Panel11.Visible = true;
            Panel12.Visible = true;
            Panel13.Visible = true;
           fill_data();
        }
        else if (t == 4)
        {
            pan_close();
            reset();
            Panel1.Visible = true;
            //Panel2.Visible = true;
            Panel4.Visible = true;
            Panel5.Visible = true;
            Panel10.Visible = true;
            Panel11.Visible = true;
            Panel12.Visible = true;
            Panel13.Visible = true;
           fill_data();
        }
        else if (t == 5)
        {
            pan_close();
            reset();
            Panel1.Visible = true;
            //Panel2.Visible = true;
            Panel4.Visible = true;
            Panel6.Visible = true;
            //Panel10.Visible = true;
            //Panel11.Visible = true;
            Panel12.Visible = true;
            Panel13.Visible = true;
           fill_data();
        }
        else if (t == 6)
        {
            pan_close();
            reset();
           //Panel1.Visible = true;
           // Panel2.Visible = true;
           // Panel4.Visible = true;
            Panel5.Visible = true;
            //Panel10.Visible = true;
            //Panel11.Visible = true;
            Panel12.Visible = true;
            Panel13.Visible = true;
           fill_data();
        }
        else if (t == 7)
        {
            pan_close();
            reset();
            Panel7.Visible = true;
            Panel8.Visible = true;
            //Panel4.Visible = true;
            Panel5.Visible = true;
            //Panel10.Visible = true;
            //Panel11.Visible = true;
            Panel12.Visible = true;
            Panel13.Visible = true;
           fill_data();
        }
        else if (t == 8)
        {
            pan_close();
            reset();
           Panel7.Visible = true;
            Panel9.Visible = true;
            //Panel4.Visible = true;
            Panel5.Visible = true;
            //Panel10.Visible = true;
            //Panel11.Visible = true;
            Panel12.Visible = true;
            Panel13.Visible = true;
           fill_data();
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

    public string def = "~/upload/missing person/";
    protected void Button9_Click(object sender, EventArgs e)
    {
        imagedata = string.Empty;
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath((def) + FileUpload1.FileName));
            imagedata = def + FileUpload1.FileName;
        }
        FileUpload1.Visible = false;
        Label34.Visible = true;
        Label34.Text = imagedata;
  
    }

    public string def1 = "~/upload/files/";
    protected void Button10_Click(object sender, EventArgs e)
    {
        imagedata1 = string.Empty;
        if (FileUpload2.HasFile)
        {
            FileUpload2.SaveAs(Server.MapPath((def1) + FileUpload2.FileName));
            imagedata1 = def1 + FileUpload2.FileName;
        }
        FileUpload2.Visible = false;
        Label35.Visible = true;
        Label35.Text = imagedata1;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox19.Text == "")
        {
            Response.Write("<script> alert('Please enter the FIR Number')</script>");
        }
        else
        {
            //string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            //SqlConnection con2 = new SqlConnection(cnstr2);

            //System.Data.DataTable dt = new System.Data.DataTable();
            ////string query2 = "select type_id from firinfo where fir_no=" + Convert.ToInt32(TextBox19.Text);
           
            //SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
            //SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

            //da2.Fill(dt);
            //System.Data.DataSet ds2 = new System.Data.DataSet();

            //int t = Convert.ToInt32(dt.Rows[0]["type_id"]);
            //if (t == 1)
            //{
            //    //pan_close();
            //    //reset();
            //    //Panel1.Visible = true;
            //    //Panel2.Visible = true;
            //    //Panel4.Visible = true;
            //    //Panel5.Visible = true;
            //    //Panel10.Visible = true;
            //    //Panel11.Visible = true;
            //    //Panel12.Visible = true;
            //    //Panel13.Visible = true;
            //    //fill_data();
            //    cat1();
            //}
            //else if (t == 2)
            //{
            //    //pan_close();
            //    //reset();
            //    //Panel1.Visible = true;
            //    //Panel3.Visible = true;
            //    //Panel4.Visible = true;
            //    //Panel5.Visible = true;
            //    //Panel10.Visible = true;
            //    //Panel11.Visible = true;
            //    //Panel12.Visible = true;
            //    //Panel13.Visible = true;
            //    //fill_data();
            //    cat2();
            //}
            //else if (t == 3)
            //{
            //    //pan_close();
            //    //reset();
            //    ////Panel1.Visible = true;
            //    ////Panel2.Visible = true;
            //    ////Panel4.Visible = true;
            //    //Panel5.Visible = true;
            //    //Panel10.Visible = true;
            //    //Panel11.Visible = true;
            //    //Panel12.Visible = true;
            //    //Panel13.Visible = true;
            //    //fill_data();
            //}
            //else if (t == 4)
            //{
            //    //pan_close();
            //    //reset();
            //    //Panel1.Visible = true;
            //    ////Panel2.Visible = true;
            //    //Panel4.Visible = true;
            //    //Panel5.Visible = true;
            //    //Panel10.Visible = true;
            //    //Panel11.Visible = true;
            //    //Panel12.Visible = true;
            //    //Panel13.Visible = true;
            //    //fill_data();
            //}
            //else if (t == 5)
            //{
            //    //pan_close();
            //    //reset();
            //    //Panel1.Visible = true;
            //    ////Panel2.Visible = true;
            //    //Panel4.Visible = true;
            //    //Panel6.Visible = true;
            //    ////Panel10.Visible = true;
            //    ////Panel11.Visible = true;
            //    //Panel12.Visible = true;
            //    //Panel13.Visible = true;
            //    //fill_data();
            //}
            //else if (t == 6)
            //{
            //    //pan_close();
            //    //reset();
            //    ////Panel1.Visible = true;
            //    //// Panel2.Visible = true;
            //    //// Panel4.Visible = true;
            //    //Panel5.Visible = true;
            //    ////Panel10.Visible = true;
            //    ////Panel11.Visible = true;
            //    //Panel12.Visible = true;
            //    //Panel13.Visible = true;
            //    //fill_data();
            //}
            //else if (t == 7)
            //{
            //    //pan_close();
            //    //reset();
            //    //Panel7.Visible = true;
            //    //Panel8.Visible = true;
            //    ////Panel4.Visible = true;
            //    //Panel5.Visible = true;
            //    ////Panel10.Visible = true;
            //    ////Panel11.Visible = true;
            //    //Panel12.Visible = true;
            //    //Panel13.Visible = true;
            //    //fill_data();
            //}
            //else if (t == 8)
            //{
            //    //pan_close();
            //    //reset();
            //    //Panel7.Visible = true;
            //    //Panel9.Visible = true;
            //    ////Panel4.Visible = true;
            //    //Panel5.Visible = true;
            //    ////Panel10.Visible = true;
            //    ////Panel11.Visible = true;
            //    //Panel12.Visible = true;
            //    //Panel13.Visible = true;
            //    //fill_data();
            //}

            string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection con2 = new SqlConnection(cnstr2);


            string subt = "";

            string mp = TextBox7.Text;
            string md = TextBox8.Text;
            string n = TextBox18.Text;
            string c = DropDownList1.SelectedItem.ToString();

            string v = TextBox2.Text;
            string fh = TextBox3.Text;
            string t = DropDownList4.SelectedItem.ToString();

            string st = DropDownList3.SelectedItem.ToString();
            string z = DropDownList2.SelectedItem.ToString();
            string de = TextBox9.Text;

            string a = TextBox13.Text;
            string rel = TextBox17.Text;
            string add = TextBox14.Text;
            string ad = TextBox15.Text;
            string ak = "";
            if (RadioButton12.Checked)
            {
                ak = RadioButton12.Text;
            }
            else if (RadioButton13.Checked)
            {
                ak = RadioButton13.Text;
            }
            string ip = TextBox4.Text;
            string id = TextBox5.Text;
            string age = TextBox6.Text;

            string g = "";
            if (RadioButton8.Checked)
            {
                g = RadioButton8.Text;
            }
            else if (RadioButton9.Checked)
            {
                g = RadioButton9.Text;
            }

            if (RadioButton1.Checked)
            {
                subt = RadioButton1.Text;
            }
            else if (RadioButton2.Checked)
            {
                subt = RadioButton2.Text;
            }
            else if (RadioButton4.Checked)
            {
                subt = RadioButton4.Text;
            }
            else if (RadioButton14.Checked)
            {
                subt = RadioButton14.Text;
            }

            string co = TextBox12.Text;
            string m = TextBox11.Text;
            string b = TextBox10.Text;
            string tr = "";
            if (RadioButton10.Checked)
            {
                tr = RadioButton10.Text;
            }
            else if (RadioButton11.Checked)
            {
                tr = RadioButton11.Text;
            }
           string pl = TextBox16.Text;

           string q = "update firinfo set filer_name='" + n + "', city='" + c + "', type='" + t + "', vic='" + v + "', fh_name='" + fh + "',station='" + st + "', zone='" + z + "', descp='" + de + "', i_place='" + ip + "', i_date='" + id + "', age='" + age + "', gender='" + g + "', a_name='" + g + "', rel='" + rel + "', address='" + add + "', a_det='" + ad + "', a_known='" + ak + "', subtype='" + subt + "', brand='" + b + "', model='" + m + "', color='" + co + "', m_place='" + mp + "', m_date='" + md + "', track='" + tr + "', plate='" + pl + "' where fir_no=" + Convert.ToInt32(TextBox19.Text);
            con2.Open();
            SqlCommand cmd = new SqlCommand(q, con2);
            int p = cmd.ExecuteNonQuery();
            con2.Close();
            reset();
            DropDownList2.SelectedIndex = 0;
            DropDownList3.SelectedIndex = 0;
        }
    }

    //public void cat1()
    //{
    //    string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
    //        SqlConnection con2 = new SqlConnection(cnstr2);
          
           
    //        string subt="";
           
         
          
    //        string n = TextBox18.Text;
    //        string c = DropDownList1.SelectedItem.ToString();
           
    //        string v = TextBox2.Text;
    //        string fh = TextBox3.Text;
    //        string t = DropDownList4.SelectedItem.ToString();
           
    //        string st = DropDownList3.SelectedItem.ToString();
    //        string z = DropDownList2.SelectedItem.ToString();
    //        string de = TextBox9.Text;
           
    //       string a = TextBox13.Text;
    //          string rel = TextBox17.Text;
    //         string add = TextBox14.Text;
    //        string ad = TextBox15.Text;
    //    string ak="";
    //        if (RadioButton12.Checked)
    //        {
    //            ak = RadioButton12.Text;
    //        }
    //        else if (RadioButton13.Checked)
    //        {
    //            ak = RadioButton13.Text;
    //        }
    //        string ip = TextBox4.Text;
    //        string id = TextBox5.Text;
    //        int age = int.Parse(TextBox6.Text);

    //    string g="";
    //        if (RadioButton8.Checked)
    //        {
    //            g = RadioButton8.Text;
    //        }
    //        else if (RadioButton9.Checked)
    //        {
    //            g = RadioButton9.Text;
    //        }

    //        if (RadioButton1.Checked)
    //        {
    //            subt = RadioButton1.Text;
    //        }
    //        else if (RadioButton2.Checked)
    //        {
    //            subt = RadioButton2.Text;
    //        }
    //        else if (RadioButton4.Checked)
    //        {
    //            subt = RadioButton4.Text;
    //        }
    //        else if (RadioButton14.Checked)
    //        {
    //            subt = RadioButton14.Text;
    //        }

    //        string q = "update firinfo set filer_name='"+n+"', city='"+c+"', type='"+ t + "', vic='" + v + "', fh_name='" + fh + "',station='" + st + "', zone='" + z + "', descp='" + de + "', u_file='" + Label35.Text +  "', i_place='" + ip + "', i_date='" + id + "', age=" + age + ", gender='" + g + "', a_name='" + g + "', rel='" + rel + "', address='" + add + "', a_det='" + ad + "', a_known='" + ak + "', subtype='" + subt + "' where fir_no="+Convert.ToInt32(TextBox19.Text);
    //        con2.Open();
    //        SqlCommand cmd = new SqlCommand(q, con2);
    //        int p = cmd.ExecuteNonQuery();
    //        con2.Close();
    //}

    //public void cat2()
    //{
    //    string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
    //    SqlConnection con2 = new SqlConnection(cnstr2);


    //    string subt = "";



    //    string n = TextBox18.Text;
    //    string c = DropDownList1.SelectedItem.ToString();

    //    string v = TextBox2.Text;
    //    string fh = TextBox3.Text;
    //    string t = DropDownList4.SelectedItem.ToString();

    //    string st = DropDownList3.SelectedItem.ToString();
    //    string z = DropDownList2.SelectedItem.ToString();
    //    string de = TextBox9.Text;

    //    string a = TextBox13.Text;
    //    string rel = TextBox17.Text;
    //    string add = TextBox14.Text;
    //    string ad = TextBox15.Text;
    //    string ak = "";
    //    if (RadioButton12.Checked)
    //    {
    //        ak = RadioButton12.Text;
    //    }
    //    else if (RadioButton13.Checked)
    //    {
    //        ak = RadioButton13.Text;
    //    }
    //    string ip = TextBox4.Text;
    //    string id = TextBox5.Text;
    //    int age = int.Parse(TextBox6.Text);

    //    string g = "Female";
      

    //    if (RadioButton5.Checked)
    //    {
    //        subt = RadioButton5.Text;
    //    }
    //    else if (RadioButton6.Checked)
    //    {
    //        subt = RadioButton7.Text;
    //    }
    //    else if (RadioButton15.Checked)
    //    {
    //        subt = RadioButton15.Text;
    //    }
    //    else if (RadioButton16.Checked)
    //    {
    //        subt = RadioButton16.Text;
    //    }

    //    string q = "update firinfo set filer_name='" + n + "', city='" + c + "', type='" + t + "', vic='" + v + "', fh_name='" + fh + "',station='" + st + "', zone='" + z + "', descp='" + de + "', u_file='" + Label35.Text + "', i_place='" + ip + "', i_date='" + id + "', age=" + age + ", gender='" + g + "', a_name='" + g + "', rel='" + rel + "', address='" + add + "', a_det='" + ad + "', a_known='" + ak + "', subtype='" + subt + "' where fir_no=" + Convert.ToInt32(TextBox19.Text);
    //    con2.Open();
    //    SqlCommand cmd = new SqlCommand(q, con2);
    //    int p = cmd.ExecuteNonQuery();
    //    con2.Close();
    //}

    //public void cat3()
    //{
    //    string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
    //    SqlConnection con2 = new SqlConnection(cnstr2);


    



    //    string n = TextBox18.Text;
    //    string c = DropDownList1.SelectedItem.ToString();

    //    string v = TextBox2.Text;
    //    string fh = TextBox3.Text;
    //    string t = DropDownList4.SelectedItem.ToString();

    //    string st = DropDownList3.SelectedItem.ToString();
    //    string z = DropDownList2.SelectedItem.ToString();
    //    string de = TextBox9.Text;

    //    string a = TextBox13.Text;
    //    string rel = TextBox17.Text;
    //    string add = TextBox14.Text;
    //    string ad = TextBox15.Text;
    //    string ak = "";
    //    if (RadioButton12.Checked)
    //    {
    //        ak = RadioButton12.Text;
    //    }
    //    else if (RadioButton13.Checked)
    //    {
    //        ak = RadioButton13.Text;
    //    }
    //    string ip = TextBox4.Text;
    //    string id = TextBox5.Text;
    //    //int age = int.Parse(TextBox6.Text);

    //    string g = "";
    //    if (RadioButton8.Checked)
    //    {
    //        g = RadioButton8.Text;
    //    }
    //    else if (RadioButton9.Checked)
    //    {
    //        g = RadioButton9.Text;
    //    }

       

    //    string q = "update firinfo set filer_name='" + n + "', city='" + c + "', type='" + t + "', vic='" + v + "', fh_name='" + fh + "',station='" + st + "', zone='" + z + "', descp='" + de + "', u_file='" + Label35.Text + "', i_place='" + ip + "', i_date='" + id + "', age=" + age + ", gender='" + g + "', a_name='" + g + "', rel='" + rel + "', address='" + add + "', a_det='" + ad + "', a_known='" + ak + "', subtype='" + subt + "' where fir_no=" + Convert.ToInt32(TextBox19.Text);
    //    con2.Open();
    //    SqlCommand cmd = new SqlCommand(q, con2);
    //    int p = cmd.ExecuteNonQuery();
    //    con2.Close();
    //}
}
