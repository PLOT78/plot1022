using fc.common.cmn.domain;
using fc.common.fcdb.domain.vo;
using System.Collections.Generic;

namespace fc.common.fcdb.domain.listVo
{
    /// <summary>
    /// 사용자가족성별구분ListVo
    /// </summary>
    public class UserFamilySexTypeListVo
    {
        /// <summary>
        /// 사용자가족성별구분ListVo 생성자
        /// </summary>
        public UserFamilySexTypeListVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFamilySexTypeVoList = new List<UserFamilySexTypeVo>();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자가족성별구분VoList property
        /// </summary>
        public List<UserFamilySexTypeVo> userFamilySexTypeVoList { get; set; }
    }
}
