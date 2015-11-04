using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    int id, fno;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            pan_close();
             id = Convert.ToInt32(Request.QueryString["a"]);
            fno = Convert.ToInt32(Request.QueryString["b"]);
            Label42.Text = fno.ToString();
            if (id == 1)
            {
                cat1();
            }
            else if (id == 2)
            {
                cat2();
            }
            else if (id == 3)
            {
                cat3();
            }
            else if (id == 4)
            {
                cat4();
            }
            else if (id == 5)
            {
                cat5();
            }
            else if (id == 6)
            {
                cat3();
            }
            else if (id == 7)
            {
                cat7();
            }
            else if (id == 8)
            {
                cat8();
            }
            else
            {
                Response.Write("<script> alert('Please Select a type')</script>");
            }

        }
    }
    public void pan_close()
    {
        Panel1.Visible = false;
        Panel2.Visible = false;
        Panel14.Visible = false;
        Panel13.Visible = false;
        Panel5.Visible = false;
        Panel6.Visible = false;
        Panel7.Visible = false;
        Panel8.Visible = false;
        Panel9.Visible = false;
        Panel4.Visible = false;
        Panel10.Visible = false;
        Panel11.Visible = false;
    }

    public void cat1()
    {
        Panel4.Visible = true;
       
        //Panel10.Visible = true;
        Panel11.Visible = true;
        Panel5.Visible = true;       
        Panel1.Visible = true;
        Panel2.Visible = true;

        Panel14.Visible = true;
        Panel13.Visible = true;
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";;
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select * from firinfo where fir_no=" + fno;
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        Label43.Text = dt.Rows[0]["station"].ToString();
        Label44.Text = dt.Rows[0]["zone"].ToString();
        Label45.Text = dt.Rows[0]["city"].ToString();
        Label68.Text = dt.Rows[0]["date"].ToString();
        Label50.Text = dt.Rows[0]["type"].ToString();
        Label46.Text = dt.Rows[0]["filer_name"].ToString();
        Label51.Text = dt.Rows[0]["vic"].ToString();
        Label52.Text = dt.Rows[0]["fh_name"].ToString();
        Label53.Text = dt.Rows[0]["age"].ToString();
        Label54.Text = dt.Rows[0]["gender"].ToString();
        Label55.Text = dt.Rows[0]["subtype"].ToString();
        Label58.Text = dt.Rows[0]["i_place"].ToString();
        Label59.Text = dt.Rows[0]["i_date"].ToString();
        Label65.Text = dt.Rows[0]["descp"].ToString();
        Label66.Text = dt.Rows[0]["u_file"].ToString();
        //Label66.Text = dt.Rows[0]["u_file"].ToString();
        string caa = dt.Rows[0]["a_known"].ToString();
        if (caa == "Person Known")
        {
            Label69.Text = dt.Rows[0]["a_name"].ToString();
            Label70.Text = dt.Rows[0]["rel"].ToString();
        }
        else
        {
            Panel10.Visible = true;
            Panel11.Visible = false;
            Label67.Text = caa;
        }
      
    }

    public void cat2()
    {
        Panel4.Visible = true;
        Panel5.Visible = true;
        Panel1.Visible = true;
        Panel2.Visible = true;
        Panel11.Visible = true;
        Panel14.Visible = true;
        Panel13.Visible = true;
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select * from firinfo where fir_no=" + fno;
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        Label43.Text = dt.Rows[0]["station"].ToString();
        Label44.Text = dt.Rows[0]["zone"].ToString();
        Label45.Text = dt.Rows[0]["city"].ToString();
        Label68.Text = dt.Rows[0]["date"].ToString();
        Label50.Text = dt.Rows[0]["type"].ToString();
        Label46.Text = dt.Rows[0]["filer_name"].ToString();
        Label51.Text = dt.Rows[0]["vic"].ToString();
        Label52.Text = dt.Rows[0]["fh_name"].ToString();
        Label53.Text = dt.Rows[0]["age"].ToString();
        Label54.Text = "Female";
        Label55.Text = dt.Rows[0]["subtype"].ToString();
        Label58.Text = dt.Rows[0]["i_place"].ToString();
        Label59.Text = dt.Rows[0]["i_date"].ToString();
        Label65.Text = dt.Rows[0]["descp"].ToString();
        Label66.Text = dt.Rows[0]["u_file"].ToString();
        //Label66.Text = dt.Rows[0]["u_file"].ToString();
        string caa = dt.Rows[0]["a_known"].ToString();
        if (caa == "Person Known")
        {
            Label69.Text = dt.Rows[0]["a_name"].ToString();
            Label70.Text = dt.Rows[0]["rel"].ToString();
        }
        else
        {
            Panel10.Visible = true;
            Panel11.Visible = false;
            Label67.Text = caa;
        }

    }

    public void cat3()
    {
        //Panel4.Visible = true;

        //Panel10.Visible = true;
        Panel11.Visible = true;
        Panel5.Visible = true;
        //Panel1.Visible = true;
        //Panel2.Visible = true;

        Panel14.Visible = true;
        Panel13.Visible = true;
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select * from firinfo where fir_no=" + fno;
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        Label43.Text = dt.Rows[0]["station"].ToString();
        Label44.Text = dt.Rows[0]["zone"].ToString();
        Label45.Text = dt.Rows[0]["city"].ToString();
        Label68.Text = dt.Rows[0]["date"].ToString();
        Label50.Text = dt.Rows[0]["type"].ToString();
        Label46.Text = dt.Rows[0]["filer_name"].ToString();
        Label51.Text = dt.Rows[0]["vic"].ToString();
        Label52.Text = dt.Rows[0]["fh_name"].ToString();
        //Label53.Text = dt.Rows[0]["age"].ToString();
        //Label54.Text = dt.Rows[0]["gender"].ToString();
        //Label55.Text = dt.Rows[0]["subtype"].ToString();
        Label58.Text = dt.Rows[0]["i_place"].ToString();
        Label59.Text = dt.Rows[0]["i_date"].ToString();
        Label65.Text = dt.Rows[0]["descp"].ToString();
        Label66.Text = dt.Rows[0]["u_file"].ToString();
        //Label66.Text = dt.Rows[0]["u_file"].ToString();
        string caa = dt.Rows[0]["a_known"].ToString();
        if (caa == "Person Known")
        {
            Label69.Text = dt.Rows[0]["a_name"].ToString();
            Label70.Text = dt.Rows[0]["rel"].ToString();
        }
        else
        {
            Panel10.Visible = true;
            Panel11.Visible = false;
            Label67.Text = caa;
        }

    }

    public void cat4()
    {
        Panel4.Visible = true;

        //Panel10.Visible = true;
        Panel11.Visible = true;
        Panel5.Visible = true;
        Panel1.Visible = true;
        //Panel2.Visible = true;

        Panel14.Visible = true;
        Panel13.Visible = true;
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select * from firinfo where fir_no=" + fno;
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        Label43.Text = dt.Rows[0]["station"].ToString();
        Label44.Text = dt.Rows[0]["zone"].ToString();
        Label45.Text = dt.Rows[0]["city"].ToString();
        Label68.Text = dt.Rows[0]["date"].ToString();
        Label50.Text = dt.Rows[0]["type"].ToString();
        Label46.Text = dt.Rows[0]["filer_name"].ToString();
        Label51.Text = dt.Rows[0]["vic"].ToString();
        Label52.Text = dt.Rows[0]["fh_name"].ToString();
        Label53.Text = dt.Rows[0]["age"].ToString();
        Label54.Text = dt.Rows[0]["gender"].ToString();
        //Label55.Text = dt.Rows[0]["subtype"].ToString();
        Label58.Text = dt.Rows[0]["i_place"].ToString();
        Label59.Text = dt.Rows[0]["i_date"].ToString();
        Label65.Text = dt.Rows[0]["descp"].ToString();
        Label66.Text = dt.Rows[0]["u_file"].ToString();
        //Label66.Text = dt.Rows[0]["u_file"].ToString();
        string caa = dt.Rows[0]["a_known"].ToString();
        if (caa == "Person Known")
        {
            Label69.Text = dt.Rows[0]["a_name"].ToString();
            Label70.Text = dt.Rows[0]["rel"].ToString();
        }
        else
        {
            Panel10.Visible = true;
            Panel11.Visible = false;
            Label67.Text = caa;
        }

    }

    public void cat5()
    {
        Panel4.Visible = true;

        Panel6.Visible = true;
        Panel11.Visible = true;
        //Panel5.Visible = true;
        Panel1.Visible = true;
        Panel2.Visible = true;

        Panel14.Visible = true;
        Panel13.Visible = true;
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select * from firinfo where fir_no=" + fno;
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        Label43.Text = dt.Rows[0]["station"].ToString();
        Label44.Text = dt.Rows[0]["zone"].ToString();
        Label45.Text = dt.Rows[0]["city"].ToString();
        Label68.Text = dt.Rows[0]["date"].ToString();
        Label50.Text = dt.Rows[0]["type"].ToString();
        Label46.Text = dt.Rows[0]["filer_name"].ToString();
        Label51.Text = dt.Rows[0]["vic"].ToString();
        Label52.Text = dt.Rows[0]["fh_name"].ToString();
        Label53.Text = dt.Rows[0]["age"].ToString();
        Label54.Text = dt.Rows[0]["gender"].ToString();
        Label55.Text = dt.Rows[0]["subtype"].ToString();
        Label56.Text = dt.Rows[0]["m_place"].ToString();
        Label57.Text = dt.Rows[0]["m_date"].ToString();
        Label65.Text = dt.Rows[0]["descp"].ToString();
        Label66.Text = dt.Rows[0]["u_file"].ToString();
        //Label66.Text = dt.Rows[0]["u_file"].ToString();
        string caa = dt.Rows[0]["a_known"].ToString();
        if (caa == "Person Known")
        {
            Label69.Text = dt.Rows[0]["a_name"].ToString();
            Label70.Text = dt.Rows[0]["rel"].ToString();
        }
        else
        {
            Panel10.Visible = true;
            Panel11.Visible = false;
            Label67.Text = caa;
        }

    }

    public void cat6()
    {
        Panel4.Visible = true;

        //Panel10.Visible = true;
        Panel11.Visible = true;
        Panel5.Visible = true;
        Panel1.Visible = true;
        //Panel2.Visible = true;

        Panel14.Visible = true;
        Panel13.Visible = true;
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select * from firinfo where fir_no=" + fno;
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        Label43.Text = dt.Rows[0]["station"].ToString();
        Label44.Text = dt.Rows[0]["zone"].ToString();
        Label45.Text = dt.Rows[0]["city"].ToString();
        Label68.Text = dt.Rows[0]["date"].ToString();
        Label50.Text = dt.Rows[0]["type"].ToString();
        Label46.Text = dt.Rows[0]["filer_name"].ToString();
        Label51.Text = dt.Rows[0]["vic"].ToString();
        Label52.Text = dt.Rows[0]["fh_name"].ToString();
        Label53.Text = dt.Rows[0]["age"].ToString();
        Label54.Text = dt.Rows[0]["gender"].ToString();
        //Label55.Text = dt.Rows[0]["subtype"].ToString();
        Label58.Text = dt.Rows[0]["i_place"].ToString();
        Label59.Text = dt.Rows[0]["i_date"].ToString();
        Label65.Text = dt.Rows[0]["descp"].ToString();
        Label66.Text = dt.Rows[0]["u_file"].ToString();
        //Label66.Text = dt.Rows[0]["u_file"].ToString();
        string caa = dt.Rows[0]["a_known"].ToString();
        if (caa == "Person Known")
        {
            Label69.Text = dt.Rows[0]["a_name"].ToString();
            Label70.Text = dt.Rows[0]["rel"].ToString();
        }
        else
        {
            Panel10.Visible = true;
            Panel11.Visible = false;
            Label67.Text = caa;
        }

    }

    public void cat7()
    {
        //Panel4.Visible = true;

        Panel8.Visible = true;
        //Panel11.Visible = true;
        Panel5.Visible = true;
        //Panel1.Visible = true;
        Panel7.Visible = true;

        Panel14.Visible = true;
        Panel13.Visible = true;
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select * from firinfo where fir_no=" + fno;
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        Label43.Text = dt.Rows[0]["station"].ToString();
        Label44.Text = dt.Rows[0]["zone"].ToString();
        Label45.Text = dt.Rows[0]["city"].ToString();
        Label68.Text = dt.Rows[0]["date"].ToString();
        Label50.Text = dt.Rows[0]["type"].ToString();
        Label46.Text = dt.Rows[0]["filer_name"].ToString();
        Label51.Text = dt.Rows[0]["vic"].ToString();
        Label52.Text = dt.Rows[0]["fh_name"].ToString();
        Label62.Text = dt.Rows[0]["color"].ToString();
        Label60.Text = dt.Rows[0]["brand"].ToString();
        Label61.Text = dt.Rows[0]["model"].ToString();
        Label58.Text = dt.Rows[0]["i_place"].ToString();
        Label59.Text = dt.Rows[0]["i_date"].ToString();
        Label65.Text = dt.Rows[0]["descp"].ToString();
        Label66.Text = dt.Rows[0]["u_file"].ToString();
        //Label66.Text = dt.Rows[0]["u_file"].ToString();
       Label63.Text = dt.Rows[0]["track"].ToString();
        //if (caa == "Person Known")
        //{
        //    Label69.Text = dt.Rows[0]["a_name"].ToString();
        //    Label70.Text = dt.Rows[0]["rel"].ToString();
        //}
        //else
        //{
        //    Panel10.Visible = true;
        //    Label67.Text = dt.Rows[0]["caa"].ToString();
        //}

    }

    public void cat8()
    {
        //Panel4.Visible = true;

        Panel9.Visible = true;
        //Panel11.Visible = true;
        Panel5.Visible = true;
        //Panel1.Visible = true;
        Panel7.Visible = true;

        Panel14.Visible = true;
        Panel13.Visible = true;
        string cnstr2 = @"Data Source=.\sqlexpress;AttachDbFilename=E:\projects\FIR\fir_sys\fir.mdf;Integrated Security=True";
        SqlConnection con2 = new SqlConnection(cnstr2);
        con2.Open();
        System.Data.DataTable dt = new System.Data.DataTable();
        string query2 = "select * from firinfo where fir_no=" + fno;
        SqlDataAdapter da2 = new SqlDataAdapter(query2, con2);
        SqlCommandBuilder cmd2 = new SqlCommandBuilder(da2);

        da2.Fill(dt);
        System.Data.DataSet ds2 = new System.Data.DataSet();
        Label43.Text = dt.Rows[0]["station"].ToString();
        Label44.Text = dt.Rows[0]["zone"].ToString();
        Label45.Text = dt.Rows[0]["city"].ToString();
        Label68.Text = dt.Rows[0]["date"].ToString();
        Label50.Text = dt.Rows[0]["type"].ToString();
        Label46.Text = dt.Rows[0]["filer_name"].ToString();
        Label51.Text = dt.Rows[0]["vic"].ToString();
        Label52.Text = dt.Rows[0]["fh_name"].ToString();
        Label62.Text = dt.Rows[0]["color"].ToString();
        Label60.Text = dt.Rows[0]["brand"].ToString();
        Label61.Text = dt.Rows[0]["model"].ToString();
        Label58.Text = dt.Rows[0]["i_place"].ToString();
        Label59.Text = dt.Rows[0]["i_date"].ToString();
        Label65.Text = dt.Rows[0]["descp"].ToString();
        Label66.Text = dt.Rows[0]["u_file"].ToString();
        //Label66.Text = dt.Rows[0]["u_file"].ToString();
        Label64.Text = dt.Rows[0]["plate"].ToString();
        //if (caa == "Person Known")
        //{
        //    Label69.Text = dt.Rows[0]["a_name"].ToString();
        //    Label70.Text = dt.Rows[0]["rel"].ToString();
        //}
        //else
        //{
        //    Panel10.Visible = true;
        //    Label67.Text = dt.Rows[0]["caa"].ToString();
        //}

    }
}