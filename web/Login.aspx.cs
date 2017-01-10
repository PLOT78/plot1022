using fc.common.fcdb.domain.vo;
using fc.common.fcdb.facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //this.txtID.Focus();
        this.txtID.Focus();
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        Session.Clear();

        UserVo userVo = new UserVo();
        userVo.user.userId = this.txtID.Text;
        userVo.user.pwd = this.txtPass.Text;

        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            userVo = fcdbFacade.selectUserVo(userVo);

            if ( (userVo != null) && (userVo.user != null) && (userVo.user.userId != null) && (userVo.user.userId != ""))
            {
                Session["userVo"] = userVo;
                //Response.Redirect("Default.aspx");
                Response.Redirect("~");
            }
            else
            {
                this.lbResult.Text = "로그인정보 불일치";
            }
        }
    }
}