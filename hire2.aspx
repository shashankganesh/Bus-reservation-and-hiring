<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hire2.aspx.cs" Inherits="hire2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
<script language="javascript" type="text/javascript">
// <!CDATA[

function TABLE1_onclick() {

}

// ]]>
</script>

<link rel="stylesheet" type="text/css" />
<style type="text/css">
body{
background="title.jpg"
background-repeat: no-repeat;
background-size:100%; 
}
</style>
</head>

<body background="title.jpg" > 
    <form id="form1" runat="server">
        <br />
        &nbsp;
       <center> &nbsp;</center>
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
            <table><tr><td style="width: 686px"><table visible="false" style="font-size:x-large;font-weight:bold;">
            <tr>
                <td style="width: 100px">
                    <asp:Button ID="Button2" runat="server" Text="With in a City" OnClick="Button2_Click" BackColor="#0000C0" BorderColor="White" ForeColor="White"  style="font-size:x-large;font-weight:bold;" Height="37px" Width="250px" /></td>
                <td style="width: 100px">
                    <asp:Button ID="Button1" runat="server" Text="Out of City" OnClick="Button1_Click" BackColor="#0000C0" BorderColor="White" ForeColor="White"  style="font-size:x-large;font-weight:bold;" Height="37px" Width="250px" /></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    Pickuppoint</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="DropDownList1" runat="server" BackColor="Transparent" ForeColor="Black" Width="150px"></asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    &nbsp;
                    Destination</td>
                <td style="width: 100px">
                    <asp:DropDownList ID="DropDownList2" runat="server" BackColor="Transparent" CssClass="hire2" ForeColor="Black" Width="150px"></asp:DropDownList></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:CheckBox ID="CheckBox1" runat="server" Text="Round trip" />
                    (Return will be same as pick up point)</td>
            </tr>
        </table>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="DropDownList1"
                        ControlToValidate="DropDownList2" ErrorMessage="Destination can't be same as Pick up point"
                        Operator="NotEqual"></asp:CompareValidator><br />
                    <br />
                    <br />
        <table visible="false" style="font-size:x-large;font-weight:bold;">
      
            <tr>
                <td colspan="2">
                    <center>Select your Bus type</center></td>
            </tr>
            <tr>
                <td style="width: 210px; height: 22px">
                    <asp:RadioButton ID="sl" runat="server" Text="Sleeper" GroupName="a" /></td>
                <td style="width: 188px; height: 22px">
                    <asp:RadioButton ID="nonsl" runat="server" Text="Non Sleeper" GroupName="a" Checked="True" /></td>
            </tr>
            <tr>
                <td style="width: 210px">
                    <asp:RadioButton ID="ac" runat="server" Text="A\C" GroupName="b" /></td>
                <td style="width: 188px">
                    <asp:RadioButton ID="noac" runat="server" Text="Non A\C" GroupName="b" Checked="True" /></td>
            </tr>
            <tr>
                <td style="width: 210px">
                    <asp:RadioButton ID="s40" runat="server" Text="40 Seeter" GroupName="c" /></td>
                <td style="width: 188px">
                    <asp:RadioButton ID="s20" runat="server" Text="20 Seeter" GroupName="c" Checked="True" /></td>
            </tr>
        </table></td><td>
                    <br />
                    <br />
                    <br />
        <table id="TABLE1" visible="false"  style="font-size:x-large;font-weight:bold;" onclick="return TABLE1_onclick()">
            <tr>
                <td style="width: 205px">
                </td>
                <td style="width: 100px">
                    From When</td>
                <td style="width: 100px">
                    Till When</td>
            </tr>
            <tr>
                <td style="width: 205px; height: 80px;">
                    Enter Time<br />
                    (in 24hour format)</td>
                <td style="width: 100px; height: 80px;">
                    <asp:TextBox ID="TextBox1" runat="server" Style="border:none; border-bottom:1px solid black;"></asp:TextBox>
                    </td>
                <td style="width: 100px; height: 80px;">
                    <asp:TextBox ID="TextBox2" runat="server" Style="border:none; border-bottom:1px solid black;"></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td style="width: 205px">
                    Enter Date</td>
                <td style="width: 100px">
                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" VisibleDate="2021-09-21" BorderStyle="Outset" ForeColor="Black" BorderColor="Gray"></asp:Calendar>
                    <asp:Label ID="Label1" runat="server"></asp:Label></td>
                <td style="width: 100px">
                    <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged" BorderStyle="Outset" ForeColor="Black" BorderColor="Gray"></asp:Calendar>
                    <asp:Label ID="Label2" runat="server"></asp:Label></td>
            </tr>
        </table>
        &nbsp;&nbsp;
                    <br />
       
        <asp:Button ID="Button3" runat="server" Text="PROCEED" BackColor="#0000C0" ForeColor="White" Width="237px" BorderColor="Red" BorderStyle="Double" BorderWidth="1px" OnClick="Button3_Click" Font-Bold="True" Height="63px"  style="font-size:x-large;font-weight:bold;" />
        <br /></td></tr></table>
        </center>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/home.jpg" ForeColor="Transparent" OnClick="ImageButton1_Click" />
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/mybooking.jpg" OnClick="ImageButton2_Click" />
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/helpandsupport.jpg" OnClick="ImageButton3_Click" />
        <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/myaccount.jpg" OnClick="ImageButton4_Click" />
                
    </form>
</body>
</html>
