using fc.common.cmn.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain.vo
{
    /// <summary>
    /// 사용자가족예상수명Vo
    /// </summary>
    public class UserFamilyLifeSpanVo
    {
        /// <summary>
        /// 사용자가족예상수명Vo 생성자
        /// </summary>
        public UserFamilyLifeSpanVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFamilyLifeSpan = new UserFamilyLifeSpan();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자가족예상수명 property
        /// </summary>
        public UserFamilyLifeSpan userFamilyLifeSpan { get; set; }
    }
}
