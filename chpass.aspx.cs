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

public partial class chpass : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = (string)Session["username"];
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox3.Text == "" && TextBox4.Text == ""&&TextBox2.Text=="")
            MessageBox.Show("Enter all feilds");
        else
        {
            c = new connect();
            c.cmd.CommandText = "select * from userdetail where username='" + (string)Session["username"] + "' and password='" + TextBox2.Text + "'";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "sp");
            if (ds.Tables["sp"].Rows.Count > 0)
            {
                c.cmd.CommandText = "update userdetail set password='" + TextBox3.Text + "' where username='" + TextBox1.Text + "'";
                c.cmd.ExecuteNonQuery();
                MessageBox.Show("Password changed");
                Response.Redirect("myaccount.aspx");
            }
            else
                MessageBox.Show("INCORRECT PASSWORD");
            c.cnn.Close();
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("forgot.aspx");
    }
}
