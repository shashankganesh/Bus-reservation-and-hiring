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
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class forgot : System.Web.UI.Page
{
    connect c;

    static int otp;
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = (string)Session["username"];
    }
    private AlternateView Mail_body()
    {
        Random rnd = new Random();
        otp = rnd.Next(1000, 9999);
        string path = Server.MapPath(@"buslogo.jpg");
        LinkedResource img = new LinkedResource(path, MediaTypeNames.Image.Jpeg);
        img.ContentId = "myimage";
        string str = @"<center><h1><img src=cid:myimage id='img' alt=''/><br/>E BUS TRAVELS</h1><br><br>Your OTP is <h1>" + otp + "</h1></center>";
        //string str = @"<div style=""fo"
        AlternateView AV = AlternateView.CreateAlternateViewFromString(str, null, MediaTypeNames.Text.Html);
        AV.LinkedResources.Add(img);
        return AV;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        c = new connect();
        c.cmd.CommandText = "select * from userdetail detail where username='" + (string)Session["username"] + "'";
        SqlDataReader sd = c.cmd.ExecuteReader();
        while (sd.Read())
        {
            string to = (string)sd["email"];
        }
        sd.Close();
       
        MailMessage msg= new MailMessage();
        msg.From = new MailAddress("aebus287@gmail.com");
        msg.To.Add(TextBox1.Text);
        msg.Subject = "E Bus Travellers";
        msg.AlternateViews.Add(Mail_body());
        msg.IsBodyHtml = true;
        SmtpClient smtp = new SmtpClient("smtp.gmail.com",587);
        smtp.EnableSsl = true;
        NetworkCredential netCre = new NetworkCredential("aebus287@gmail.com", "qwerty@123");
        smtp.Credentials = netCre;
        smtp.Send(msg);
        c.cnn.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int o = Convert.ToInt16(TextBox2.Text);
        if (o == otp)
            Response.Redirect("forgot2.aspx");
        else
            MessageBox.Show("Invalid OTP");

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
}
