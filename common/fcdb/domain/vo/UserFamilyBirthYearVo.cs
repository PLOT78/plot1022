using fc.common.cmn.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain.vo
{
    /// <summary>
    /// 사용자가족출생년도Vo
    /// </summary>
    public class UserFamilyBirthYearVo
    {
        /// <summary>
        /// 사용자가족출생년도Vo 생성자
        /// </summary>
        public UserFamilyBirthYearVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFamilyBirthYear = new UserFamilyBirthYear();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자가족출생년도 property
        /// </summary>
        public UserFamilyBirthYear userFamilyBirthYear { get; set; }
    }
}
