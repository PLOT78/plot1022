using fc.common.cmn.domain;
using fc.common.fcdb.domain.vo;
using System.Collections.Generic;

namespace fc.common.fcdb.domain.listVo
{
    /// <summary>
    /// 사용자재무카탈로그그룹ListVo
    /// </summary>
    public class UserFinanceCatalogGroupListVo
    {
        /// <summary>
        /// 사용자재무카탈로그그룹ListVo 생성자
        /// </summary>
        public UserFinanceCatalogGroupListVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFinanceCatalogGroupVoList = new List<UserFinanceCatalogGroupVo>();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자재무VoList property
        /// </summary>
        public List<UserFinanceCatalogGroupVo> userFinanceCatalogGroupVoList { get; set; }
    }
}
