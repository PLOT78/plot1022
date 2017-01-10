using fc.common.fcdb.domain.vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Top : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ( (Session != null) && (Session["userVo"] != null) )
        {
            UserVo userVo = (UserVo)Session["userVo"];

            this.lbUserInfo.Text = string.Format("{0}({1})님 안녕하세요.", userVo.user.userId, userVo.user.userNm);
        } else
        {
            Response.Redirect("~/Login.aspx");
        }
    }

    protected void btnLogout_Click(object sender, EventArgs e)
    {
        Session.Clear();
    }

    public UserVo GetUserVo()
    {
        UserVo userVo = null;

        if ((Session != null) && (Session["userVo"] != null))
        {
            userVo = (UserVo)Session["userVo"];
        }

        return userVo;
    }
}