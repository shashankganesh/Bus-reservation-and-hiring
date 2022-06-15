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

public partial class userdetaildelete : System.Web.UI.Page
{
    //connect c;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       // c = new connect();
        //c.cmd.CommandText = "delete from cseat where bno=" + Convert.ToInt16( TextBox1.Text);
        //c.cmd.ExecuteNonQuery();
        Label1.Text = Convert.ToString(DateTime.Now);
    }
}
