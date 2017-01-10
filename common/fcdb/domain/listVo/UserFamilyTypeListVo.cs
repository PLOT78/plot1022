using fc.common.cmn.domain;
using fc.common.fcdb.domain.vo;
using System.Collections.Generic;

namespace fc.common.fcdb.domain.listVo
{
    /// <summary>
    /// 사용자가족구분ListVo
    /// </summary>
    public class UserFamilyTypeListVo
    {
        /// <summary>
        /// 사용자가족구분ListVo 생성자
        /// </summary>
        public UserFamilyTypeListVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFamilyTypeVolist = new List<UserFamilyTypeVo>();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자가족구분VoList property
        /// </summary>
        public List<UserFamilyTypeVo> userFamilyTypeVolist { get; set; }
    }
}
