using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain
{
    /// <summary>
    /// 사용자가족출생년도domain
    /// </summary>
    public class UserFamilyBirthYear
    {
        /// <summary>
        /// 사용자가족출생년도domain 생성자
        /// </summary>
        public UserFamilyBirthYear()
        {
            this.birthYear = -1;
        }

        /// <summary>
        /// 출생년도 property
        /// </summary>
        public int birthYear { get; set; }
        /// <summary>
        /// 기본설정여부 property
        /// </summary>
        public bool? defaultVal { get; set; }
    }
}
