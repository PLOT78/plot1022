<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserFamily.aspx.cs" Inherits="UserMgmt_UserFamilyInsert" enableSessionState="true"  %>
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
        var mode    = '<%= mode %>';
        var no      = '<%= no %>';

        $(document).ready(function () {

            Top.DataBind(home);
            
            fn_initData();  // 데이터 초기화

            // 저장 클릭시
            $("#btnSave").bind("click", function () {
                fn_addUserFamilyVo();
            });

            // 취소 클릭시
            $("#btnCancel").bind("click", function () {
                window.location.href = home + "/UserMgmt/UserFamilyList.aspx";
            });

            // 가족구분 선택변경시
            $('#selectUserFamilyType').change(function () {
                if ($('#selectUserFamilyType option:selected').val() == 3) { // 자녀 선택시
                    $('#selectUserFamilyRetirementAge').attr("disabled", true);
                    $('#selectUserFamilyLifeSpan').attr("disabled", true);
                } else {
                    $('#selectUserFamilyRetirementAge').removeAttr("disabled");
                    $('#selectUserFamilyLifeSpan').removeAttr("disabled");
                }
            });
            
        });

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 사용자가족Vo추가
        ///////////////////////////////////////////////////////////////////////////////////////////
        function fn_addUserFamilyVo() {

            debugger;

            var userFamilyVo = {};
            userFamilyVo.userFamily = {};
            userFamilyVo.userFamily.userId              = userId;                                                       // 사용자아이디
            userFamilyVo.userFamily.userFamilyTypeNo    = $("#selectUserFamilyType option:selected").val();             // 사용자가족구분번호
            userFamilyVo.userFamily.userFamilyNm        = $.trim($("#txtFamilyNm").val());                              // 사용자가족명
            userFamilyVo.userFamily.birthYear           = $("#selectFamilyBirthYear option:selected").val();            // 출생년도
            userFamilyVo.userFamily.sexTypeNo           = $("#selectUserFamilySexType option:selected").val();          // 성별구분번호
            userFamilyVo.userFamily.jobTypeNo           = $("#selectUserFamilyJobType option:selected").val();          // 직업구분번호

            if (userFamilyVo.userFamily.userFamilyTypeNo == 3) { // 자녀 선택시
                userFamilyVo.userFamily.retirementAge   = null;
                userFamilyVo.userFamily.lifeSpan        = null;
            } else {
                userFamilyVo.userFamily.retirementAge   = $("#selectUserFamilyRetirementAge option:selected").val();    // 은퇴연령
                userFamilyVo.userFamily.lifeSpan        = $("#selectUserFamilyLifeSpan option:selected").val();         // 예상수명
            }

            debugger;

            if (userFamilyVo.userFamily.userFamilyNm == "") {
                $.sweetModal('가족명을 입력하세요.');
                return;
            }

            if (mode == "I") {

                UserFamily.insertUserFamilyVo(
                    userFamilyVo,
                    function (result) {
                        $.sweetModal.confirm(
                            "가족정보가 변경되었습니다."
                            , "가족정보조회로 이동하시겠습니까?"
                            , function () {
                                window.location.href = home + "/UserMgmt/UserFamilyList.aspx";
                            }, function () { }
                        );
                    }, function (error) {
                        debugger;   $.sweetModal(error._message);   return;
                    }
                );

            } else if (mode == "U") {

                userFamilyVo.userFamily.userFamilyNo = no;

                UserFamily.updateUserFamilyVo(userFamilyVo, function (result) {

                    debugger;

                    if (result.commonAttr.execSuccess == false) {
                        $.sweetModal(result.commonAttr.exceptionMessage);
                        return;
                    }

                    $.sweetModal.confirm(
                        "가족정보가 변경되었습니다."
                        , "가족정보조회로 이동하시겠습니까?"
                        , function () {
                            window.location.href = home + "/UserMgmt/UserFamilyList.aspx";
                        }, function () { }
                    );
                });

            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 데이터초기화
        ///////////////////////////////////////////////////////////////////////////////////////////
        function fn_initData() {
            debugger;

            UserFamily.InitData(function (succeededResult) {

                fn_initDataUserFamilyType(succeededResult);             // 데이터초기화_사용자가족구분
                fn_ininDataUserFamilyBirthYear(succeededResult);        // 데이터초기화_사용자가족출생년도
                fn_ininDataUserFamilySexType(succeededResult);          // 데이터초기화_사용자가족성별구분
                fn_ininDataUserFamilyJobType(succeededResult);          // 데이터초기화_사용자가족직업구분
                fn_ininDataUserFamilyRetirementAge(succeededResult);    // 데이터초기화_사용자가족은퇴연령
                fn_ininDataUserFamilyLifeSpan(succeededResult);         // 데이터초기화_사용자가족예상수명

                //alert("mode:" + mode + ",NO:" + no);

                if (mode == "U") {

                    var userFamilyVo = {};
                    userFamilyVo.userFamily = {};
                    userFamilyVo.userFamily.userId = userId;    // 사용자아이디
                    userFamilyVo.userFamily.userFamilyNo = no;  // 사용자가족번호

                    UserFamily.selectUserFamilyVo(userFamilyVo, function (selectResult) {
                        debugger;
                        var userFamily = selectResult.userFamily;

                        $("#selectUserFamilyType").val(userFamily.userFamilyTypeNo);        // 가족구분
                        $('#selectUserFamilyType').attr("disabled", true);

                        $("#txtFamilyNm").val(userFamily.userFamilyNm);                     // 가족명
                        $("#selectFamilyBirthYear").val(userFamily.birthYear);              // 출생년도
                        $("#selectUserFamilySexType").val(userFamily.sexTypeNo);            // 성별
                        $("#selectUserFamilyJobType").val(userFamily.jobTypeNo);            // 직업

                        if ($('#selectUserFamilyType option:selected').val() == 3) { // 자녀 선택시
                            $('#selectUserFamilyRetirementAge').attr("disabled", true);
                            $('#selectUserFamilyLifeSpan').attr("disabled", true);
                        } else {
                            $('#selectUserFamilyRetirementAge').removeAttr("disabled");
                            $('#selectUserFamilyLifeSpan').removeAttr("disabled");

                            $("#selectUserFamilyRetirementAge").val(userFamily.retirementAge);  // 은퇴연령
                            $("#selectUserFamilyLifeSpan").val(userFamily.lifeSpan);            // 예상수명
                        }
                        
                    });
                }
            });
        }


        ///////////////////////////////////////////////////////////////////////////////////////////
        // 데이터초기화_사용자가족구분
        ///////////////////////////////////////////////////////////////////////////////////////////
        function fn_initDataUserFamilyType(userFamilyInitVo) {

            var userFamilyTypeVolist = userFamilyInitVo.userFamilyTypeListVo.userFamilyTypeVolist;

            for (var i = 0; i < userFamilyTypeVolist.length; i++) {
                var userFamilyType = userFamilyTypeVolist[i].userFamilyType;
                $("#selectUserFamilyType").append("<option value='" + userFamilyType.userFamilyTypeNo + "'>" + userFamilyType.userFamilyTypeNm + "</option>");
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 데이터초기화_사용자가족출생년도
        ///////////////////////////////////////////////////////////////////////////////////////////
        function fn_ininDataUserFamilyBirthYear(userFamilyInitVo) {

            var userFamilyBirthYearVoList = userFamilyInitVo.userFamilyBirthYearListVo.userFamilyBirthYearVoList;

            for (var i = 0; i < userFamilyBirthYearVoList.length; i++) {
                var userFamilyBirthYear = userFamilyBirthYearVoList[i].userFamilyBirthYear;

                if (userFamilyBirthYear.defaultVal == true) {
                    $("#selectFamilyBirthYear").append("<option value='" + userFamilyBirthYear.birthYear + "' selected='selected'>" + userFamilyBirthYear.birthYear + "</option>");
                } else {
                    $("#selectFamilyBirthYear").append("<option value='" + userFamilyBirthYear.birthYear + "'>" + userFamilyBirthYear.birthYear + "</option>");
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 데이터초기화_사용자가족성별구분
        ///////////////////////////////////////////////////////////////////////////////////////////
        function fn_ininDataUserFamilySexType(userFamilyInitVo) {

            var userFamilySexTypeVoList = userFamilyInitVo.userFamilySexTypeListVo.userFamilySexTypeVoList;

            for (var i = 0; i < userFamilySexTypeVoList.length; i++) {
                var userFamilySexType = userFamilySexTypeVoList[i].userFamilySexType;
                $("#selectUserFamilySexType").append("<option value='" + userFamilySexType.sexTypeNo + "'>" + userFamilySexType.sexTypeNm + "</option>");
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 데이터초기화_사용자가족직업구분
        ///////////////////////////////////////////////////////////////////////////////////////////
        function fn_ininDataUserFamilyJobType(userFamilyInitVo) {

            var userFamilyJobTypeVoList = userFamilyInitVo.userFamilyJobTypeListVo.userFamilyJobTypeVoList;

            for (var i = 0; i < userFamilyJobTypeVoList.length; i++) {
                var userFamilyJobType = userFamilyJobTypeVoList[i].userFamilyJobType;
                $("#selectUserFamilyJobType").append("<option value='" + userFamilyJobType.jobTypeNo + "'>" + userFamilyJobType.jobTypeNm + "</option>");
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 데이터초기화_사용자가족은퇴연령
        ///////////////////////////////////////////////////////////////////////////////////////////
        function fn_ininDataUserFamilyRetirementAge(userFamilyInitVo) {

            var userFamilyRetirementAgeVoList = userFamilyInitVo.userFamilyRetirementAgeListVo.userFamilyRetirementAgeVoList;

            for (var i = 0; i < userFamilyRetirementAgeVoList.length; i++) {
                var userFamilyRetirementAge = userFamilyRetirementAgeVoList[i].userFamilyRetirementAge;
                $("#selectUserFamilyRetirementAge").append("<option value='" + userFamilyRetirementAge.retirementAge + "'>" + userFamilyRetirementAge.retirementAge + "</option>");
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////
        // 데이터초기화_사용자가족예상수명
        ///////////////////////////////////////////////////////////////////////////////////////////
        function fn_ininDataUserFamilyLifeSpan(userFamilyInitVo) {

            var userFamilyLifeSpanVoList = userFamilyInitVo.userFamilyLifeSpanListVo.userFamilyLifeSpanVoList;

            for (var i = 0; i < userFamilyLifeSpanVoList.length; i++) {
                var userFamilyLifeSpan = userFamilyLifeSpanVoList[i].userFamilyLifeSpan;
                $("#selectUserFamilyLifeSpan").append("<option value='" + userFamilyLifeSpan.lifeSpan + "'>" + userFamilyLifeSpan.lifeSpan + "</option>");
            }
        }

        
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server">
             <Services>
                <asp:ServiceReference Path="~/WS/UserFamily.asmx" InlineScript="true" />
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
                            <th style="width:150px;">가족구분</th>
                            <td style="width:150px;"><select id="selectUserFamilyType" style="width:150px;"></select></td>
                            <td style="width:50px"></td>
                            <th style="width:150px;">가족명</th>
                            <td style="width:150px;"><input id="txtFamilyNm" type="text" style="width:146px;" /></td>
                            <td style="width:50px"></td>
                            <th style="width:150px;"></th>
                            <td style="width:150px;"></td>
                        </tr>
                        <tr>
                            <th>출생년도</th>
                            <td><select id="selectFamilyBirthYear" style="width:150px;"></select></td>
                            <td style="width:30px"></td>
                            <th>성별</th>
                            <td><select id="selectUserFamilySexType" style="width:150px;"></select></td>
                            <td style="width:30px"></td>
                            <th>직업</th>
                            <td><select id="selectUserFamilyJobType" style="width:150px;"></select></td>
                        </tr>
                        <tr>
                            <th>은퇴연령</th>
                            <td><select id="selectUserFamilyRetirementAge" style="width:150px;"></select></td>
                            <td style="width:30px"></td>
                            <th>예상수명</th>
                            <td><select id="selectUserFamilyLifeSpan" style="width:150px;"></select></td>
                            <td style="width:30px"></td>
                            <th></th>
                            <td></td>
                        </tr>
                    </thead>
                    <tbody></tbody>
                </table>
            </div>
            <br />
            <div style="width:1024px;" align="right">
                <input id="btnSave"     type="button" value="저장" />
                <input id="btnCancel"   type="button" value="취소" />
            </div>
        </div>
    </form>
</body>
</html>
