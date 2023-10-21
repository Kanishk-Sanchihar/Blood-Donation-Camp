using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class total : System.Web.UI.Page
{
    blood b = new blood();
    string s;
    protected void Page_Load(object sender, EventArgs e)
    {
        blood b = new blood();
        string s;
        s = "select * from total ";
        DataSet ds = new DataSet();
        ds = b.select(s);

        GridView1.DataSource = ds.Tables[0];
        GridView1.DataBind();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}