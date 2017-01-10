using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain
{
    /// <summary>
    /// 사용자가족예상수명domain
    /// </summary>
    public class UserFamilyLifeSpan
    {
        /// <summary>
        /// 사용자가족예상수명domain 생성자
        /// </summary>
        public UserFamilyLifeSpan()
        {
            this.lifeSpan = -1;
        }

        /// <summary>
        /// 예상수명 property
        /// </summary>
        public int lifeSpan { get; set; }
    }
}
