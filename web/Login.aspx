<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:TextBox ID="txtID" runat="server" TabIndex="1">USER001</asp:TextBox>
                </td>
                <td rowspan="2" style="vertical-align:middle">
                    <asp:Button ID="btnLogin" runat="server" Text="로그인" Height="46px" OnClick="btnLogin_Click" TabIndex="3" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="txtPass" runat="server" TabIndex="2" TextMode="Password">1</asp:TextBox>
                </td>
            </tr>
        </table>
    </div>
    <asp:Label ID="lbResult" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
