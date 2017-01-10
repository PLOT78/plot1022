using System;

public partial class UserMgmt_UserFamily : WebCommon
{
    public string uiId      = "User00101";
    public string uiTitle   = "가족정보조회";

    protected void Page_Load(object sender, EventArgs e)
    {
        base.userVo = Top1.GetUserVo();
    }
}