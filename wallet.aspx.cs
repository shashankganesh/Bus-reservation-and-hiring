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

public partial class wallet : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        decimal w = 0;
        c.cmd.CommandText = "select * from userdetail where username='" + (string)Session["username"] + "'";
        SqlDataReader sd = c.cmd.ExecuteReader();
        while (sd.Read())
        {
            w = (decimal)sd["wal"];
        }
        sd.Close();
        Label1.Text = w.ToString();
        c.cnn.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (TextBox5.Text != "")
        {
            c = new connect();
            decimal w=0, a=0,t;
            t = Convert.ToDecimal(TextBox5.Text);
            c.cmd.CommandText = "select * from debitcard where cno=" + Convert.ToDecimal(TextBox1.Text) + " and name='" + TextBox2.Text + "' and exdate='" + TextBox3.Text + "' and cvv=" + Convert.ToInt16(TextBox4.Text);
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "sp");
            if (ds.Tables["sp"].Rows.Count > 0)
            {
                c.cmd.CommandText = "select * from debitcard where cno=" + Convert.ToDecimal(TextBox1.Text);
                SqlDataReader sdr = c.cmd.ExecuteReader();
                while (sdr.Read())
                {
                    a = (decimal)sdr["amt"];
                }
                sdr.Close();
                if (t < a)
                {
                    c.cmd.CommandText = "select * from userdetail where username='" + (string)Session["username"] + "'";
                    SqlDataReader sd = c.cmd.ExecuteReader();
                    while (sd.Read())
                    {
                        w = (decimal)sd["wal"];
                    }
                    sd.Close();
                    w = w + t;
                    a = a - t;
                    c.cmd.CommandText = "update userdetail set wal=" + w + " where username='" + (string)Session["username"] + "'";
                    c.cmd.ExecuteNonQuery();
                    c.cmd.CommandText = "update debitcard set amt=" + a + " where cno=" + Convert.ToDecimal(TextBox1.Text);
                    c.cmd.ExecuteNonQuery();
                    Label1.Text = w.ToString();
                    MessageBox.Show("Succsessfully Recharged");
                    Panel1.Visible = false;
                }
                else
                    MessageBox.Show("not enough balance");
            }
            else
                MessageBox.Show("Invalid card");
        }
        else
            MessageBox.Show("Enter amount properly");
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Panel1.Visible = true;
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
        Response.Redirect("myaccount.aspx");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("help.aspx");
    }
}
