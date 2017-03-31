<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        input{
            width:35px;
            height:35px;
        }
        #txtLCD{
            width:190px;
            height:initial;
        }
        #btnClear{
            width:100%;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblOperand" runat="server" Text=""></asp:Label>
        <asp:TextBox ID="txtLCD" runat="server">0</asp:TextBox>
        <asp:Label ID="lblMemory" runat="server" Text=""></asp:Label>
        <table>
        <tr>
            <td><asp:Button ID="butSMem" runat="server" Text="MS" OnClick="btnSMem_Click" /></td>
            <td><asp:Button ID="butCMem" runat="server" Text="MC" OnClick="btnCMem_Click" /></td>
            <td><asp:Button ID="butRMem" runat="server" Text="MR" OnClick="btnRMem_Click" /></td>
            <td><asp:Button ID="btnPlus" runat="server" Text="+" OnClick="btnPlus_Click" /></td>
            <td><asp:Button ID="btnNegPos" runat="server" Text="-/+" OnClick="btnNegPos_Click" /></td>
        </tr><tr>
            <td><asp:Button ID="btnNum7" runat="server" Text="7" OnClick="btnNum7_Click" /></td>
            <td><asp:Button ID="btnNum8" runat="server" Text="8" OnClick="btnNum8_Click" /></td>
            <td><asp:Button ID="btnNum9" runat="server" Text="9" OnClick="btnNum9_Click" /></td>
            <td><asp:Button ID="btnMinus" runat="server" Text="-" OnClick="btnMinus_Click" /></td>
            <td><asp:Button ID="btnPercent" runat="server" Text="%" OnClick="btnPercent_Click" /></td>
        </tr><tr>
            <td><asp:Button ID="btnNum4" runat="server" Text="4" OnClick="btnNum4_Click" /></td>
            <td><asp:Button ID="btnNum5" runat="server" Text="5" OnClick="btnNum5_Click" /></td>
            <td><asp:Button ID="btnNum6" runat="server" Text="6" OnClick="btnNum6_Click" /></td>
            <td><asp:Button ID="btnMulti" runat="server" Text="X" OnClick="btnMulti_Click" /></td>
            <td><asp:Button ID="btnPi" runat="server" Text="π" OnClick="btnPi_Click" /></td>
        </tr><tr>
            <td><asp:Button ID="btnNum1" runat="server" Text="1" OnClick="btnNum1_Click" /></td>
            <td><asp:Button ID="btnNum2" runat="server" Text="2" OnClick="btnNum2_Click" /></td>
            <td><asp:Button ID="btnNum3" runat="server" Text="3" OnClick="btnNum3_Click" /></td>
            <td><asp:Button ID="btnDivide" runat="server" Text="÷" OnClick="btnDivide_Click" /></td>
            <td><asp:Button ID="btnSquareR" runat="server" Text="√" OnClick="btnSquareR_Click" /></td>
        </tr><tr>
            <td><asp:Button ID="btnNum0" runat="server" Text="0" OnClick="btnNum0_Click" /></td>
            <td><asp:Button ID="btnPoint" runat="server" Text="." OnClick="btnPoint_Click" /></td>
            <td><asp:Button ID="btnEqual" runat="server" Text="=" OnClick="btnEqual_Click" /></td>
            <td colspan="8"><asp:Button ID="btnClear" runat="server" Text="ON/C" OnClick="btnClear_Click" /></td>
        </tr>
        </table>
    </div>
    </form>
</body>
</html>
