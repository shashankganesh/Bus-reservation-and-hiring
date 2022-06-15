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

public partial class register2 : System.Web.UI.Page
{
    connect c;
    protected void Page_Load(object sender, EventArgs e)
    {
        cname.Text = (string)Session["eml"];
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        c = new connect();
        
        c.cmd.CommandText = "update userdetail set username='" + cname.Text + "', password='" + cadd.Text+"' where email='"+cname.Text+"'";
        c.cmd.ExecuteNonQuery();
        Session["username"] = cname.Text;

        Response.Redirect("home.aspx");
    }
}
