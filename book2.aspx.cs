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

public partial class book2 : System.Web.UI.Page
{
    connect c;
    static decimal tot;
    protected void Page_Load(object sender, EventArgs e)
    {
        string n1 = "";
        int n2 = 0;
        c = new connect();
        c.cmd.CommandText = "select * from userdetail detail where username='" + (string)Session["username"] + "'";
        SqlDataReader sd = c.cmd.ExecuteReader();
        while (sd.Read())
        {
           n1 = (string)sd["name"];
        }
        sd.Close();
        DateTime dt = DateTime.Now;
        DateTime dt1 = dt.AddDays(1);
        Label1.Text = n1;
        Label2.Text = Convert.ToString(Session["rf"]);
        Label3.Text = Convert.ToString(Session["rt"]);
        Label4.Text = Convert.ToString(Session["n"]);
        Label5.Text = Convert.ToString(Session["time"]);
        Label6.Text = dt1.ToShortDateString();
        decimal a = Convert.ToDecimal(Session["at"]),n=Convert.ToDecimal(Session["n"]);
        tot = a * n;
        Label7.Text = tot.ToString();
        if ("am" == Convert.ToString(Session["t"]))
        {
            c.cmd.CommandText = "select * from bseat where rout='" + Convert.ToString(Session["r"]) + "'";
            SqlDataReader ss = c.cmd.ExecuteReader();
            while (ss.Read())
            {
                n2 = (int)ss["bno"];
            }
            ss.Close();
            Label8.Text = n2.ToString();
        }
        else
        {
            c.cmd.CommandText = "select * from cseat where rout='" + Convert.ToString(Session["r"]) + "'";
            SqlDataReader ss = c.cmd.ExecuteReader();
            while (ss.Read())
            {
                n2 = (int)ss["bno"];
            }
            ss.Close();
            Label8.Text = n2.ToString();
        }
        c.cnn.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        c = new connect();
        decimal w = 0, p;
        c.cmd.CommandText = "select * from userdetail detail where username='" + (string)Session["username"] + "'";
        p = Convert.ToDecimal(tot);
        SqlDataReader sd = c.cmd.ExecuteReader();
        while (sd.Read())
        {
            w = (decimal)sd["wal"];
        }
        sd.Close();
        if (w > p)
        {
            c.cmd.CommandText = "select max(no) from seatbking";
            int id = (int)c.cmd.ExecuteScalar();
            c.cmd.CommandText = "insert into seatbking(no,username,rout,amt,tseat,dat,bid,rout1) values (@no,@username,@rout,@amt,@tseat,@dat,@bid,@rout1)";
            c.cmd.Parameters.Clear();
            c.cmd.Parameters.Add("@no", SqlDbType.Int).Value = id + 1;
            c.cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = Convert.ToString(Session["username"]);
            c.cmd.Parameters.Add("@rout", SqlDbType.NVarChar).Value = Convert.ToString(Session["r"]);
            c.cmd.Parameters.Add("@amt", SqlDbType.Int).Value = Label7.Text;
            c.cmd.Parameters.Add("@tseat", SqlDbType.Int).Value = Convert.ToInt16(Session["n"]);
            c.cmd.Parameters.Add("@dat", SqlDbType.DateTime).Value = Convert.ToDateTime(Label6.Text);
            c.cmd.Parameters.Add("@bid", SqlDbType.Int).Value = Convert.ToInt16(Label8.Text);
            c.cmd.Parameters.Add("@rout1", SqlDbType.NVarChar).Value = Convert.ToString(Session["rf"]) + " To " + Convert.ToString(Session["rt"]);
            c.cmd.ExecuteNonQuery();
            int d = id + 1;
            if ("r" == Convert.ToString(Session["s1"]))
            {
                c.cmd.CommandText = "update seatbking set s1='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            }
            if ("r" == Convert.ToString(Session["s2"]))
            {
                c.cmd.CommandText = "update seatbking set s2='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            }
            if ("r" == Convert.ToString(Session["s3"]))
            {
                c.cmd.CommandText = "update seatbking set s3='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            }
            if ("r" == Convert.ToString(Session["s4"]))
            {
                c.cmd.CommandText = "update seatbking set s4='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s5"]))
            {
                c.cmd.CommandText = "update seatbking set s5='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s6"]))
            {
                c.cmd.CommandText = "update seatbking set s6='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s7"]))
            {
                c.cmd.CommandText = "update seatbking set s7='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s8"]))
            {

                c.cmd.CommandText = "update seatbking set s8='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s9"]))
            {
                c.cmd.CommandText = "update seatbking set s9='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s10"]))
            {
                c.cmd.CommandText = "update seatbking set s10='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s11"]))
            {
                c.cmd.CommandText = "update seatbking set s11='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s12"]))
            {
                c.cmd.CommandText = "update seatbking set s12='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s13"]))
            {
                c.cmd.CommandText = "update seatbking set s13='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s14"]))
            {
                c.cmd.CommandText = "update seatbking set s14='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s15"]))
            {
                c.cmd.CommandText = "update seatbking set s15='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s16"]))
            {
                c.cmd.CommandText = "update seatbking set s16='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s17"]))
            {
                c.cmd.CommandText = "update seatbking set s17='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s18"]))
            {
                c.cmd.CommandText = "update seatbking set s18='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s19"]))
            {
                c.cmd.CommandText = "update seatbking set s19='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s20"]))
            {
                c.cmd.CommandText = "update seatbking set s20='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s21"]))
            {
                c.cmd.CommandText = "update seatbking set s21='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s22"]))
            {
                c.cmd.CommandText = "update seatbking set s22='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s23"]))
            {
                c.cmd.CommandText = "update seatbking set s23='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s24"]))
            {
                c.cmd.CommandText = "update seatbking set s24='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s25"]))
            {
                c.cmd.CommandText = "update seatbking set s25='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s26"]))
            {
                c.cmd.CommandText = "update seatbking set s26='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s27"]))
            {
                c.cmd.CommandText = "update seatbking set s27='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s28"]))
            {
                c.cmd.CommandText = "update seatbking set s28='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s29"]))
            {
                c.cmd.CommandText = "update seatbking set s29='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            } if ("r" == Convert.ToString(Session["s30"]))
            {
                c.cmd.CommandText = "update seatbking set s30='r' where no=" + d;
                c.cmd.ExecuteNonQuery();
            }
            if ("am" == Convert.ToString(Session["t"]))
            {
                c.cmd.CommandText = "update bseat set dat=@dat where rout='" + Convert.ToString(Session["r"]) + "'";
                c.cmd.Parameters.Clear();
                c.cmd.Parameters.Add("@dat", SqlDbType.DateTime).Value = Convert.ToDateTime(Label6.Text);
                c.cmd.ExecuteNonQuery();
                if ("r" == Convert.ToString(Session["s1"]))
                {
                    c.cmd.CommandText = "update bseat set s1='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                }
                if ("r" == Convert.ToString(Session["s2"]))
                {
                    c.cmd.CommandText = "update bseat set s2='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                }
                if ("r" == Convert.ToString(Session["s3"]))
                {
                    c.cmd.CommandText = "update bseat set s3='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                }
                if ("r" == Convert.ToString(Session["s4"]))
                {
                    c.cmd.CommandText = "update bseat set s4='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s5"]))
                {
                    c.cmd.CommandText = "update bseat set s5='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s6"]))
                {
                    c.cmd.CommandText = "update bseat set s6='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s7"]))
                {
                    c.cmd.CommandText = "update bseat set s7='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s8"]))
                {

                    c.cmd.CommandText = "update bseat set s8='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s9"]))
                {
                    c.cmd.CommandText = "update bseat set s9='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s10"]))
                {
                    c.cmd.CommandText = "update bseat set s10='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s11"]))
                {
                    c.cmd.CommandText = "update bseat set s11='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s12"]))
                {
                    c.cmd.CommandText = "update bseat set s12='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s13"]))
                {
                    c.cmd.CommandText = "update bseat set s13='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s14"]))
                {
                    c.cmd.CommandText = "update bseat set s14='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s15"]))
                {
                    c.cmd.CommandText = "update bseat set s15='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s16"]))
                {
                    c.cmd.CommandText = "update bseat set s16='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s17"]))
                {
                    c.cmd.CommandText = "update bseat set s17='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s18"]))
                {
                    c.cmd.CommandText = "update bseat set s18='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s19"]))
                {
                    c.cmd.CommandText = "update bseat set s19='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s20"]))
                {
                    c.cmd.CommandText = "update bseat set s20='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s21"]))
                {
                    c.cmd.CommandText = "update bseat set s21='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s22"]))
                {
                    c.cmd.CommandText = "update bseat set s22='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s23"]))
                {
                    c.cmd.CommandText = "update bseat set s23='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s24"]))
                {
                    c.cmd.CommandText = "update bseat set s24='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s25"]))
                {
                    c.cmd.CommandText = "update bseat set s25='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s26"]))
                {
                    c.cmd.CommandText = "update bseat set s26='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s27"]))
                {
                    c.cmd.CommandText = "update bseat set s27='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s28"]))
                {
                    c.cmd.CommandText = "update bseat set s28='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s29"]))
                {
                    c.cmd.CommandText = "update bseat set s29='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s30"]))
                {
                    c.cmd.CommandText = "update bseat set s30='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                }
            }
            else
            {
                c.cmd.CommandText = "update cseat set dat=@dat where rout='" + Convert.ToString(Session["r"]) + "'";
                c.cmd.Parameters.Clear();
                c.cmd.Parameters.Add("@dat", SqlDbType.DateTime).Value = Convert.ToDateTime(Label6.Text);
                c.cmd.ExecuteNonQuery();
                if ("r" == Convert.ToString(Session["s1"]))
                {
                    c.cmd.CommandText = "update cseat set s1='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                }
                if ("r" == Convert.ToString(Session["s2"]))
                {
                    c.cmd.CommandText = "update cseat set s2='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                }
                if ("r" == Convert.ToString(Session["s3"]))
                {
                    c.cmd.CommandText = "update cseat set s3='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                }
                if ("r" == Convert.ToString(Session["s4"]))
                {
                    c.cmd.CommandText = "update cseat set s4='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s5"]))
                {
                    c.cmd.CommandText = "update cseat set s5='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s6"]))
                {
                    c.cmd.CommandText = "update cseat set s6='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s7"]))
                {
                    c.cmd.CommandText = "update cseat set s7='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s8"]))
                {

                    c.cmd.CommandText = "update cseat set s8='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s9"]))
                {
                    c.cmd.CommandText = "update cseat set s9='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s10"]))
                {
                    c.cmd.CommandText = "update cseat set s10='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s11"]))
                {
                    c.cmd.CommandText = "update cseat set s11='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s12"]))
                {
                    c.cmd.CommandText = "update cseat set s12='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s13"]))
                {
                    c.cmd.CommandText = "update cseat set s13='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s14"]))
                {
                    c.cmd.CommandText = "update cseat set s14='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s15"]))
                {
                    c.cmd.CommandText = "update cseat set s15='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s16"]))
                {
                    c.cmd.CommandText = "update cseat set s16='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s17"]))
                {
                    c.cmd.CommandText = "update cseat set s17='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s18"]))
                {
                    c.cmd.CommandText = "update cseat set s18='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s19"]))
                {
                    c.cmd.CommandText = "update cseat set s19='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s20"]))
                {
                    c.cmd.CommandText = "update cseat set s20='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s21"]))
                {
                    c.cmd.CommandText = "update cseat set s21='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s22"]))
                {
                    c.cmd.CommandText = "update cseat set s22='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s23"]))
                {
                    c.cmd.CommandText = "update cseat set s23='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s24"]))
                {
                    c.cmd.CommandText = "update cseat set s24='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s25"]))
                {
                    c.cmd.CommandText = "update cseat set s25='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s26"]))
                {
                    c.cmd.CommandText = "update cseat set s26='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s27"]))
                {
                    c.cmd.CommandText = "update cseat set s27='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s28"]))
                {
                    c.cmd.CommandText = "update cseat set s28='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s29"]))
                {
                    c.cmd.CommandText = "update cseat set s29='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                } if ("r" == Convert.ToString(Session["s30"]))
                {
                    c.cmd.CommandText = "update cseat set s30='r' where rout='" + Convert.ToString(Session["r"]) + "'";
                    c.cmd.ExecuteNonQuery();
                }
            }
           /* decimal w = 0, p;
            c.cmd.CommandText = "select * from userdetail detail where username='" + (string)Session["username"] + "'";
            p = Convert.ToDecimal(tot);
            SqlDataReader sd = c.cmd.ExecuteReader();
            while (sd.Read())
            {
                w = (decimal)sd["wal"];
            }
            sd.Close();*/
            w = w - p;
            c.cmd.CommandText = "update userdetail set wal=" + w + "where username='" + (string)Session["username"] + "'";
            c.cmd.ExecuteNonQuery();
            MessageBox.Show("Amount of " + p + "has been debited to your wallet available balance is " + w);
        }
        else
            MessageBox.Show("not enough balance");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {

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
        Response.Redirect("booking.aspx");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("help.aspx");
    }
}
