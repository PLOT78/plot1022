using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserMgmt_v0002_UserPension : WebCommon
{
    public string uiId = "User01301";
    public string uiTitle = "연금적립액";

    protected void Page_Load(object sender, EventArgs e)
    {
        base.userVo = Top1.GetUserVo();
    }
}