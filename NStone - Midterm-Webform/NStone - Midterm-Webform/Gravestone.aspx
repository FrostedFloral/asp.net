<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Gravestone.aspx.cs" Inherits="Gravestone" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cphInput" Runat="Server">
Relationship/Title<br />
    <table>
    <tr><td><asp:RadioButton ID="rbtnMr" runat="server" GroupName="Title" />Mr.</td>
    <td><asp:RadioButton ID="rbtnMs" runat="server" GroupName="Title" />Ms.</td>
    <td><asp:RadioButton ID="rbtnMrs" runat="server" GroupName="Title" />Mrs.</td> </tr>
    <tr><td><asp:RadioButton ID="rbtnMiss" runat="server" GroupName="Title" />Miss.</td>
    <td><asp:RadioButton ID="rbtnDr" runat="server" GroupName="Title" />Dr.</td>
    <td><asp:RadioButton ID="rbtnRev" runat="server" GroupName="Title" />Rev.</td> </tr>
    </table>
Name<br />
    <asp:TextBox ID="txtFName" runat="server" Width="80px" placeholder="First name"></asp:TextBox>
    <asp:TextBox ID="txtMName" runat="server" Width="80px" placeholder="Middle"></asp:TextBox>
    <asp:TextBox ID="txtLName" runat="server" Width="80px" placeholder="Last"></asp:TextBox><br />
DOB (Date of Birth)<br />
    <asp:TextBox ID="txtDOBMonth" runat="server" Width="24px" MaxLength="2" placeholder="MM"></asp:TextBox>
    <asp:TextBox ID="txtDOBDay" runat="server" Width="24px" MaxLength="2" placeholder="DD"></asp:TextBox>
    <asp:TextBox ID="txtDOBYear" runat="server" Width="38px" MaxLength="4" placeholder="YYYY"></asp:TextBox><br />
DOD (Date of Death)<br />
    <asp:TextBox ID="txtDODMonth" runat="server" Width="24px" placeholder="MM"></asp:TextBox>
    <asp:TextBox ID="txtDODDay" runat="server" Width="24px" placeholder="DD"></asp:TextBox>
    <asp:TextBox ID="txtDODYear" runat="server" Width="38px" placeholder="YYYY"></asp:TextBox><br />
Military Branch<br />
    <asp:DropDownList ID="ddlMilitary" runat="server"></asp:DropDownList><br />
Cemetery<br />
    <asp:DropDownList ID="ddlCemetery" runat="server"></asp:DropDownList><br />
Stone Condition<br />
    <asp:DropDownList ID="ddlStone" runat="server"></asp:DropDownList><br />
Notes<br />
    <asp:TextBox ID="txtNotes" runat="server" TextMode="MultiLine" Width="400px" Height="50px" placeholder="..."></asp:TextBox><br />
Today's date (last edited/visited)<br />
    <asp:TextBox ID="txtVisitMonth" runat="server" Width="24px" MaxLength="2" placeholder="MM" ReadOnly="True"></asp:TextBox>
    <asp:TextBox ID="txtVisitDay" runat="server" Width="24px" MaxLength="2" placeholder="DD" ReadOnly="True"></asp:TextBox>
    <asp:TextBox ID="txtVisitYear" runat="server" Width="38px" MaxLength="4" placeholder="YYYY" ReadOnly="True"></asp:TextBox><br /><br /><br />

    <asp:Button ID="btnAction" runat="server" Text="Add" OnClick="btnAction_Click" /><br /><br /><br /><br /><br /><br />
    <asp:Button ID="btnDelete" runat="server" Text="!!!DELETE!!!" Visible="False" OnClick="btnDelete_Click" /><br />
    <asp:Label ID="lblFeedback" runat="server" Text=""></asp:Label>
</asp:Content>

