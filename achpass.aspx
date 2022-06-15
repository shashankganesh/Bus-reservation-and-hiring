<%@ Page Language="C#" AutoEventWireup="true" CodeFile="achpass.aspx.cs" Inherits="achpass" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <table>
                <tr>
                    <td style="width: 115px">
                        Old Password</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 115px">
                        New Password</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
                <tr>
                    <td style="width: 115px">
                        Confirm Password</td>
                    <td style="width: 100px">
                        <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox></td>
                </tr>
            </table>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm" /></div>
    
    </div>
    </form>
</body>
</html>
