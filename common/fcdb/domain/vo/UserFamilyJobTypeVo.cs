using fc.common.cmn.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain.vo
{
    /// <summary>
    /// 사용자가족직업구분Vo
    /// </summary>
    public class UserFamilyJobTypeVo
    {
        /// <summary>
        /// 사용자가족직업구분Vo 생성자
        /// </summary>
        public UserFamilyJobTypeVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFamilyJobType = new UserFamilyJobType();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자가족직업구분 property
        /// </summary>
        public UserFamilyJobType userFamilyJobType { get; set; }
    }
}
