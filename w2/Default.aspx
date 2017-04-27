<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphUser" Runat="Server">   
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphLeftContent" Runat="Server">
    <h1>Person</h1>
        <table>
            <tr><td><h2>Name</h2></td></tr>
            <tr><td>First Name</td><td><asp:TextBox ID="txtFName" runat="server"></asp:TextBox></td></tr>
            <tr><td>Middle Name</td><td><asp:TextBox ID="txtMName" runat="server"></asp:TextBox></td></tr>
            <tr><td>Last Name</td><td><asp:TextBox ID="txtLName" runat="server"></asp:TextBox></td></tr>
            <tr><td><h2>location</h2></td></tr>
            <tr><td>Street</td><td><asp:TextBox ID="txtStreet1" runat="server"></asp:TextBox></td></tr>
            <tr><td>Street</td><td><asp:TextBox ID="txtStreet2" runat="server" Text="optional"></asp:TextBox></td></tr>
            <tr><td>City</td><td><asp:TextBox ID="txtCity" runat="server"></asp:TextBox></td></tr>
            <tr><td>State</td><td><asp:DropDownList ID="ddlState" runat="server"></asp:DropDownList></td></tr>
            <tr><td>Zip</td><td><asp:TextBox ID="txtZip" runat="server"></asp:TextBox></td></tr>
            <tr><td>Country</td><td><asp:TextBox ID="txtCountry" runat="server"></asp:TextBox></td></tr>
            <tr><td><h2>Contact</h2></td></tr>
            <tr><td>Phone</td><td><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td></tr>
            <tr><td>Email</td><td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td></tr>
        </table>
    <table>
            <tr><td><h2>Name</h2></td></tr>
            <tr><td>First Name</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td></tr>
            <tr><td>Middle Name</td><td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td></tr>
            <tr><td>Last Name</td><td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td></tr>
            <tr><td><h2>location</h2></td></tr>
            <tr><td>Street</td><td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td></tr>
            <tr><td>Street</td><td><asp:TextBox ID="TextBox5" runat="server" Text="optional"></asp:TextBox></td></tr>
            <tr><td>City</td><td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td></tr>
            <tr><td>State</td><td><asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td></tr>
            <tr><td>Zip</td><td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td></tr>
            <tr><td>Country</td><td><asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td></tr>
            <tr><td><h2>Contact</h2></td></tr>
            <tr><td>Phone</td><td><asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td></tr>
            <tr><td>Email</td><td><asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td></tr>
        </table>
       <asp:Button ID="btnAdd" runat="server" Text="Add Person" OnClick="btnAdd_Click" />
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphRightContent" Runat="Server">
    <asp:Label ID="lblDisplay" runat="server" Text=""></asp:Label>  
</asp:Content>