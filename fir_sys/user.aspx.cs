using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    public void pan()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel3.Visible = false;
        Panel4.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        pan();
    }

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        pan();
        reset();
        Panel1.Visible = true;
        Panel3.Visible = true;
        Panel5.Visible = true;
    }
    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        pan();
        reset();
        Panel1.Visible = true;
        Panel4.Visible = true;
        Panel6.Visible = true;
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        pan();
        reset();
        Panel2.Visible = true;

    }

    public void reset()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox10.Text = "";
        TextBox6.Text = "";
        TextBox11.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox14.Text = "";
        TextBox12.Text = "";
        TextBox13.Text = "";
        DropDownList1.SelectedIndex = 0;
    }

    public void view()
    {
        
        string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(str);
        string q = "select * from login where userid='" + TextBox14.Text +"'";

        conn.Open();
        SqlDataAdapter da = new SqlDataAdapter(q, conn);
        System.Data.DataTable dt = new System.Data.DataTable();
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da);
        System.Data.DataSet ds = new System.Data.DataSet();
        da.Fill(dt);
        TextBox1.Text = dt.Rows[0]["name"].ToString();
        TextBox2.Text = dt.Rows[0]["fname"].ToString();
        TextBox3.Text = dt.Rows[0]["designation"].ToString();
        TextBox4.Text = dt.Rows[0]["email"].ToString();
        TextBox9.Text = dt.Rows[0]["address"].ToString();
        TextBox6.Text = dt.Rows[0]["contact_o"].ToString();
        TextBox8.Text = dt.Rows[0]["contact_p"].ToString();
        TextBox10.Text = dt.Rows[0]["userid"].ToString();
        TextBox11.Text = dt.Rows[0]["password"].ToString();
        conn.Close();

    }
    

    public void submit()
    {
        string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(str);
        conn.Open();

        string query3 = "insert into login (userid, password, name, fname, designation, city, address, contact_o, contact_p,email) values('" + TextBox10.Text + "', '" + TextBox11.Text + "', '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + DropDownList1.SelectedItem.ToString() + "', '" + TextBox9.Text + "', '" + TextBox6.Text + "', '" + TextBox8.Text + "', '" + TextBox4.Text + "')";

        SqlCommand cmdd = new SqlCommand(query3, conn);
        int x = cmdd.ExecuteNonQuery();

        conn.Close();

        //Panel2.Visible = false;
        Response.Write("<script>alert('New user added. ')</script>");
    }

    public void updt()
    {
        string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(str);
        conn.Open();

        string query3 = "update login set userid='" + TextBox10.Text + "', password= '" + TextBox11.Text + "', name='" + TextBox1.Text + "', fname='" + TextBox2.Text + "', designation='" + TextBox3.Text + "', city='" + DropDownList1.SelectedItem.ToString() + "', address='" + TextBox9.Text + "', contact_o='" + TextBox6.Text + "', contact_p='" + TextBox8.Text + "', email='" + TextBox4.Text + "' where userid='"+TextBox14.Text + "'";

        SqlCommand cmdd = new SqlCommand(query3, conn);
        int x = cmdd.ExecuteNonQuery();

        conn.Close();

        //Panel2.Visible = false;
        Response.Write("<script>alert('User account updated. ')</script>");
    }

    public void dlt()
    {
        string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection conn = new SqlConnection(str);
        conn.Open();

        string query3 = "delete from login where userid='"+TextBox12.Text + "' and name='"+TextBox13.Text+"'";

        SqlCommand cmdd = new SqlCommand(query3, conn);
        int x = cmdd.ExecuteNonQuery();

        conn.Close();

        //Panel2.Visible = false;
        Response.Write("<script>alert('User deleted. ')</script>");
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        reset();
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox9.Text == "" || TextBox6.Text == "" || TextBox8.Text == "" || TextBox10.Text == "" || TextBox11.Text == "" || DropDownList1.SelectedIndex == 0)
        {
            Response.Write("<script>alert('Please fill all entries. ')</script>");
        }
        else
        {
            string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query3 = "select count(*) from login where userid='" + TextBox10.Text + "'";

            SqlCommand cmdd = new SqlCommand(query3, conn);
            int x = Convert.ToInt32(cmdd.ExecuteScalar());
            if (x > 0)
            {
                Label10.Visible = true;
            }
            else
            {
                Label10.Visible = false;
                submit();
            }
            conn.Close();
        }
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        if (TextBox14.Text == "")
        {
            Response.Write("<script>alert('Enter User ID to view account details ')</script>");
        }
        else
        {
            string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query3 = "select count(*) from login where userid='" + TextBox14.Text + "'";

            SqlCommand cmdd = new SqlCommand(query3, conn);
            int x = Convert.ToInt32(cmdd.ExecuteScalar());
            if (x > 0)
            {
                view();
                Label8.Visible = false;
            }
            else
            {
                Label8.Visible = true;
                reset();
            }
            conn.Close();
           
        }
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox9.Text == "" || TextBox6.Text == "" || TextBox8.Text == "" || TextBox10.Text == "" || TextBox11.Text == "" || DropDownList1.SelectedIndex == 0 || TextBox14.Text == "")
        {
            Response.Write("<script>alert('All fields should be filled ')</script>");
        }
        else
        {
            string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            if (TextBox14.Text != TextBox10.Text)
            {

                string query3 = "select count(*) from login where userid='" + TextBox10.Text + "'";

                SqlCommand cmdd = new SqlCommand(query3, conn);
                int x = Convert.ToInt32(cmdd.ExecuteScalar());
                if (x > 0)
                {
                    Label10.Visible = true;
                }
                else
                {
                    Label10.Visible = false;
                    updt();
                    reset();
                }
                conn.Close();
            }
            else
            {
                Label10.Visible = false;
                updt();
                reset();
            }
        }
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        if (TextBox12.Text == "" || TextBox13.Text == "")
        {
            Response.Write("<script>alert('All fields should be filled ')</script>");
        }
        else
        {
            string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query3 = "select count(*) from login where userid='" + TextBox12.Text + "'";

            SqlCommand cmdd = new SqlCommand(query3, conn);
            int x = Convert.ToInt32(cmdd.ExecuteScalar());
            if (x > 0)
            {
                Label9.Visible = false;
                dlt();
                reset();
                //Label10.Visible = true;
            }
            else
            {
                reset();
                Label9.Visible = true;
            }
            conn.Close();
        }
    }
}