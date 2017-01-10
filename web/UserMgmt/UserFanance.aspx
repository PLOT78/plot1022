<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserFanance.aspx.cs" Inherits="UserMgmt_UserFanance" %>
<%@ Register src="../Top.ascx" tagname="Top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link href="../Content/Table.css" rel="stylesheet" type="text/css" />
    <link href="../Content/jquery.sweet-modal.min.css" rel="stylesheet" type="text/css" />

    <script src="../Scripts/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="../Scripts/jquery.sweet-modal.min.js" type="text/javascript"></script>

    <script src="../Scripts/top.js" type="text/javascript"></script>

    <script type="text/javascript">

        var home    = '<%= base.home %>';
        var userId = '<%= base.userVo.user.userId %>';

        var userFinanceVoList = null;

        $(document).ready(function () {

            Top.DataBind(home);

            fn_initData();  // 데이터 초기화

            // 전체 텍스트박스 Enter시 재무재계산
            $("input:text").keyup(function (e) {
                $(this).val($(this).val().replace(/[^0-9]/g, ""));
                $(this).val(comma(uncomma($(this).val())));
                fn_cal();
            });

            // 초기화 클릭시
            $("#btnInit").bind("click", function () {
                fn_initData();  // 데이터 초기화
            });

            // 저장 클릭시
            $("#btnUpdate").bind("click", function () {
                fn_saveData();  // 데이터 저장
            });

            
        });

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 데이터초기화
        ///////////////////////////////////////////////////////////////////////////////////////////
        function fn_initData() {
            debugger;

            var userFinanceVo = {};
            userFinanceVo.UserFinance = {};
            userFinanceVo.UserFinance.userId = userId;    // 사용자재무

            UserFinance.selectListUserFinanceVo(userFinanceVo, function (selectListResult) {
                debugger;
                userFinanceVoList = selectListResult.userFinanceVoList;

                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "ASSETS0000001"));
                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "ASSETS0000002"));

                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "ASSETS0001001"));
                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "ASSETS0001002"));
                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "ASSETS0001003"));
                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "ASSETS0001004"));
                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "ASSETS0001005"));

                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "ASSETS0002001"));
                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "ASSETS0002002"));

                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "ASSETS0003001"));
                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "ASSETS0003002"));

                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "DEBT0000001"));
                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "DEBT0000002"));

                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "DEBT0001001"));
                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "DEBT0001002"));
                fn_initDataUserFinance(fn_getUserFinance(userFinanceVoList, "DEBT0001003"));

                fn_cal();
            });
        }

        function fn_cal() {

            $("#spanSubGroupNo1").text(          comma(   uncomma($("#txtASSETS0000001").val()) * 1 + uncomma($("#txtASSETS0000002").val()) * 1     )       );
            $("#spanSubGroupNo2").text(          comma(   uncomma($("#txtASSETS0001001").val()) * 1 + uncomma($("#txtASSETS0001002").val()) * 1 
                                                        + uncomma($("#txtASSETS0001003").val()) * 1 + uncomma($("#txtASSETS0001004").val()) * 1 
                                                        + uncomma($("#txtASSETS0001005").val()) * 1                                                 )       );
            $("#spanSubGroupNo3").text(          comma(   uncomma($("#txtASSETS0002001").val()) * 1 + uncomma($("#txtASSETS0002002").val()) * 1     )       );
            $("#spanSubGroupNo4").text(          comma(   uncomma($("#txtASSETS0003001").val()) * 1 + uncomma($("#txtASSETS0003002").val()) * 1     )       );
            $("#spanSubGroupNo5").text(          comma(   uncomma($("#txtDEBT0000001").val()) * 1   + uncomma($("#txtDEBT0000002").val()) * 1       )       );
            $("#spanSubGroupNo6").text(          comma(   uncomma($("#txtDEBT0001001").val()) * 1   + uncomma($("#txtDEBT0001002").val()) * 1 
                                                        + uncomma($("#txtDEBT0001003").val()) * 1                                                   )       );



            
            // 총자산 = 현금성자산 + 투자자산 + 사용자산 + 기타자산
            $("#spanTotalAssets").text(         comma(    uncomma($("#spanSubGroupNo1").text()) * 1 + uncomma($("#spanSubGroupNo2").text()) * 1
                                                        + uncomma($("#spanSubGroupNo3").text()) * 1 + uncomma($("#spanSubGroupNo4").text()) * 1     )       );
            // 총부채계 = 단기부채 + 장기부채
            $("#spanTotalDebt").text(           comma(    uncomma($("#spanSubGroupNo5").text()) * 1 + uncomma($("#spanSubGroupNo6").text()) * 1     )       );
            // 순자산 = 총자산 - 총부채계
            $("#spanNetAssets").text(           comma(    uncomma($("#spanTotalAssets").text()) * 1 - uncomma($("#spanTotalDebt").text()) * 1       )       );
            // 부채와순자산 = 총자산
            $("#spanDebtNetAssets").text(       comma(    uncomma($("#spanTotalAssets").text()) * 1                                                 )       );
            
        }

        function comma(str) {
            str = String(str);
            return str.replace(/(\d)(?=(?:\d{3})+(?!\d))/g, '$1,');
        }

        function uncomma(str) {
            str = String(str);
            return str.replace(/[^\d]+/g, '');
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 데이터초기화(사용자재무)
        ///////////////////////////////////////////////////////////////////////////////////////////
        function fn_initDataUserFinance(userFinanceVo) {

            if ((userFinanceVo != null) && (userFinanceVo.userFinance != null) && (userFinanceVo.userFinance.userFinanceCatalogId != null)) {

                $("#span" + userFinanceVo.userFinance.userFinanceCatalogId).text(userFinanceVo.userFinanceCatalog.userFinanceCatalogNm);
                $("#txt" + userFinanceVo.userFinance.userFinanceCatalogId).val(comma(userFinanceVo.userFinance.price));
            }     
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 사용자재무 조회
        ///////////////////////////////////////////////////////////////////////////////////////////
        function fn_getUserFinance(userFinanceVoList, userFinanceCatalogId) {

            //debugger;

            var rtnUserFinanceVo = null;

            for (var i = 0; i < userFinanceVoList.length; i++) {
                var userFinanceVo = userFinanceVoList[i]

                if (userFinanceVo.userFinance.userFinanceCatalogId == userFinanceCatalogId) {
                    rtnUserFinanceVo = userFinanceVo;
                    break;
                }
            }

            // [object Object]{price: 1500, userFinanceCatalogId: "ASSETS0000001", userId: "USER001"}

            return rtnUserFinanceVo;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 사용자재무 조회
        ///////////////////////////////////////////////////////////////////////////////////////////
        function fn_setUserFinance(userId, userFinanceCatalogId, price) {

            var userFinanceVo = {};

            userFinanceVo.userFinance = {};
            userFinanceVo.userFinance.userId = userId;
            userFinanceVo.userFinance.userFinanceCatalogId = userFinanceCatalogId;
            userFinanceVo.userFinance.price = price;

            return userFinanceVo;
        }


        function fn_saveData() {

            var userFinanceListVo = {};
            userFinanceListVo.userFinanceVoList = new Array();

            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "ASSETS0000001", (uncomma($("#txtASSETS0000001").val()) * 1)));
            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "ASSETS0000002", (uncomma($("#txtASSETS0000002").val()) * 1)));

            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "ASSETS0001001", (uncomma($("#txtASSETS0001001").val()) * 1)));
            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "ASSETS0001002", (uncomma($("#txtASSETS0001002").val()) * 1)));
            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "ASSETS0001003", (uncomma($("#txtASSETS0001003").val()) * 1)));
            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "ASSETS0001004", (uncomma($("#txtASSETS0001004").val()) * 1)));
            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "ASSETS0001005", (uncomma($("#txtASSETS0001005").val()) * 1)));

            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "ASSETS0002001", (uncomma($("#txtASSETS0002001").val()) * 1)));
            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "ASSETS0002002", (uncomma($("#txtASSETS0002002").val()) * 1)));

            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "ASSETS0003001", (uncomma($("#txtASSETS0003001").val()) * 1)));
            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "ASSETS0003002", (uncomma($("#txtASSETS0003002").val()) * 1)));

            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "DEBT0000001",   (uncomma($("#txtDEBT0000001").val()) * 1)));
            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "DEBT0000002",   (uncomma($("#txtDEBT0000002").val()) * 1)));

            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "DEBT0001001",   (uncomma($("#txtDEBT0001001").val()) * 1)));
            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "DEBT0001002",   (uncomma($("#txtDEBT0001002").val()) * 1)));
            userFinanceListVo.userFinanceVoList.push(fn_setUserFinance(userId, "DEBT0001003",   (uncomma($("#txtDEBT0001003").val() )* 1)));
 
            UserFinance.updateUserFinanceVo(
                userFinanceListVo,
                function (result) {

                    if (result.commonAttr.execSuccess == false) {
                        $.sweetModal(result.commonAttr.exceptionMessage);
                        return;
                    }

                    $.sweetModal("재무상태표가 변경되었습니다.");
                    fn_initData();

                }, function (error) {
                    $.sweetModal(error._message);
                    return;
                }
            );

            debugger;
        }

        
        

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
            <div style="width:1024px;">
                <table>
                    <thead>   
                        <tr>
                            <th style="width:400px;" colspan="2">자산</th>
                            <th style="width:50px;"></th>
                            <th style="width:400px;" colspan="2">부채 및 순자산</th>
                        </tr>
                        <tr>
                            <th style="width:300px;">항목</th>
                            <th style="width:100px;">금액(만원)</th>
                            <th style="width:50px;"></th>
                            <th style="width:300px;">항목</th>
                            <th style="width:100px;">금액(만원)</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th style="width:300px;">현금성자산</th>
                            <th style="width:100px;"><span id="spanSubGroupNo1"></span></th>
                            <th style="width:50px;"></th>
                            <th style="width:300px;">단기부채</th>
                            <th style="width:100px;"><span id="spanSubGroupNo5"></span></th>
                        </tr>
                        <tr>
                            <td style="width:300px;"><span id="spanASSETS0000001"></span></td>
                            <td style="width:100px;"><input id="txtASSETS0000001" type="text" /></td>
                            <td style="width:50px;"></td>
                            <td style="width:300px;"><span id="spanDEBT0000001"></span></td>
                            <td style="width:100px;"><input id="txtDEBT0000001" type="text" /></td>
                        </tr>
                        <tr>
                            <td style="width:300px;"><span id="spanASSETS0000002"></span></td>
                            <td style="width:100px;"><input id="txtASSETS0000002" type="text" /></td>
                            <td style="width:50px;"></td>
                            <td style="width:300px;"><span id="spanDEBT0000002"></span></td>
                            <td style="width:100px;"><input id="txtDEBT0000002" type="text" /></td>
                        </tr>
                        <tr>
                            <th style="width:300px;">투자자산</th>
                            <th style="width:100px;"><span id="spanSubGroupNo2"></span></th>
                            <th style="width:50px;"></th>
                            <th style="width:300px;">장기부채</th>
                            <th style="width:100px;"><span id="spanSubGroupNo6"></span></th>
                        </tr>
                        <tr>
                            <td style="width:300px;"><span id="spanASSETS0001001"></span></td>
                            <td style="width:100px;"><input id="txtASSETS0001001" type="text" /></td>
                            <td style="width:50px;"></td>
                            <td style="width:300px;"><span id="spanDEBT0001001"></span></td>
                            <td style="width:100px;"><input id="txtDEBT0001001" type="text" /></td>
                        </tr>
                        <tr>
                            <td style="width:300px;"><span id="spanASSETS0001002"></span></td>
                            <td style="width:100px;"><input id="txtASSETS0001002" type="text" /></td>
                            <td style="width:50px;"></td>
                            <td style="width:300px;"><span id="spanDEBT0001002"></span></td>
                            <td style="width:100px;"><input id="txtDEBT0001002" type="text" /></td>
                        </tr>
                        <tr>
                            <td style="width:300px;"><span id="spanASSETS0001003"></span></td>
                            <td style="width:100px;"><input id="txtASSETS0001003" type="text" /></td>
                            <td style="width:50px;"></td>
                            <td style="width:300px;"><span id="spanDEBT0001003"></span></td>
                            <td style="width:100px;"><input id="txtDEBT0001003" type="text" /></td>
                        </tr>
                        <tr>
                            <td style="width:300px;"><span id="spanASSETS0001004"></span></td>
                            <td style="width:100px;"><input id="txtASSETS0001004" type="text" /></td>
                            <td style="width:50px;"></td>
                            <td style="width:300px;"></td>
                            <td style="width:100px;"></td>
                        </tr>
                        <tr>
                            <td style="width:300px;"><span id="spanASSETS0001005"></span></td>
                            <td style="width:100px;"><input id="txtASSETS0001005" type="text" /></td>
                            <td style="width:50px;"></td>
                            <td style="width:300px;"></td>
                            <td style="width:100px;"></td>
                        </tr>
                        <tr>
                            <th style="width:300px;">사용자산</th>
                            <th style="width:100px;"><span id="spanSubGroupNo3"></span></th>
                            <th style="width:50px;"></th>
                            <th style="width:300px;">총부채계</th>
                            <th style="width:100px;"><span id="spanTotalDebt"></span></th>
                        </tr>
                        <tr>
                            <td style="width:300px;"><span id="spanASSETS0002001"></span></td>
                            <td style="width:100px;"><input id="txtASSETS0002001" type="text" /></td>
                            <td style="width:50px;"></td>
                            <td style="width:300px;"></td>
                            <td style="width:100px;"></td>
                        </tr>
                        <tr>
                            <td style="width:300px;"><span id="spanASSETS0002002"></span></td>
                            <td style="width:100px;"><input id="txtASSETS0002002" type="text" /></td>
                            <td style="width:50px;"></td>
                            <td style="width:300px;"></td>
                            <td style="width:100px;"></td>
                        </tr>
                        <tr>
                            <th style="width:300px;">기타자산</th>
                            <th style="width:100px;"><span id="spanSubGroupNo4"></span></th>
                            <th style="width:50px;"></th>
                            <th style="width:300px;">순자산</th>
                            <th style="width:100px;"><span id="spanNetAssets"></span></th>
                        </tr>
                        <tr>
                            <td style="width:300px;"><span id="spanASSETS0003001"></span></td>
                            <td style="width:100px;"><input id="txtASSETS0003001" type="text" /></td>
                            <td style="width:50px;"></td>
                            <td style="width:300px;"></td>
                            <td style="width:100px;"></td>
                        </tr>
                        <tr>
                            <td style="width:300px;"><span id="spanASSETS0003002"></span></td>
                            <td style="width:100px;"><input id="txtASSETS0003002" type="text" /></td>
                            <td style="width:50px;"></td>
                            <td style="width:300px;"></td>
                            <td style="width:100px;"></td>
                        </tr>
                        <tr>
                            <th style="width:300px;">총자산</th>
                            <th style="width:100px;"><span id="spanTotalAssets"></span></th>
                            <th style="width:50px;"></th>
                            <th style="width:300px;">부채와순자산</th>
                            <th style="width:100px;"><span id="spanDebtNetAssets"></span></th>
                        </tr>
                    </tbody>
                </table>
            </div>
            <br />
            <div style="width:1024px;" align="right">
                <input id="btnInit"   type="button" value="초기화" />
                <input id="btnUpdate" type="button" value="저장" />
            </div>
        </div>
    </form>
</body>
</html>
