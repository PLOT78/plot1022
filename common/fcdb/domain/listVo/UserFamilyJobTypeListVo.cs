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
    /// 사용자가족직업구분ListVo
    /// </summary>
    public class UserFamilyJobTypeListVo
    {
        /// <summary>
        /// 사용자가족직업구분ListVo 생성자
        /// </summary>
        public UserFamilyJobTypeListVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFamilyJobTypeVoList = new List<UserFamilyJobTypeVo>();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자가족직업구분VoList property
        /// </summary>
        public List<UserFamilyJobTypeVo> userFamilyJobTypeVoList { get; set; }
    }
}
