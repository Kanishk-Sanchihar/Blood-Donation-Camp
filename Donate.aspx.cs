using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Donate : System.Web.UI.Page
{
    blood b = new blood();
    string s;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        blood b = new blood();
        string s;
        s = "insert into donate values('" +DropDownList1.Text+ "','" +TextBox2.Text+ "','" + TextBox3.Text+ "')";
        b.command(s);

        
        TextBox2.Text = "";
        TextBox3.Text = "";
        
       
        TextBox2.Focus();
        Response.Redirect("donate.aspx");
    }
}