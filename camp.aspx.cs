using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class camp : System.Web.UI.Page
{
    blood b = new blood();
    string s;
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = DateTime.Now.ToShortDateString();
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        blood b = new blood();
        string s;
        s = "insert into camp values('" + TextBox1.Text + "','" + Label1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
        b.command(s);

        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
       // Label3.Text = "Record Inserted Succesfully";
        TextBox1.Focus();
        Response.Redirect("camp.aspx");
    }
}