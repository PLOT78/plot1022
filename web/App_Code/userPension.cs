using fc.common.fcdb.domain.listVo;
using fc.common.fcdb.domain.vo;
using fc.common.fcdb.facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

/// <summary>
/// userPension의 요약 설명입니다.
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]
public class UserPension : System.Web.Services.WebService
{

    public UserPension()
    {

        //디자인된 구성 요소를 사용하는 경우 다음 줄의 주석 처리를 제거합니다. 
        //InitializeComponent(); 
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public UserPensionListVo selectListUserPensionVo(UserPensionVo userPensionVo)
    {
        UserPensionListVo userPensionListVo = new UserPensionListVo();

        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            userPensionListVo = fcdbFacade.selectListUserPensionVo(userPensionVo);
        }

        return userPensionListVo;
    }

}

