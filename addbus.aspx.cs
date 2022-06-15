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

public partial class addbus : System.Web.UI.Page
{
    connect c;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string s = "", a = "";
        int se = 0;
        try
        {
            if (sl.Checked == true)
            {
                s = "sleeper";
            }
            else
            {
                s = "non";
            }
            if (ac.Checked == true)
            {
                a = "ac";
            }
            else
            {
                a = "non";
            }
            if (s40.Checked == true)
            {
                se = 40;
            }
            else
            {
                se = 20;
            }
                c = new connect();
                c.cmd.CommandText = "select max(bno) from splbus";
                int id = (int)c.cmd.ExecuteScalar();
                c.cmd.CommandText = "insert into splbus values(@bno,@type1,@type2,@seat,'n',@dat)";
                c.cmd.Parameters.Clear();
                c.cmd.Parameters.Add("@bno", SqlDbType.Int).Value = id + 1;
                c.cmd.Parameters.Add("@type1", SqlDbType.NVarChar).Value = a;
                c.cmd.Parameters.Add("@type2", SqlDbType.NVarChar).Value = s;
                c.cmd.Parameters.Add("@seat", SqlDbType.Int).Value = se;
                //c.cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = "n";
                c.cmd.Parameters.Add("@dat", SqlDbType.DateTime).Value = "1-1-2100";
                
                c.cmd.ExecuteNonQuery();
               

           

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
