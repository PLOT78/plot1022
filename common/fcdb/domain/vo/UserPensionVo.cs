using fc.common.cmn.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain.vo
{
    /// <summary>
    /// 연금Vo
    /// </summary>
    public class UserPensionVo
    {
        /// <summary>
        /// 사용자가족Vo 생성자
        /// </summary>
        public UserPensionVo()
        {
            this.commonAttr = new CommonAttr();

            this.userPension = new UserPension();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 연금 property
        /// </summary>
        public UserPension userPension { get; set; }
    }
}
