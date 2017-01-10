using fc.common.fcdb.domain.listVo;
using fc.common.fcdb.domain.vo;
using fc.common.fcdb.facade;
using System.Web.Script.Services;
using System.Web.Services;

/// <summary>
/// UserFamily 웹서비스
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[ScriptService]
public class UserFamily : System.Web.Services.WebService
{
    public UserFamily()
    {

        //디자인된 구성 요소를 사용하는 경우 다음 줄의 주석 처리를 제거합니다. 
        //InitializeComponent();  
    }

    /// <summary>
    /// 데이터초기화
    /// </summary>
    /// <returns>사용자가족구분초기화Vo</returns>
    [WebMethod]
    public UserFamilyInitVo InitData()
    {
        UserFamilyInitVo userFamilyInitVo = new UserFamilyInitVo();

        userFamilyInitVo.userFamilyTypeListVo           = this.InitDataUserFamilyType();            // 데이터초기화_사용자가족구분
        userFamilyInitVo.userFamilyBirthYearListVo      = this.ininDataUserFamilyBirthYear();       // 데이터초기화_사용자가족출생년도
        userFamilyInitVo.userFamilySexTypeListVo        = this.ininDataUserFamilySexType();         // 데이터초기화_사용자가족성별구분
        userFamilyInitVo.userFamilyJobTypeListVo        = this.ininDataUserFamilyJobType();         // 데이터초기화_사용자가족직업구분
        userFamilyInitVo.userFamilyRetirementAgeListVo  = this.ininDataUserFamilyRetirementAge();   // 데이터초기화_사용자가족은퇴연령
        userFamilyInitVo.userFamilyLifeSpanListVo       = this.ininDataUserFamilyLifeSpan();        // 데이터초기화_사용자가족예상수명

        return userFamilyInitVo;
    }

    #region 데이터초기화_사용자가족구분
    /// <summary>
    /// 데이터초기화_사용자가족구분
    /// </summary>
    /// <returns>사용자가족구분ListVo</returns>
    private UserFamilyTypeListVo InitDataUserFamilyType()
    {
        UserFamilyTypeListVo userFamilyTypeListVo = null;

        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            userFamilyTypeListVo = fcdbFacade.selectlistUserFamilyTypeVo(new UserFamilyTypeVo());
        }

        return userFamilyTypeListVo;
    }
    #endregion

    #region 데이터초기화_사용자가족출생년도
    /// <summary>
    /// 데이터초기화_사용자가족출생년도
    /// </summary>
    /// <returns>사용자가족출생년도ListVo</returns>
    private UserFamilyBirthYearListVo ininDataUserFamilyBirthYear()
    {
        UserFamilyBirthYearListVo userFamilyBirthYearListVo = null;

        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            userFamilyBirthYearListVo = fcdbFacade.selectlistUserFamilyBirthYearVo(new UserFamilyBirthYearVo());
        }

        return userFamilyBirthYearListVo;
    }
    #endregion

    #region 데이터초기화_사용자가족성별구분
    /// <summary>
    /// 데이터초기화_사용자가족성별구분
    /// </summary>
    /// <returns>사용자가족성별구분ListVo</returns>
    private UserFamilySexTypeListVo ininDataUserFamilySexType()
    {
        UserFamilySexTypeListVo userFamilySexTypeListVo = null;

        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            userFamilySexTypeListVo = fcdbFacade.selectlistUserFamilySexTypeVo(new UserFamilySexTypeVo());
        }

        return userFamilySexTypeListVo;
    }
    #endregion 

    #region 데이터초기화_사용자가족직업구분
    private UserFamilyJobTypeListVo ininDataUserFamilyJobType()
    {
        UserFamilyJobTypeListVo userFamilyJobTypeListVo = null;

        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            userFamilyJobTypeListVo = fcdbFacade.selectlistUserFamilyJobTypeVo(new UserFamilyJobTypeVo());
        }

        return userFamilyJobTypeListVo;
    }
    #endregion

    #region 데이터초기화_사용자가족은퇴연령
    private UserFamilyRetirementAgeListVo ininDataUserFamilyRetirementAge()
    {
        UserFamilyRetirementAgeListVo userFamilyRetirementAgeListVo = null;

        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            userFamilyRetirementAgeListVo = fcdbFacade.selectlistUserFamilyRetirementAgeVo(new UserFamilyRetirementAgeVo());
        }

        return userFamilyRetirementAgeListVo;
    }
    #endregion

    #region 데이터초기화_사용자가족예상수명
    private UserFamilyLifeSpanListVo ininDataUserFamilyLifeSpan()
    {
        UserFamilyLifeSpanListVo userFamilyLifeSpanListVo = null;

        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            userFamilyLifeSpanListVo = fcdbFacade.selectlistUserFamilyLifeSpanVo(new UserFamilyLifeSpanVo());
        }

        return userFamilyLifeSpanListVo;
    }
    #endregion

    #region 사용자가족Vo추가
    /// <summary>
    /// 사용자가족Vo추가
    /// </summary>
    /// <param name="userFamilyVo">사용자가족Vo</param>
    [WebMethod]
    public void insertUserFamilyVo(UserFamilyVo userFamilyVo)
    {
        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            fcdbFacade.insertUserFamilyVo(userFamilyVo);
        }
    }
    #endregion

    #region 사용자가족Vo조회
    /// <summary>
    /// 사용자가족Vo조회
    /// </summary>
    /// <param name="userFamilyVo">사용자가족Vo</param>
    /// <returns>사용자가족Vo</returns>
    [WebMethod]
    public UserFamilyVo selectUserFamilyVo(UserFamilyVo userFamilyVo)
    {
        UserFamilyVo rtnUserFamilyVo = new UserFamilyVo();

        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            rtnUserFamilyVo = fcdbFacade.selectUserFamilyVo(userFamilyVo);
        }

        return rtnUserFamilyVo;
    }
    #endregion

    #region 사용자가족ListVo조회
    /// <summary>
    /// 사용자가족ListVo조회
    /// </summary>
    /// <param name="userFamilyVo">사용자가족Vo</param>
    /// <returns>사용자가족ListVo</returns>
    [WebMethod]
    public UserFamilyListVo selectListUserFamilyVo(UserFamilyVo userFamilyVo)
    {
        UserFamilyListVo userFamilyListVo = new UserFamilyListVo();

        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            userFamilyListVo = fcdbFacade.selectListUserFamilyVo(userFamilyVo);
        }

        return userFamilyListVo;
    }
    #endregion

    #region 사용자가족Vo수정
    /// <summary>
    /// 사용자가족Vo수정
    /// </summary>
    /// <param name="userFamilyVo">사용자가족Vo</param>
    /// <returns>사용자가족Vo</returns>
    [WebMethod]
    public UserFamilyVo updateUserFamilyVo(UserFamilyVo userFamilyVo)
    {
        UserFamilyVo rtnUserFamilyVo = new UserFamilyVo();

        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            rtnUserFamilyVo = fcdbFacade.updateUserFamilyVo(userFamilyVo);
        }

        return rtnUserFamilyVo;
    }
    #endregion

    #region 사용자가족Vo삭제
    /// <summary>
    /// 사용자가족Vo삭제
    /// </summary>
    /// <param name="userFamilyVo">사용자가족Vo</param>
    [WebMethod]
    public void deleteUserFamilyVo(UserFamilyVo userFamilyVo)
    {
        using (FCdbFacade fcdbFacade = new FCdbFacade())
        {
            fcdbFacade.deleteUserFamilyVo(userFamilyVo);
        }
    }
    #endregion
}
