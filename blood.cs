using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class blood
{
    SqlConnection con;
    SqlCommand cmd;
    SqlDataAdapter da;

	public blood()
	{
        con = new SqlConnection(@"Data Source=KEVIN\SQLEXPRESS;Initial Catalog=blood_donation;Integrated Security=True");
        con.Open();

	}
    public void command(String s)
    {
       cmd= new SqlCommand(s,con);
       cmd.ExecuteNonQuery();
    }
  public DataSet select(String s)
    {
      DataSet ds= new DataSet();
      da=new SqlDataAdapter(s,con);
      da.Fill(ds);
      return(ds);

    }
}