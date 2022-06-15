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
using System.Windows.Forms;
using System.Data.SqlClient;

public partial class achpass : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        c = new connect();
        c.cmd.CommandText = "select * from admintable where username='aebus287@gmail.com' and password='" + TextBox1.Text + "'";
        ds = new DataSet();
        adp.SelectCommand = c.cmd;
        adp.Fill(ds, "sp");
        if (ds.Tables["sp"].Rows.Count > 0)
        {
            c.cmd.CommandText = "update admintable set password='" + TextBox2.Text  + "' where username='aebus287@gmail.com'";
            c.cmd.ExecuteNonQuery();
            MessageBox.Show("Password changed");
            Response.Redirect("ahome.aspx");
        }
        else
            MessageBox.Show("INCORRECT PASSWORD");
        c.cnn.Close();
    }
}
