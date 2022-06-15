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

public partial class book1 : System.Web.UI.Page
{
   static int k=0;
    connect c;
    protected void Page_Load(object sender, EventArgs e)
    {
        c = new connect();
        string s = (string)Session["r"],i=(string)Session["t"];
        string[] a =new string[30];
        if (i == "am")
        {
            c.cmd.CommandText = "select * from bseat where rout='" + s + "'";
            SqlDataReader sd = c.cmd.ExecuteReader();
            while (sd.Read())
            {
                for (int j = 0; j < 30; j++)
                {
                    a[j] = sd[j + 2].ToString();
                }
            }

            sd.Close();
            if (a[0] == "r")
                ImageButton1.ImageUrl = "seat1.jpg";
            if (a[1] == "r")
                ImageButton2.ImageUrl = "seat1.jpg";
            if (a[2] == "r")
                ImageButton3.ImageUrl = "seat1.jpg";
            if (a[3] == "r")
                ImageButton4.ImageUrl = "seat1.jpg";
            if (a[4] == "r")
                ImageButton5.ImageUrl = "seat1.jpg";
            if (a[5] == "r")
                ImageButton6.ImageUrl = "seat1.jpg";
            if (a[6] == "r")
                ImageButton7.ImageUrl = "seat1.jpg";
            if (a[7] == "r")
                ImageButton8.ImageUrl = "seat1.jpg";
            if (a[8] == "r")
                ImageButton9.ImageUrl = "seat1.jpg";
            if (a[9] == "r")
                ImageButton10.ImageUrl = "seat1.jpg";
            if (a[10] == "r")
                ImageButton11.ImageUrl = "seat1.jpg";
            if (a[11] == "r")
                ImageButton12.ImageUrl = "seat1.jpg";
            if (a[12] == "r")
                ImageButton13.ImageUrl = "seat1.jpg";
            if (a[13] == "r")
                ImageButton14.ImageUrl = "seat1.jpg";
            if (a[14] == "r")
                ImageButton15.ImageUrl = "seat1.jpg";
            if (a[15] == "r")
                ImageButton16.ImageUrl = "seat1.jpg";
            if (a[16] == "r")
                ImageButton17.ImageUrl = "seat1.jpg";
            if (a[17] == "r")
                ImageButton18.ImageUrl = "seat1.jpg";
            if (a[18] == "r")
                ImageButton19.ImageUrl = "seat1.jpg";
            if (a[19] == "r")
                ImageButton20.ImageUrl = "seat1.jpg";
            if (a[20] == "r")
                ImageButton21.ImageUrl = "seat1.jpg";
            if (a[21] == "r")
                ImageButton22.ImageUrl = "seat1.jpg";
            if (a[22] == "r")
                ImageButton23.ImageUrl = "seat1.jpg";
            if (a[23] == "r")
                ImageButton24.ImageUrl = "seat1.jpg";
            if (a[24] == "r")
                ImageButton25.ImageUrl = "seat1.jpg";
            if (a[25] == "r")
                ImageButton26.ImageUrl = "seat1.jpg";
            if (a[26] == "r")
                ImageButton27.ImageUrl = "seat1.jpg";
            if (a[27] == "r")
                ImageButton28.ImageUrl = "seat1.jpg";
            if (a[28] == "r")
                ImageButton29.ImageUrl = "seat1.jpg";
            if (a[29] == "r")
                ImageButton30.ImageUrl = "seat1.jpg";

        }
        else
        {
            c.cmd.CommandText = "select * from cseat where rout='" + s + "'";
            SqlDataReader sd = c.cmd.ExecuteReader();
            while (sd.Read())
            {
                for (int j = 0; j < 30; j++)
                {
                    a[j] = sd[j + 2].ToString();
                }
            }

            sd.Close();
            if (a[0] == "r")
                ImageButton1.ImageUrl = "seat1.jpg";
            if (a[1] == "r")
                ImageButton2.ImageUrl = "seat1.jpg";
            if (a[2] == "r")
                ImageButton3.ImageUrl = "seat1.jpg";
            if (a[3] == "r")
                ImageButton4.ImageUrl = "seat1.jpg";
            if (a[4] == "r")
                ImageButton5.ImageUrl = "seat1.jpg";
            if (a[5] == "r")
                ImageButton6.ImageUrl = "seat1.jpg";
            if (a[6] == "r")
                ImageButton7.ImageUrl = "seat1.jpg";
            if (a[7] == "r")
                ImageButton8.ImageUrl = "seat1.jpg";
            if (a[8] == "r")
                ImageButton9.ImageUrl = "seat1.jpg";
            if (a[9] == "r")
                ImageButton10.ImageUrl = "seat1.jpg";
            if (a[10] == "r")
                ImageButton11.ImageUrl = "seat1.jpg";
            if (a[11] == "r")
                ImageButton12.ImageUrl = "seat1.jpg";
            if (a[12] == "r")
                ImageButton13.ImageUrl = "seat1.jpg";
            if (a[13] == "r")
                ImageButton14.ImageUrl = "seat1.jpg";
            if (a[14] == "r")
                ImageButton15.ImageUrl = "seat1.jpg";
            if (a[15] == "r")
                ImageButton16.ImageUrl = "seat1.jpg";
            if (a[16] == "r")
                ImageButton17.ImageUrl = "seat1.jpg";
            if (a[17] == "r")
                ImageButton18.ImageUrl = "seat1.jpg";
            if (a[18] == "r")
                ImageButton19.ImageUrl = "seat1.jpg";
            if (a[19] == "r")
                ImageButton20.ImageUrl = "seat1.jpg";
            if (a[20] == "r")
                ImageButton21.ImageUrl = "seat1.jpg";
            if (a[21] == "r")
                ImageButton22.ImageUrl = "seat1.jpg";
            if (a[22] == "r")
                ImageButton23.ImageUrl = "seat1.jpg";
            if (a[23] == "r")
                ImageButton24.ImageUrl = "seat1.jpg";
            if (a[24] == "r")
                ImageButton25.ImageUrl = "seat1.jpg";
            if (a[25] == "r")
                ImageButton26.ImageUrl = "seat1.jpg";
            if (a[26] == "r")
                ImageButton27.ImageUrl = "seat1.jpg";
            if (a[27] == "r")
                ImageButton28.ImageUrl = "seat1.jpg";
            if (a[28] == "r")
                ImageButton29.ImageUrl = "seat1.jpg";
            if (a[29] == "r")
                ImageButton30.ImageUrl = "seat1.jpg";

        }

        c.cnn.Close();
    }
    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        c = new connect();
        string se = (string)Session["r"];
        if (ImageButton1.ImageUrl != "seat1.jpg")
        {
            if (ImageButton1.ImageUrl == "seat3.jpg")
            {
               
                ImageButton1.ImageUrl = "seat2.jpg";
                --k;             
            }
            else
            {
                if (k < 3)
                {
                  
                    ImageButton1.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");

            }
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton2.ImageUrl != "seat1.jpg")
        {
            if (ImageButton2.ImageUrl == "seat3.jpg")
            {
                    ImageButton2.ImageUrl = "seat2.jpg";
                    --k;      
            }
            else
            {
                if (k < 3)
                {
                    ImageButton2.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                     MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton3.ImageUrl != "seat1.jpg")
        {
            if (ImageButton3.ImageUrl == "seat3.jpg")
            {
                ImageButton3.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton3.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    } 
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton4.ImageUrl != "seat1.jpg")
        {
            if (ImageButton4.ImageUrl == "seat3.jpg")
            {
                ImageButton4.ImageUrl = "seat2.jpg";
                --k;

            }
            else
            {
                if (k < 3)
                {
                    ImageButton4.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton5.ImageUrl != "seat1.jpg")
        {
            if (ImageButton5.ImageUrl == "seat3.jpg")
            {
                ImageButton5.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton5.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton6.ImageUrl != "seat1.jpg")
        {
            if (ImageButton6.ImageUrl == "seat3.jpg")
            {
                ImageButton6.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton6.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton7.ImageUrl != "seat1.jpg")
        {
            if (ImageButton7.ImageUrl == "seat3.jpg")
            {
                ImageButton7.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton7.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton8.ImageUrl != "seat1.jpg")
        {
            if (ImageButton8.ImageUrl == "seat3.jpg")
            {
                ImageButton8.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton8.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton9.ImageUrl != "seat1.jpg")
        {
            if (ImageButton9.ImageUrl == "seat3.jpg")
            {
                ImageButton9.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton9.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton10_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton10.ImageUrl != "seat1.jpg")
        {
            if (ImageButton10.ImageUrl == "seat3.jpg")
            {
                ImageButton10.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton10.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }

        }
    }
    protected void ImageButton11_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton11.ImageUrl != "seat1.jpg")
        {
            if (ImageButton11.ImageUrl == "seat3.jpg")
            {
                ImageButton11.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton11.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton12_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton12.ImageUrl != "seat1.jpg")
        {
            if (ImageButton12.ImageUrl == "seat3.jpg")
            {
                ImageButton12.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if(k<3)
                {

                ImageButton12.ImageUrl = "seat3.jpg";
                ++k;
            }
            else
            MessageBox.Show("You cant select more than 3 seats");
        }
        }
    }
    protected void ImageButton13_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton13.ImageUrl != "seat1.jpg")
        {
            if (ImageButton13.ImageUrl == "seat3.jpg")
            {
                ImageButton13.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton13.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton14_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton14.ImageUrl != "seat1.jpg")
        {
            if (ImageButton14.ImageUrl == "seat3.jpg")
            {
                ImageButton14.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {

                    ImageButton14.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton15_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton15.ImageUrl != "seat1.jpg")
        {
            if (ImageButton15.ImageUrl == "seat3.jpg")
            {
                ImageButton15.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton15.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton16_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton16.ImageUrl != "seat1.jpg")
        {
            if (ImageButton16.ImageUrl == "seat3.jpg")
            {
                ImageButton16.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton16.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats"); ;
            }
        }
    }
    protected void ImageButton17_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton17.ImageUrl != "seat1.jpg")
        {
            if (ImageButton17.ImageUrl == "seat3.jpg")
            {
                ImageButton17.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton17.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton18_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton18.ImageUrl != "seat1.jpg")
        {
            if (ImageButton18.ImageUrl == "seat3.jpg")
            {
                ImageButton18.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton18.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton19_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton19.ImageUrl != "seat1.jpg")
        {
            if (ImageButton19.ImageUrl == "seat3.jpg")
            {
                ImageButton19.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton19.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton20_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton20.ImageUrl != "seat1.jpg")
        {
            if (ImageButton20.ImageUrl == "seat3.jpg")
            {
                ImageButton20.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton20.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton21_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton21.ImageUrl != "seat1.jpg")
        {
            if (ImageButton21.ImageUrl == "seat3.jpg")
            {
                ImageButton21.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton21.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton22_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton12.ImageUrl != "seat1.jpg")
        {
            if (ImageButton22.ImageUrl == "seat3.jpg")
            {
                ImageButton22.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton22.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton23_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton23.ImageUrl != "seat1.jpg")
        {
            if (ImageButton23.ImageUrl == "seat3.jpg")
            {
                ImageButton23.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton23.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton24_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton24.ImageUrl != "seat1.jpg")
        {
            if (ImageButton24.ImageUrl == "seat3.jpg")
            {
                ImageButton24.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton24.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton25_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton25.ImageUrl != "seat1.jpg")
        {
            if (ImageButton25.ImageUrl == "seat3.jpg")
            {
                ImageButton25.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if(k<3)
                {
                ImageButton25.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton26_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton26.ImageUrl != "seat1.jpg")
        {
            if (ImageButton26.ImageUrl == "seat3.jpg")
            {
                ImageButton26.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if(k<3)
                {
                ImageButton26.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton27_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton17.ImageUrl != "seat1.jpg")
        {
            if (ImageButton27.ImageUrl == "seat3.jpg")
            {
                ImageButton27.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton27.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton28_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton28.ImageUrl != "seat1.jpg")
        {
            if (ImageButton28.ImageUrl == "seat3.jpg")
            {
                ImageButton28.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton28.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton29_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton29.ImageUrl != "seat1.jpg")
        {
            if (ImageButton29.ImageUrl == "seat3.jpg")
            {
                ImageButton29.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if (k < 3)
                {
                    ImageButton29.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                    MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void ImageButton30_Click(object sender, ImageClickEventArgs e)
    {
        if (ImageButton30.ImageUrl != "seat1.jpg")
        {
            if (ImageButton30.ImageUrl == "seat3.jpg")
            {
                ImageButton30.ImageUrl = "seat2.jpg";
                --k;
            }
            else
            {
                if(k<3)
                {
                ImageButton30.ImageUrl = "seat3.jpg";
                    ++k;
                }
                else
                MessageBox.Show("You cant select more than 3 seats");
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
            if (ImageButton1.ImageUrl == "seat3.jpg")
                Session["s1"] = "r";
            if (ImageButton2.ImageUrl == "seat3.jpg")
                Session["s2"] = "r";
            if (ImageButton3.ImageUrl == "seat3.jpg")
                Session["s3"] = "r";
            if (ImageButton4.ImageUrl == "seat3.jpg")
                Session["s4"] = "r";
            if (ImageButton5.ImageUrl == "seat3.jpg")
                Session["s5"] = "r";
            if (ImageButton6.ImageUrl == "seat3.jpg")
                Session["s6"] = "r";
            if (ImageButton7.ImageUrl == "seat3.jpg")
                Session["s7"] = "r";
            if (ImageButton8.ImageUrl == "seat3.jpg")
                Session["s8"] = "r";
            if (ImageButton9.ImageUrl == "seat3.jpg")
                Session["s9"] = "r";
            if (ImageButton10.ImageUrl == "seat3.jpg")
                Session["s10"] = "r";
            if (ImageButton11.ImageUrl == "seat3.jpg")
                Session["s11"] = "r";
            if (ImageButton12.ImageUrl == "seat3.jpg")
                Session["s12"] = "r";
            if (ImageButton13.ImageUrl == "seat3.jpg")
                Session["s13"] = "r";
            if (ImageButton14.ImageUrl == "seat3.jpg")
                Session["s14"] = "r";
            if (ImageButton15.ImageUrl == "seat3.jpg")
                Session["s15"] = "r";
            if (ImageButton16.ImageUrl == "seat3.jpg")
                Session["s16"] = "r";
            if (ImageButton17.ImageUrl == "seat3.jpg")
                Session["s17"] = "r";
            if (ImageButton18.ImageUrl == "seat3.jpg")
                Session["s18"] = "r";
            if (ImageButton19.ImageUrl == "seat3.jpg")
                Session["s19"] = "r";
            if (ImageButton20.ImageUrl == "seat3.jpg")
                Session["s20"] = "r";
            if (ImageButton21.ImageUrl == "seat3.jpg")
                Session["s21"] = "r";
            if (ImageButton22.ImageUrl == "seat3.jpg")
                Session["s22"] = "r";
            if (ImageButton23.ImageUrl == "seat3.jpg")
                Session["s23"] = "r";
            if (ImageButton24.ImageUrl == "seat3.jpg")
                Session["s24"] = "r";
            if (ImageButton25.ImageUrl == "seat3.jpg")
                Session["s25"] = "r";
            if (ImageButton26.ImageUrl == "seat3.jpg")
                Session["s26"] = "r";
            if (ImageButton27.ImageUrl == "seat3.jpg")
                Session["s27"] = "r";
            if (ImageButton28.ImageUrl == "seat3.jpg")
                Session["s28"] = "r";
            if (ImageButton29.ImageUrl == "seat3.jpg")
                Session["s29"] = "r";
            if (ImageButton30.ImageUrl == "seat3.jpg")
                Session["s30"] = "r";
        Session["n"] = k;
        k = 0;
        Response.Redirect("book2.aspx");
        DateTime dt = DateTime.Now;
        DateTime dt1 = dt.AddDays(1);
        Session["dt"] = dt1.ToShortDateString();
       
    }
    protected void ImageButton31_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("home.aspx");
    }

    protected void ImageButton32_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("booking.aspx");
    }
    protected void ImageButton34_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("myaccount.aspx");
    }
    protected void ImageButton33_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("help.aspx");
    }
}
