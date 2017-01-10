using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain
{
    /// <summary>
    /// 사용자재무domain
    /// </summary>
    public class UserFinance
    {
        /// <summary>
        /// 사용자재무domain 생성자
        /// </summary>
        public UserFinance()
        {
            this.userId                 = string.Empty;
            this.userFinanceCatalogId   = string.Empty;
            this.price                  = -1;
        }

        /// <summary>
        /// 사용자아이디 property
        /// </summary>
        public string userId { get; set; }
        /// <summary>
        /// 사용자재무카탈로그아이디 property
        /// </summary>
        public string userFinanceCatalogId { get; set; }
        /// <summary>
        /// 금액 property
        /// </summary>
        public int price { get; set; }
    }
}
