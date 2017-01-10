Top = {};

Top.DataBind = function (home) {

    //debugger;

    $("#linkHome").attr("href", home);

    $("#linkUser00101").attr("href", home + "/UserMgmt/UserFamilyList.aspx");
    $("#linkUser00102").attr("href", home + "/UserMgmt/v0002/UserFanance.aspx");
    $("#linkUser00103").attr("href", home + "/UserMgmt/v0002/UserCashFlow.aspx");

    $("#linkUser01301").attr("href", home + "/UserMgmt/v0002/UserPension.aspx");
}