<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="addbus.aspx.cs" Inherits="addbus" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <table style="font-weight: bold; font-size: x-large" visible="false">
        <tr>
            <td colspan="2">
                <center>
                    Select your Bus type</center>
            </td>
        </tr>
        <tr>
            <td style="width: 210px; height: 22px">
                <asp:RadioButton ID="sl" runat="server" GroupName="a" Text="Sleeper" /></td>
            <td style="width: 188px; height: 22px">
                <asp:RadioButton ID="nonsl" runat="server" Checked="True" GroupName="a" Text="Non Sleeper" /></td>
        </tr>
        <tr>
            <td style="width: 210px">
                <asp:RadioButton ID="ac" runat="server" GroupName="b" Text="A\C" /></td>
            <td style="width: 188px">
                <asp:RadioButton ID="noac" runat="server" Checked="True" GroupName="b" Text="Non A\C" /></td>
        </tr>
        <tr>
            <td style="width: 210px">
                <asp:RadioButton ID="s40" runat="server" GroupName="c" Text="40 Seeter" /></td>
            <td style="width: 188px">
                <asp:RadioButton ID="s20" runat="server" Checked="True" GroupName="c" Text="20 Seeter" /></td>
        </tr>
    </table>
    <br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" BackColor="Transparent" BorderColor="White"
        Height="40px" OnClick="Button1_Click" Style="font-weight: bold; font-size: large"
        Text="Add" Width="160px" />
</asp:Content>

