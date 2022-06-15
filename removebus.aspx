<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="removebus.aspx.cs" Inherits="removebus" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <br />
    Enter Bus ID(bno) to remove&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;<br />
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<asp:Button
        ID="Button3" runat="server" BackColor="Transparent" BorderColor="Black" Height="40px"
        Style="font-weight: bold; font-size: large" Text="Remove" Width="160px" OnClick="Button3_Click1" />
</asp:Content>

