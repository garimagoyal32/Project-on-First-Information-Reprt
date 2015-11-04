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
        DropDownList1.SelectedItem.Selected = false;
    }

    public void view()
    {
        string gen = "";
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);

        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select * from filer_details where filer_id=" + Convert.ToInt32(TextBox13.Text);
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        TextBox1.Text = dt.Rows[0]["name"].ToString();
        TextBox3.Text = dt.Rows[0]["fname"].ToString();
         gen = dt.Rows[0]["f_city"].ToString();
         DropDownList1.SelectedItem.Selected = false;
         DropDownList1.Items.FindByText(gen).Selected = true;
         HiddenField1.Value = DropDownList1.SelectedIndex.ToString();
        //TextBox3.Text = dt.Rows[0]["city"].ToString();
        TextBox5.Text = dt.Rows[0]["address"].ToString();
        TextBox9.Text = dt.Rows[0]["phone"].ToString();
        TextBox12.Text = dt.Rows[0]["mobile"].ToString();
        TextBox11.Text = dt.Rows[0]["email"].ToString();
     
    }

    public void updt()
    {
        string cnstr = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con = new SqlConnection(cnstr);
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = con;

        con.Open();


        cmd.CommandText = "update filer_details set name='" + TextBox1.Text + "',address='" + TextBox5.Text + "', phone='" +TextBox9.Text + "',mobile='" + TextBox12.Text + "',email='" + TextBox11.Text + "',fname='" + TextBox3.Text + "',f_city='" + DropDownList1.SelectedItem.ToString() + "' where filer_id='" + Convert.ToInt32(TextBox13.Text) + "'";
        int p = cmd.ExecuteNonQuery();
        con.Close();
        Response.Write("<script> alert('Updated')</script>");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (TextBox13.Text == "")
        {
            Response.Write("<script> alert('Please fill all entries')</script>");
        }
        else
        {
           
            string str = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();

            string query3 = "select count(*) from filer_details where filer_id=" +Convert.ToInt32(TextBox13.Text);

            SqlCommand cmdd = new SqlCommand(query3, conn);
            int x = (int)cmdd.ExecuteScalar();
            if (x > 0)
            {
                //Panel1.Visible = true;
                Label11.Visible = false;
                view();
            }
            else
            {
                TextBox1.Text = " ";
                Label11.Visible = true;
            }

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //DropDownList1.Items.FindByText(HiddenField1.Value).Selected = true;
        DropDownList1.SelectedIndex=Convert.ToInt32( HiddenField1.Value);
        if (TextBox1.Text == "" || TextBox3.Text == "" || TextBox5.Text == "" || DropDownList1.SelectedIndex == 0 || TextBox13.Text == "")
        {
            Response.Write("<script> alert('Please fill all entries')</script>");
        }
        else if (TextBox9.Text == "" && TextBox12.Text == "")
        {
            Response.Write("<script> alert('Either Phone or Mobile field is mandatory to be filled')</script>");
        }
        else
        {
            updt();
            //Response.Write("<script> alert('Updated')</script>");
        }
    }
}