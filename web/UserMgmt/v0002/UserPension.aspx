<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserPension.aspx.cs" Inherits="UserMgmt_v0002_UserPension" %>
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

            // 초기화 클릭시
            $("#btnInit").bind("click", function () {

                $('#list > tbody').children().remove();
                $("#txtAge").val(0);        // 나이
                $("#txtPayment").val(0);    // 납입액
                $("#txtPer").val(0);        // 기간
                $("#txtRate").val(0);       // 적립액
            });

            // 조회 클릭시
            $("#btnSearch").bind("click", function () {
                fn_search();
            });
        });

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 조회
        ///////////////////////////////////////////////////////////////////////////////////////////
        function fn_search() {

            var userPensionVo = {};
            userPensionVo.userPension = {};
            userPensionVo.userPension.age = $("#txtAge").val();         // 나이
            userPensionVo.userPension.payment = $("#txtPayment").val(); // 납입액
            userPensionVo.userPension.per = $("#txtPer").val();         // 기간
            userPensionVo.userPension.rate = $("#txtRate").val();       // 적립액

            UserPension.selectListUserPensionVo(
                userPensionVo,
                function (result) {

                    debugger;

                    $('#list > tbody').children().remove();

                    var userPensionVoList = result.userPensionVoList;
                    var data = "";

                    for (var i = 0; i < userPensionVoList.length; i++) {

                        var userPension = userPensionVoList[i].userPension;

                        data = "";
                        data += "<tr>";

                        data += "<td>" + userPension.age + "</td>";
                        data += "<td>" + comma(userPension.payment) + "</td>";
                        data += "<td>" + userPension.per + "</td>";
                        data += "<td>" + userPension.rate + "</td>";
                        data += "<td>" + comma(userPension.accumulate) + "</td>";

                        data += "</tr>";

                        $('#list > tbody:last').append(data);

                    }

                }, function (error) {
                    $.sweetModal(error._message);
                    return;
                }
            );
        }

        function comma(str) {
            str = String(str);
            return str.replace(/(\d)(?=(?:\d{3})+(?!\d))/g, '$1,');
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server">
             <Services>
                <asp:ServiceReference Path="~/WS/UserPension.asmx" InlineScript="true" />
             </Services>
        </asp:ScriptManager>
        <div>
            <uc1:Top ID="Top1" runat="server" />
            <div style="width:1024px;">
                * <%= uiTitle %>
                <hr />
            </div>
            
            <div style="width:1024px;">
                <table>
                    <thead>   
                        <tr>
                            <th style="width:256px">연령</th>
                            <td style="width:256px"><input id="txtAge" type="text" value="0" /></td>
                            <th style="width:256px">납입액</th>
                            <td style="width:256px"><input id="txtPayment" type="text" value="0" /></td>
                        </tr>
                        <tr>
                            <th style="width:256px">기간(년)</th>
                            <td style="width:256px"><input id="txtPer" type="text" value="0" /></td>
                            <th style="width:256px">이율</th>
                            <td style="width:256px"><input id="txtRate" type="text" value="0" /></td>
                        </tr>
                    </thead>
                </table>
            </div>
            <br />
            <div style="width:1024px;" align="right">
                <input id="btnInit"     type="button" value="초기화" />
                <input id="btnSearch"   type="button" value="조회" />
            </div>
            <br />
            <div style="width:1024px;">
                <table id="list">
                    <thead>   
                        <tr>
                            <th style="width:145px">연령</th>
                            <th style="width:290px">납입액</th>
                            <th style="width:145px">기간(년)</th>
                            <th style="width:145px">이율</th>
                            <th style="width:299px">적립액(연말기준)</th>
                        </tr>
                    </thead>
                    <tbody></tbody>
                </table>
            </div>
        </div>
    </form>
</body>
</html>
