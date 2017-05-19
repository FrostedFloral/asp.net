<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="hLinks" Runat="Server">
    <div id="hLogo" runat="server"><a href="Default.aspx">ASP.NET Webforms</a></div>
            <div id="hNav" runat="server">
                <div class="hNavLink"><a href="About.aspx">About</a></div>
                <div class="hNavLink"><a href="Controls/ContactMgr.aspx">Persons</a></div>
            </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphUser" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphLeftContent" Runat="Server">
    Here is a some basic ASP.NET Webform learning,<br />
    Nothing all too fancy<br />
    Nathan Stone<br />
    NEIT<br />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphRightContent" Runat="Server">
</asp:Content>

