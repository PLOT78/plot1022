using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fc.common.fcdb.domain
{
    /// <summary>
    /// 연금domain
    /// </summary>
    public class UserPension
    {
        /// <summary>
        /// 연금domain 생성자
        /// </summary>
        public UserPension()
        {
            this.age        = -1;
            this.payment    = -1;
            this.per        = -1;
            this.rate       = -1;
            this.accumulate = -1;
        }

        /// <summary>
        /// 나이 property
        /// </summary>
        public double age { get; set; }
        /// <summary>
        /// 납입액 property
        /// </summary>
        public double payment { get; set; }
        /// <summary>
        /// 기간(년) property
        /// </summary>
        public double per { get; set; }
        /// <summary>
        /// 이율 property
        /// </summary>
        public double rate { get; set; }
        /// <summary>
        /// 적립액 property
        /// </summary>
        public double accumulate { get; set; }
    }
}
