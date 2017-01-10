<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserFamilyList.aspx.cs" Inherits="UserMgmt_UserFamily" %>
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
        var userId  = '<%= base.userVo.user.userId %>';        

        $(document).ready(function () {

            Top.DataBind(home);

            fn_initData();  // 데이터 초기화

            //$("#list tbody tr").hover(
            //    function () { debugger; $(this).css("backgroundColor", "#999999"); },
            //    function () { debugger; $(this).css("backgroundColor", "#ffffff"); }
            //);

            // 추가 클릭시
            $("#btnInsert").bind("click", function () {
                window.location.href = home + "/UserMgmt/UserFamily.aspx?MODE=I";
            });

            // 수정 클릭시
            $("#btnUpdate").bind("click", function () {
                var selectRow = $(':radio[name="selectRow"]:checked').val();
                if (typeof (selectRow) == "undefined") {
                    $.sweetModal('수정할 항목을 선택하세요.');
                } else {
                    window.location.href = home + "/UserMgmt/UserFamily.aspx?MODE=U&NO=" + selectRow;
                }
            });
            
            // 삭제 클릭시
            $("#btnDelete").bind("click", function () {

                debugger;

                var selectRow = $(':radio[name="selectRow"]:checked').val();
                if (typeof (selectRow) == "undefined") {
                    $.sweetModal('삭제할 항목을 선택하세요.');
                } else {

                    $.sweetModal.confirm(
                        ""
                        , "선택한 가족정보를 삭제하시겠습니까?"
                        , function () {
                            //window.location.href = home + "/UserMgmt/UserFamilyList.aspx";

                            var userFamilyVo = {};
                            userFamilyVo.userFamily = {};
                            userFamilyVo.userFamily.userFamilyNo = selectRow;

                            UserFamily.deleteUserFamilyVo(
                                userFamilyVo
                                , function (result) {
                                    debugger;
                                    fn_initData();
                                }, function (error) {
                                    debugger;
                                    $.sweetModal(error._message);
                                    return;
                                }
                            );
                        }, function () {}
                    );
                }
            });
        });

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 데이터초기화
        ///////////////////////////////////////////////////////////////////////////////////////////
        function fn_initData() {
            debugger;

            var userFamilyVo = {};
            userFamilyVo.userFamily = {};
            userFamilyVo.userFamily.userId = userId;                    // 사용자아이디

            UserFamily.selectListUserFamilyVo(
                userFamilyVo,
                function (result) {

                    debugger;

                    $('#list > tbody').children().remove();

                    var userFamilyVoList = result.userFamilyVoList;
                    var data = "";

                    for (var i = 0; i < userFamilyVoList.length; i++) {

                        var userFamily = userFamilyVoList[i].userFamily;
                        var userFamilyType = userFamilyVoList[i].userFamilyType;
                        var userFamilySexType = userFamilyVoList[i].userFamilySexType;
                        var userFamilyJobType = userFamilyVoList[i].userFamilyJobType;

                        data = "";
                        //data += "<tr onmouseover='fn_overRow(this)' onmouseout='fn_outRow(this)'>";
                        //data += "<tr onclick='fn_selectRow(this)'>";
                        data += "<tr>";

                    

                        data += "<td>" + "<input type='radio' name='selectRow' value='" + userFamily.userFamilyNo + "' />" + "</td>";
                        //data += "<td>" + userFamily.userFamilyNo + "</td>";
                        //data += "<td>" + userFamily.userId + "</td>";
                        //data += "<td>" + userFamilyType.userFamilyTypeNo + "</td>";
                        data += "<td>" + userFamilyType.userFamilyTypeNm + "</td>";
                        data += "<td>" + userFamily.userFamilyNm + "</td>";

                        data += "<td>" + userFamily.birthYear + "</td>";
                        //data += "<td>" + userFamilySexType.sexTypeNo + "</td>";
                        data += "<td>" + userFamilySexType.sexTypeNm + "</td>";
                        //data += "<td>" + userFamilyJobType.jobTypeNo + "</td>";
                        data += "<td>" + userFamilyJobType.jobTypeNm + "</td>";

                        data += "<td>" + userFamily.retirementAge + "</td>";
                        data += "<td>" + userFamily.lifeSpan + "</td>";

                        data += "</tr>";

                        $('#list > tbody:last').append(data);
                    }

                
                }, function (error) {
                    $.sweetModal(error._message);
                    return;
                }

            );
        }

        //function fn_selectRow(row) {
        //    $("#list").css("background-color", "#ffffff");
        //    $(row).css("background-color", "#999999");
        //    //alert($(row).find("input[name='selectRow']"));
        //    $("#list").find("input:radio[name='selectRow']").removeAttr("checked");
        //    $(row).find("input:radio[name='selectRow']").attr("checked", true);
            
        //    debugger;
        //}

        //function fn_outRow(row) {
        //    $(row).css("background-color", "#ffffff");
        //    $(row).find("input[name='selectRow']").removeAttr("checked");
        //}

        //function fn_testString() {
        //    fcdb.testString(function (succeededResult) {
        //        alert(succeededResult);
        //    });
        //}
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server">
             <Services>
                <asp:ServiceReference Path="~/WS/userFamily.asmx" InlineScript="true" />
             </Services>
        </asp:ScriptManager>
        <div>
            <uc1:Top ID="Top1" runat="server" />
            <div style="width:1024px;">
                * <%= uiTitle %>
                <hr />
            </div>
            
            <%--<div style="width:1024px;border-collapse:collapse; border:1px gray solid;">
                필요시 조건
            </div>--%>
            <div style="width:1024px;" align="right">
                <%--<input type="button" value="조회" onclick="fn_testString()" />--%>
            </div>
            <br />
            <div style="width:1024px;">
                <table id="list">
                    <thead>   
                        <tr>
                            <th style="width:150px">선택</th>
                            <%--<td>사용자가족번호</td>
                            <td>사용자아이디</td>
                            <td>사용자가족구분번호</td>--%>
                            <th style="width:150px">가족구분</th>
                            <th style="width:150px">가족명</th>
                            <th style="width:150px">출생년도</th>
                            <%--<td>성별구분번호</td>--%>
                            <th style="width:150px">성별</th>
                            <%--<td>직업구분번호</td>--%>
                            <th style="width:150px">직업</th>
                            <th style="width:150px">은퇴연령</th>
                            <th style="width:150px">예상수명</th>
                        </tr>
                    </thead>
                    <tbody></tbody>
                </table>
            </div>
            <br />
            <div style="width:1024px;" align="right">
                <input id="btnInsert" type="button" value="추가" />
                <input id="btnUpdate" type="button" value="수정" />
                <input id="btnDelete" type="button" value="삭제" />
            </div>
        </div>
    </form>
</body>
</html>
