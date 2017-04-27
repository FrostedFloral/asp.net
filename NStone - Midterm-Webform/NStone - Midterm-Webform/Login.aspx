<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphInput" Runat="Server">
    <table style="text-align:right;">
        <tr><th>Please Log in</th></tr>
        <tr><td>User</td><td><asp:TextBox ID="txtUserName" runat="server" Width="140px" placeholder="User Name"></asp:TextBox></td></tr>
        <tr><td>Password</td><td><asp:TextBox ID="txtPassword" runat="server" Width="140px" placeholder="Password" TextMode="Password"></asp:TextBox></td></tr>
        <tr><td></td><td><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click"/><br /></td></tr>
    </table>

    <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>
</asp:Content>