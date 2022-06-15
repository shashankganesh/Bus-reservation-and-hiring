<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hire3.aspx.cs" Inherits="hire3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    
</head>

<body text="blue" background="title.jpg">

    <form id="form1" runat="server">
    <div >
        <br />
        <br />
        <br />
        <br />
        <br />
        <h2 style="" >
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
            &nbsp;&nbsp;
              INVOICE &nbsp; &nbsp; &nbsp;
        </h2> 
   <center>   <table  style="font-size:x-large;font-weight:bold;" >
            <tr>
                <td style="width: 182px">
                    Name</td>
                <td style="width: 253px">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 182px">
                    Moblile</td>
                <td style="width: 253px">
                    <asp:Label ID="mb" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 182px">
                    E-mail</td>
                <td style="width: 253px">
                    <asp:Label ID="em" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 182px">
                    Your Bus id</td>
                <td style="width: 253px">
                    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 182px; height: 28px;">
                    Pick up point</td>
                <td style="width: 253px; height: 28px;">
                    <asp:Label ID="plocation" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 182px; height: 12px;">
                    Destination</td>
                <td style="width: 253px; height: 12px;">
                    <asp:Label ID="dlocation" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 182px; height: 12px">
                    Trip type</td>
                <td style="width: 253px; height: 12px">
                    <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 182px; height: 12px">
                    Travel distance</td>
                <td style="width: 253px; height: 12px">
                    <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 182px; height: 12px">
                    When</td>
                <td style="width: 253px; height: 12px">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 182px; height: 12px">
                    Till</td>
                <td style="width: 253px; height: 12px">
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 182px; height: 12px">
                    Bus type</td>
                <td style="width: 253px; height: 12px">
                    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
                    ,
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 182px; height: 12px">
                    Seater</td>
                <td style="width: 253px; height: 12px">
                    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 182px; height: 12px">
                    Bus seat Charge</td>
                <td style="width: 253px; height: 12px">
                    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 182px; height: 21px;">
                    Driver charge</td>
                <td style="width: 253px; height: 21px;">
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 182px">
                    Bus Charge(per km Rs.50/
                    A/C per km Rs.75)</td>
                <td style="width: 253px">
                    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
                    &nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td style="width: 182px">
                    Total Amount</td>
                <td style="width: 253px">
                    <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label></td>
            </tr>
        </table>
      
        <br />
        <asp:Button ID="Button1" runat="server" Text="Pay with Wallet" OnClick="Button1_Click" BackColor="Red" BorderWidth="3px" ForeColor="Black" Height="32px" Width="188px" style="font-size:x-large;font-weight:bold;" BorderColor="#FF8000" />
        <asp:Button ID="Button2" runat="server" Text="Pay with credit card" BackColor="Transparent" BorderWidth="2px" ForeColor="White" Height="32px" Width="188px"  style="font-size:x-large;font-weight:bold;"  /></center>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/home.jpg" OnClick="ImageButton1_Click" />
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/mybooking.jpg" OnClick="ImageButton2_Click" />
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/helpandsupport.jpg" OnClick="ImageButton3_Click" />
        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/myaccount.jpg" OnClick="ImageButton4_Click" />
       </div>
    </form>
    
</body>
</html>
