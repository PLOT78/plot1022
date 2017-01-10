using fc.common.cmn.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain.vo
{
    /// <summary>
    /// 사용자가족은퇴연령Vo
    /// </summary>
    public class UserFamilyRetirementAgeVo
    {
        /// <summary>
        /// 사용자가족은퇴연령Vo 생성자
        /// </summary>
        public UserFamilyRetirementAgeVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFamilyRetirementAge = new UserFamilyRetirementAge();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자가족은퇴연령 property
        /// </summary>
        public UserFamilyRetirementAge userFamilyRetirementAge { get; set; }
    }
}
