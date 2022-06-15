<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="changecost.aspx.cs" Inherits="changecost" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <h3><b> &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Seat Booking</b></h3> 
    <table>
        <tr>
            <td style="width: 100px">
                Per KM cost</td>
            <td style="width: 65px">
                <asp:TextBox ID="TextBox1" runat="server" Style="border:none; border-bottom:1px solid black;" OnTextChanged="TextBox1_TextChanged" ReadOnly="True" BorderStyle="None" Width="50px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Change" /></td>
            <td style="width: 132px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="textbox1"
                    ErrorMessage="only numbers allowed" ValidationExpression="\d+" Width="176px"></asp:RegularExpressionValidator></td>
        </tr>
    </table>
    <br />
    <h3><b>&nbsp; &nbsp; &nbsp; Bus Hiring Cost(Per KM)</b></h3>
    <table>
        <tr>
            <td style="width: 100px">
                40 Seater</td>
            <td style="width: 65px">
                <asp:TextBox ID="TextBox2" runat="server" Style="border:none; border-bottom:1px solid black;" ReadOnly="True" OnTextChanged="TextBox2_TextChanged" Width="50px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:Button ID="Button2" runat="server" Text="Change" OnClick="Button2_Click" /></td>
            <td style="width: 100px">
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="textbox2"
                    ErrorMessage="only numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
                20 Seater</td>
            <td style="width: 65px">
                <asp:TextBox ID="TextBox3" runat="server" Style="border:none; border-bottom:1px solid black;" ReadOnly="True" Width="50px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:Button ID="Button3" runat="server" Text="Change" OnClick="Button3_Click" /></td>
            <td style="width: 100px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="textbox3"
                    ErrorMessage="only numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
                A/C</td>
            <td style="width: 65px">
                <asp:TextBox ID="TextBox4" runat="server" Style="border:none; border-bottom:1px solid black;" ReadOnly="True" Width="50px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:Button ID="Button4" runat="server" Text="Change" OnClick="Button4_Click" /></td>
            <td style="width: 100px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="textbox4"
                    ErrorMessage="only numbers allowed" ValidationExpression="\d+"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
                Non A/C</td>
            <td style="width: 65px">
                <asp:TextBox ID="TextBox5" runat="server" Style="border:none; border-bottom:1px solid black;" ReadOnly="True" Width="50px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:Button ID="Button5" runat="server" Text="Change" OnClick="Button5_Click" /></td>
            <td style="width: 100px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="textbox5"
                    ErrorMessage="only numbers allowed" ValidationExpression="\d+" Width="160px"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td style="width: 100px">
                Driver Charge</td>
            <td style="width: 65px">
                <asp:TextBox ID="TextBox6" runat="server" Style="border:none; border-bottom:1px solid black;" ReadOnly="True" Width="50px"></asp:TextBox></td>
            <td style="width: 100px">
                <asp:Button ID="Button6" runat="server" Text="Change" OnClick="Button6_Click" /></td>
            <td style="width: 100px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="textbox6"
                    ErrorMessage="only numbers allowed" ValidationExpression="\d+" Width="154px"></asp:RegularExpressionValidator></td>
        </tr>
    </table>
</asp:Content>

