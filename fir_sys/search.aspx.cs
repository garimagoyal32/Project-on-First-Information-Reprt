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
        if (!IsPostBack)
        {
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
            Panel4.Visible = false;
        }
    }
    int f = 0;
    //bool ff, ff1, ff2;
    public void search1()
    {

    }

    public void checkp1()
    {
        string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(str);
        conn.Open();
        string q = "";
        if (RadioButton11.Checked)
        {
            q = "select count(*) from firinfo where fir_no=" + Convert.ToInt32(TextBox1.Text) + " and filer_name='" + TextBox4.Text + "'";
        }
        else if (RadioButton12.Checked)
        {
            q = "select count(*) from firinfo where fir_no=" + Convert.ToInt32(TextBox1.Text) + " and vic='" + TextBox4.Text + "'";
        }
        else if (RadioButton13.Checked)
        {
            q = "select count(*) from firinfo where fir_no=" + Convert.ToInt32(TextBox1.Text) + " and a_name='" + TextBox4.Text + "'";
        }
        //string query3 = "select count(*) from firinfo where fir_no=" + TextBox1.Text + " and filer_name='" + TextBox4.Text + "'";

        SqlCommand cmdd = new SqlCommand(q, conn);
        int x = (int)cmdd.ExecuteScalar();
        if (x > 0)
        {
            check1();
        }
        else
        {
            TextBox1.Text = " ";
            Label1.Visible = true;
        }

    }

    public void checkp2()
    {
        string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(str);
        conn.Open();
        string q = "";
        string date = TextBox3.Text;
        string ps = DropDownList3.SelectedItem.ToString();
        if (RadioButton11.Checked)
        {
            q = "select count(*) from firinfo where station='" + ps + "' and filer_name='" + TextBox4.Text + "' and date_short='" + date + "'";
        }
        else if (RadioButton12.Checked)
        {
            q = "select count(*) from firinfo where  station='" + ps + "' and vic='" + TextBox4.Text + "' and date_short='" + date + "'";
        }
        else if (RadioButton13.Checked)
        {
            q = "select count(*) from firinfo where  station='" + ps + "' and a_name='" + TextBox4.Text + "' and date_short='" + date + "'";
        }
        //string query3 = "select count(*) from firinfo where fir_no=" + TextBox1.Text + " and filer_name='" + TextBox4.Text + "'";

        SqlCommand cmdd = new SqlCommand(q, conn);
        int x = (int)cmdd.ExecuteScalar();
        if (x > 0)
        {
            check2();
        }
        else
        {
            Response.Write("<script> alert('No FIR matching with the combination entered found in the database.')</script>");
        }

    }
    
    public void check2()
    {
       //try
       //{
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        string q="";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        
        string date = TextBox3.Text;
        string ps = DropDownList3.SelectedItem.ToString();
        if (RadioButton11.Checked)
        {
            q = "select type_id, fir_no from firinfo where station='" + ps + "' and filer_name='" + TextBox4.Text + "' and date_short='" + TextBox3.Text + "' ";
        }
        else if (RadioButton12.Checked)
        {
            q = "select type_id, fir_no from firinfo where  station='" + ps + "' and vic='" + TextBox4.Text + "' and date_short='" + TextBox3.Text + "'";
        }
        else if (RadioButton13.Checked)
        {
            q = "select type_id, fir_no from firinfo where  station='" + ps + "' and a_name='" + TextBox4.Text + "' and date_short='" + TextBox3.Text + "'";
        }
        SqlDataAdapter da2 = new SqlDataAdapter(q, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        int fno = Convert.ToInt32(dt.Rows[0]["fir_no"]);
        
                int id = Convert.ToInt32(dt.Rows[0]["type_id"]);
               Server.Transfer("viewfir.aspx?a="+id+"&b="+fno);

       //}

       //catch (Exception ex)
       //{
       //    Response.Write("<script> alert('No FIR matching with the combination entered found in the database.')</script>");
       //}
    }

    public void check1()
    {

        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        string q = "";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();

        q = "select type_id from firinfo where fir_no=" + Convert.ToInt32(TextBox1.Text);

        SqlDataAdapter da2 = new SqlDataAdapter(q, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        int fno = Convert.ToInt32(TextBox1.Text);

        int id = Convert.ToInt32(dt.Rows[0]["type_id"]);
        Server.Transfer("viewfir.aspx?a=" + id + "&b=" + fno);

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
    protected void RadioButton9_CheckedChanged(object sender, EventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = true;
        f = 1;
        HiddenField1.Value = f.ToString();
    }
    protected void RadioButton10_CheckedChanged(object sender, EventArgs e)
    {
        Panel2.Visible = true;
        Panel1.Visible = false;
        Panel3.Visible = true;
        Panel4.Visible = true;
        f = 2;
        HiddenField1.Value = f.ToString();
    }
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
       
            Calendar1.Visible = !Calendar1.Visible;
            Calendar1.Focus();
       
    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
         Calendar1.Visible = true;
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {

        TextBox3.Text = Calendar1.SelectedDate.ToShortDateString();
        Calendar1.Visible = !Calendar1.Visible;
       Button1.Focus();
    }
    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {

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
        DropDownList2.Focus();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        bool sel = RadioButton11.Checked || RadioButton12.Checked || RadioButton13.Checked || RadioButton14.Checked;
        f = Convert.ToInt32(HiddenField1.Value);
        if (f == 1)
        {

            if (TextBox1.Text == "" || sel == false || TextBox4.Text == "")
           
            {
                
                Response.Write("<script> alert('Please fill all entries')</script>");
            }
            else if (RadioButton14.Checked)
            {
                TextBox4.ReadOnly = true;
                Response.Write("<script> alert('Only Complainant, Accused person or victim can view FIR')</script>");
            }


            else
            {
               
                TextBox4.ReadOnly = false;
                checkp1();
            }
        }
        else if (f == 2)
        {
            //bool drop=DropDownList1.SelectedIndex == 0 || DropDownList2.SelectedIndex == 0 || DropDownList3.SelectedIndex == 0;
            //if (drop == false || Calendar1.SelectedDate.ToString() == "" || TextBox4.Text == "" || sel == false)
                if (TextBox3.Text == "" || TextBox4.Text == "" || sel == false || DropDownList1.SelectedIndex==0 || DropDownList2.SelectedIndex==0 || DropDownList3.SelectedIndex==0)
            {
                Response.Write("<script> alert('Please fill all fields')</script>");
            }
            else if (RadioButton14.Checked)
            {
                TextBox4.ReadOnly = true;
                Response.Write("<script> alert('Only Complainant, Accused person or victim can view FIR')</script>");
            }
            else
            {
                TextBox4.ReadOnly = false;
                checkp2();
            }

        }
        else
        {            
            Response.Write("<script> alert('An unexpected error occured. \n Please refresh the page and try again')</script>");
        }
    }

    protected void RadioButton14_CheckedChanged(object sender, EventArgs e)
    {
        TextBox3.ReadOnly = true;
        Response.Write("<script> alert('Only Complainant, Accused person or victim can view FIR')</script>");
    }
    protected void RadioButton11_CheckedChanged(object sender, EventArgs e)
    {
        TextBox3.ReadOnly = false;
    }
    protected void RadioButton12_CheckedChanged(object sender, EventArgs e)
    {
        TextBox3.ReadOnly = false;
    }
    protected void RadioButton13_CheckedChanged(object sender, EventArgs e)
    {
        TextBox3.ReadOnly = false;
    }
}