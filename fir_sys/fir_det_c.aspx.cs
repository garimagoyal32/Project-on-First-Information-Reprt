using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    int x, y;
    string ak;
    string g,imagedata;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            fill_list();
            
            pan_close();
            //cat4();
        }

    }
    int type;

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
       
    }
    public void fill_list()
    {

        DropDownList2.Items.Clear();
        DropDownList3.Items.Clear();
        DropDownList2.Items.Add("Select");
        DropDownList3.Items.Add("Select");
        string s = Request.Cookies["fdet"].Values["city"];
        //string s = DropDownList1.SelectedItem.ToString();
        //string s = "Bagalkot";

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

    public string def = "~/upload/files/";
    protected void Button8_Click(object sender, EventArgs e)
    {
        imagedata = string.Empty;
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath((def) + FileUpload1.FileName));
            imagedata = def + FileUpload1.FileName;
        }
        FileUpload1.Visible = false;
        Label30.Visible = true;
        Label30.Text = imagedata;
    }

    string imagedata1;
    public string def1 = "~/upload/missing person/";
    protected void Button9_Click(object sender, EventArgs e)
    {
        imagedata1 = string.Empty;
        if (FileUpload2.HasFile)
        {
            FileUpload2.SaveAs(Server.MapPath((def1) + FileUpload2.FileName));
            imagedata1 = def1 + FileUpload2.FileName;
        }
        FileUpload2.Visible = false;
        Label34.Visible = true;
        Label34.Text = imagedata1;

    }

    public int fno()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);

        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select max(fir_no) rn from firinfo";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        string st = dt.Rows[0]["rn"].ToString();
        int x = Convert.ToInt32(st);
        return x;
    }



    public void f_sub()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        int y = Convert.ToInt32(Request.Cookies["fdet"].Values["fid"]);
        string n = Request.Cookies["fdet"].Values["name"].ToString();
        string fn = Request.Cookies["fdet"].Values["fname"].ToString();
        string ad = Request.Cookies["fdet"].Values["address"].ToString();
        string c= Request.Cookies["fdet"].Values["city"].ToString();
        string e = Request.Cookies["fdet"].Values["email"].ToString();
       string ph = Request.Cookies["fdet"].Values["phone"].ToString();
        string mo = Request.Cookies["fdet"].Values["mobile"].ToString();
        string q = "insert into filer_details ( filer_id, name, fname, address, f_city, phone ,mobile, email) values(" + y + ", '" + n + "', '" + fn + "', '" +ad + "', '" + c + "', '" + ph + "', '" + mo + "', '"+e+"') ";
        con2.Open();
        SqlCommand cmd = new SqlCommand(q, con2);
        int p = cmd.ExecuteNonQuery();
        con2.Close();
    }

    //crime against children
    public void cat1()
    {
        
      bool gen=RadioButton8.Checked || RadioButton9.Checked;
        bool check=RadioButton12.Checked || RadioButton13.Checked;
          bool sub=RadioButton1.Checked || RadioButton2.Checked || RadioButton4.Checked || RadioButton14.Checked;
        

        if (DropDownList2.SelectedIndex == 0 || DropDownList3.SelectedIndex == 0 || TextBox2.Text == "" || TextBox3.Text == "" || TextBox6.Text == "" || gen == false || TextBox4.Text == "" || TextBox5.Text == "" || TextBox9.Text == "" || check == false || sub==false)
        {
            Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
        }
        else if ((RadioButton12.Checked) && (TextBox13.Text == "" || TextBox17.Text == ""))
        {
            Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
        }
        else
        {
            string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection con2 = new SqlConnection(cnstr2);
            x = fno() + 1;
            string a, rel, add, ad;
            string subt="";
            string s = DateTime.Now.ToString();
            string sd = DateTime.Now.ToShortDateString();
            int y = Convert.ToInt32(Request.Cookies["fdet"].Values["fid"]);
            string n = Request.Cookies["fdet"].Values["name"].ToString();
            string c = Request.Cookies["fdet"].Values["city"].ToString();
            string w = "Waiting for confirmation";
            string v = TextBox2.Text;
            string fh = TextBox3.Text;
            string t = DropDownList4.SelectedItem.ToString();
            int t_id = 1;
            string st = DropDownList3.SelectedItem.ToString();
            string z = DropDownList2.SelectedItem.ToString();
            string de = TextBox9.Text;
            string da = DateTime.Today.ToString();
            a = TextBox13.Text;
            rel = TextBox17.Text;
            add = TextBox14.Text;
            ad = TextBox15.Text;
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
            int age = int.Parse(TextBox6.Text);


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

            string q = "insert into firinfo ( fir_no,filer_id,filer_name, city, type, vic, fh_name, status, station, zone, descp, u_file, date, type_id, i_place, i_date, age, gender, a_name, rel, address, a_det, a_known, subtype, date_short) values(" + x + ", " + y + ", '" + n + "', '" + c + "', '" + t + "', '" + v + "', '" + fh + "', '" + w + "', '" + st + "', '" + z + "', '" + de + "', '" + Label30.Text +  "', '" + s + "', " + t_id + ", '" + ip + "', '" + id + "', " + age + ", '" + g + "', '" + a + "', '" + rel + "', '" + add + "', '" + ad + "', '" + ak + "', '" + subt + "', '" + sd + "')";
            con2.Open();
            SqlCommand cmd = new SqlCommand(q, con2);
            int p = cmd.ExecuteNonQuery();
            con2.Close();
        }
           
        }

    //crime against women
      public void cat2()
      {

         
          bool check = RadioButton12.Checked || RadioButton13.Checked;
          bool sub = RadioButton5.Checked || RadioButton6.Checked || RadioButton7.Checked || RadioButton15.Checked || RadioButton16.Checked;


          if (DropDownList2.SelectedIndex == 0 || DropDownList3.SelectedIndex == 0 || TextBox2.Text == "" || TextBox3.Text == "" || TextBox6.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox9.Text == "" || check == false || sub == false)
          {
              Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
          }
          else if ((RadioButton12.Checked) && (TextBox13.Text == "" || TextBox17.Text == ""))
          {
              Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
          }
          else
          {
              string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
              SqlConnection con2 = new SqlConnection(cnstr2);
              x = fno() + 1;
              string a, rel, add, ad;
              string subt = "";
              string s = DateTime.Now.ToString();
              string sd = DateTime.Now.ToShortDateString();

              int y = Convert.ToInt32(Request.Cookies["fdet"].Values["fid"]);
              string n = Request.Cookies["fdet"].Values["name"].ToString();
              string c = Request.Cookies["fdet"].Values["city"].ToString();
              string w = "Waiting for confirmation";
              string v = TextBox2.Text;
              string fh = TextBox3.Text;
              string t = DropDownList4.SelectedItem.ToString();
              int t_id = 2;
              string st = DropDownList3.SelectedItem.ToString();
              string z = DropDownList2.SelectedItem.ToString();
              string de = TextBox9.Text;
              string da = DateTime.Today.ToString();
              string gen = "Female";
              a = TextBox13.Text;
              rel = TextBox17.Text;
              add = TextBox14.Text;
              ad = TextBox15.Text;
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
              int age = int.Parse(TextBox6.Text);


              if (RadioButton5.Checked)
              {
                  subt = RadioButton5.Text;
              }
              else if (RadioButton6.Checked)
              {
                  subt = RadioButton6.Text;
              }
              else if (RadioButton7.Checked)
              {
                  subt = RadioButton7.Text;
              }
              else if (RadioButton15.Checked)
              {
                  subt = RadioButton15.Text;
              }
              else if (RadioButton16.Checked)
              {
                  subt = RadioButton16.Text;
              }

              string q = "insert into firinfo ( fir_no,filer_id,filer_name, city, type, vic, fh_name, status, station, zone, descp, u_file, date, type_id, i_place, i_date, age, a_name, rel, address, a_det, a_known, subtype,date_short, gender) values(" + x + ", " + y + ", '" + n + "', '" + c + "', '" + t + "', '" + v + "', '" + fh + "', '" + w + "', '" + st + "', '" + z + "', '" + de + "', '" + Label30.Text + "', '" + s + "', " + t_id + ", '" + ip + "', '" + id + "', " + age + ", '" + a + "', '" + rel + "', '" + add + "', '" + ad + "', '" + ak + "', '" + subt + "', '" + sd +  "', '" + gen +"')";
              con2.Open();
              SqlCommand cmd = new SqlCommand(q, con2);
              int p = cmd.ExecuteNonQuery();
              con2.Close();
          }

      }

    //other
      public void cat3()
      {

          //bool gen = RadioButton8.Checked || RadioButton9.Checked;
          bool check = RadioButton12.Checked || RadioButton13.Checked;

          if (DropDownList2.SelectedIndex == 0 || DropDownList3.SelectedIndex == 0 || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox9.Text == "" || check == false)
          {
              Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
          }
          else if ((RadioButton12.Checked) && (TextBox13.Text == "" || TextBox15.Text == "" || TextBox17.Text == ""))
          {
              Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
          }
          else
          {
              string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
              SqlConnection con2 = new SqlConnection(cnstr2);
              x = fno() + 1;
              string a, rel, add, ad;
              string s = DateTime.Now.ToString();
              string sd = DateTime.Now.ToShortDateString();

              int y = Convert.ToInt32(Request.Cookies["fdet"].Values["fid"]);
              string n = Request.Cookies["fdet"].Values["name"].ToString();
              string c = Request.Cookies["fdet"].Values["city"].ToString();
              string w = "Waiting for confirmation";
              string v = TextBox2.Text;
              string fh = TextBox3.Text;
              string t = DropDownList4.SelectedItem.ToString();
              int t_id = 3;
              string st = DropDownList3.SelectedItem.ToString();
              string z = DropDownList2.SelectedItem.ToString();
              string de = TextBox9.Text;
              string da = DateTime.Today.ToString();
              a = TextBox13.Text;
              rel = TextBox17.Text;
              add = TextBox14.Text;
              ad = TextBox15.Text;
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

              string q = "insert into firinfo ( fir_no,filer_id,filer_name, city, type, vic, fh_name, status, station, zone, descp, u_file, date, type_id, i_place, i_date, a_name, rel, address, a_det, a_known,date_short) values(" + x + ", " + y + ", '" + n + "', '" + c + "', '" + t + "', '" + v + "', '" + fh + "', '" + w + "', '" + st + "', '" + z + "', '" + de + "', '" + Label30.Text + "', '" + s + "', " + t_id + ", '" + ip + "', '" + id + "', '" + a + "', '" + rel + "', '" + add + "', '" + ad + "', '" + ak + "', '" + sd + "')";
              con2.Open();
              SqlCommand cmd = new SqlCommand(q, con2);
              int p = cmd.ExecuteNonQuery();
              con2.Close();

          }

      }

      //kidnapping--extortion--murder--assault--harrassment--domestic violence
    public void cat4()
    {
        
      bool gen=RadioButton8.Checked || RadioButton9.Checked;
        bool check=RadioButton12.Checked || RadioButton13.Checked;
       
        if (DropDownList2.SelectedIndex == 0 || DropDownList3.SelectedIndex == 0 || TextBox2.Text == "" || TextBox3.Text == "" || TextBox6.Text == "" || gen == false || TextBox4.Text == "" || TextBox5.Text == "" || TextBox9.Text == "" || check == false)
        {
            Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
        }
        else if ((RadioButton12.Checked) && (TextBox13.Text == "" || TextBox15.Text == "" || TextBox17.Text == ""))
        {
            Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
        }
        else
        {
            string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection con2 = new SqlConnection(cnstr2);
            x = fno() + 1;
            string a, rel, add, ad;
            string s = DateTime.Now.ToString();
            string sd = DateTime.Now.ToShortDateString();
           
            int y = Convert.ToInt32(Request.Cookies["fdet"].Values["fid"]);
            string n = Request.Cookies["fdet"].Values["name"].ToString();
            string c = Request.Cookies["fdet"].Values["city"].ToString();
            string w="Waiting for confirmation";
            string v=TextBox2.Text;
            string fh=TextBox3.Text;
            string t=DropDownList4.SelectedItem.ToString();
            int t_id=4;
            string st=DropDownList3.SelectedItem.ToString();
            string z=DropDownList2.SelectedItem.ToString();
            string de=TextBox9.Text;
            string da=DateTime.Now.ToString();
            a = TextBox13.Text;
            rel = TextBox17.Text;
            add = TextBox14.Text;
            ad = TextBox15.Text;
            if (RadioButton12.Checked)
            {
               ak = RadioButton12.Text;
            }
            else if (RadioButton13.Checked)
            {
                ak = RadioButton13.Text;
            }
            string ip=TextBox4.Text;
            string id=TextBox5.Text;
            int age=int.Parse(TextBox6.Text);
           
           
            if(RadioButton8.Checked)
            {
                g=RadioButton8.Text;
            }
            else if(RadioButton9.Checked)
            {
                g=RadioButton9.Text;
            }


            string q = "insert into firinfo ( fir_no,filer_id,filer_name, city, type, vic, fh_name, status, station, zone, descp, u_file, date, type_id, i_place, i_date, age, gender, a_name, rel, address, a_det, a_known,date_short) values(" + x + ", " + y + ", '" + n + "', '" + c + "', '" + t + "', '" + v + "', '" + fh + "', '" + w + "', '" + st + "', '" + z + "', '" + de + "', '" + Label30.Text + "', '" + s + "', " + t_id + ", '" + ip + "', '" + id + "', " + age + ", '" + g + "', '" + a + "', '" + rel + "', '" + add + "', '" + ad + "', '" + ak + "', '" + sd + "')";
            con2.Open();
            SqlCommand cmd = new SqlCommand(q, con2);
            int p = cmd.ExecuteNonQuery();
            con2.Close();

           
        }
    
    }

    //missing person
    public void cat5()
    {

        bool gen = RadioButton8.Checked || RadioButton9.Checked;
        //bool check = RadioButton12.Checked || RadioButton13.Checked;

        if (DropDownList2.SelectedIndex == 0 || DropDownList3.SelectedIndex == 0 || TextBox2.Text == "" || TextBox3.Text == "" || TextBox6.Text == "" || gen == false || TextBox7.Text == "" || TextBox8.Text == "" || TextBox9.Text == "" )
        {
            Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
        }
        
        else
        {
            string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection con2 = new SqlConnection(cnstr2);
            x = fno() + 1;
            string a, rel, add, ad;
            string s = DateTime.Now.ToString();
            string sd = DateTime.Now.ToShortDateString();
            int y = Convert.ToInt32(Request.Cookies["fdet"].Values["fid"]);
            string n = Request.Cookies["fdet"].Values["name"].ToString();
            string c = Request.Cookies["fdet"].Values["city"].ToString();
            string w = "Waiting for confirmation";
            string v = TextBox2.Text;
            string fh = TextBox3.Text;
            string t = DropDownList4.SelectedItem.ToString();
            int t_id = 5;
            string st = DropDownList3.SelectedItem.ToString();
            string z = DropDownList2.SelectedItem.ToString();
            string de = TextBox9.Text;
            string da = DateTime.Today.ToString();
           
            string ip = TextBox7.Text;
            string id = TextBox8.Text;
            int age = int.Parse(TextBox6.Text);


            if (RadioButton8.Checked)
            {
                g = RadioButton8.Text;
            }
            else if (RadioButton9.Checked)
            {
                g = RadioButton9.Text;
            }


            string q = "insert into firinfo ( fir_no,filer_id,filer_name, city, type, vic, fh_name, status, station, zone, descp, u_file,url, date, type_id, m_place, m_date, age, gender,date_short) values(" + x + ", " + y + ", '" + n + "', '" + c + "', '" + t + "', '" + v + "', '" + fh + "', '" + w + "', '" + st + "', '" + z + "', '" + de + "', '" + Label30.Text + "', '" + Label34.Text + "', '" + s + "', " + t_id + ", '" + ip + "', '" + id + "', " + age + ", '" + g + "', '" + sd + "')";
            con2.Open();
            SqlCommand cmd = new SqlCommand(q, con2);
            int p = cmd.ExecuteNonQuery();
            con2.Close();

        }

    }

    //theft---robbery
    public void cat6()
    {
        if (DropDownList2.SelectedIndex == 0 || DropDownList3.SelectedIndex == 0 || TextBox2.Text == "" || TextBox3.Text == "" || TextBox5.Text == "" || TextBox4.Text == "" || TextBox9.Text == "")
        {
            Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
        }

        else
        {
            string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection con2 = new SqlConnection(cnstr2);
            x = fno() + 1;

            string s = DateTime.Now.ToString();
            string sd = DateTime.Now.ToShortDateString();

            int y = Convert.ToInt32(Request.Cookies["fdet"].Values["fid"]);
            string n = Request.Cookies["fdet"].Values["name"].ToString();
            string c = Request.Cookies["fdet"].Values["city"].ToString();
            string w = "Waiting for confirmation";
            string v = TextBox2.Text;
            string fh = TextBox3.Text;
            string t = DropDownList4.SelectedItem.ToString();
            int t_id = 6;
            string st = DropDownList3.SelectedItem.ToString();
            string z = DropDownList2.SelectedItem.ToString();
            string de = TextBox9.Text;
            string da = DateTime.Today.ToString();
          
            string ip = TextBox4.Text;
            string id = TextBox5.Text;


            string q = "insert into firinfo ( fir_no,filer_id,filer_name, city, type, vic, fh_name, status, station, zone, descp, u_file, date, type_id, i_place, i_date,date_short) values(" + x + ", " + y + ", '" + n + "', '" + c + "', '" + t + "', '" + v + "', '" + fh + "', '" + w + "', '" + st + "', '" + z + "', '" + de + "', '" + Label30.Text +  "', '" + s + "', " + t_id + ", '" + ip + "', '" + id + "', '" + sd + "')";
            con2.Open();
            SqlCommand cmd = new SqlCommand(q, con2);
            int p = cmd.ExecuteNonQuery();
            con2.Close();

        }

    }

    //mobile theft
    public void cat7()
    {
        string tr="";
        bool track = RadioButton10.Checked || RadioButton11.Checked;
        if (DropDownList2.SelectedIndex == 0 || DropDownList3.SelectedIndex == 0 || TextBox2.Text == "" || TextBox3.Text == "" || TextBox5.Text == "" || TextBox4.Text == "" || TextBox9.Text == "" || TextBox10.Text == "" || TextBox11.Text == "" || TextBox12.Text == "" || track==false)
        {
            Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
        }

        else
        {
            string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection con2 = new SqlConnection(cnstr2);
            x = fno() + 1;
            //string a, rel, add, ad;
            string s = DateTime.Now.ToString();
            string sd = DateTime.Now.ToShortDateString();

            int y = Convert.ToInt32(Request.Cookies["fdet"].Values["fid"]);
            string n = Request.Cookies["fdet"].Values["name"].ToString();
            string c = Request.Cookies["fdet"].Values["city"].ToString();
            string w = "Waiting for confirmation";
            string v = TextBox2.Text;
            string fh = TextBox3.Text;
            string t = DropDownList4.SelectedItem.ToString();
            int t_id = 7;
            string st = DropDownList3.SelectedItem.ToString();
            string z = DropDownList2.SelectedItem.ToString();
            string de = TextBox9.Text;
            string da = DateTime.Today.ToString();
           
            string ip = TextBox4.Text;
            string id = TextBox5.Text;
            string co = TextBox12.Text;
            string m = TextBox11.Text;
            string b = TextBox10.Text;
            if (RadioButton10.Checked)
            {
                tr = RadioButton10.Text;
            }
            else if (RadioButton11.Checked)
            {
                tr = RadioButton11.Text;
            }


            string q = "insert into firinfo ( fir_no,filer_id,filer_name, city, type, vic, fh_name, status, station, zone, descp, u_file, date, type_id, i_place, i_date, color, brand, model, track,date_short) values(" + x + ", " + y + ", '" + n + "', '" + c + "', '" + t + "', '" + v + "', '" + fh + "', '" + w + "', '" + st + "', '" + z + "', '" + de + "', '" + Label30.Text +"', '" + s + "', " + t_id + ", '" + ip + "', '" + id + "', '" + co + "', '" + b + "', '" + m + "', '" + tr + "', '" + sd + "')";
            con2.Open();
            SqlCommand cmd = new SqlCommand(q, con2);
            int p = cmd.ExecuteNonQuery();
            con2.Close();

        }

    }

    //vehicle theft
    public void cat8()
    {
        string pl = "";

        if (DropDownList2.SelectedIndex == 0 || DropDownList3.SelectedIndex == 0 || TextBox2.Text == "" || TextBox3.Text == "" || TextBox5.Text == "" || TextBox4.Text == "" || TextBox9.Text == "" || TextBox10.Text == "" || TextBox11.Text == "" || TextBox12.Text == "" || TextBox16.Text == "")
        {
            Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
        }

        else
        {
            string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection con2 = new SqlConnection(cnstr2);
            x = fno() + 1;
            //string a, rel, add, ad;
            string s = DateTime.Now.ToString();
            string sd = DateTime.Now.ToShortDateString();

            int y = Convert.ToInt32(Request.Cookies["fdet"].Values["fid"]);
            string n = Request.Cookies["fdet"].Values["name"].ToString();
            string c = Request.Cookies["fdet"].Values["city"].ToString();
            string w = "Waiting for confirmation";
            string v = TextBox2.Text;
            string fh = TextBox3.Text;
            string t = DropDownList4.SelectedItem.ToString();
            int t_id = 8;
            string st = DropDownList3.SelectedItem.ToString();
            string z = DropDownList2.SelectedItem.ToString();
            string de = TextBox9.Text;
            string da = DateTime.Today.ToString();

            string ip = TextBox4.Text;
            string id = TextBox5.Text;
            string co = TextBox12.Text;
            string m = TextBox11.Text;
            string b = TextBox10.Text;
            pl = TextBox16.Text;

            string q = "insert into firinfo ( fir_no,filer_id,filer_name, city, type, vic, fh_name, status, station, zone, descp, u_file, date, type_id, i_place, i_date, color, brand, model, plate,date_short) values(" + x + ", " + y + ", '" + n + "', '" + c + "', '" + t + "', '" + v + "', '" + fh + "', '" + w + "', '" + st + "', '" + z + "', '" + de + "', '" + Label30.Text + "', '" + s + "', " + t_id + ", '" + ip + "', '" + id + "', '" + co + "', '" + b + "', '" + m + "', '" + pl + "', '" + sd + "')";
            con2.Open();
            SqlCommand cmd = new SqlCommand(q, con2);
            int p = cmd.ExecuteNonQuery();
            con2.Close();

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
    protected void Button2_Click(object sender, EventArgs e)
    {
        //type = DropDownList4.SelectedIndex;
        //Response.Write(type);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        type = Convert.ToInt32(HiddenField1.Value);
        if ((type == 1 || type == 4) || (type == 5 || type == 7) || (type == 8 || type == 11))
        {
            f_sub();
            cat4();
            int x = 1;
            int y = fno();
            Server.Transfer("fir_msg.aspx?a=" + x + "&fn=" + y);
        }
        else if (type == 2)
        {
            f_sub();
            cat1();
            int x = 1;
            int y = fno();
           Server.Transfer("fir_msg.aspx?a=" + x + "&fn=" + y);
        }
        else if (type == 3)
        {
            f_sub();
            cat2();
            int x = 1;
            int y = fno();
            Server.Transfer("fir_msg.aspx?a=" + x + "&fn=" + y);
        }
        else if (type == 12)
        {
            f_sub();
            cat3();
            int x = 1;
            int y = fno();
            Server.Transfer("fir_msg.aspx?a=" + x + "&fn=" + y);
        }
        else if (type == 9)
        {
            f_sub();
            cat5();
            int x = 1;
            int y = fno();
            Server.Transfer("fir_msg.aspx?a=" + x + "&fn=" + y);
        }
            else if (type == 6 || type == 13)
        {
            f_sub();
            cat3();
            int x = 1;
            int y = fno();
            Server.Transfer("fir_msg.aspx?a=" + x + "&fn=" + y);
        }
        else if (type == 10)
        {
            f_sub();
            cat7();
            int x = 1;
            int y = fno();
            Server.Transfer("fir_msg.aspx?a=" + x + "&fn=" + y);
        }
        else if (type == 14)
        {
            f_sub();
            cat8();
            int x = 1;
            int y = fno();
            Server.Transfer("fir_msg.aspx?a=" + x + "&fn=" + y);
        }
        else
            Response.Write("<script> alert('wow')</script>");
    }


    protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
    {
        type = DropDownList4.SelectedIndex;
        HiddenField1.Value = type.ToString();
        if (type == 0)
        {
            Response.Write("<script> alert('Please Select a type')</script>");
        }
        else if ((type == 1 || type == 4) || (type == 5 || type == 7) || (type == 8 || type == 11))
        {
            pan_close();

            Panel1.Visible = true;
            Panel4.Visible = true;
            Panel5.Visible = true;
            Panel10.Visible = true;

           
        }
        else if (type == 6 || type == 13) 
        {
            pan_close();

            Panel12.Visible = true;
            Panel13.Visible = true;
            Panel5.Visible = true;
            Panel10.Visible = true;
        }
        else if (type == 12)
        {
            pan_close();

            Panel12.Visible = true;
            Panel13.Visible = true;
            Panel5.Visible = true;
            Panel10.Visible = true;
           

        }
        else if (type == 9 )
        {
            pan_close();

            Panel12.Visible = true;
            Panel13.Visible = true;
            Panel1.Visible = true;
            Panel4.Visible = true;
            Panel6.Visible = true;

        }
        else if (type == 10)
        {
            pan_close();

            Panel12.Visible = true;
            Panel13.Visible = true;
            Panel5.Visible = true;
            Panel7.Visible = true;
            Panel8.Visible = true;

        }
        else if (type == 14)
        {
            pan_close();

            Panel12.Visible = true;
            Panel13.Visible = true;
            Panel5.Visible = true;
            Panel7.Visible = true;
            Panel9.Visible = true;
            
        }
        else if (type == 2)
        {
            pan_close();

            Panel12.Visible = true;
            Panel13.Visible = true;
            Panel5.Visible = true;
            Panel1.Visible = true;
            Panel2.Visible = true;
            Panel4.Visible = true;
            Panel10.Visible = true;
          

        }
        else if (type == 3)
        {
            pan_close();

            Panel12.Visible = true;
            Panel13.Visible = true;
            Panel5.Visible = true;
            Panel1.Visible = true;
            Panel3.Visible = true;
            //Panel4.Visible = true;
            Panel10.Visible = true;
        }

    }
    protected void RadioButton12_CheckedChanged(object sender, EventArgs e)
    {
        Panel11.Visible = true;
        //Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
    }
    protected void RadioButton13_CheckedChanged(object sender, EventArgs e)
    {
        Panel11.Visible = false;
        //Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
    }
    protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = !Calendar1.Visible;
        Calendar1.Focus();
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox5.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = !Calendar1.Visible;
    }
    protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
    {
        Calendar2.Visible = !Calendar2.Visible;
        Calendar2.Focus();
    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        TextBox8.Text = Calendar2.SelectedDate.ToShortDateString();
        Calendar2.Visible = !Calendar2.Visible;
    }
   
}