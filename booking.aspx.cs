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
public partial class booking : System.Web.UI.Page
{
    connect c;
    DataSet ds,ds1;
    SqlDataAdapter adp = new SqlDataAdapter();
    SqlDataAdapter adp1 = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            string u = (string)Session["username"];
            c.cmd.CommandText = "select id,pickup,dest,dt1,dt2,t1,t2,seat,amt from splbking1 where username='"+u+"'";
          
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "sp");
            if (ds.Tables["sp"].Rows.Count > 0)
            {
                GridView2.DataSource = ds.Tables["sp"];
                GridView2.DataBind();

            }
            else
                Label2.Visible=true;
            
            c.cmd.CommandText = "select rout1,tseat,amt,dat from seatbking where username='" + u + "'";

            ds1 = new DataSet();
            adp1.SelectCommand = c.cmd;
            adp1.Fill(ds1, "sp");
            if (ds1.Tables["sp"].Rows.Count > 0)
            {
                GridView1.DataSource = ds1.Tables["sp"];
                GridView1.DataBind();

            }
            else
                Label1.Visible = true;
            
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

    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {

    }
    protected void ImageButton6_Click1(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("home.aspx");
    }
    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
       
    }
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("myaccount.aspx");
    }
    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("help.aspx");
    }
}
