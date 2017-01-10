using fc.common.cmn.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain.vo
{
    /// <summary>
    /// 사용자재무Vo
    /// </summary>
    public class UserFinanceVo
    {
        /// <summary>
        /// 사용자재무Vo 생성자
        /// </summary>
        public UserFinanceVo()
        {
            this.commonAttr = new CommonAttr();
            this.userFinance = new UserFinance();
            this.userFinanceCatalog = new UserFinanceCatalog();
        }

        /// <summary>
        /// 공통속성 property
        /// </summary>
        public CommonAttr commonAttr { get; set; }
        /// <summary>
        /// 사용자재무 property
        /// </summary>
        public UserFinance userFinance { get; set; }
        /// <summary>
        /// 사용자재무카탈로그 property
        /// </summary>
        public UserFinanceCatalog userFinanceCatalog { get; set; }
    }
}
