<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 468px;
        }

        .auto-style2 {
            width: 125px;
        }

        .auto-style3 {
            width: 75px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="ValuesText" runat="server" BorderStyle="Solid" Font-Size="XX-Large" Height="35px" Width="458px" Wrap="False" Font-Bold="True"></asp:TextBox>
        <br />
        <asp:TextBox ID="Calc" runat="server" Height="22px" Width="458px" Wrap="False" BorderStyle="Solid" Font-Size="X-Large" Font-Bold="True"></asp:TextBox>
        <div>
        <table class="auto-style1">

            <tr>
               
    <td class="auto-style2">
        <asp:Button ID="ButtonNum7" runat="server" Height="54px" OnClick="ButtonNum7_Click" Text="7" Width="125px" Font-Bold="True"  BorderStyle="Solid"  Font-Size="XX-Large" />
    </td>
                <td class="auto-style2">
                    <asp:Button ID="ButtonNum8" runat="server" Height="54px" OnClick="ButtonNum8_Click" Text="8" Width="125px" Font-Bold="True" BorderStyle="Solid" Font-Size="XX-Large" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="ButtonNum9" runat="server" Height="54px" OnClick="ButtonNum9_Click" Text="9" Width="125px" Font-Bold="True" BorderStyle="Solid"  Font-Size="XX-Large" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="ButtonSplit" runat="server" Height="54px" OnClick="ButtonSplit_Click" Text="/" ViewStateMode="Enabled" Width="75px" Font-Bold="True"  BorderStyle="Solid"  Font-Size="XX-Large" />
                </td>
            </tr>
            <tr>
                
    <td class="auto-style2">
        <asp:Button ID="ButtonNum4" runat="server" Height="54px" OnClick="ButtonNum4_Click" Text="4" Width="125px" Font-Bold="True"  BorderStyle="Solid"  Font-Size="XX-Large" />
    </td>
                <td class="auto-style2">
                    <asp:Button ID="ButtonNum5" runat="server" Height="54px" OnClick="ButtonNum5_Click" Text="5" Width="125px" Font-Bold="True"  BorderStyle="Solid" Font-Size="XX-Large" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="ButtonNum6" runat="server" Height="54px" OnClick="ButtonNum6_Click" Text="6" Width="125px" Font-Bold="True"  BorderStyle="Solid"   Font-Size="XX-Large" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="ButtonMultiple" runat="server" Height="54px" OnClick="ButtonNumMultiple_Click" Text="x" ViewStateMode="Enabled" Width="75px" Font-Bold="True" BorderStyle="Solid"  Font-Size="XX-Large" />
                </td>
            </tr>
            <tr>
               
                <td class="auto-style2">
                    <asp:Button ID="ButtonNum1" runat="server" Height="54px" OnClick="ButtonNum1_Click" Text="1" Width="125px" Font-Bold="True" BorderStyle="Solid" Font-Size="XX-Large" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="ButtonNum2" runat="server" Height="54px" OnClick="ButtonNum2_Click" Text="2" Width="125px" Font-Bold="True" BorderStyle="Solid" Font-Size="XX-Large" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="ButtonNum3" runat="server" Height="54px" OnClick="ButtonNum3_Click" Text="3" Width="125px" Font-Bold="True" BorderStyle="Solid" Font-Size="XX-Large" />
                </td>
                <td class="auto-style3">
                    <asp:Button ID="ButtonMinus" runat="server" Height="54px" Text="-" OnClick="ButtonMinus_Click" ViewStateMode="Enabled" Width="75px" Font-Bold="True" BorderStyle="Solid" Font-Size="XX-Large" />

                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="ButtonEqualTo" runat="server" Height="54px" Text="=" OnClick="ButtonEqualTo_Click" ViewStateMode="Enabled" Width="255px" BorderStyle="Solid" Font-Bold="True" Font-Size="XX-Large" />

                </td>
                <td class="auto-style2">
                    <asp:Button ID="ButtonC" runat="server" Height="54px" Text="C" OnClick="ButtonC_Click" ViewStateMode="Enabled" Width="125px" BorderStyle="Solid" Font-Bold="True" Font-Size="29pt" />
                </td>
                <td>
                    <asp:Button ID="ButtonPlus" runat="server" Height="54px" Text="+" OnClick="ButtonPlus_Click" ViewStateMode="Enabled" Width="73px" BorderStyle="Solid" Font-Bold="True" Font-Size="XX-Large" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
