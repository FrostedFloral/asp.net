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
        <asp:Label ID="lblUser" runat="server" Text=""></asp:Label>
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
            <!--first and last name fields are required-->
            <tr><td></td><td><asp:RequiredFieldValidator ID="rfvFName" class="error" runat="server" ErrorMessage="A first name is required." ControlToValidate="txtFName"></asp:RequiredFieldValidator></td></tr>
            <tr><td>Middle Name</td><td><asp:TextBox ID="txtMName" runat="server"></asp:TextBox></td></tr>
            <tr><td>Last Name</td><td><asp:TextBox ID="txtLName" runat="server"></asp:TextBox></td></tr>
            <tr><td></td><td><asp:RequiredFieldValidator ID="rfvLName" class="error" runat="server" ErrorMessage="A last name is required." ControlToValidate="txtLName"></asp:RequiredFieldValidator></td></tr>
            <tr><td colspan="2"><h2 style="text-align:left;">Location</h2></td></tr>
            <tr><td>Street</td><td><asp:TextBox ID="txtStreet1" runat="server"></asp:TextBox></td></tr>
            <tr><td></td><td><asp:TextBox ID="txtStreet2" runat="server" placeholder="2ndstreet"></asp:TextBox></td></tr>
            <tr><td>City</td><td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td></tr>
            <tr><td>State</td><td><asp:TextBox ID="txtState" runat="server"></asp:TextBox></td></tr>
            <!--state field needs 2 alpha characters, full stop-->
            <tr><td><asp:RequiredFieldValidator ID="rfvState" class="error" runat="server" ErrorMessage="Empty State" ControlToValidate="txtState"></asp:RequiredFieldValidator></td><td><asp:RegularExpressionValidator ID="revState" class="error" runat="server" ErrorMessage="please use 2 character state" ValidationExpression="^[a-zA-Z]{2}?$" ControlToValidate="txtState"></asp:RegularExpressionValidator></td></tr>
            <tr><td>Zip</td><td><asp:TextBox ID="txtZip" runat="server"></asp:TextBox></td></tr>
            <!--zip needs to be within the 5 or 5-4 range-->
            <tr><td><asp:RequiredFieldValidator ID="rfvZip" class="error" runat="server" ErrorMessage="Empty zip" ControlToValidate="txtZip"></asp:RequiredFieldValidator></td><td><asp:RegularExpressionValidator ID="revZip" class="error" runat="server" ErrorMessage="invalid zip" ValidationExpression="^\d{5}(?:[-\s]\d{4})?$" ControlToValidate="txtZip"></asp:RegularExpressionValidator></td></tr>
            <tr><td>Country</td><td><asp:TextBox ID="txtCountry" runat="server"></asp:TextBox></td></tr>
            <tr><td colspan="2"><h2 style="text-align:left;">Contact</h2></td></tr>
            <tr><td>Phone</td><td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td></tr>
            <tr><td>Email</td><td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td></tr>
            <tr><td><asp:RequiredFieldValidator ID="rfvEmail" class="error" runat="server" ErrorMessage="Empty email" ControlToValidate="txtEmail"></asp:RequiredFieldValidator></td><td><asp:RegularExpressionValidator ID="revEmail" class="error" runat="server" ErrorMessage="invalid email format" ControlToValidate="txtEmail" ValidationExpression="[\w\.-]+(\+[\w-]*)?@([\w-]+\.)+[\w-]+"></asp:RegularExpressionValidator></td></tr>
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
    <!--even though we've validated a good chunk of the fields with the use of validators, it doesn't hurt to validate them further with the server side code aswell
        we do this, as the addition load is miniscule in resources, not all users will be using the same browser and resources that the developemnt used. There is a possiblity things
        will not work on a global level, so it's best to validate offten.-->
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" CausesValidation="false" />


</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphRightContent" Runat="Server">
            <asp:Label ID="lblDisplay" runat="server" Text="Output"></asp:Label>
            <asp:ValidationSummary ID="vsAdd" runat="server" ShowMessageBox="False" />
</asp:Content>
