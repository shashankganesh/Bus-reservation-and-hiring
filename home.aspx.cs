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

public partial class home : System.Web.UI.Page
{
    connect c;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        c = new connect();
        c.cmd.CommandText = "update bseat set s1='n',s2='n',s3='n',s4='n',s5='n',s6='n',s7='n',s8='n',s9='n',s10='n',s11='n',s12='n',s13='n',s14='n',s15='n',s16='n',s17='n',s18='n',s19='n',s20='n',s21='n',s22='n',s23='n',s24='n',s25='n',s26='n',s27='n',s28='n',s29='n',s30='n' where dat < @dat";
        c.cmd.Parameters.Add("@dat", SqlDbType.DateTime).Value = DateTime.Now;
        c.cmd.ExecuteNonQuery();
        c.cmd.CommandText = "update cseat set s1='n',s2='n',s3='n',s4='n',s5='n',s6='n',s7='n',s8='n',s9='n',s10='n',s11='n',s12='n',s13='n',s14='n',s15='n',s16='n',s17='n',s18='n',s19='n',s20='n',s21='n',s22='n',s23='n',s24='n',s25='n',s26='n',s27='n',s28='n',s29='n',s30='n' where dat < @dat1";
        c.cmd.Parameters.Add("@dat1", SqlDbType.DateTime).Value = DateTime.Now;
        c.cmd.CommandText = "delete from seatbking where dat < @dat2";
        c.cmd.Parameters.Add("@dat2", SqlDbType.DateTime).Value = DateTime.Now;
        c.cmd.ExecuteNonQuery();
        c.cnn.Close();
        Response.Redirect("book.aspx");

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        c = new connect();
        c.cmd.CommandText = "update splbus set status='n' where dat < @dat";
        c.cmd.Parameters.Add("@dat", SqlDbType.DateTime).Value = DateTime.Now;
        c.cmd.ExecuteNonQuery();
        c.cmd.CommandText = "delete from splbking1 where dt2 < @dat1";
        c.cmd.Parameters.Add("@dat1", SqlDbType.DateTime).Value = DateTime.Now;
        c.cmd.ExecuteNonQuery();
        c.cnn.Close();
        Response.Redirect("hire1.aspx");
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("covid.aspx");
    }
    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("booking.aspx");
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("saftey.aspx");
    }
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("myaccount.aspx");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("wallet.aspx");
    }
    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("help.aspx");
    }
}
