using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain
{
    /// <summary>
    /// 사용자가족domain
    /// </summary>
    public class UserFamily
    {
        /// <summary>
        /// 사용자가족domain 생성자
        /// </summary>
        public UserFamily()
        {
            this.userFamilyNo       = -1;
            this.userId             = string.Empty;
            this.userFamilyTypeNo   = -1;
            this.userFamilyNm       = string.Empty;
            this.birthYear          = -1;
            this.sexTypeNo          = -1;
            this.jobTypeNo          = -1;
            this.retirementAge      = -1;
            this.lifeSpan           = -1;
        }

        /// <summary>
        /// 사용자가족번호 property
        /// </summary>
        public int userFamilyNo { get; set; }
        /// <summary>
        /// 사용자아이디 property
        /// </summary>
        public string userId { get; set; }
        /// <summary>
        /// 사용자가족구분번호 property
        /// </summary>
        public int userFamilyTypeNo { get; set; }
        /// <summary>
        /// 사용자가족명 property
        /// </summary>
        public string userFamilyNm { get; set; }
        /// <summary>
        /// 출생년도 property
        /// </summary>
        public int birthYear { get; set; }
        /// <summary>
        /// 성별구분번호 property
        /// </summary>
        public int sexTypeNo { get; set; }
        /// <summary>
        /// 직업구분번호 property
        /// </summary>
        public int jobTypeNo { get; set; }
        /// <summary>
        /// 은퇴연령 property
        /// </summary>
        public int? retirementAge { get; set; }
        /// <summary>
        /// 예상수명 property
        /// </summary>
        public int? lifeSpan { get; set; }
    }
}
