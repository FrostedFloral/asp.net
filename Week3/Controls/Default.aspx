<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Controls_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphUser" Runat="Server">
    <div id="hLogo" runat="server"><a href="../Default.aspx">ASP.NET Webforms</a></div>
            <div id="hNav" runat="server">
                <div class="hNavLink"><a href="../About.aspx">About</a></div>
                <div class="hNavLink"><a href="ContactMgr.aspx">Persons</a></div>
            </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphLeftContent" Runat="Server">
    <table>
        <tr><td colspan="2">Please sign in:</td></tr>
        <tr>
            <td style="text-align:right;">User</td>
            <td><asp:TextBox ID="txtUser" runat="server"></asp:TextBox></td>
        </tr>        
        <tr>
            <td>Password</td>
            <td><asp:TextBox ID="txtPW" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>        <tr>
            <td></td>
            <td><asp:Button ID="btnLogin" runat="server" Text="Log in" Width="125px" OnClick="btnLogin_Click" /></td>
        </tr>
    </table>
    <asp:Label ID="lblFeedback" runat="server" Text="text fields are case sensitive"></asp:Label>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphRightContent" Runat="Server">
</asp:Content>

