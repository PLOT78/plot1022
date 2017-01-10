using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain
{
    /// <summary>
    /// 사용자가족직업구분domain
    /// </summary>
    public class UserFamilyJobType
    {
        /// <summary>
        /// 사용자가족직업구분domain 생성자
        /// </summary>
        public UserFamilyJobType()
        {
            this.jobTypeNo = -1;
            this.jobTypeNm = string.Empty;
        }

        /// <summary>
        /// 직업구분번호 property
        /// </summary>
        public int jobTypeNo { get; set; }
        /// <summary>
        /// 직업구분명 property
        /// </summary>
        public string jobTypeNm { get; set; }
    }
}
