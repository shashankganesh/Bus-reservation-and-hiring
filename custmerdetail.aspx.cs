using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class custmerdetail : System.Web.UI.Page
{

    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
        c = new connect();
        c.cmd.CommandText = "select * from userdetail";
        ds = new DataSet();
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "us");
        if (ds.Tables["us"].Rows.Count > 0)
        {
            GridView1.DataSource = ds.Tables["us"];
            GridView1.DataBind();

        }
        else
            MessageBox.Show("No Users");


        }
        catch (Exception)
        {
          throw;
        }
        finally
        {
        c.cnn.Close();
        }

    }
}
