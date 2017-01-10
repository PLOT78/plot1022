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
    /// 사용자가족출생년도ListVo
    /// </summary>
    public class UserFamilyBirthYearListVo
    {
        /// <summary>
        /// 사용자가족출생년도ListVo 생성자
        /// </summary>
        public UserFamilyBirthYearListVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFamilyBirthYearVoList = new List<UserFamilyBirthYearVo>();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자가족출생년도VoList property
        /// </summary>
        public List<UserFamilyBirthYearVo> userFamilyBirthYearVoList { get; set; }
    }
}
