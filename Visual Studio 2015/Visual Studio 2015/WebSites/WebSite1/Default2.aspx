<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 27%;
        }
        .auto-style2 {
            width: 16px;
        }
        .auto-style3 {
            width: 41px;
        }
        .auto-style4 {
            margin-left: 0px;
        }
        .auto-style5 {
            width: 115px;
        }
        .auto-style6 {
            width: 322px;
        }
        .auto-style7 {
            margin-left: 680px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <p class="auto-style7">
            The Calculator</p>
    
    </div>
        <table align="center" class="auto-style1">
            <tr>
                <td colspan="4">
                    <asp:TextBox ID="Result" runat="server" Height="80px" Width="403px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" colspan="1">
                    <asp:Button ID="Button10" runat="server" Text="*" Width="100px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Button11" runat="server" Text="/" Width="100px" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="Button12" runat="server" CssClass="auto-style4" Text="+" Width="100px" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="Button13" runat="server" Height="21px" Text="-" Width="100px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button7" runat="server" Text="7" Width="100px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Button8" runat="server" Text="8" Width="100px" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="Button9" runat="server" Text="9" Width="100px" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="Button16" runat="server" Width="100px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button4" runat="server" Text="4" Width="100px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Button5" runat="server" Text="5" Width="100px" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="Button6" runat="server" Text="6" Width="100px" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="Button14" runat="server" Text="Clear" Width="100px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" Text="1" Width="100px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Button2" runat="server" Text="2" Width="100px" />
                </td>
                <td class="auto-style5">
                    <asp:Button ID="Button3" runat="server" Text="3" Width="100px" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="Button15" runat="server" Text="=" Width="100px" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
