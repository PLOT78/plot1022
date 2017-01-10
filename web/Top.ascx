<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Top.ascx.cs" Inherits="Top" %>
<table>
    <thead>
        <tr>
            <th><a id="linkHome">HOME</a></th>
            <th>
                <asp:Label      ID="lbUserInfo" runat="server"></asp:Label>
                <asp:LinkButton ID="lnkLogout"  runat="server" PostBackUrl="~/Login.aspx">로그아웃</asp:LinkButton>
            </th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                <table>
                    <thead>
                        <tr>
                            <th>시스템관리</th>
                            <th>사용자관리</th>
                            <th>재무목표관리</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>메뉴추가</td>
                            <td><a id="linkUser00101">가족정보관리</a></td>
                            <td><a id="linkUser01301">연금적립액관리</a></td>
                        </tr>
                        <tr>
                            <td>메뉴추가</td>
                            <td><a id="linkUser00102">재무상태표</a></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>메뉴추가</td>
                            <td><a id="linkUser00103">현금흐름표</a></td>
                            <td></td>
                        </tr>
                    </tbody>
                </table>
            </td>
            <td></td>
        </tr>
    </tbody>
</table>
<br />