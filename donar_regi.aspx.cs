using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class donar_regi : System.Web.UI.Page
{

    blood b = new blood();
    String s;
    protected void Page_Load(object sender, EventArgs e)
    {

        s = "select did from doner order by did desc";
        DataSet ds = new DataSet();
        ds = b.select(s);

        if (ds.Tables[0].Rows.Count == 0)

            Label1.Text = "1";


        else

            Label1.Text = Convert.ToString(Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1);
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        blood b = new blood();
        string s;
        s="insert into doner values("+Label1.Text+",'"+TextBox2.Text+"','"+DropDownList1.Text+"','"+TextBox3.Text+"')";

        b.command(s);

        TextBox2.Text = "";
        TextBox3.Text = "";
        Label2.Text = "Record Inserted Succesfully";
        TextBox2.Focus();
        Response.Redirect ("donar_regi.aspx");

    }
}