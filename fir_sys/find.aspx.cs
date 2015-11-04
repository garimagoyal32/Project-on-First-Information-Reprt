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
        DropDownList2.Focus();


    }
   
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        fill_list();
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

    protected void Button8_Click(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedIndex == 0 || DropDownList1.SelectedIndex == 0 || DropDownList1.SelectedIndex == 0)
        {
            Response.Write("<script> alert('Please select city, division and police station from the respective drop down lists')</script>");
        }
        else
        {
            Panel1.Visible = true;
            string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
            
            SqlConnection con2 = new SqlConnection(cnstr2);
            con2.Open();
            System.Data.DataTable dt = new System.Data.DataTable();

            
            string ps = DropDownList3.SelectedItem.ToString();
            
               string q = "select * from stations where  police='" + ps + "'";
           
            SqlDataAdapter da2 = new SqlDataAdapter(q, con2);
            SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

            da2.Fill(dt);
            System.Data.DataSet ds2 = new System.Data.DataSet();
            Label4.Text = dt.Rows[0]["police"].ToString();
            Label5.Text = dt.Rows[0]["contact"].ToString();
            Label6.Text = dt.Rows[0]["email"].ToString();
            if (Label5.Text == "" && Label5.Text == "")
            {
                Response.Write("<script> alert('The data you are trying to search is not yet available in the database.')</script>");
            }
        }
    }
}