<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <asp:Repeater ID="listResult" runat="server">
            <HeaderTemplate>
                <table>
            </HeaderTemplate>
            <ItemTemplate>
                    <tr id="trQuestion" runat="server" visible='<%# !isShowQuestion(int.Parse(Eval("surveyCatalog.surveyCatalogQuestionNo").ToString())) %>'>
                        <td style="background:#CCFFCC"><%# Eval("surveyCatalog.surveyCatalogQuestionAlias") %></td>
                        <td style="background:#CCFFCC"></td>
                        <td style="background:#CCFFCC"><%# Eval("surveyCatalogQuestion.surveyCatalogQuestionContents") %></td>
                        <td style="background:#CCFFCC">점수</td>
                    </tr>
                    <tr>
                        <td></td>
                        <td><%# Eval("surveyCatalog.surveyCatalogAnswerAlias") %></td>
                        <td><%# Eval("surveyCatalogAnswer.surveyCatalogAnswerContents") %></td>
                        <td><%# Eval("surveyCatalog.score") %></td>
                    </tr>
            </ItemTemplate>
            <FooterTemplate>
                </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    <table>
        <tr>
            <td>1</td>
        </tr>
    </table>
</form>
</body>
</html>
