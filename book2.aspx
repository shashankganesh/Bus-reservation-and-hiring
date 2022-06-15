<%@ Page Language="C#" AutoEventWireup="true" CodeFile="book2.aspx.cs" Inherits="book2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body background="ticket.jpg">
    <form id="form1" runat="server">
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Image ID="Image1" runat="server" Height="70px" ImageUrl="~/buslogo.jpg" Width="120px" /><br />
        <br />
        <center> <h1>
            &nbsp;
            &nbsp;&nbsp;
            <b1>E Bus Travels</b1></h1>
       
       <h1><b><table width="400px" height="200px">
            <tr>
                <td colspan="3">
                   <center> <asp:Label ID="Label1" runat="server" Text="Label" BackColor="White" ForeColor="Red"></asp:Label></center></td>
            </tr>
            <tr>
                <td style="width: 294px">
                   <center> <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>&nbsp;</center></td>
                <td style="width: 28px">
                   <center> To</center></td>
                <td style="width: 345px">
                   <center> <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></center></td>
            </tr>
            <tr>
                <td style="width: 294px">
                    No. of&nbsp; Seat
                </td>
                <td style="width: 28px">
                </td>
                <td style="width: 345px">
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 294px; height: 21px">
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
                <td style="width: 28px; height: 21px">
                </td>
                <td style="width: 345px; height: 21px">
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 294px; height: 21px">
                    Bus id
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label></td>
                <td style="width: 28px; height: 26px">
                </td>
                <td style="width: 345px; height: 26px">
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                    INR</td>
            </tr>
        </table></b></h1>
        </center>
        <center>
            &nbsp;</center>
        <center>
            &nbsp;</center>
        <center>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="PAY WITH WALLET" BackColor="Red" BorderColor="#FF8000" BorderWidth="3px" Height="36px" Width="213px" />&nbsp;</center>
        <center>
            &nbsp;</center>
        <center>
            &nbsp;</center>
        <center>
            &nbsp;</center>
        <center>
            &nbsp;</center>
        <center>
            &nbsp;</center>
        <center>
            &nbsp;</center>
        <center>
            &nbsp;</center>
        <center>
            &nbsp;</center>
        <center>
            &nbsp;</center>
        <center>
            &nbsp;</center>
        <center>
            &nbsp;</center>
        <center>
            <br />
            &nbsp;</center>
            
        
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/home.jpg" OnClick="ImageButton1_Click" />
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/mybooking.jpg" OnClick="ImageButton2_Click" />
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/helpandsupport.jpg" OnClick="ImageButton3_Click" />
        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/myaccount.jpg" OnClick="ImageButton4_Click" />&nbsp;
        </div>
    </form>
</body>
</html>
