using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain
{
    /// <summary>
    /// 사용자재무카탈로그domain
    /// </summary>
    public class UserFinanceCatalog
    {
        /// <summary>
        /// 사용자재무카탈로그domain 생성자
        /// </summary>
        public UserFinanceCatalog()
        {
            this.userFinanceCatalogId = string.Empty;
            this.userFinanceCatalogNm = string.Empty;
            this.userFinanceCatalogSubgroupNo = -1;
        }

        /// <summary>
        /// 사용자재무카탈로그아이디 property
        /// </summary>
        public string userFinanceCatalogId { get; set; }
        /// <summary>
        /// 사용자재무카탈로그명 property
        /// </summary>
        public string userFinanceCatalogNm { get; set; }
        /// <summary>
        /// 사용자재무카탈로그서브그룹번호 property
        /// </summary>
        public int userFinanceCatalogSubgroupNo { get; set; }
    }
}
