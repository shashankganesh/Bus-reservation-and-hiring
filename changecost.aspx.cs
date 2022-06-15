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
public partial class changecost : System.Web.UI.Page
{
    connect c;
    protected void Button1_Click(object sender, EventArgs e)
    {
            if (Button1.Text == "Change")
            {
                Button1.Text = "Done";
                TextBox1.ReadOnly = false;
                TextBox1.Focus();
            }
            else
            {
                 if (TextBox1.Text == "")
                 {
                     MessageBox.Show("Enter properly");
                 }
                 else
                 {
                c = new connect();
                c.cmd.CommandText = "update pkcost set cost=" + Convert.ToDecimal(TextBox1.Text);
                c.cmd.ExecuteNonQuery();
                c.cnn.Close();
                Button1.Text = "Change";
                TextBox1.ReadOnly = true;
                }
            }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            c = new connect();
            decimal cost = 0;
            int s40 = 0, s20 = 0, a = 0, n = 0, d = 0;

            c.cmd.CommandText = "select * from pkcost";
            SqlDataReader sdr = c.cmd.ExecuteReader();
            while (sdr.Read())
            {
                cost = (decimal)sdr["cost"];

            }
            sdr.Close();
            TextBox1.Text = cost.ToString();
            c.cmd.CommandText = "select * from splcost";
            SqlDataReader sd = c.cmd.ExecuteReader();
            while (sd.Read())
            {
                s40 = (int)sd["s40"];
                s20 = (int)sd["s20"];
                a = (int)sd["ac"];
                n = (int)sd["nonac"];
                d = (int)sd["driver"];

            }
            sd.Close();
            TextBox2.Text = s40.ToString();
            TextBox3.Text = s20.ToString();
            TextBox4.Text = a.ToString();
            TextBox5.Text = n.ToString();
            TextBox6.Text = d.ToString();
            c.cnn.Close();
        }
    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
       
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Button2.Text == "Change")
        {
            Button2.Text = "Done";
            TextBox2.ReadOnly = false;
            TextBox2.Focus();
        }
        else
        {
            if (TextBox2.Text == "")
            {
                MessageBox.Show("Enter properly");
            }
            else
            {
                c = new connect();
                c.cmd.CommandText = "update splcost set s40=" + Convert.ToDecimal(TextBox2.Text);
                c.cmd.ExecuteNonQuery();
                c.cnn.Close();
                Button2.Text = "Change";
                TextBox2.ReadOnly = true;
            }
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (Button3.Text == "Change")
        {
            Button3.Text = "Done";
            TextBox3.ReadOnly = false;
            TextBox3.Focus();
        }
        else
        {
            if (TextBox3.Text == "")
            {
                MessageBox.Show("Enter properly");
            }
            else
            {
                c = new connect();
                c.cmd.CommandText = "update splcost set s20=" + Convert.ToDecimal(TextBox3.Text);
                c.cmd.ExecuteNonQuery();
                c.cnn.Close();
                Button3.Text = "Change";
                TextBox3.ReadOnly = true;
            }
        }
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        if (Button4.Text == "Change")
        {
            Button4.Text = "Done";
            TextBox4.ReadOnly = false;
            TextBox4.Focus();
        }
        else
        {
            if (TextBox4.Text == "")
            {
                MessageBox.Show("Enter properly");
            }
            else
            {
                c = new connect();
                c.cmd.CommandText = "update splcost set ac=" + Convert.ToDecimal(TextBox4.Text);
                c.cmd.ExecuteNonQuery();
                c.cnn.Close();
                Button4.Text = "Change";
                TextBox4.ReadOnly = true;
            }
        }
    }
    protected void  Button5_Click(object sender, EventArgs e)
{
if (Button5.Text == "Change")
        {
            Button5.Text = "Done";
            TextBox5.ReadOnly = false;
            TextBox5.Focus();
        }
        else
        {
            if (TextBox5.Text == "")
            {
                MessageBox.Show("Enter properly");
            }
            else
            {
                c = new connect();
                c.cmd.CommandText = "update splcost set nonac=" + Convert.ToDecimal(TextBox5.Text);
                c.cmd.ExecuteNonQuery();
                c.cnn.Close();
                Button5.Text = "Change";
                TextBox5.ReadOnly = true;
            }
        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        if (Button6.Text == "Change")
        {
            Button6.Text = "Done";
            TextBox6.ReadOnly = false;
            TextBox6.Focus();
        }
        else
        {
            if (TextBox6.Text == "")
            {
                MessageBox.Show("Enter properly");
            }
            else
            {
                c = new connect();
                c.cmd.CommandText = "update splcost set driver=" + Convert.ToDecimal(TextBox6.Text);
                c.cmd.ExecuteNonQuery();
                c.cnn.Close();
                Button6.Text = "Change";
                TextBox6.ReadOnly = true;
            }
        }
    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}




