using fc.common.cmn.domain;
using fc.common.fcdb.domain.vo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain.listVo
{
    /// <summary>
    /// 사용자가족은퇴연령ListVo
    /// </summary>
    public class UserFamilyRetirementAgeListVo
    {
        /// <summary>
        /// 사용자가족은퇴연령ListVo 생성자
        /// </summary>
        public UserFamilyRetirementAgeListVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFamilyRetirementAgeVoList = new List<UserFamilyRetirementAgeVo>();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자가족은퇴연령VoList property
        /// </summary>
        public List<UserFamilyRetirementAgeVo> userFamilyRetirementAgeVoList { get; set; }
    }
}
