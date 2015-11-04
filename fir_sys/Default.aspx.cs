using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //int x;
    //public int rad()
    //{
    //    Random randomNumber = new Random();
    //    //Provide the min and max limit for the no
    //    int generatedNo = randomNumber.Next(100000, 999999);
    //    //TextBox1.Text = generatedNo.ToString();  
    //    return generatedNo;
    //}
    //public void filer_det(int x)
    //{
    //    //try
    //    //{
    //    string cnstr = "Data Source=.;Initial Catalog=fir_sys;Integrated Security=True;Pooling=False";
    //    string g;
    //    if (TextArea1.Text == true)
    //    {
    //        g = RadioButton1.Text;
    //    }
    //    else if (RadioButton2.Checked == true)
    //    {
    //        g = RadioButton2.Text;
    //    }
    //    else
    //    {
    //        Label18.Visible = true;
    //    }

    //    if (TextBox1.Text == " ")
    //    {
    //        Label12.Visible = true;
    //    }
    //    if (TextBox3.Text == " ")
    //    {
    //        Label17.Visible = true;
    //    }
    //    if (TextBox1.Text == " ")
    //    {
    //        Label12.Visible = true;
    //    }
    //    string query = "insert into filer (filer_id, fname,gender, age, address, city, phone, mobile, email) values(" + x + ", " + TextBox1.Text + ", " + TextBox3.Text + "' " + ") ";
    //    SqlConnection con = new SqlConnection();
    //    SqlConnection n = new SqlConnection();
    //    con.ConnectionString = cnstr;
    //    SqlCommand cmd = new SqlCommand();
    //    cmd.CommandText = query;
    //    cmd.Connection = con;
    //    //int x = a;
    //    //string s = TextBox1.Text;
    //    //string b = TextBox2.Text;
    //    //string c = TextBox3.Text;
    //    //string ef = TextBox4.Text;
    //    //string f = TextBox5.Text;
    //    //cmd.Parameters.AddWithValue("p", x);
    //    //cmd.Parameters.AddWithValue("q", s);
    //    //cmd.Parameters.AddWithValue("r", b);
    //    //cmd.Parameters.AddWithValue("s", c);
    //    //cmd.Parameters.AddWithValue("t", ef);
    //    //cmd.Parameters.AddWithValue("u", f);

    //    con.Open();
    //    int p = cmd.ExecuteNonQuery();

    //    con.Close();

    //    TextBox1.Text = " ";
    //    TextBox2.Text = " ";
    //    TextBox3.Text = " ";
    //    TextBox4.Text = " ";
    //    TextBox5.Text = " ";

    //}
    ////catch (Exception e)
    ////{
    ////    Response("Fill all entries and in proper format");
    ////}
    ////}
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

        int x = Convert.ToInt32(dt.Rows[0]["m"]);
        return x;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //int x = rad();
        //filer_det(x);
        if (TextBox1.Text == "" || TextBox3.Text == "" || TextBox5.Text == "" || DropDownList1.SelectedIndex == 0)
        {
            Response.Write("<script> alert('All fields marked * are mandatory to fill')</script>");
        }
        else if (TextBox9.Text == "" && TextBox12.Text == "")
        {
            Response.Write("<script> alert('Please fill your mobile number or phone number')</script>");
        }
        else
        {
            try
            {
                int y = fid() + 1;
                HttpCookie k = new HttpCookie("fdet");
                k.Values["name"] = TextBox1.Text;
                k.Values["fname"] = TextBox3.Text;
                k.Values["address"] = TextBox5.Text;
                k.Values["city"] = DropDownList1.SelectedItem.ToString();
                k.Values["phone"] = TextBox9.Text;
                k.Values["mobile"] = TextBox12.Text;
                k.Values["email"] = TextBox11.Text;
                k.Values["fid"] = y.ToString();

                Response.Cookies.Add(k);

                Response.Redirect("fir_det_c.aspx");
            }

            catch (Exception ex)
            {
                Response.Write("<script> alert('An unexpected error occured.\n Please make sure you fill all entries in proper format.\n Please refresh the page and try agian')</script>");
            }
        }
        //Server.Transfer("fir_det_c.aspx ? fid=" + y + "&name='" + TextBox1.Text + "' &fname='" + TextBox3.Text + "' &address='" + TextBox5.Text + "' &city='" + DropDownList1.SelectedItem.ToString() + "' &email='" + TextBox11.Text + "' &phone=" + TextBox9.Text + " &mobile=" + TextBox12.Text);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = " ";
        TextBox3.Text = " ";
        TextBox5.Text = " ";
        DropDownList1.SelectedIndex = 0;

        TextBox9.Text = " ";
        TextBox11.Text = " ";
        TextBox12.Text = " ";
    }
}