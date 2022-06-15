using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Windows.Forms;


public partial class _Default : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp=new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("rigister1.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select * from userdetail where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["username"] = TextBox1.Text;

                Response.Redirect("home.aspx");
            }
            else
            {
                c.cmd.CommandText = "select * from admintable where username='" + TextBox1.Text + "' and password='" + TextBox2.Text + "'";
                ds = new DataSet();
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "use");
                if (ds.Tables["use"].Rows.Count > 0)
                {
                    Session["username"] = TextBox1.Text;

                    Response.Redirect("ahome.aspx");
                }
                MessageBox.Show("Invalid Username and Password");
            }
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
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select * from userdetail where username='" + TextBox1.Text + "'";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["username"] = TextBox1.Text;

                Response.Redirect("forgot.aspx");
            }
            else
            {
                c.cmd.CommandText = "select * from admintable where username='" + TextBox1.Text + "'";
                ds = new DataSet();
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "use");
                if (ds.Tables["use"].Rows.Count > 0)
                {
                    Session["username"] = TextBox1.Text;

                    Response.Redirect("forgot.aspx");
                }
                MessageBox.Show("User does not exist....");
            }
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
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
