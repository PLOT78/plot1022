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
    /// 사용자가족예상수명ListVo
    public class UserFamilyLifeSpanListVo
    {
        /// <summary>
        /// 사용자가족예상수명ListVo 생성자
        /// </summary>
        public UserFamilyLifeSpanListVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFamilyLifeSpanVoList = new List<UserFamilyLifeSpanVo>();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자가족예상수명VoList property
        /// </summary>
        public List<UserFamilyLifeSpanVo> userFamilyLifeSpanVoList { get; set; }
    }
}
