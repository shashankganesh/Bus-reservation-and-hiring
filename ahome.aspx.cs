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

public partial class ahome : System.Web.UI.Page
{
    connect c;
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        c.cmd.CommandText = "select count(*) from userdetail";
        int r = (int)c.cmd.ExecuteScalar();
        r++;
        Label1.Text = r.ToString();
    }
}
