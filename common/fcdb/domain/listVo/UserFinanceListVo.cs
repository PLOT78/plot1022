using fc.common.cmn.domain;
using fc.common.fcdb.domain.vo;
using System.Collections.Generic;

namespace fc.common.fcdb.domain.listVo
{
    /// <summary>
    /// 사용자재무ListVo
    /// </summary>
    public class UserFinanceListVo
    {
        /// <summary>
        /// 사용자재무ListVo 생성자
        /// </summary>
        public UserFinanceListVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFinanceVoList = new List<UserFinanceVo>();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자재무VoList property
        /// </summary>
        public List<UserFinanceVo> userFinanceVoList { get; set; }
    }
}
