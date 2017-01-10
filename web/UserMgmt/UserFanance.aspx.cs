using System;

public partial class UserMgmt_UserFanance : WebCommon
{
    public string uiId = "User00103";
    public string uiTitle = "재무상태표";

    protected void Page_Load(object sender, EventArgs e)
    {
        base.userVo = Top1.GetUserVo();
    }
}