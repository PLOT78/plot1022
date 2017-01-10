using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserMgmt_v0002_UserFanance : WebCommon
{
    public string uiId = "User00103";
    public string uiTitle = "재무상태표";

    protected void Page_Load(object sender, EventArgs e)
    {
        base.userVo = Top1.GetUserVo();
    }
}