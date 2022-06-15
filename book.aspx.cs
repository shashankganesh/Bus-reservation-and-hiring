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

public partial class book : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp = new SqlDataAdapter();
    protected void Page_Load(object sender, EventArgs e)
    {
        decimal a=0,t;
        c = new connect();
        c.cmd.CommandText = "select * from pkcost";
        SqlDataReader sdr = c.cmd.ExecuteReader();
        while (sdr.Read())
        {
            a = (decimal)sdr["cost"];
        }
        sdr.Close();
        t = 504 * a;
        Label1.Text = t.ToString();
        t = 590 * a;
        Label2.Text = t.ToString();
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Session["rf"] = "Belagavi";
        Session["rt"] = "Bangalore";
        Session["at"] = Label1.Text;
        c = new connect();
        Session["r"] = "betoba";
        if (RadioButton1.Checked == true)
        {
            Session["time"] = "6AM";
                c.cmd.CommandText = "select * from bseat where rout='betoba' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

                ds = new DataSet();
                adp.SelectCommand = c.cmd;
                adp.Fill(ds, "a");
                if (ds.Tables["a"].Rows.Count > 0)
                {
                    Session["t"] = "am";
                    Response.Redirect("book1.aspx");
                }
                else
                    MessageBox.Show("Seat is FULL...!");
                

        }
        else
        {
            Session["time"] = "3PM";
            c.cmd.CommandText = "select * from cseat where rout='betoba' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "b");
            if (ds.Tables["b"].Rows.Count > 0)
            {
                Session["t"] = "pm";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");
                
 
        }
        c.cnn.Close();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {

        Session["rf"] = "belagavi";
        Session["rt"] = "maysoor";
        Session["at"] = 1770;
        c = new connect();
        Session["r"] = "betomy";
        if (RadioButton3.Checked == true)
        {
            Session["time"] = "5AM";
            c.cmd.CommandText = "select * from bseat where rout='betomy' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "c");
            if (ds.Tables["c"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "3.30PM";
            c.cmd.CommandText = "select * from cseat where rout='betomy' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "d");
            if (ds.Tables["d"].Rows.Count > 0)
            {
                Session["t"] = "pm";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        Session["rf"] = "Belagavi";
        Session["rt"] = "mangalore";
        Session["at"] = 1754;
        c = new connect();
        Session["r"] = "betoma";
        if (RadioButton9.Checked == true)
        {
            Session["time"] = "8AM";
            c.cmd.CommandText = "select * from bseat where rout='betoma' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "e");
            if (ds.Tables["e"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "5PM";
            c.cmd.CommandText = "select * from cseat where rout='betoma' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "f");
            if (ds.Tables["f"].Rows.Count > 0)
            {
                Session["t"] = "pm";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {

        Session["rf"] = "Belagavi";
        Session["rt"] = "udupi";
        Session["at"] = 1092;
        c = new connect();
        Session["r"] = "betoud";
        if (RadioButton13.Checked == true)
        {
            Session["time"] = "9AM";
            c.cmd.CommandText = "select * from bseat where rout='betoud' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "g");
            if (ds.Tables["g"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "5PM";
            c.cmd.CommandText = "select * from cseat where rout='betoud' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "pm";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {

        Session["rf"] = "Bangalore";
        Session["rt"] ="udupi";
        Session["at"] = 1215;
        c = new connect();
        Session["r"] = "batoud";
        if (RadioButton17.Checked == true)
        {
            Session["time"] = "9AM";
            c.cmd.CommandText = "select * from bseat where rout='batoud' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "5.30PM";
            c.cmd.CommandText = "select * from cseat where rout='batoud' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "pm";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Session["rf"] = "Bangalore";
        Session["rt"] = "maysoor";
        Session["at"] = 516;
        c = new connect();
        Session["r"] = "batomy";
        if (RadioButton21.Checked == true)
        {
            Session["time"] = "11AM";
            c.cmd.CommandText = "select * from bseat where rout='batomy' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "2.30PM";
            c.cmd.CommandText = "select * from cseat where rout='batomy' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "pm";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Session["rf"] = "Bangalore";
        Session["rt"] = "mangalore";
        Session["at"] = 1056;
        c = new connect();
        Session["r"] = "batoma";
        if (RadioButton25.Checked == true)
        {
            Session["time"] = "7.30AM";
            c.cmd.CommandText = "select * from bseat where rout='batoma' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "3.30PM";
            c.cmd.CommandText = "select * from cseat where rout='batoma' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Session["rf"] = "Bangalore";
        Session["rt"] = "beagavi";
        Session["at"] = 1512;
        c = new connect();
        Session["r"] = "batobe";
        if (RadioButton5.Checked == true)
        {Session["time"]="6AM";

            c.cmd.CommandText = "select * from bseat where rout='batobe' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"]="3PM";
            c.cmd.CommandText = "select * from cseat where rout='batobe' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        Session["rf"] = "mysoor";
        Session["rt"] = "udupi";
        Session["at"] = 918;
        c = new connect();
        Session["r"] = "mytoud";
        if (RadioButton29.Checked == true)
        {
            Session["time"] = "9.30AM";
            c.cmd.CommandText = "select * from bseat where rout='mytoud' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "4.30";
            c.cmd.CommandText = "select * from cseat where rout='mytoud' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        Session["rf"] = "maysoor";
        Session["rt"] ="mangalore";
        Session["at"] = 1215;
        c = new connect();
        Session["r"] = "mytoma";
        if (RadioButton33.Checked == true)
        {
            Session["time"] = "10AM";
            c.cmd.CommandText = "select * from bseat where rout='mytoma' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "4.30PM";
            c.cmd.CommandText = "select * from cseat where rout='mytoma' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {

                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        Session["rf"] = "maysoor";
        Session["rt"] = "belagavi";
        Session["at"] = 1770;
        c = new connect();
        Session["r"] = "mytobe";
        if (RadioButton7.Checked == true)
        {
            Session["time"] = "5AM";
            c.cmd.CommandText = "select * from bseat where rout='mytobe' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "3.30";
            c.cmd.CommandText = "select * from cseat where rout='mytobe' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        Session["rf"] = "maysoor";
        Session["rt"] = "bangalore";
        Session["at"] = 1512;
        c = new connect();
        Session["r"] = "mytoba";
        if (RadioButton23.Checked == true)
        {
            Session["time"]="11AM";
            c.cmd.CommandText = "select * from bseat where rout='mytoba' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"]="2.30PM";
            c.cmd.CommandText = "select * from cseat where rout='mytoba' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button14_Click(object sender, EventArgs e)
    {
        Session["rf"] = "mangalore";
        Session["rt"] = "belagavi";
        Session["at"] = 1754;
        c = new connect();
        Session["r"] = "matobe";
        if (RadioButton11.Checked == true)
        {
            Session["time"] = "8AM";
            c.cmd.CommandText = "select * from bseat where rout='matobe' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "5PM";
            c.cmd.CommandText = "select * from cseat where rout='matobe' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button13_Click(object sender, EventArgs e)
    {
        Session["rf"] = "mangalore";
        Session["rt"] = "bangalore";
        Session["at"] = 1056;
        c = new connect();
        Session["r"] = "matobe";
        if (RadioButton27.Checked == true)
        {
            Session["time"] = "7.30AM";
            c.cmd.CommandText = "select * from bseat where rout='matoba' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "3.30PM";
            c.cmd.CommandText = "select * from cseat where rout='matoba' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        Session["rf"] = "mangalore";
        Session["rt"] = "maysoor";
        Session["at"] = 765;
        c = new connect();
        Session["r"] = "matomy";
        if (RadioButton35.Checked == true)
        {
            Session["time"] = "10AM";
            c.cmd.CommandText = "select * from bseat where rout='matomy' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "5.30PM";
            c.cmd.CommandText = "select * from cseat where rout='matomy' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button16_Click(object sender, EventArgs e)
    {
        Session["rf"] = "mangalore";
        Session["rt"] = "udupi";
        Session["at"] = 165;
        c = new connect();
        Session["r"] = "matoud";
        if (RadioButton37.Checked == true)
        {
            Session["time"] = "11AM";
            c.cmd.CommandText = "select * from bseat where rout='matoud' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "3PM";
            c.cmd.CommandText = "select * from cseat where rout='matoud' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button17_Click(object sender, EventArgs e)
    {
        Session["rf"] = "udupi";
        Session["rt"] = "mangalore";
        Session["at"] = 165;
        c = new connect();
        Session["r"] = "udtoma";
        if (RadioButton39.Checked == true)
        {
            Session["time"] = "11AM";
            c.cmd.CommandText = "select * from bseat where rout='udtoma' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "3PM";
            c.cmd.CommandText = "select * from cseat where rout='udtoma' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button18_Click(object sender, EventArgs e)
    {
        Session["rf"] = "udupi";
        Session["rt"] = "bangalore";
        Session["at"] = 1092;
        c = new connect();
        Session["r"] = "udtobe";
        if (RadioButton15.Checked == true)
        {
            Session["time"] = "9AM";
            c.cmd.CommandText = "select * from bseat where rout='udtobe' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "5PM";
            c.cmd.CommandText = "select * from cseat where rout='udtobe' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        Session["rf"] = "udupi";
        Session["rt"] = "bangalore";
        Session["at"] = 1215;
        c = new connect();
        Session["r"] = "udtoba";
        if (RadioButton19.Checked == true)
        {
            Session["time"] = "9AM";
            c.cmd.CommandText = "select * from bseat where rout='udtoba' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "5.30PM";
            c.cmd.CommandText = "select * from cseat where rout='udtoba' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
    }
    protected void Button20_Click(object sender, EventArgs e)
    {
        Session["rf"] = "udupi";
        Session["rt"] = "maysoor";
        Session["at"] = 918;
        c = new connect();
        Session["r"] = "udtomy";
        if (RadioButton31.Checked == true)
        {
            Session["time"] = "9.30AM";
            c.cmd.CommandText = "select * from bseat where rout='udtomy' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Session["t"] = "am";
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        else
        {
            Session["time"] = "4.30PM";
            c.cmd.CommandText = "select * from cseat where rout='udtomy' and (s1='n' or s2='n' or s3='n' or s4='n' or s5='n' or s6='n' or s7='n' or s8='n' or s9='n' or s10='n' or s11='n' or s13='n' or s14='n' or s15='n' or s16='n' or s17='n' or s18='n' or s19='n' or s20='n' or s21='n' or s22='n' or s23='n' or s23='n' or s24='n' or s25='n' or s26='n' or s27='n' or s28='n' or s29='n' or s30='n')";

            ds = new DataSet();
            adp.SelectCommand = c.cmd;
            adp.Fill(ds, "use");
            if (ds.Tables["use"].Rows.Count > 0)
            {
                Response.Redirect("book1.aspx");
            }
            else
                MessageBox.Show("Seat is FULL...!");


        }
        c.cnn.Close();
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
