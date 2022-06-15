<%@ Page Language="C#" AutoEventWireup="true" CodeFile="covid.aspx.cs" Inherits="covid" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body bgcolor="black" text="#ff0000">
    <form id="form1" runat="server">
        <table style="width: 1554px; height: 956px " visible="false">
            <tr>
                <td style="width: 15px; height: 952px">
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Samba-phone-wallpaper.jpg" Width="544px" /></td>
                <td style="width: 100px; height: 952px; text-align: justify">
                   <strong> <h2>IMPORTANT : ADHERE TO STATE GUIDELINES &nbsp; </h2><br />
                        <br />
                        States have released their travel guidelines for inbound and outbound travellers
                        vis-a-vis passes,permits,quarintine rules and other requirements. Please go through
                        the guidelines of your source and destination state carefully before planing your
                        travel and have hassele free experience<br />
                       <br />
                       <br />
                       <br />
                       <asp:Button ID="Button1" runat="server" BackColor="Red" ForeColor="Black" OnClick="Button1_Click"
                           Text="HOME" /></strong></td>
            </tr>
        </table>
    </form>
</body>
</html>
