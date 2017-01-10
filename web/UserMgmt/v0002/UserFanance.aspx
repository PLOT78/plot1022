<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserFanance.aspx.cs" Inherits="UserMgmt_v0002_UserFanance" %>
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
        var userId  = '<%= base.userVo.user.userId %>';

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
                            <th style="width:500px;">자산</th>
                            <th style="width:24px;"></th>
                            <th style="width:500px;">부채 및 순자산</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr style="vertical-align:top">
                            <td style="width:500px;">
                                 <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">현금성자산</th>
                                            <th style="width:200px;">3,000</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">CMA,MMF,수시입출금통장</td>
                                            <td style="width:200px;">1,500</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">정기적금</td>
                                            <td style="width:200px;">500</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">정기예금</td>
                                            <td style="width:200px;">1,000</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                            <td style="width:24px;"></td>
                            <td style="width:500px;">
                                <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">단기부채</th>
                                            <th style="width:200px;">700</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">신용카드잔액</td>
                                            <td style="width:200px;">1,000</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">마이너스통장</td>
                                            <td style="width:200px;">300</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">신용대출잔액</td>
                                            <td style="width:200px;">500</td>
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
                                            <th style="width:300px;">투자자산</th>
                                            <th style="width:200px;">4,000</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">주식,채권</td>
                                            <td style="width:200px;">500</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">펀드,ELS,랩어카운트</td>
                                            <td style="width:200px;">1,500</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">연금,저축성보험</td>
                                            <td style="width:200px;">2,000</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">투자용부동산</td>
                                            <td style="width:200px;">0</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">기타투자상품(골프회원권등)</td>
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
                                            <th style="width:300px;">장기부채</th>
                                            <th style="width:200px;">10,000</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">주택담보대출</td>
                                            <td style="width:200px;">10,000</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">투자용부동산담보대출</td>
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
                                            <th style="width:300px;">사용자산</th>
                                            <th style="width:200px;">27,000</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">거주주택</td>
                                            <td style="width:200px;">25,000</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">자동차</td>
                                            <td style="width:200px;">2,000</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                            <td style="width:24px;"></td>
                            <td style="width:500px;">
                                <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">총부채계</th>
                                            <th style="width:200px;">10,700</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                        <tr style="vertical-align:top">
                            <td style="width:500px;">
                                 <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">기타자산</th>
                                            <th style="width:200px;">4,500</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td style="width:300px;">퇴직금</td>
                                            <td style="width:200px;">3,000</td>
                                        </tr>
                                        <tr>
                                            <td style="width:300px;">국민연금/공무원연금</td>
                                            <td style="width:200px;">1,500</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>
                            <td style="width:24px;"></td>
                            <td style="width:500px;">
                                <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">순자산</th>
                                            <th style="width:200px;">27,800</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                    </tbody>
                                </table>
                            </td>
                        </tr>
                        <tr style="vertical-align:top">
                            <td style="width:500px;">
                                 <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">총자산</th>
                                            <th style="width:200px;">38,500</th>
                                        </tr>
                                    </thead>
                                </table>
                            </td>
                            <td style="width:24px;"></td>
                            <td style="width:500px;">
                                <table>
                                    <thead>   
                                        <tr>
                                            <th style="width:300px;">부채와순자산</th>
                                            <th style="width:200px;">38,500</th>
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
