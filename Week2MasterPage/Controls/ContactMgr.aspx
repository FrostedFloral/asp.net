<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ContactMgr.aspx.cs" Inherits="ContactMgr" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="hLinks" Runat="Server">
    <div id="hLogo" runat="server"><a href="../Default.aspx">ASP.NET Webforms</a></div>
            <div id="hNav" runat="server">
                <div class="hNavLink"><a href="../About.aspx">About</a></div>
                <div class="hNavLink"><a href="ContactMgr.aspx">Persons</a></div>
            </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphUser" Runat="Server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphLeftContent" Runat="Server">
    <h1>Person</h1>
        <h2>Name</h2>
        <asp:RadioButtonList ID="rblTitle" runat="server" RepeatColumns="3">
            <asp:ListItem>Mr.</asp:ListItem>
            <asp:ListItem>Mrs.</asp:ListItem>
            <asp:ListItem>Ms.</asp:ListItem>
        </asp:RadioButtonList>
        <table>
            <tr><td>First Name</td><td><asp:TextBox ID="txtFName" runat="server"></asp:TextBox></td></tr>
            <tr><td>Middle Name</td><td><asp:TextBox ID="txtMName" runat="server"></asp:TextBox></td></tr>
            <tr><td>Last Name</td><td><asp:TextBox ID="txtLName" runat="server"></asp:TextBox></td></tr>
            <tr><td colspan="2"><h2 style="text-align:left;">Location</h2></td></tr>
            <tr><td>Street</td><td><asp:TextBox ID="txtStreet1" runat="server"></asp:TextBox></td></tr>
            <tr><td></td><td><asp:TextBox ID="txtStreet2" runat="server" placeholder="2ndstreet"></asp:TextBox></td></tr>
            <tr><td>City</td><td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td></tr>
            <tr><td>State</td><td><asp:DropDownList ID="ddlState" runat="server">
                                    <asp:ListItem>RI</asp:ListItem>
                                    <asp:ListItem>Rhode Island</asp:ListItem>
                                  </asp:DropDownList></td></tr>
            <tr><td>Zip</td><td><asp:TextBox ID="txtZip" runat="server"></asp:TextBox></td></tr>
            <tr><td>Country</td><td><asp:TextBox ID="txtCountry" runat="server"></asp:TextBox></td></tr>
            <tr><td colspan="2"><h2 style="text-align:left;">Contact</h2></td></tr>
            <tr><td>Phone</td><td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td></tr>
            <tr><td>Email</td><td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td></tr>
            <tr><td colspan="2"><h2 style="text-align:left;">Info</h2></td></tr>
        </table>
   <div id="info">
    Birthday
       <asp:Calendar ID="calBirth" runat="server" Visible="true"></asp:Calendar>
    Anniversery 
        <asp:Calendar ID="calAnni" runat="server" Visible="true"></asp:Calendar>     
   </div>
    <br />
           <asp:Button ID="btnAdd" runat="server" Text="Add Person" OnClick="btnAdd_Click" />


</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphRightContent" Runat="Server">
            <asp:Label ID="lblDisplay" runat="server" Text="Output"></asp:Label>
</asp:Content>
