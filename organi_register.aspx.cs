using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class organi_register : System.Web.UI.Page
{ 
    blood b=new blood();
    String s;


    protected void Page_Load(object sender, EventArgs e)
    {
       
        
        s = "select oid from organiser order by oid desc";
        DataSet ds = new DataSet();
        ds = b.select(s);

        if (ds.Tables[0].Rows.Count == 0)
        {
            Label2.Text = "101";
        }

        else
        {
            Label2.Text = Convert.ToString(Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString()) + 1);
        }
        Label1.Text = DateTime.Now.ToShortDateString();
        
        
        

        

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        blood b = new blood();
        string s;
        s="insert into organiser values("+Label2.Text+",'"+TextBox7.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"','"+Label1.Text+"','"+TextBox5.Text+"','"+TextBox6.Text+"')";

        b.command(s);

        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox7.Focus();
        Label3.Text = "Record Inserted Successfully";
        

    }
}