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
    int x;
    int y;
    string imagedata;
   
   
    public int fid()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
      
        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select max(filer_id) m from filer_details";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();

       int x = Convert.ToInt32( dt.Rows[0]["m"]);
        return x;
    }

    public int rep()
    {
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);

        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select max(rep_no) rn from rpg";
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        string st = dt.Rows[0]["rn"].ToString();
        int x = Convert.ToInt32(st);
        return x;
    }
   
    public string def = "~/upload/files/" ;

    protected void Button8_Click(object sender, EventArgs e)
    {
        imagedata = string.Empty;
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath((def) + FileUpload1.FileName));
            imagedata = def + FileUpload1.FileName;
        }
        FileUpload1.Visible = false;
        Label17.Visible = true;
        Label17.Text = imagedata;
        //Image1.ImageUrl = imagedata;
    }

    public void f_sub()
    {
        try
        {
            string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection con2 = new SqlConnection(cnstr2);
            y = fid() + 1;
            string q = "insert into filer_details ( filer_id, name, fname, address, f_city, phone ,mobile) values(" + y + ", '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + DropDownList1.SelectedItem.ToString() + "', '" + TextBox5.Text + "', '" + TextBox6.Text + "') ";
            con2.Open();
            SqlCommand cmd = new SqlCommand(q, con2);
            int p = cmd.ExecuteNonQuery();
            con2.Close();
        }
        catch (Exception ex)
        {
            Response.Write("<script> alert('An unexpected error occured.\n Please make sure you fill all entries in proper format.\n Please refresh the page and try agian')</script>");
        }
    }

    public void rpg_sub()
    {
        try
        {
            string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection con2 = new SqlConnection(cnstr2);
            x = rep() + 1;
            //int y = fid();
            string s = Calendar1.SelectedDate.ToShortDateString();
            string s1 = DateTime.Now.ToString();
            //string s = TextBox10.Text;

            string q = "insert into rpg ( rep_no, name, desig, city, zone, station, date, filer_id, date_filed, descp, u_file) values(" + x + ", '" + TextBox7.Text + "', '" + TextBox8.Text + "', '" + DropDownList1.SelectedItem.ToString() + "', '" + DropDownList2.SelectedItem.ToString() + "', '" + DropDownList3.SelectedItem.ToString() + "', '" + s + "', " + y + ", '" + s1 + "', '" + TextBox9.Text + "', '" + Label17.Text + "')";
            con2.Open();
            SqlCommand cmd = new SqlCommand(q, con2);
            int p = cmd.ExecuteNonQuery();
            con2.Close();
        }
        catch (Exception ex)
        {
            Response.Write("<script> alert('An unexpected error occured.\n Please make sure you fill all entries in proper format.\n Please refresh the page and try agian')</script>");
        }
    }

    public void fill_list()
    {

        DropDownList2.Items.Clear();
        DropDownList3.Items.Clear();
        DropDownList2.Items.Add("Select");
        DropDownList3.Items.Add("Select");
        //string s = Request.Cookies["fdet"].Values["city"];
        //Response.Write(s);

        string cnstr = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        con.ConnectionString = cnstr;
        cmd.Connection = con;
        string query = "select distinct zone from stations where city='" + DropDownList1.SelectedItem.ToString() + "'";
        con.Open();


        cmd.CommandText = query;
        SqlDataReader r = cmd.ExecuteReader();
        while (r.Read())
        {
            ListItem z = new ListItem();

            z.Text = r[0].ToString();

            DropDownList2.Items.Add(z);

            //DropDownList2.Items.Add(r[0].ToString);



        }
        con.Close();
       TextBox5.Focus();
       

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

            //DropDownList2.Items.Add(r[0]);



        }
        con.Close();
        DropDownList3.Focus();
       

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        fill_list();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox7.Text == "" || TextBox8.Text == "" || TextBox10.Text == "" || TextBox9.Text == "" || DropDownList1.SelectedIndex == 0 || DropDownList2.SelectedIndex == 0 || DropDownList3.SelectedIndex == 0)
        {
            Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
        }
        else if (TextBox5.Text == "" && TextBox6.Text == "")
        {
            Response.Write("<script> alert('please enter phone number or mobile number')</script>");
        }
        else
        {
            f_sub();
            rpg_sub();
            int x = 2;
            Response.Redirect("fir_msg.aspx?a=" + x);
        }
    }
    protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
    {
        Calendar1.Visible = !Calendar1.Visible;
        Calendar1.Focus();
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox10.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = !Calendar1.Visible;
        TextBox9.Focus();
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        TextBox10.Focus();
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
   
}