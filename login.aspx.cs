using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    blood b = new blood();
    string s;

    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        s = "select * from login where bid=" + TextBox1.Text + " and bpass='" + TextBox2.Text + "'";
        DataSet ds1 = new DataSet();
        ds1 = b.select(s);
        if (ds1.Tables[0].Rows.Count != 0)
        {
            Response.Redirect("home_admin.aspx");
        }
        else
            s = "select * from organiser where oid=" + TextBox1.Text + " and opass=" + TextBox2.Text + "";
        DataSet ds = new DataSet();
        ds = b.select(s);
        if (ds.Tables[0].Rows.Count != 0)
        {
            Session["uid"] = TextBox1.Text;
            Response.Redirect("home_orga.aspx");
        }
        else
        {
            Response.Write("<script>alert('Invalid id and password')</script>");
        }
    }
}