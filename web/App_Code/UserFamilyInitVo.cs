using fc.common.cmn.domain;
using fc.common.fcdb.domain.listVo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// 사용자가족구분초기화Vo
/// </summary>
public class UserFamilyInitVo
{
    /// <summary>
    /// 사용자가족구분초기화Vo 생성자
    /// </summary>
    public UserFamilyInitVo()
    {
        this.commonAttr = new CommonAttr();
        this.userFamilyTypeListVo = new UserFamilyTypeListVo();
        this.userFamilyBirthYearListVo = new UserFamilyBirthYearListVo();
        this.userFamilySexTypeListVo = new UserFamilySexTypeListVo();
        this.userFamilyJobTypeListVo = new UserFamilyJobTypeListVo();
        this.userFamilyRetirementAgeListVo = new UserFamilyRetirementAgeListVo();
        this.userFamilyLifeSpanListVo = new UserFamilyLifeSpanListVo();
    }

    /// <summary>
    /// 공통속성 property
    /// </summary>
    public CommonAttr commonAttr { get; set; }
    /// <summary>
    /// 사용자가족구분ListVo property
    /// </summary>
    public UserFamilyTypeListVo userFamilyTypeListVo { get; set; }
    /// <summary>
    /// 사용자가족출생년도ListVo property
    /// </summary>
    public UserFamilyBirthYearListVo userFamilyBirthYearListVo { get; set; }

    /// <summary>
    /// 사용자가족성별구분ListVo property
    /// </summary>
    public UserFamilySexTypeListVo userFamilySexTypeListVo { get; set; }
    /// <summary>
    /// 사용자가족직업구분ListVo property
    /// </summary>
    public UserFamilyJobTypeListVo userFamilyJobTypeListVo { get; set; }
    /// <summary>
    /// 사용자가족은퇴연령ListVo property
    /// </summary>
    public UserFamilyRetirementAgeListVo userFamilyRetirementAgeListVo { get; set; }
    /// <summary>
    /// 사용자가족예상수명ListVo property
    /// </summary>
    public UserFamilyLifeSpanListVo userFamilyLifeSpanListVo { get; set; }

}