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

public partial class myaccount : System.Web.UI.Page
{
    connect c;
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        c.cmd.CommandText = "select * from userdetail where username='" + (string)Session["username"] + "'";
        SqlDataReader sd = c.cmd.ExecuteReader();
        while (sd.Read())
        {
            decimal d = (decimal)sd["mobile"];
            Label2.Text = (string)sd["name"];
            Label3.Text = (string)sd["username"];
            Label4.Text = d.ToString();
            Label1.Text = (string)sd["addr"];

        }
        sd.Close();
        c.cnn.Close();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("wallet.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("chpass.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("home.aspx");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("booking.aspx");
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("myaccount");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("help.aspx");
    }
}
