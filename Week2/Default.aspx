<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="hLinks" Runat="Server">
    <div id="hLogo" runat="server"><a href="Default.aspx">ASP.NET Webforms</a></div>
            <div id="hNav" runat="server">
                <div class="hNavLink"><a href="About.aspx">About</a></div>
                <div class="hNavLink"><a href="Controls/ContactMgr.aspx">Person</a></div>
            </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphUser" Runat="Server">   
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphLeftContent" Runat="Server">
    HELLO!~<br />
    WELCOME TO THE MAIN PAGE<br /><br />
    Go elsewhere<br />
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphRightContent" Runat="Server">
</asp:Content>