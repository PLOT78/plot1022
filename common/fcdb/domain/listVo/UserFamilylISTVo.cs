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
    /// 사용자가족ListVo
    /// </summary>
    public class UserFamilyListVo
    {
        /// <summary>
        /// 사용자가족ListVo 생성자
        /// </summary>
        public UserFamilyListVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFamilyVoList = new List<UserFamilyVo>();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자가족VoList property
        /// </summary>
        public List<UserFamilyVo> userFamilyVoList { get; set; }
    }
}
