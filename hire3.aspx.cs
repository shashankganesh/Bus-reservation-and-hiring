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

public partial class hire3 : System.Web.UI.Page
{
    connect c=new connect();
    int t,i;
    string u;
    protected void Page_Load(object sender, EventArgs e)
    {
        //try
        //{
           u=(string)Session["username"];
            string email = "", na = "";
            decimal mob = 0;
            int s, d, k, ss, sp, kk;
            c.cmd.CommandText = "select * from userdetail where username='" + u + "'";
            SqlDataReader sdr = c.cmd.ExecuteReader();
            while (sdr.Read())
            {
                mob = (decimal)sdr["mobile"];
                email = (string)sdr["email"];
                na = (string)sdr["name"];
            }
            sdr.Close();
           
            i = (int)Session["id"];
            ss = (int)Session["s"];
            sp = (int)Session["seatp"];
            s = (int)Session["seatp"];
            d = (int)Session["drive"];
            k = (int)Session["price"];
            kk = (int)Session["km"];
            Label1.Text = na;
            mb.Text = mob.ToString(); ;
            em.Text = email;
            Label10.Text = i.ToString();

            plocation.Text = (string)Session["pic"];
            dlocation.Text = (string)Session["des"];
            Label2.Text = (string)Session["when"];
            Label3.Text = (string)Session["till"];
            Label7.Text = (string)Session["type1"];
            Label5.Text = (string)Session["type2"];
            Label6.Text = ss.ToString();
            Label9.Text = sp.ToString();
            Label4.Text = d.ToString();
            Label8.Text = k.ToString();
            Label11.Text = (string)Session["triptype"];
            Label13.Text = kk.ToString();

            t = s + d + k;
            Label12.Text = t.ToString();

            
        //}
        //catch(Exception)
        //{
        //    throw;
        //}
       // finally
       // {
            c.cnn.Close();

       // }



            
        }
    protected void Button1_Click(object sender, EventArgs e)
    {
        c = new connect();
        string u = (string)Session["username"];
        decimal w=0;
        //int id=0;
        c.cmd.CommandText = "select * from userdetail where username='" + u + "'";
        SqlDataReader sdr = c.cmd.ExecuteReader();
        while (sdr.Read())
        {
             w = (decimal)sdr["wal"];
        }
        sdr.Close();
        if (w > t)
        {
            w = w - t;
            c.cmd.CommandText = "update userdetail set wal=" + w + "where username='" + u + "'";
            c.cmd.ExecuteNonQuery();
            /*c.cmd.CommandText = "select * from splbus where status='n' and type1='" + Label5.Text + "' and type2='" + Label7.Text + "' and seat=" + Convert.ToInt16(Session["s"]);
            SqlDataReader sd = c.cmd.ExecuteReader();
            while (sd.Read())
            {
                id = (int)sd["bno"];

            }
            sd.Close*/
            MessageBox.Show("Amount of " + t + "has been debited to your wallet available balance is " + w);
            c.cmd.CommandText = "insert into splbking1 values(@username,@id,@pickup,@dest,@dt1,@dt2,@t1,@t2,@seat,@amt)";
            c.cmd.Parameters.Clear();
            c.cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = u;
            c.cmd.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt16(Label10.Text);
            c.cmd.Parameters.Add("@pickup", SqlDbType.NVarChar).Value = Session["pic"];
            c.cmd.Parameters.Add("@dest", SqlDbType.NVarChar).Value = Session["des"];
            c.cmd.Parameters.Add("@dt1", SqlDbType.DateTime).Value = Convert.ToDateTime(Session["when"]);
            c.cmd.Parameters.Add("@dt2", SqlDbType.DateTime).Value = Convert.ToDateTime(Session["till"]);
            c.cmd.Parameters.Add("@t1", SqlDbType.NVarChar).Value = Session["type1"];
            c.cmd.Parameters.Add("@t2", SqlDbType.NVarChar).Value = Session["type2"];
            c.cmd.Parameters.Add("@seat", SqlDbType.Int).Value = Convert.ToInt16(Session["s"]);
            c.cmd.Parameters.Add("amt", SqlDbType.Int).Value = t;
            c.cmd.ExecuteNonQuery();
            c.cmd.CommandText = "update splbus set status=@sta,dat=@dat where bno=" + Convert.ToInt16(Label10.Text);
            c.cmd.Parameters.Add("@dat", SqlDbType.DateTime).Value = Convert.ToDateTime(Session["till"]);
            c.cmd.Parameters.Add("@sta", SqlDbType.NVarChar).Value = "r";
            c.cmd.ExecuteNonQuery();
            c.cnn.Close();
            Response.Redirect("home.aspx");
        }
        else
            MessageBox.Show("Not enought balance in wallet");
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("home.aspx");
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("myaccount.aspx");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("mybooking.aspx");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("help.aspx");
    }
}

