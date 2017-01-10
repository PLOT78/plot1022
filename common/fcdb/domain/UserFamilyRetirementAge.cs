using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain
{
    /// <summary>
    /// 사용자가족은퇴연령domain
    /// </summary>
    public class UserFamilyRetirementAge
    {
        /// <summary>
        /// 사용자가족은퇴연령domain 생성자
        /// </summary>
        public UserFamilyRetirementAge()
        {
            this.retirementAge = -1;
        }

        /// <summary>
        /// 은퇴연령 property
        /// </summary>
        public int retirementAge { get; set; }
    }
}
