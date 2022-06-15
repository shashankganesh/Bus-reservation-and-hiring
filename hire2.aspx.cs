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

public partial class hire2 : System.Web.UI.Page
{
    connect c;
    DataSet ds;
    SqlDataAdapter adp=new SqlDataAdapter();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string[] ds={"--SELECT--","udupi","hebri","katpadi"};
        string[] ds1 ={"--SELECT--","hebri", "katpadi", "udupi" };
        DropDownList1.DataSource = ds;
        DropDownList2.DataSource = ds1;
        DropDownList1.DataBind();
        DropDownList2.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string[] dw ={ "--SELECT--","udupi", "kundapura", "mangalore" };
        string[] dw1 ={ "--SELECT--","kundapura", "mangalore", "udupi" };
        DropDownList1.DataSource = dw;
        DropDownList2.DataSource = dw1;
        DropDownList1.DataBind();
        DropDownList2.DataBind();
    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        DateTime d1 = Calendar1.SelectedDate;
        DateTime d2 = DateTime.Today;
        if (d1 < d2)
            MessageBox.Show("select proper date");
        else
        Label1.Text =  d1.ToShortDateString();
   

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
       /* try
        {*/
            if (DropDownList1.SelectedItem.Text != "--SELECT--" && DropDownList2.SelectedItem.Text !="--SELECT--")
            {
                c = new connect();
                string s, a, so, de, ss, aa, tt = "single way";
                int se, id = 0, k = 0, p, d, sp = 0, pp = 0, dd = 0;
                // try{

                DateTime dt1 = Calendar1.SelectedDate;
                DateTime dt2 = Calendar2.SelectedDate;
                Session["ddt"] = dt2.ToShortDateString();


                if (dt2 < dt1)
                {
                    MessageBox.Show("Enter proper date");
                }
                else
                {
                    TimeSpan dt3 = dt2.Subtract(dt1);
                    int dt4 = Convert.ToInt16(dt3.TotalDays);
                    if (dt4 < 3)
                    {
                        if (TextBox1.Text == "" || TextBox2.Text == "")
                        {
                            MessageBox.Show("Enter time properly");
                        }
                        else
                        {
                            if (sl.Checked == true)
                            {
                                s = "sleeper";
                                ss = sl.Text;
                            }
                            else
                            {
                                s = "non";
                                ss = nonsl.Text;
                            }
                            if (ac.Checked == true)
                            {
                                a = "ac";
                                aa = ac.Text;
                            }
                            else
                            {
                                a = "non";
                                aa = noac.Text;
                            }
                            if (s40.Checked == true)
                            {
                                se = 40;
                                c.cmd.CommandText = "select * from splcost";
                                SqlDataReader sa = c.cmd.ExecuteReader();
                                while (sa.Read())
                                {
                                    sp = (int)sa["s40"];
                                }
                                sa.Close();
                            }
                            else
                            {
                                se = 20;
                                c.cmd.CommandText = "select * from splcost";
                                SqlDataReader sb = c.cmd.ExecuteReader();
                                while (sb.Read())
                                {
                                    sp = (int)sb["s20"];
                                }
                                sb.Close();
                            }
                            so = DropDownList1.SelectedItem.ToString();
                            de = DropDownList2.SelectedItem.ToString();

                            c.cmd.CommandText = "select * from splmap where pickup='" + so + "' and dest='" + de + "'";
                            SqlDataReader sd = c.cmd.ExecuteReader();
                            while (sd.Read())
                            {
                                k = (int)sd["km"];
                            }
                            sd.Close();
                            if (ac.Checked == true)
                            {
                                c.cmd.CommandText = "select * from splcost";
                                SqlDataReader sc = c.cmd.ExecuteReader();
                                while (sc.Read())
                                {
                                    pp = (int)sc["ac"];
                                }
                                sc.Close();
                                p = k * pp;
                            }
                            else
                            {
                                c.cmd.CommandText = "select * from splcost";
                                SqlDataReader sc = c.cmd.ExecuteReader();
                                while (sc.Read())
                                {
                                    pp = (int)sc["nonac"];
                                }
                                sc.Close();
                                p = k * pp;
                            }
                            c.cmd.CommandText = "select * from splcost";
                            SqlDataReader sf = c.cmd.ExecuteReader();
                            while (sf.Read())
                            {
                                dd = (int)sf["driver"];
                            }
                            sf.Close();
                            d = k * dd;
                            if (CheckBox1.Checked == true)
                            {
                                p = p * 2;
                                d = d * 2;
                                tt = "Round tripe";
                                k = k * 2;
                            }

                            c.cmd.CommandText = "select * from splbus where status='n' and type1='" + a + "' and type2='" + s + "' and seat=" + se;

                            ds = new DataSet();
                            adp.SelectCommand = c.cmd;
                            adp.Fill(ds, "spl");
                            if (ds.Tables["spl"].Rows.Count > 0)
                            {

                                SqlDataReader sdr = c.cmd.ExecuteReader();
                                while (sdr.Read())
                                {
                                    id = (int)sdr["bno"];

                                }
                                sdr.Close();

                                Session["pic"] = DropDownList1.SelectedItem.ToString();
                                Session["des"] = DropDownList2.SelectedItem.ToString();
                                Session["when"] = dt1.ToShortDateString();
                                Session["till"] = dt2.ToShortDateString();
                                Session["drive"] = d;
                                Session["price"] = p;
                                Session["type1"] = ss;
                                Session["type2"] = aa;
                                Session["s"] = se;
                                Session["seatp"] = sp;
                                Session["id"] = id;
                                Session["triptype"] = tt;
                                Session["km"] = k;

                                Response.Redirect("hire3.aspx");
                            }
                            else
                                MessageBox.Show("no bus left");
                            c.cnn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("you can hire bus for only for minimum 10 days");
                    }

                }
            }
            else
            {
                MessageBox.Show("Enter travel rout properly");
            }
      /*  }
        catch (Exception)
        {
            MessageBox.Show("Enter pickup and destination");
        }*/
    }
     //catch (Exception)
      //{
      //      throw;
        //}
       // finally
       //{
            
       //}


  
       
   
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        DateTime d1 = Calendar2.SelectedDate;
        DateTime d2 = DateTime.Now;
        if (d1 < d2)
            MessageBox.Show("enter proper date");
        else
        Label2.Text = d1.ToShortDateString();
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("home.aspx");
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("booking.aspx");
    }
    protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("help.aspx");
    }
    protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("myaccount.aspx");
    }
}
