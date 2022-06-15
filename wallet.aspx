<%@ Page Language="C#" AutoEventWireup="true" CodeFile="wallet.aspx.cs" Inherits="wallet" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body background="titlew.jpg">
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
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
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
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp;
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Height="18px" Text="Label" style="font-size:x-large;font-weight:bold;" ></asp:Label><br />
        <br />
        <br />
        <center>
            <asp:Button ID="Button1" runat="server" BackColor="Transparent" BorderColor="#0000C0"
                Text="Recharge" style="font-size:x-large;font-weight:bold;" OnClick="Button1_Click1" />&nbsp;</center>
        <center>
            &nbsp;</center>
        <center>
            &nbsp;</center>
        <center>
            <table style="height: 126px"  visible="true">
                <tr>
                    <td style="width: 211px; height: 397px;">
        
            <asp:Panel ID="Panel1" runat="server" Width="376px" Visible="False">
                Enter Amount<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="textbox5"
                    ErrorMessage="only numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator>
                <hr />
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                <b>DEBIT/ATM CARD</b><br />
                CARD NO.<br />
                <asp:TextBox ID="TextBox1" runat="server" Height="25px" Width="357px"></asp:TextBox><br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="textbox1"
                    ErrorMessage="only numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator><br />
                NAME ON CARD<br />
                <asp:TextBox ID="TextBox2" runat="server" Height="25px" Width="354px"></asp:TextBox><br />
                EXPIRY DATE &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;CVV<br />
                <asp:TextBox ID="TextBox3" runat="server" Height="25px" Width="251px"></asp:TextBox>
                &nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server" Height="25px" Width="81px"></asp:TextBox><br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="textbox4"
                    ErrorMessage="only numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator><br />
                <asp:Button ID="Button2" runat="server" BackColor="Blue" BorderColor="#0000C0" Height="42px"
                    OnClick="Button2_Click" Text="Pay Now" Width="356px" ForeColor="white" style="font-size:x-large;font-weight:bold;" /></asp:Panel>
                    </td>
                </tr>
            </table>
             </center>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <table>
            <tr>
                <td style="width: 100px">
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/home.jpg" OnClick="ImageButton1_Click" /></td>
                <td style="width: 100px">
                    <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/mybooking.jpg" OnClick="ImageButton2_Click" /></td>
                <td style="width: 100px">
                    <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/helpandsupport.jpg" OnClick="ImageButton3_Click" /></td>
                <td style="width: 100px">
                    <asp:ImageButton ID="ImageButton4" runat="server" ImageUrl="~/myaccount.jpg" OnClick="ImageButton4_Click" /></td>
            </tr>
        </table>
       
    </div>
    </form>
</body>
</html>
