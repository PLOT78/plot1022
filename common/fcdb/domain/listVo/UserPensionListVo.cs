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
    /// 연금ListVo
    /// </summary>
    public class UserPensionListVo
    {
        /// <summary>
        /// 연금ListVo 생성자
        /// </summary>
        public UserPensionListVo()
        {
            this.commonAttr = new CommonAttr();
            this.userPensionVoList = new List<UserPensionVo>();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 연금VoList property
        /// </summary>
        public List<UserPensionVo> userPensionVoList { get; set; }
    }
}
