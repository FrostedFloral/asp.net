<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Gravesites.aspx.cs" Inherits="Gravesites" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphInput" Runat="Server">
    <table style="text-align:right;">
        <tr><th>Search</th></tr>
        <tr><td>Cemetery</td><td><asp:TextBox ID="txtCemetery" runat="server" Width="140px"></asp:TextBox></td></tr>
        <tr><td>First Name</td><td><asp:TextBox ID="txtFName" runat="server" Width="140px"></asp:TextBox></td></tr>
        <tr><td>Last Name</td><td><asp:TextBox ID="txtLName" runat="server" Width="140px"></asp:TextBox></td></tr>
        <tr><td></td><td><asp:Button runat="server" ID="Button1" Text="Search" onclick="btnSearch_Click" /><br /></td></tr>
    </table>


    <asp:GridView runat="server" ID="gvGravestones" AutoGenerateColumns="false" >
        <Columns>
            <asp:BoundField DataField="FName" HeaderText="First Name"  />
            <asp:BoundField DataField="LName" HeaderText="Last Name" />
            <asp:BoundField DataField="Dob" HeaderText="Day of birth" />
            <asp:BoundField DataField="Dod" HeaderText="Day of death" />
            <asp:BoundField DataField="Cemetery" HeaderText="Cemetery" />
            <asp:HyperLinkField Text="More Details" DataNavigateUrlFormatString="Gravestone.aspx?Grave_ID={0}" DataNavigateUrlFields="GravestoneID"/>
        </Columns>

    </asp:GridView>
</asp:Content>

