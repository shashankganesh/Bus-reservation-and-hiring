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


public partial class removebus : System.Web.UI.Page
{
    connect c;
    DataSet ds,ds1;
    SqlDataAdapter adp = new SqlDataAdapter();
    SqlDataAdapter adp1 = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{
            c = new connect();
            c.cmd.CommandText = "select * from splbus";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "sp");
            if (ds.Tables["sp"].Rows.Count > 0)
            {
                GridView1.DataSource = ds.Tables["sp"];
                GridView1.DataBind();

            }
           
           
        //}
        //catch (Exception)
        //{
          //  throw;
        //}
        //finally
        //{
            c.cnn.Close();
        //}
    }
  
    protected void Button3_Click1(object sender, EventArgs e)
    {
        c = new connect();
        int i = Convert.ToInt16(TextBox1.Text);
        c.cmd.CommandText = "select * from splbus where bno=" + i;
        ds = new DataSet();
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "s");
        if (ds.Tables["s"].Rows.Count > 0)
        {
            c.cmd.CommandText = "delete from splbus where bno=" + i;
            c.cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
        }
        else
            MessageBox.Show("Enter proper Bus ID");
        c.cmd.CommandText = "select * from splbus";
        ds1 = new DataSet();
        adp1.SelectCommand = c.cmd;
        adp.Fill(ds1, "sp");
        if (ds1.Tables["sp"].Rows.Count > 0)
        {
            GridView1.DataSource = ds1.Tables["sp"];
            GridView1.DataBind();

        }
        c.cnn.Close();
    }
}
