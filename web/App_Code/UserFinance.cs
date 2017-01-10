using fc.common.fcdb.domain.listVo;
using fc.common.fcdb.domain.vo;
using fc.common.fcdb.facade;
using System.Web.Script.Services;
using System.Web.Services;

/// <summary>
/// UserFinance 웹서비스
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]
public class UserFinance : System.Web.Services.WebService
{
    public UserFinance()
    {

        //디자인된 구성 요소를 사용하는 경우 다음 줄의 주석 처리를 제거합니다. 
        //InitializeComponent(); 
    }

    #region 사용자재무ListVo조회
    /// <summary>
    /// 사용자재무ListVo조회
    /// </summary>
    /// <param name="userFinanceVo">사용자재무Vo</param>
    /// <returns>사용자재무ListVo</returns>
    [WebMethod]
    public UserFinanceListVo selectListUserFinanceVo(UserFinanceVo userFinanceVo)
    {
        UserFinanceListVo userFinanceListVo = new UserFinanceListVo();

        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            userFinanceListVo = fcdbFacade.selectListUserFinanceVo(userFinanceVo);
        }

        return userFinanceListVo;
    }
    #endregion

    #region 사용자재무Vo수정
    /// <summary>
    /// 사용자재무Vo수정
    /// </summary>
    /// <param name="userFinanceListVo">사용자재무ListVo</param>
    /// <returns>사용자재무ListVo</returns>
    [WebMethod]
    public UserFinanceListVo updateUserFinanceVo(UserFinanceListVo userFinanceListVo)
    {
        UserFinanceListVo rtnUserFinanceListVo = new UserFinanceListVo();

        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            rtnUserFinanceListVo = fcdbFacade.updateUserFinanceVo(userFinanceListVo);
        }

        return rtnUserFinanceListVo;
    }
    #endregion

}
