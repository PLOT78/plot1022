<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserCashFlow.aspx.cs" Inherits="UserMgmt_v0002_UserCashFlow" %>
<%@ Register src="../../Top.ascx" tagname="Top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link href="../../Content/Table.css" rel="stylesheet" type="text/css" />
    <link href="../../Content/jquery.sweet-modal.min.css" rel="stylesheet" type="text/css" />

    <script src="../../Scripts/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="../../Scripts/jquery.sweet-modal.min.js" type="text/javascript"></script>

    <script src="../../Scripts/top.js" type="text/javascript"></script>

    <script type="text/javascript">

        var home    = '<%= base.home %>';
        var userId = '<%= base.userVo.user.userId %>';

        $(document).ready(function () {

            Top.DataBind(home);
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server">
            <Services>
                 <asp:ServiceReference Path="~/WS/UserFinance.asmx" InlineScript="true" />
            </Services>
        </asp:ScriptManager>
        <div>
            <uc1:Top ID="Top1" runat="server" />
            <div style="width:1024px;">
                * <%= uiTitle %>
                <hr />
            </div>
            <br />
            <div>

                <table style="width:1024px;">
                    <thead>   
                        <tr>
                            <th style="width:500px;">소득</th>
                            <th style="width:24px;"></th>
                            <th style="width:500px;">지출</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr style="vertical-align:top">
                            <td style="width:500px;">
                                    <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">근로소득</th>
                                            <th style="width:200px;">550</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">김OO급여</td>
                                            <td style="width:200px;">350</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">안OO급여</td>
                                            <td style="width:200px;">200</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">상여금,보너스</td>
                                            <td style="width:200px;">0</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                            <td style="width:24px;"></td>
                            <td style="width:500px;">
                                <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">저축 및 투자</th>
                                            <th style="width:200px;">185</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">적금</td>
                                            <td style="width:200px;">100</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">예금</td>
                                            <td style="width:200px;">0</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">펀드</td>
                                            <td style="width:200px;">0</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">주식</td>
                                            <td style="width:200px;">0</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">채권</td>
                                            <td style="width:200px;">0</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">보장성 보험</td>
                                            <td style="width:200px;">15</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">저축성 보험</td>
                                            <td style="width:200px;">40</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">연금</td>
                                            <td style="width:200px;">30</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                        <tr style="vertical-align:top">
                            <td style="width:500px;">
                                    <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">사업소득</th>
                                            <th style="width:200px;">0</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">사업소득</td>
                                            <td style="width:200px;">0</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                            <td style="width:24px;"></td>
                            <td style="width:500px;">
                                <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">고정지출</th>
                                            <th style="width:200px;">275</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">신용카드</td>
                                            <td style="width:200px;">100</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">4대보험</td>
                                            <td style="width:200px;">35</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">월세(관리비)</td>
                                            <td style="width:200px;">20</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">신용대출</td>
                                            <td style="width:200px;">0</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">담보대출</td>
                                            <td style="width:200px;">40</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">통신비</td>
                                            <td style="width:200px;">20</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">식비</td>
                                            <td style="width:200px;">50</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">세금</td>
                                            <td style="width:200px;">10</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">교육및보육비</td>
                                            <td style="width:200px;">0</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">교통비</td>
                                            <td style="width:200px;">0</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                        <tr style="vertical-align:top">
                            <td style="width:500px;">
                                    <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">투자소득</th>
                                            <th style="width:200px;">0</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">투자소득</td>
                                            <td style="width:200px;">0</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                            <td style="width:24px;"></td>
                            <td style="width:500px;">
                                <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">변동지출</th>
                                            <th style="width:200px;">80</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">경조사비</td>
                                            <td style="width:200px;">30</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">의료비</td>
                                            <td style="width:200px;">20</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">기타생활비</td>
                                            <td style="width:200px;">30</td>
                                        </tr>
                                     </tbody>
                                </table>
                            </td>
                        </tr>
                        <tr style="vertical-align:top">
                            <td style="width:500px;">
                                    <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">이자소득</th>
                                            <th style="width:200px;">0</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">이자소득</td>
                                            <td style="width:200px;">0</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                            <td style="width:24px;"></td>
                            <td style="width:500px;">
                                <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">미파악지출</th>
                                            <th style="width:200px;">10</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">미파악지출</td>
                                            <td style="width:200px;">10</td>
                                        </tr>
                                     </tbody>
                                </table>
                            </td>
                        </tr>
                        <tr style="vertical-align:top">
                            <td style="width:500px;">
                                    <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">기타소득</th>
                                            <th style="width:200px;">0</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">기타소득</td>
                                            <td style="width:200px;">0</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                            <td style="width:24px;"></td>
                            <td style="width:500px;">
                            </td>
                        </tr>
                        <tr style="vertical-align:top">
                            <td style="width:500px;">
                                    <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">총수입계</th>
                                            <th style="width:200px;">550</th>
                                        </tr>
                                    </thead>
                                </table>
                            </td>
                            <td style="width:24px;"></td>
                            <td style="width:500px;">
                                <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">총지출계</th>
                                            <th style="width:200px;">550</th>
                                        </tr>
                                    </thead>
                                </table>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
