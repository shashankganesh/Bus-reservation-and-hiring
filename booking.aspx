<%@ Page Language="C#" AutoEventWireup="true" CodeFile="booking.aspx.cs" Inherits="booking" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body background="title.jpg">
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
       <center> <table ><tr><td style="width: 541px; height: 598px;">
   <h1> Seat booking detail</h1><br />
    <br />
        <asp:GridView ID="GridView1" runat="server" >
        </asp:GridView>
           <asp:Label ID="Label1" runat="server" Text="No Booking" Visible="False" style="font-size:large;font-weight:bold;" BackColor="Transparent" BorderColor="Black"></asp:Label></td><td style="width: 501px; height: 598px;">
           <h1> Bus hire detail</h1><br />
            <br />
            <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
            <asp:Label ID="Label2" runat="server" Text="No Booking" Visible="False" style="font-size:large;font-weight:bold;" BackColor="Transparent" BorderColor="Black"></asp:Label></td></tr></table></center>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton6" runat="server" ImageUrl="~/home.jpg" OnClick="ImageButton6_Click1" /><asp:ImageButton
            ID="ImageButton7" runat="server" ImageUrl="~/mybooking.jpg" OnClick="ImageButton7_Click" /><asp:ImageButton
                ID="ImageButton8" runat="server" ImageUrl="~/helpandsupport.jpg" OnClick="ImageButton8_Click" /><asp:ImageButton
                    ID="ImageButton9" runat="server" ImageUrl="~/myaccount.jpg" OnClick="ImageButton9_Click" /></div>
    </form>
</body>
</html>
