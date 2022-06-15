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

public partial class rigister1 : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
            
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            c = new connect();
            c.cmd.CommandText = "select * from userdetail where email='" + cmail.Text + "'";
            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "sp");
            if (ds.Tables["sp"].Rows.Count > 0)
            {
                MessageBox.Show("This email is already in use");
            }
            else
            {
           if (cname.Text == "" && cadd.Text == "" && cmob.Text == "" && cmail.Text == "")
             MessageBox.Show("Enter all the fields ");
           else
            {
               
                c.cmd.CommandText = "select max(custno) from userdetail";
                int id = (int)c.cmd.ExecuteScalar();
                c.cmd.CommandText = "insert into userdetail values(@custno,@name,@mobile,@email,@addr,@username,@password,@offer,@wal)";
                c.cmd.Parameters.Clear();
                c.cmd.Parameters.Add("@custno", SqlDbType.Int).Value = id+1;
                c.cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = cname.Text;
                c.cmd.Parameters.Add("@mobile", SqlDbType.Decimal).Value = Convert.ToDecimal(cmob.Text);
                c.cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = cmail.Text;
                c.cmd.Parameters.Add("@addr", SqlDbType.NVarChar).Value = cadd.Text;
                c.cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = "";
                c.cmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = "";
                c.cmd.Parameters.Add("@offer", SqlDbType.NVarChar).Value = "";
                c.cmd.Parameters.Add("@wal", SqlDbType.Decimal).Value = 100;
                c.cmd.ExecuteNonQuery();
                Session["eml"] = cmail.Text;
                Response.Redirect("register2.aspx");
               

            }
               
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
}
